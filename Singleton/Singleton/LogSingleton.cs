namespace Singleton
{
    public class LogSingleton
    {
        private static LogSingleton? Instancia;

        private LogSingleton()
        {

        }
        public static LogSingleton GetInstance
        {
            get
            {
                if (Instancia == null)
                    Instancia = new();

                return Instancia;
            }
        }

        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }

    }
}
