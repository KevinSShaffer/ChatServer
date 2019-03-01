using System;
using System.Net;
using System.Net.Sockets;

namespace ChatServer
{
    class Program
    {
        const int port = 13000;
        static readonly IPAddress localAddr = IPAddress.Parse("10.131.41.77");

        static void Main(string[] args)
        {
            Console.WriteLine("Starting server... ");

            var server = new TcpListener(localAddr, port);

            Console.WriteLine($"Server started at {((IPEndPoint)server.LocalEndpoint).Address.ToString()}:{((IPEndPoint)server.LocalEndpoint).Port.ToString()}");

            server.Start();
            Console.WriteLine("Waiting for a connection... ");

            while (true)
            {
                var client = server.AcceptTcpClient();

                Console.WriteLine("User joined!");
            }
        }
    }
}
