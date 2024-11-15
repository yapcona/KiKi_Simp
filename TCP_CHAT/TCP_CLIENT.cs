using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace Chat_With_Cats_meow
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.WebHost.UseUrls("http://127.0.0.1:8080");
            var app = builder.Build();
            app.UseWebSockets();
            
            app.Map("/ws", async context => { 
                if (context.WebSockets.IsWebSocketRequest)
                {
                    using var ws = await context.WebSockets.AcceptWebSocketAsync();
                    while (true)
                    {
                        if (ws.State == WebSocketState.Open)
                        {
                            var message = "Test Message!";
                            var bytes = Encoding.UTF8.GetBytes(message);
                            var arraySegment = new ArraySegment<byte>(bytes, 0, bytes.Length);
                            await ws.SendAsync(arraySegment,
                                                WebSocketMessageType.Text,
                                                true,
                                                CancellationToken.None);
                        }
                        else if (ws.State == WebSocketState.Closed || ws.State == WebSocketState.Aborted)
                        {
                            break;
                        }
                        
                        await Task.Delay(1000);
                    }
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
            });
            
            await app.RunAsync();
        }
    }
}