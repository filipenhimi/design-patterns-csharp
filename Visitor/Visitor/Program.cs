using System;
using System.Collections.Generic;

// Interface para o visitante
public interface IVisitor
{
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
}

// Implementação do visitante
public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        Console.WriteLine($"Visitando {elementA.GetType().Name}...");
    }

    public void Visit(ElementB elementB)
    {
        Console.WriteLine($"Visitando {elementB.GetType().Name}...");
    }
}

// Interface para o elemento visitável
public interface IVisitable
{
    void Accept(IVisitor visitor);
}

// Implementação dos elementos visitáveis
public class ElementA : IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ElementB : IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Classe que mantém a lista de elementos e aceita visitantes
public class ObjectStructure
{
    private List<IVisitable> _elements = new List<IVisitable>();

    public void AddElement(IVisitable element)
    {
        _elements.Add(element);
    }

    public void RemoveElement(IVisitable element)
    {
        _elements.Remove(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}

/*
Nesse exemplo, a interface IVisitor define o contrato para os visitantes, que são implementados pela classe ConcreteVisitor. 
A interface IVisitable define o contrato para os elementos visitáveis, que são implementados pelas classes ElementA e ElementB. 
A classe ObjectStructure mantém uma lista de elementos e permite que os visitantes acessem esses elementos por meio do método Accept. 
O programa de exemplo cria uma estrutura de objetos com dois elementos, cria um visitante concreto e usa a estrutura para aceitar a visita do visitante. 
O resultado é que cada elemento é visitado pelo visitante e a mensagem correspondente é exibida no console
*/
class Program
{
    static void Main(string[] args)
    {
        var objectStructure = new ObjectStructure();
        objectStructure.AddElement(new ElementA());
        objectStructure.AddElement(new ElementB());

        var visitor = new ConcreteVisitor();
        objectStructure.Accept(visitor);

        Console.ReadLine();
    }
}
