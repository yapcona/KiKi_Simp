#include <iostream>
#include <thread>
#include <string>
#include <cstring>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/socket.h>
#include <netinet/in.h>

class ChatClient {
public:
    ChatClient(const std::string& ip, int port) : ip_address(ip), port(port) {}

    void start() {
        int sock = 0;
        struct sockaddr_in serv_addr;

        if ((sock = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
            std::cerr << "Socket creation error" << std::endl;
            return;
        }

        serv_addr.sin_family = AF_INET;
        serv_addr.sin_port = htons(port);

        if (inet_pton(AF_INET, ip_address.c_str(), &serv_addr.sin_addr) <= 0) {
            std::cerr << "Invalid address/ Address not supported" << std::endl;
            return;
        }

        if (connect(sock, (struct sockaddr*)&serv_addr, sizeof(serv_addr)) < 0) {
            std::cerr << "Connection Failed" << std::endl;
            return;
        }

        std::thread receiver_thread(&ChatClient::receiveMessages, this, sock);
        std::thread sender_thread(&ChatClient::sendMessages, this, sock);

        receiver_thread.join();
        sender_thread.join();

        close(sock);
    }

private:
    std::string ip_address;
    int port;

    void receiveMessages(int socket) {
        char buffer[1024] = {0};
        while (true) {
            int valread = read(socket, buffer, 1024);
            if (valread > 0) {
                std::cout << "Server: " << buffer << std::endl;
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
    ChatClient client("127.0.0.1", 8080);
    client.start();
    return 0;
}



