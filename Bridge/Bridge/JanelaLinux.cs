namespace Bridge
{
    public class JanelaLinux : IJanelaBridge
    {
        public void desenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Linux");
        }

        public void desenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Linux");
        }
    }
}
