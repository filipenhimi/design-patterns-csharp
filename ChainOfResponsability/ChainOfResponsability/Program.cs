// Set up the chain
using ChainOfResponsability;

Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();
Handler handler3 = new ConcreteHandler3();
handler1.SetSuccessor(handler2);
handler2.SetSuccessor(handler3);

// Send requests to the chain
int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

foreach (int request in requests)
{
    handler1.HandleRequest(request);
}