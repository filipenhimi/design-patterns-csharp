using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteTelaWebCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaWeb();
        }
    }
}
