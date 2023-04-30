/*
O padrão Memento é usado para capturar e armazenar o estado interno de um objeto sem violar o encapsulamento. 
Isso permite que o objeto seja restaurado posteriormente para o seu estado anterior. 
Para implementar o padrão Memento, precisamos de três classes:

A classe Originator, que é a classe cujo estado desejamos salvar e restaurar.
A classe Memento, que é uma classe auxiliar que armazena o estado interno do Originator.
A classe Caretaker, que é responsável por armazenar e gerenciar os objetos Memento.
*/

// Classe Originator
public class EditorTexto
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

    public Memento Salvar()
    {
        Console.WriteLine("Salvando estado. Texto atual: " + texto);
        return new Memento(texto);
    }

    public void Restaurar(Memento memento)
    {
        texto = memento.GetText();
        Console.WriteLine("Estado restaurado. Texto atual: " + texto);
    }

    public void ExibirTexto()
    {
        Console.WriteLine("Texto atual: " + texto);
    }
}

// Classe Memento
public class Memento
{
    private string texto;

    public Memento(string texto)
    {
        this.texto = texto;
    }

    public string GetText()
    {
        return texto;
    }
}

// Classe Caretaker
public class GerenciadorMemento
{
    private List<Memento> estadosSalvos = new List<Memento>();

    public void AdicionarMemento(Memento memento)
    {
        estadosSalvos.Add(memento);
    }

    public Memento GetMemento(int indice)
    {
        return estadosSalvos[indice];
    }
}

// Exemplo de uso
class Program
{
    static void Main(string[] args)
    {
        EditorTexto editor = new EditorTexto("Hello world!");
        GerenciadorMemento gerenciador = new GerenciadorMemento();

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
