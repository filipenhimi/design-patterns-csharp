namespace Composite
{
    public class FuncionarioLeaf : Funcionario
    {
        public FuncionarioLeaf(string nome) : base(nome)
        {
        }

        public override string Operation()
        {
            return "Leaf";
        }
    }
}
