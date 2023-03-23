namespace Proxy
{
    public interface IConfiguracao
    {
        void Inicializar();
        void Atualizar();
        void SetConfig(string key, string value);
        string GetConfig(string key);
    }
}