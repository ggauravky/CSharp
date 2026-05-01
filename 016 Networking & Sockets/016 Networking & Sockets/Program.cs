// server code
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ServerProgram
{
    static void Main()
    {
        Console.WriteLine("=== SERVER STARTED ===");

        // Create socket
        Socket serverSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

        // Bind to IP and Port (5000)
        serverSocket.Bind(new IPEndPoint(IPAddress.Any, 5000));

        // Start listening
        serverSocket.Listen(1);
        Console.WriteLine("Waiting for client...");

        // Accept client connection
        Socket clientSocket = serverSocket.Accept();
        Console.WriteLine("Client connected!");

        // Receive data
        byte[] buffer = new byte[1024];
        int received = clientSocket.Receive(buffer);

        string message = Encoding.ASCII.GetString(buffer, 0, received);
        Console.WriteLine("Client says: " + message);

        // Send reply to client
        string reply = "Hello from Server";
        byte[] replyData = Encoding.ASCII.GetBytes(reply);

        clientSocket.Send(replyData);

        // Close connections
        clientSocket.Close();
        serverSocket.Close();

        Console.WriteLine("Server closed");
    }
}


//client code


class ClientProgram
{
    static void Main()
    {
        Console.WriteLine("=== CLIENT STARTED ===");

        // Create socket
        Socket clientSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

        // Connect to server (localhost, port 5000)
        clientSocket.Connect("127.0.0.1", 5000);

        Console.WriteLine("Connected to server");

        // Send message
        string message = "Hello Server";
        byte[] data = Encoding.ASCII.GetBytes(message);

        clientSocket.Send(data);

        // Receive response from server
        byte[] buffer = new byte[1024];
        int received = clientSocket.Receive(buffer);

        string reply = Encoding.ASCII.GetString(buffer, 0, received);
        Console.WriteLine("Server says: " + reply);

        // Close connection
        clientSocket.Close();

        Console.WriteLine("Client closed");
    }
}