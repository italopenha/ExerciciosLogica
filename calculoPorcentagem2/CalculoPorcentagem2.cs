float Todo;
float Parcial;
float Porcentagem;

Console.Write("Digite o valor total: ");
Todo = float.Parse(Console.ReadLine());

Console.Write("Digite o valor do item: ");
Parcial = float.Parse(Console.ReadLine());

Porcentagem = Parcial/Todo * 100;

Console.Write(Parcial + " é " + Porcentagem + "% do total.");


