using RabbitMQ.Client;
using System.Text;

internal class Program
{
    private string _queue = "hello";
    private string _hostname = "localhost";

    private static void Main(string[] args)
    {
        var factory = new ConnectionFactory()
        {
            HostName = "localhost"
        };
        using(var connection = factory.CreateConnection())
        {
            using(var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "logs", type: ExchangeType.Fanout);
                //channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

                string message = GetMessage(args);
                var body = Encoding.UTF8.GetBytes(message);

                //channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                channel.BasicPublish(exchange: "logs", routingKey: "", basicProperties: null, body: body);
                
                Console.WriteLine($"[x] Sent {message}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }

    private static string GetMessage(String[] args)
    {
        return ((args.Length > 0) 
            ? string.Join(" ", args) 
            : "info: Hola Mundo!");
    }
}