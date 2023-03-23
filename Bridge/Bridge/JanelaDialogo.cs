namespace Bridge
{
    public class JanelaDialogo : JanelaAbstrata
    {
        public JanelaDialogo(IJanelaBridge janela) : base(janela) { }
        
        public override void desenhar()
        {
            desenharJanela("Atenção! Deseja encerrar sem salvar?");
            desenharBotao("Sim");
            desenharBotao("Não");
        }
    }
}
