using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace FTClientApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the IP address of the server
            IPAddress serverAddress = IPAddress.Parse("192.168.1.60");

            // Create a TCP client
            TcpClient client = new TcpClient(serverAddress.ToString(), 8080);

            // Open a network stream
            NetworkStream stream = client.GetStream();

            // Get the path to the ZIP file
            string zipFilePath = @"D:\FTCCode_file.txt";

            // Open the ZIP file as a stream
            FileStream fileStream = new FileStream(zipFilePath, FileMode.Open, FileAccess.Read);

            // Send the ZIP file to the server
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer 
            int bytesRead;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                stream.Write(buffer, 0, bytesRead);
            }

            // Close the streams
            fileStream.Close();
            stream.Close();

            // Close the client
            client.Close();

            Console.WriteLine("ZIP file successfully transferred to server");
        }
    }
}
