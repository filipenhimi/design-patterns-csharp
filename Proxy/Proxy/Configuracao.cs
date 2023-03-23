namespace Proxy
{
    public class Configuracao : IConfiguracao
    {
        public void Atualizar()
        {
            Console.WriteLine("configurações atualizadas!");
        }

        public string GetConfig(string key)
        {
            Random rnd = new();
            return $"valor da configuração {key} é : {rnd.NextInt64()}";             
        }

        public void Inicializar()
        {
            Console.WriteLine("configurações inicializadas!");
        }

        public void SetConfig(string key, string value)
        {
            Console.WriteLine($"configurações registradas => {key}:{value}");
        }
    }
}
