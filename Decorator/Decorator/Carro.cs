namespace Decorator
{
    //Concrete Component
    public sealed class Carro : ICarro
    {
        public string RetornarCarro()
        {
            var carro = "Este é um carro básico:";
            return carro;
        }
    }
}
