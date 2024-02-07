using DependencyInyectionTest;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection().AddTransient<IPersona, Persona>().BuildServiceProvider();

        var personaService = serviceProvider.GetRequiredService<IPersona>();

        personaService.caminar();

        Console.ReadKey();
    }
}