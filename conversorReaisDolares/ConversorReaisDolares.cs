float Reais;
float ValorAtualDolar = 5.5f;
float Dolares;
int Contador = 1;
int Conversoes;

Console.Write("Quantas vezes você deseja converter? ");
Conversoes = int.Parse(Console.ReadLine());

while (Contador <= Conversoes)
{
    Console.Write("Quantos reais você tem? ");
Reais = float.Parse(Console.ReadLine());

Dolares = Reais / ValorAtualDolar;

    Console.WriteLine("Em dólares você tem US$ " + Dolares + ".");
Contador++;
}

