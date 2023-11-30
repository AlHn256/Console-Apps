using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Serv
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient(2000);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any,2000);
              
            string receive_data;
            byte[] receive_byte_array;
            int x = 0,y=0;


            while (true)
            {
                receive_byte_array = client.Receive(ref endpoint);
               // Console.WriteLine("Received a broadcast {0}",endpoint.ToString());
                receive_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);

                Console.Clear();
                //x = Convert.ToInt32(receive_data);

                string[] mas = receive_data.Split(' ').ToArray();
                if (mas.Count() !=0)
                {
                    Int32.TryParse(mas[0],out x);
                    Int32.TryParse(mas[1],out y);
                    //x = Convert.ToInt32(mas[0]);
                    //y = Convert.ToInt32(mas[0]);
                    //Console.WriteLine("\n X " + x + " Y " + y);
                    Console.SetCursorPosition(x, y); Console.Write((char)1); 
                }
            }
        }
    }
}
