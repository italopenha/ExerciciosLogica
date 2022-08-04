int Inicio = 0;
int Fim = 0;

Console.WriteLine("CONTADOR INTELIGENTE");
Console.WriteLine("--------------------");

Console.Write("Digite o primeiro valor: ");
Inicio = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
Fim = int.Parse(Console.ReadLine());

if (Inicio < Fim)
{
    for (int i = Inicio; i <= Fim; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = Inicio; i >= Fim; i--)
    {
        Console.WriteLine(i);
    }
}
