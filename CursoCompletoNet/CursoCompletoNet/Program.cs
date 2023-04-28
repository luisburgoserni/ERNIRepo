using Excepciones.MyExceptions;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            object obj = "aa";
            int variable = (int)obj;
        }
        catch (InvalidCastException ex)
        {

        }
        catch (MyException ex)
        {
            throw new MyException();
        }
        catch (Exception ex)
        {
            
        }
        finally
        {

        }
    }
}