using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BasicLogicCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                // Set the TCP listener endpoint to the IP address and port you want to use
                IPAddress ipAddress = IPAddress.Parse("192.168.0.26");
                int port = 8000;

                // Create a new TCP listener
                server = new TcpListener(ipAddress, port);

                // Start listening for incoming connections
                server.Start();

                Console.WriteLine("Server started on " + ipAddress + ":" + port);

                while (true)
                {
                    // Wait for a client connection
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Client connected: " + client.Client.RemoteEndPoint);

                    // Get the client stream for reading and writing
                    NetworkStream stream = client.GetStream();

                    // Read the incoming message from the client
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Received message: " + message);

                    // Send a response back to the client
                    byte[] responseBuffer = Encoding.ASCII.GetBytes("Server response: " + message);
                    stream.Write(responseBuffer, 0, responseBuffer.Length);
                    Console.WriteLine("Sent response: " + Encoding.ASCII.GetString(responseBuffer));

                    // Close the client connection
                    client.Close();
                    Console.WriteLine("Client disconnected");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                server.Stop();
            }
        }
    }
}
