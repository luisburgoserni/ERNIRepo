using RabbitMQ.Client;
using System.Security.Cryptography;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Generar un par de claves RSA
        using RSA rsa = RSA.Create();

        // Exportar la clave privada como bytes
        byte[] privateKeyBytes = rsa.ExportRSAPrivateKey();

        // Guardar la clave privada en un archivo
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string privateKeyFilePath = Path.Combine(desktopPath, "private_key.pem");
        File.WriteAllBytes(privateKeyFilePath, privateKeyBytes);

        var publicKey = rsa.ExportRSAPublicKey();

        var factory = new ConnectionFactory() { HostName = "localhost" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "hello",
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        string message = "";
        while (message != "exit")
        {
            Console.WriteLine("Enter message (type 'exit' to quit):");
            message = Console.ReadLine(); // Solicita al usuario el texto a enviar

            // Cifrar el mensaje utilizando la clave pública
            byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(message), RSAEncryptionPadding.OaepSHA256);

            //Console.WriteLine(" [x] Sent encrypted message: {0}", Convert.ToBase64String(encryptedData));

            channel.BasicPublish(exchange: "",
                                 routingKey: "hello",
                                 basicProperties: null,
                                 body: encryptedData);

            Console.WriteLine(" [x] Sent encrypted message");
        }
    }
}