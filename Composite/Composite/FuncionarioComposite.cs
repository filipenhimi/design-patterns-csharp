namespace Composite
{
    public class FuncionarioComposite : Funcionario
    {
        protected List<Funcionario> _children = new();

        public FuncionarioComposite(string nome) : base(nome)
        {
        }

        public override void Add(Funcionario component)
        {
            this._children.Add(component);
        }

        public override void Remove(Funcionario component)
        {
            this._children.Remove(component);
        }

        public override Funcionario Get(int index)
        {
            return _children[index];
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"Liderados de {this.Nome} (";

            foreach (Funcionario component in this._children)
            {
                result += component.Nome;
                if (i != this._children.Count - 1)
                {
                    result += ", ";
                }
                i++;
            }

            return result + ")";
        }
    }
}
