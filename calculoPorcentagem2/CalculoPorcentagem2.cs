float Todo;
float ValorTodo;
float Porcentagem;

Console.Write("Digite o valor total: ");
Todo = float.Parse(Console.ReadLine());

Console.Write("Digite o valor do item: ");
ValorTodo = float.Parse(Console.ReadLine());

Porcentagem = ValorTodo/Todo * 100;

Console.Write(ValorTodo + " é " + Porcentagem + "% do total.");


