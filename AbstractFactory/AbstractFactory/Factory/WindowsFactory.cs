using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton createButton()
        {
           return new WindowsButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
