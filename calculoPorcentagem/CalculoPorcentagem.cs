float Todo;
float Porcentagem;
float Resultado;

Console.Write("Qual o valor do todo? ");
Todo = float.Parse(Console.ReadLine());

Console.Write("Qual o valor da porcentagem que você quer descobrir? ");
Porcentagem = float.Parse(Console.ReadLine());

Resultado = Todo * Porcentagem / 100;

Console.Write(Porcentagem + "% de " + Todo + " é " + Resultado + ".");
