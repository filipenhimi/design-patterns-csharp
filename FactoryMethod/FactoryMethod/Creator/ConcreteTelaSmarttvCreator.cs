using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteTelaSmarttvCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmarttv();
        }
    }
}