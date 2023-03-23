using TemplateMethod;

Filme filme1 = new(1, "Titanic", 1997, 4.9);
Filme filme2 = new(2, "Click", 2006, 4.7);
Filme filme3 = new(3, "Náufrago", 2000, 4.8);
Filme filme4 = new(4, "Invencível", 2014, 5);
Filme filme5 = new(5, "O Grande Dragão Branco", 1988, 4.6);

List<Filme> lista = new()
{
    filme1,
    filme2,
    filme3,
    filme4,
    filme5
};

OrdenadorTemplate ordenador;

ordenador = new OrdenadorPorAvaliacao();
var estoque = ordenador.OrdenarFilme(lista);

foreach (var item in estoque)
{
    Console.WriteLine(item.Id + " - " + item.Titulo + " (" + item.Ano + ") => " + item.Avaliacao);
}