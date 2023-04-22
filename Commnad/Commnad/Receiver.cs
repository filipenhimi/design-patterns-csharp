namespace Commnad
{
    // O Receiver é a classe que executa as operações reais
    public class Receiver
    {
        public void OpenFile()
        {
            Console.WriteLine("Abrindo arquivo...");
        }

        public void SaveFile()
        {
            Console.WriteLine("Salvando arquivo...");
        }

        public void CloseFile()
        {
            Console.WriteLine("Fechando arquivo...");
        }
    }
}
