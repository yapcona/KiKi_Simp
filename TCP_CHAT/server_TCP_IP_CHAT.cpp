#include <iostream>
#include <thread>
#include <string>
#include <cstring>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/socket.h>
#include <netinet/in.h>

class ChatServer {
public:
    ChatServer(const std::string& ip, int port) : ip_address(ip), port(port) {}

    void start() {
        int server_fd, new_socket;
        struct sockaddr_in address;
        int opt = 1;
        int addrlen = sizeof(address);

        // Creating socket file descriptor
        if ((server_fd = socket(AF_INET, SOCK_STREAM, 0)) == 0) {
            perror("socket failed");
            exit(EXIT_FAILURE);
        }

        // Forcefully attaching socket to the port
        if (setsockopt(server_fd, SOL_SOCKET, SO_REUSEADDR | SO_REUSEPORT, &opt, sizeof(opt))) {
            perror("setsockopt");
            exit(EXIT_FAILURE);
        }

        address.sin_family = AF_INET;
        address.sin_addr.s_addr = inet_addr(ip_address.c_str());
        address.sin_port = htons(port);

        // Bind the socket
        if (bind(server_fd, (struct sockaddr*)&address, sizeof(address)) < 0) {
            perror("bind failed");
            exit(EXIT_FAILURE);
        }

        // Listen for connections
        if (listen(server_fd, 3) < 0) {
            perror("listen");
            exit(EXIT_FAILURE);
        }

        std::cout << "Server listening on " << ip_address << ":" << port << std::endl;

        // Accept incoming connection
        if ((new_socket = accept(server_fd, (struct sockaddr*)&address, (socklen_t*)&addrlen)) < 0) {
            perror("accept");
            exit(EXIT_FAILURE);
        }

        std::thread receiver_thread(&ChatServer::receiveMessages, this, new_socket);
        std::thread sender_thread(&ChatServer::sendMessages, this, new_socket);

        receiver_thread.join();
        sender_thread.join();

        close(new_socket);
        close(server_fd);
    }

private:
    std::string ip_address;
    int port;

    void receiveMessages(int socket) {
        char buffer[1024] = {0};
        while (true) {
            int valread = read(socket, buffer, 1024);
            if (valread > 0) {
                std::cout << "Client: " << buffer << std::endl;
            }
        }
    }

    void sendMessages(int socket) {
        std::string message;
        while (true) {
            std::getline(std::cin, message);
            send(socket, message.c_str(), message.size(), 0);
        }
    }
};

int main() {
    ChatServer server("127.0.0.1", 8080);
    server.start();
    return 0;
}
