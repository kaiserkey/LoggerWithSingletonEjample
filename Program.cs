namespace TestSingleton;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.Instance.LogInformation("Test Logger");
        Logger.Instance.LogInformation("Test Logger");

        var logger = Logger.Instance;
        logger.LogInformation("Test Logger");

        //var logger2 = new Logger(); // error por constructor privado
        Console.WriteLine("Logger instanciado correctamente");
        Console.WriteLine("Fin del programa");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}