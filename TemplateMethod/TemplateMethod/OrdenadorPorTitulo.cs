namespace TemplateMethod
{
    public class OrdenadorPorTitulo : OrdenadorTemplate
    {
        public override bool IsPrimeiro(Filme filme1, Filme filme2)
        {
            if (filme1.Titulo.CompareTo(filme2.Titulo) <= 0)
                return true;

            return false;
        }
    }
}
