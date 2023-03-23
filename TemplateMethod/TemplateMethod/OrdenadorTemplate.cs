namespace TemplateMethod
{
    public abstract class OrdenadorTemplate
    {
        public abstract bool IsPrimeiro(Filme filme1, Filme filme2);

        //Método de ordenação bolha (Bubble Sort) => O(N^2)
        public List<Filme> OrdenarFilme(List<Filme> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i+1; j < lista.Count; j++)
                {
                    if (!IsPrimeiro(lista[i], lista[j]))
                    {
                        Filme temp = lista[j];
                        lista[j] = lista[i];
                        lista[i] = temp;
                    }
                }
            }

            return lista;
        }
    }
}
