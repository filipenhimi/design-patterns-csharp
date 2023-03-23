using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IButton createButton()
        {
           return new MacButton();
        }

        public ICheckbox createCheckbox()
        {
            return new MacCheckbox();
        }
    }
}