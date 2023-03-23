namespace AbstractFactory.Product
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Drawing Checkbox in Windows O.S");
        }
    }
}
