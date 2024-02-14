using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // Importar la clave privada desde el archivo
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string privateKeyFilePath = Path.Combine(desktopPath, "private_key.pem");
        byte[] privateKeyBytes = File.ReadAllBytes(privateKeyFilePath);
        using RSA rsa = RSA.Create();
        rsa.ImportRSAPrivateKey(privateKeyBytes, out _);

        var factory = new ConnectionFactory() { HostName = "localhost" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "hello",
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (model, ea) =>
        {
            byte[] encryptedData = ea.Body.ToArray();

            // Descifrar el mensaje utilizando la clave privada
            byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.OaepSHA256);

            string decryptedMessage = Encoding.UTF8.GetString(decryptedData);

            //Console.WriteLine(" [x] Received encrypted message: {0}", Convert.ToBase64String(encryptedData));
            Console.WriteLine(" [x] Decrypted message: {0}", decryptedMessage);
        };
        channel.BasicConsume(queue: "hello",
                             autoAck: true,
                             consumer: consumer);

        Console.WriteLine(" Press [enter] to exit.");
        Console.ReadLine();
    }
}