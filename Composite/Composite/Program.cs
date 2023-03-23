using Composite;

FuncionarioComposite tree = new("Bill Gates");
FuncionarioLeaf liderado1 = new("João");
FuncionarioLeaf liderado2 = new("Paulo");
FuncionarioComposite liderado3 = new("Pedro");

FuncionarioLeaf liderado4 = new("Filipe");
FuncionarioLeaf liderado5 = new("Gabriel");

tree.Add(liderado1);
tree.Add(liderado2);
tree.Add(liderado3);

liderado3.Add(liderado4);
liderado3.Add(liderado5);

Console.WriteLine(tree.Operation());

Console.WriteLine(liderado3.Operation());
