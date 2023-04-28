using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //truco 1
        var car1 = new Car();
        Car car2 = new Car();
        Car car3 = new();

        //truco 2
        var variable = MightReturnNull() ?? "default";

        //truco 3
        var level = Level.Medium;
        var text = level switch
        {
            Level.Low => "Low level",
            Level.Medium => "Medium level",
            _ => "High level"
        };

        //truco 4
        var connectionString = "sql connection string";
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        //truco 5
        DoSomething("H", "j", "kjd", "dd");

        //truco 6
        ConstructorSample cs = new(1);

        //truco 7
        string text1 = "aBcDeFgH";
        string text2 = "AbCdEfGh";

        var equals = String.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(equals);

    }

    static void DoSomething(params string[] theString)
    {
        foreach (var str in theString)
        {
            Console.WriteLine(str);
        }
    }

    static string? MightReturnNull()
    {
        return "This can be null";
    }
}

class ConstructorSample
{
    int _value1;
    string _value2;

    public ConstructorSample(int value1, string value2)
    {
        _value1 = value1;
        _value2 = value2;
    }

    public ConstructorSample(int value1) : this(value1, "Default Value")
    {

    }
}

class Car
{

}

enum Level
{
    Low,
    Medium,
    High
}