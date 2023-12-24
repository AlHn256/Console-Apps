using System;
using System.Numerics;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Client
{
    class Program
    {
        static string adress = "ws://127.0.0.1:7890/Echo";
        static void Main(string[] args)
        {
            using(WebSocket ws = new WebSocket(adress))
            {
                ws.OnMessage += Ws_Onmessage;
                ws.Connect();
                ws.Send("Hello from Client");
            }
            Console.ReadKey();
        }

        private static void Ws_Onmessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Receive from serv -"+e.Data);
            try
            {
                //Vector pos= JsonConvert
            }
            catch(Exception ex)
            {

            }
        }
    }
}
