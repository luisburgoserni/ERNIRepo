using System.Net;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Servidor
{
    private TcpListener myList = null;
    private static string ip = "127.0.0.1";
    private static int port = 8010;

    public static void Main(string[] args)
    {
        new Servidor();
    }

    private Servidor()
    {
        try
        {
            myList = new TcpListener(port);
            myList.Start();

            while (true)
            {
                Socket cliente = null;

                try
                {
                    cliente = myList.AcceptSocket();
                    Thread hilo = new Thread(() => hiloClientesMethod(ref cliente));
                    hilo.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    myList.Stop();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);           
            myList.Stop();
        }
    }

    public void hiloClientesMethod(ref Socket cliente)
    {
        while(cliente.Connected)
        {
            try
            {
                byte[] b = new byte[100];
                int k = cliente.Receive(b);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                cliente.Close();
                myList.Stop();
            }
        }
        cliente.Close();
        myList.Stop();
    }
}



