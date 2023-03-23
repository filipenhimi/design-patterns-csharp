using Proxy;

ConfiguracaoProxy configuracaoProxy = new();

configuracaoProxy.Inicializar();
configuracaoProxy.SetConfig("key001", "teste");
Console.WriteLine(configuracaoProxy.GetConfig("key001"));
