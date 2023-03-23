namespace TemplateMethod
{
    public class OrdenadorPorAvaliacao : OrdenadorTemplate
    {
        public override bool IsPrimeiro(Filme filme1, Filme filme2)
        {
            if (filme1.Avaliacao > filme2.Avaliacao)
                return true;

            return false;
        }
    }
}
