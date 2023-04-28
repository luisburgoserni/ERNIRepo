internal class Program
{
    private static async Task Main(string[] args)
    {
        Cafe cup = HacerCafe();
        Console.WriteLine("coffe is ready");
        var eggsTask = FreirHuevos(2);
        var baconTask = FreirBacon(3);
        var toastTask = HacerTostadasConMantequillaYJamon(2);

        var allTasks = new List<Task> { eggsTask, baconTask, toastTask };
        while (allTasks.Any())
        {
            Task finished = await Task.WhenAny(allTasks);
            if (finished == eggsTask)
            {
                Console.WriteLine("eggs are ready");
                allTasks.Remove(eggsTask);
                var eggs = await eggsTask;

            }else if (finished == baconTask)
            {
                Console.WriteLine("bacon is ready");
                allTasks.Remove(baconTask);
                var bacon = await baconTask;

            }else if (finished == toastTask)
            {
                Console.WriteLine("toasts are prepared");
                allTasks.Remove(toastTask);
                var toast = await toastTask;
            }
            else
            {
                allTasks.Remove(finished);
            }
            Console.WriteLine("Breakfast is ready!");
        }
    }

    private async static Task<Tostada> HacerTostadasConMantequillaYJamon(int number)
    {
        var plainToast = await TostarPan(number);
        AplicarMantequilla(plainToast);
        AplicarJamon(plainToast);
        return plainToast;
    }

    private static Zumo HacerZumo()
    {
        return new Zumo();
    }

    private static async Task<Tostada> TostarPan(int v)
    {
        return new Tostada();
    }

    private static async Task<Bacon> FreirBacon(int v)
    {
        return new Bacon();
    }

    private static async Task<Huevos> FreirHuevos(int v)
    {
        return new Huevos();
    }

    private static Cafe HacerCafe()
    {
        return new Cafe();
    }

    private static void AplicarJamon(Tostada toast)
    {

    }

    private static Task AplicarMantequilla(Tostada toast)
    {
        return Task.CompletedTask;
    }
}

internal class Zumo
{
}

internal class Tostada
{
}

internal class Bacon
{
}

internal class Huevos
{
}

internal class Cafe
{
}