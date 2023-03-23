using Prototype;

InimigoA inimigo1 = new();
inimigo1.Nome = "I1";
inimigo1.Cor = "Azul";
inimigo1.Arma = new Arma("Faca");

Inimigo inimigo2 = new InimigoA();

//Não irá impactar o objeto inimigo2
inimigo2 = inimigo1.DeepCopy(); //Cópia profuda
inimigo1.Arma.Nome = "Espada";

//irá impactar o objeto inimigo2
inimigo2 = inimigo1.ShallowCopy(); //Cópia superficial
inimigo1.Arma.Nome = "Espada";


Console.WriteLine("Fim");