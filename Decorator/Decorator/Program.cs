using Decorator;

ICarro carro = new Carro();
ICarro rodaDecorator = new RodaLigaDecorator(carro);
ICarro arDecorator = new ArCondicionadoDecorator(rodaDecorator);
ICarro bancoDecorator = new BancoCouroDecorator(arDecorator);
ICarro multimidiaDecorator = new KitMultimidiaDecorator(bancoDecorator);

var result = multimidiaDecorator.RetornarCarro();

Console.WriteLine(result);