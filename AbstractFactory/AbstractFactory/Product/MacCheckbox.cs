namespace AbstractFactory.Product
{
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Drawing Checkbox in Mac O.S");
        }
    }
}
