namespace AbstractFactory.Product
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Drawing Button in Mac O.S");
        }
    }
}
