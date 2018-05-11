using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace lesson6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");
                tcpclnt.Connect("192.168.0.117",8001);
                
                while(true){
                    Console.Write("\nEnter the string to be transmitted : ");
                    String str=Console.ReadLine();
                    Stream stm = tcpclnt.GetStream();
                    ASCIIEncoding asen= new ASCIIEncoding();
                    byte[] ba=asen.GetBytes(str);
                    Console.WriteLine("Transmitting.....");
                    stm.Write(ba,0,ba.Length);
                    byte[] bb=new byte[100];
                    int k=stm.Read(bb,0,100);
                    for (int i=0;i<k;i++)
                        Console.Write(Convert.ToChar(bb[i]));
                }
                tcpclnt.Close();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);

            }

            // Console.WriteLine("Hello World!");
        }
    }
}
