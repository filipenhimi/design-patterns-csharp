namespace AbstractFactory.Product
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Drawing Button in Windows O.S");
        }
    }
}
