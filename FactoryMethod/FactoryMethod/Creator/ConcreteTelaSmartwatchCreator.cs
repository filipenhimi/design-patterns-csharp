using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteTelaSmartwatchCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartwatch();
        }
    }
}
