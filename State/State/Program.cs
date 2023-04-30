using System;

// Interface para os estados
public interface IState
{
    void Handle(Context context);
}

// Implementação dos estados
public class StateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do Estado A.");
        context.State = new StateB();
    }
}

public class StateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do Estado B.");
        context.State = new StateA();
    }
}

// Classe do contexto
public class Context
{
    private IState _state;

    public IState State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}

/*
Nesse exemplo, a interface IState define o contrato para os estados, que são implementados pelas classes StateA e StateB. 
A classe Context mantém uma referência para o estado atual e tem um método Request que executa uma ação com base no estado atual. 
Quando o método Handle de um estado é executado, ele realiza uma ação e, em seguida, atualiza o estado atual do contexto. 
O programa de exemplo cria um contexto, define o estado inicial como StateA e executa três ações, alternando entre os estados A e B. 
A saída do programa mostra que a ação correta é executada com base no estado atual do contexto.

Obs: Este exemplo é bem simples, mas na prática, os estados podem ser muito mais complexos e incluir uma série de informações e comportamentos diferentes
*/
class Program
{
    static void Main(string[] args)
    {
        var context = new Context();

        // Executa ação do Estado A
        context.State = new StateA();
        context.Request();

        // Executa ação do Estado B
        context.Request();

        // Executa ação do Estado A novamente
        context.Request();

        Console.ReadLine();
    }
}
