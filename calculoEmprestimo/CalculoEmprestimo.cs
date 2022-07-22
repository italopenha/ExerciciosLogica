float Capital;
float Parcelas;
float Taxa = 0.2f;
float Juros;
float Montante;
float ValorParcelas;

Console.Write("Qual o valor do empréstimo? ");
Capital = float.Parse(Console.ReadLine());

Console.Write("Em quantas parcelas você quer pagar? ");
Parcelas = float.Parse(Console.ReadLine());

Juros = Capital * Taxa;

Montante = Capital + Juros;

ValorParcelas = (Montante) / Parcelas;

Console.Write("O valor com juros será de R$ " + Montante + "." + "\n");

Console.Write("As parcelas serão de R$ " + ValorParcelas + ".");
