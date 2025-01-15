namespace TestSingleton
{
    /// <summary>
    /// Guardar los en archivo en disco
    /// </summary>
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance => _instance.Value;

        private object _lock = new object();

        //obtener el path actual
        private static string Path = null;

        private Logger(){
            Path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Log.txt";
            this.LogInformation("Inicio del Logger.");
        }

        public void LogInformation(string message)
        {
            lock (_lock)
            {
                using (var writer = new StreamWriter(Path, true))
                {
                    writer.WriteLine($"LogInformation - {DateTime.Now} - {message}");
                }
            }
        }

    }
}
