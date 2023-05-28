// Define a interface para um observador
public interface IObserver
{
    void Update(int value);
}

// Define a classe concreta do observador
public class ConcreteObserver : IObserver
{
    private string _observerName;

    public ConcreteObserver(string name)
    {
        _observerName = name;
    }

    public void Update(int value)
    {
        Console.WriteLine($"Observer {_observerName} received update: {value}");
    }
}

// Define a interface do assunto
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(int value);
}

// Define a classe concreta do assunto
public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(int value)
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(value);
        }
    }
}

/*
Neste exemplo, temos uma classe ConcreteSubject que implementa a interface ISubject e mantém uma lista de observadores 
que implementam a interface IObserver. A classe ConcreteObserver implementa a interface IObserver e 
recebe as atualizações do assunto através do método Update.

Ao executar este código, a saída seria:

Observer Observer 1 received update: 42
Observer Observer 2 received update: 42
Observer Observer 1 received update: 84

Observe que o primeiro valor enviado é 42, e ambos os observadores o recebem. 
Em seguida, um dos observadores é removido da lista de observadores e um novo valor (84) é enviado, sendo que apenas o observador restante o recebe.
*/
class Program
{
    static void Main(string[] args)
    {
        ConcreteSubject subject = new ConcreteSubject();
        ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);

        subject.NotifyObservers(42);

        subject.RemoveObserver(observer2);

        subject.NotifyObservers(84);

        Console.ReadLine();
    }
}