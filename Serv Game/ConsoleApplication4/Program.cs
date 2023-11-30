using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress sendToAddress = IPAddress.Parse("192.168.0.12");
            IPEndPoint endpoint = new IPEndPoint(sendToAddress, 2000);
            
            int x = 16, y = 55;
         
            Byte[] bytes;
            bytes = new Byte[x];
            ConsoleKey key = ConsoleKey.Attention;

            do{
                Console.Clear();
                Console.Write("\nX {0} Y {1}",x,y);
                socket.SendTo(Encoding.ASCII.GetBytes(x+" "+y), endpoint);
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow) {  y--; if (y < 1) y = 1; }
                if (key == ConsoleKey.DownArrow) { y++; if (y > 100) y = 100; }
                if (key == ConsoleKey.LeftArrow) { x--; if (x < 1)x = 1; }
                if (key == ConsoleKey.RightArrow) {x++; if (x > 74) x = 74;}
            } while (key != ConsoleKey.Escape);
        }
    }
}
