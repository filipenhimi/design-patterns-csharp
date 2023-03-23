namespace Decorator
{
    public class KitMultimidiaDecorator : CarroDecorator
    {
        public KitMultimidiaDecorator(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Kit Multimidia";
        }
    }
}
