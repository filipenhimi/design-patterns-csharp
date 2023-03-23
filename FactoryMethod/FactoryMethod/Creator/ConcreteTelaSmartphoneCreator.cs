using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteTelaSmartphoneCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartphone();
        }
    }
}
