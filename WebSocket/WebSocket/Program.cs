using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocket
{
    class Program
    {

        public class Echo: WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                Console.WriteLine("Receive message " + e.Data);
                Send(e.Data);
            }
        }

        static string adress = "ws://127.0.0.1:7890";
        static void Main(string[] args)
        {
            WebSocketServer server = new WebSocketServer(adress);
            server.AddWebSocketService<Echo>("/Echo");
            server.Start();
            Console.WriteLine("server.Start on "+ adress);

            Console.ReadKey();
            server.Stop();
        }
    }
}
