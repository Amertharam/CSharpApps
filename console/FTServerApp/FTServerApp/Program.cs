using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace FTServerApp
{
    public class FTServer
    {
        public static void Main(string[] args)
        {
            // Create a TCP listener
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);

            // Start listening for clients
            listener.Start();

            // Accept an incoming connection
            TcpClient client = listener.AcceptTcpClient();

            // Open a network stream
            NetworkStream stream = client.GetStream();

            // Receive the ZIP file from the client
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            int bytesReceived;
            using (FileStream fileStream = new FileStream(@"D:\received_zip_file.zip", FileMode.Create, FileAccess.Write))
            {
                while ((bytesReceived = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileStream.Write(buffer, 0, bytesReceived);
                }
            }

            // Close the streams
            stream.Close();
            client.Close();

            // Stop listening for clients
            listener.Stop();

            Console.WriteLine("ZIP file successfully received from client");
        }
    }
}