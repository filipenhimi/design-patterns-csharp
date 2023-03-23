namespace Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaBridge janela;

        public JanelaAbstrata(IJanelaBridge j)
        {
            janela = j;
        }

        public void desenharJanela(string titulo)
        {
            Console.WriteLine("Desenhando janela...");
            janela.desenharJanela(titulo);
        }

        public void desenharBotao(string titulo)
        {
            janela.desenharBotao(titulo);
        }

        public abstract void desenhar();
    }
}
