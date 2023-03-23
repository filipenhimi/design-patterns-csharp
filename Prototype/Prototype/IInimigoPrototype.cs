namespace Prototype
{
    public interface IInimigoPrototype
    {
        Inimigo ShallowCopy();
        Inimigo DeepCopy();
    }
}
