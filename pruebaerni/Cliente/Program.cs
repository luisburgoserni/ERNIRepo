using System.Net.Sockets;
using System.Net;
using System.Text;

internal class Program
{
    private static string ip = "127.0.0.1";
    private static int port = 8010;

    private static void Main(string[] args)
    {
        try
        {
            IPAddress ipAd = IPAddress.Parse(ip);
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting...");
            tcpclnt.Connect(ip, 8010);
            Console.WriteLine("Connected with " + tcpclnt.Client);
            string str = string.Empty;

            do
            {
                Console.WriteLine("Pon un mensaje: ");
                str = Console.ReadLine();
                
                Stream stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting...");
                stm.Write(ba, 0, ba.Length);
                byte[] bb = new byte[100];
                Thread.Sleep(500);
                Console.Read();
            } while (str != "exit");


            tcpclnt.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.StackTrace);
            Console.Read();
        }
    }

}