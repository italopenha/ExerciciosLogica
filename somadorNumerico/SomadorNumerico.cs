int Somador = 1;
int N;
int Soma = 0;  
int Maior = 0;
int Menor = 0;

while (Somador <= 10)
{
    Console.Write("Digite um valor: ");
    N = int.Parse(Console.ReadLine());
    if (N > Maior)
    {
        Maior = N;
    }
    if (N < Menor)
    {
        Menor = N;
    }
    Soma = Soma + N;

    Somador++;
}

Console.WriteLine("A soma dos valores é: " + Soma);
Console.WriteLine("O maior valor é: " + Maior);
Console.WriteLine("O menor valor é: " + Menor);


