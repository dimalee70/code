using System;
using System.Text;
using System.Net;
using System.Collections.Generic;
using System.Net.Sockets;

namespace lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List <Socket> clientList = new List<Socket>();
                IPAddress ipAd = IPAddress.Parse("192.168.0.117");
                TcpListener myList=new TcpListener(ipAd,8001);
                
                myList.Start();
                Console.WriteLine("The server is running at port 8001...");    
                Console.WriteLine("The local End point is  :" + 
                          myList.LocalEndpoint );
                Console.WriteLine("Waiting for a connection.....");
                
                // Socket s=myList.AcceptSocket();
               
                while(true){

                    Socket client = myList.AcceptSocket();
                    clientList.Add(myList.AcceptSocket());
                    byte[] b=new byte[100];
                    foreach(Socket s in clientList)
                    {
                        Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
                        int k=s.Receive(b);
                        Console.WriteLine("Recieved...");
                        string ans = "";
                        for (int i=0;i<k;i++)
                            ans = ans + Convert.ToChar(b[i]);
                        System.Console.WriteLine(ans);
                        
                        ASCIIEncoding asen=new ASCIIEncoding();
                        s.Send(asen.GetBytes($"from server {ans}"));
                        Console.WriteLine("\nSent Acknowledgement");
                    }
                    

                    
                }
                // s.Close();
                myList.Stop();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
            // Console.WriteLine("Hello World!");
        }
    }
}
