namespace Proxy
{
    public class ConfiguracaoProxy : IConfiguracao
    {
        Configuracao configuracao = new();

        public void Inicializar()
        {
            configuracao.Inicializar();
        }

        public string GetConfig(string key)
        {
            return configuracao.GetConfig(key);
        }

        public void SetConfig(string key, string value)
        {
            configuracao.SetConfig(key, value);
        }

        void IConfiguracao.Atualizar()
        {
            throw new NotImplementedException();
        }
    }
}
