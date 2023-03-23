using Builder;

HamburguerBuilder hamburguerBuilder = new();

//X-Salada
var xSalada =
    hamburguerBuilder
    .SetTipoPao("Branco")    
    .SetTipoCarne("Bovina")
    .TemSalada()
    .Build();

//X-Bacon
hamburguerBuilder = new();
var xBacon =
    hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemQueijo()
    .Build();

//X-Tudo
hamburguerBuilder = new();
var xTudo =
    hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemQueijo()
    .TemSalada()
    .TemBatataPalha()
    .Build();

Console.WriteLine(xSalada.GetDescricao());
Console.WriteLine("===============================================================");
Console.WriteLine(xBacon.GetDescricao());
Console.WriteLine("===============================================================");
Console.WriteLine(xTudo.GetDescricao());


