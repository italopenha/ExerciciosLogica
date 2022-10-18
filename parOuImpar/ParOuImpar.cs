int N;

Console.Write("Digite um número: ");
N = int.Parse(Console.ReadLine());

static string ParOuImpar(int V)
{
    if (V % 2 == 0)
    {
        return "par.";
    }
    else
    {
        return "ímpar.";
    }
}

string R = ParOuImpar(N);

Console.Write("O número " + N + " é um valor " + R);
