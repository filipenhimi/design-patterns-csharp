using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public interface IGUIFactory
    {
        IButton createButton();
        ICheckbox createCheckbox();
    }
}
