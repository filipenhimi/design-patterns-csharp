using System;

// Interface para a estratégia
public interface IStrategy
{
    void Execute();
}

// Implementação das estratégias
public class StrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executando a estratégia A");
    }
}

public class StrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executando a estratégia B");
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

/*
Nesse exemplo, a interface IStrategy define o contrato para as estratégias, que são implementadas pelas classes StrategyA e StrategyB. 
A classe Context é responsável por manter a referência para a estratégia atual e por chamar o método Execute da estratégia quando necessário. 
O programa de exemplo cria um contexto com a estratégia A, executa a estratégia A, troca a estratégia para a estratégia B e executa a estratégia B
*/
class Program
{
    static void Main(string[] args)
    {
        var context = new Context(new StrategyA());
        context.ExecuteStrategy();

        context.SetStrategy(new StrategyB());
        context.ExecuteStrategy();

        Console.ReadLine();
    }
}
