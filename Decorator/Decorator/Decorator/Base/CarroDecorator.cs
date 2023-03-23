namespace Decorator
{
    //Decorator (Base)
    public class CarroDecorator : ICarro
    {
        private readonly ICarro Carro;

        public CarroDecorator(ICarro carro)
        {
            Carro = carro;
        }

        public virtual string RetornarCarro()
        {
            return Carro.RetornarCarro();
        }
    }
}
