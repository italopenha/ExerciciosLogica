float Reais;
float ValorAtualDolar = 5.5f;
float Dolares;


Console.Write("Quantos reais você tem? ");
Reais = float.Parse(Console.ReadLine());

Dolares = Reais / ValorAtualDolar;

Console.Write("Em dólares você tem US$ " + Dolares + ".");
