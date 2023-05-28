/*
O padrão ConcreteMemento é usado para capturar e armazenar o estado interno de um objeto sem violar o encapsulamento. 
Isso permite que o objeto seja restaurado posteriormente para o seu estado anterior. 
Para implementar o padrão ConcreteMemento, precisamos de três classes:

A classe Originator, que é a classe cujo estado desejamos salvar e restaurar.
A classe ConcreteMemento, que é uma classe auxiliar que armazena o estado interno do Originator.
A classe Caretaker, que é responsável por armazenar e gerenciar os objetos ConcreteMemento.
*/

// Classe Originator
public interface IOriginator
{
    ConcreteMemento Salvar();
}

public class EditorTexto : IOriginator
{
    private string texto;

    public EditorTexto(string texto)
    {
        this.texto = texto;
    }

    public void Escrever(string novoTexto)
    {
        Console.WriteLine("Escrevendo: " + novoTexto);
        texto += " " + novoTexto;
    }

    public ConcreteMemento Salvar()
    {
        Console.WriteLine("Salvando estado. Texto atual: " + texto);
        return new ConcreteMemento(texto);
    }

    public void Restaurar(ConcreteMemento memento)
    {
        texto = memento.GetText();
        Console.WriteLine("Estado restaurado. Texto atual: " + texto);
    }

    public void ExibirTexto()
    {
        Console.WriteLine("Texto atual: " + texto);
    }
}

// Classe ConcreteMemento

public interface IMemento
{
    string GetText();
}

public class ConcreteMemento : IMemento
{
    private readonly string texto;

    public ConcreteMemento(string texto)
    {
        this.texto = texto;
    }

    public string GetText()
    {
        return texto;
    }
}

// Classe Caretaker
public class CaretakerMemento
{
    private List<ConcreteMemento> estadosSalvos = new();

    public void AdicionarMemento(ConcreteMemento memento)
    {
        estadosSalvos.Add(memento);
    }

    public ConcreteMemento GetMemento(int indice)
    {
        return estadosSalvos[indice];
    }
}

// Exemplo de uso
class Program
{
    static void Main(string[] args)
    {
        EditorTexto editor = new("Hello world!");
        CaretakerMemento gerenciador = new();

        editor.ExibirTexto();

        gerenciador.AdicionarMemento(editor.Salvar());

        editor.Escrever("Olá");
        editor.ExibirTexto();

        gerenciador.AdicionarMemento(editor.Salvar());

        editor.Escrever("Mundo");
        editor.ExibirTexto();

        gerenciador.AdicionarMemento(editor.Salvar());

        editor.Restaurar(gerenciador.GetMemento(1));
        editor.ExibirTexto();

        editor.Restaurar(gerenciador.GetMemento(0));
        editor.ExibirTexto();

        Console.ReadKey();
    }
}
