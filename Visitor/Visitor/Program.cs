// Elemento visitável
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Interface visitante
public interface IVisitor
{
    void Visit(Pessoa pessoa);
}

// Implementação do visitante
public class PessoaVisitor : IVisitor
{
    public void Visit(Pessoa pessoa)
    {
        if (pessoa.Idade >= 18)
        {
            Console.WriteLine($"{pessoa.Nome} é maior de idade.");
        }
        else
        {
            Console.WriteLine($"{pessoa.Nome} é menor de idade.");
        }
    }
}

/*
Neste exemplo, Pessoa é uma classe que representa uma pessoa, que possui um método Accept para receber um objeto visitante. 
A interface IVisitor define o método Visit para o tipo Pessoa. 
PessoaVisitor é uma implementação concreta de IVisitor que define o comportamento de Visit, verificando se a pessoa é maior ou menor de idade. 
No método Main, dois objetos Pessoa são criados e o visitante PessoaVisitor é utilizado para visitar cada objeto, 
imprimindo no console se a pessoa é maior ou menor de idade. 
*/
class Program
{
    static void Main(string[] args)
    {
        var pessoa1 = new Pessoa { Nome = "João", Idade = 20 };
        var pessoa2 = new Pessoa { Nome = "Maria", Idade = 16 };        

        var visitor = new PessoaVisitor();

        pessoa1.Accept(visitor); // João é maior de idade.
        pessoa2.Accept(visitor); // Maria é menor de idade.
    }
}