// Interface Mediator
public interface IChatRoom
{
    void Register(User user);
    void Send(string message, User user);
}

// Classe ConcreteMediator
public class ChatRoom : IChatRoom
{
    private List<User> _users = new List<User>();

    public void Register(User user)
    {
        _users.Add(user);
    }

    public void Send(string message, User sender)
    {
        foreach (User user in _users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}

// Classe Colleague
public abstract class User
{
    protected IChatRoom _chatRoom;

    public User(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

// Classe ConcreteColleague
public class ChatUser : User
{
    public ChatUser(IChatRoom chatRoom) : base(chatRoom) { }

    public override void Send(string message)
    {
        Console.WriteLine("User sends message: " + message);
        _chatRoom.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine("User receives message: " + message);
    }
}

/*
Nesse exemplo, temos a classe ChatRoom implementando a interface IChatRoom, que define o método Register para 
registrar novos usuários na sala de chat e o método Send para enviar mensagens a todos os usuários, exceto o remetente.
A classe User é uma classe abstrata que define os métodos Send e Receive, que serão implementados pelas classes concretas que representam os usuários. 
A classe ChatUser é uma classe concreta que implementa esses métodos e que recebe a instância da sala de chat no construtor.
Por fim, temos um exemplo de uso da sala de chat, com a criação da sala, dos usuários e o registro dos usuários na sala. 
Depois, é feito o envio de mensagens pelos usuários. Ao enviar uma mensagem, a sala de chat repassa a mensagem para todos os usuários, exceto o remetente.
*/
class Program
{
    static void Main(string[] args)
    {
        // Cria a sala de chat
        IChatRoom chatRoom = new ChatRoom();

        // Cria os usuários
        User user1 = new ChatUser(chatRoom);
        User user2 = new ChatUser(chatRoom);
        User user3 = new ChatUser(chatRoom);

        // Registra os usuários na sala de chat
        chatRoom.Register(user1);
        chatRoom.Register(user2);
        chatRoom.Register(user3);

        // Envio de mensagens
        user1.Send("Hello, world!");
        user2.Send("Hi there!");
    }
}