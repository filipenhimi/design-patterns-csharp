namespace Facade
{
    public class SerasaAPI
    {
        public int Score(string CPF)
        {
            Random random = new Random();
            return random.Next(0, 1000);
        }
    }
}
