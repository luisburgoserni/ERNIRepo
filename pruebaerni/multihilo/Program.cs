internal class Program
{
    private static void Main(string[] args)
    {
        List<Thread> tlist = new List<Thread>();
        for (int i = 0; i < 50; i++){
            tlist.Add(new Thread(print));
            tlist[i].Start();
        }
        
    }

    static void print()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }
}