int Ano;
int AnoNascimento;
int Idade;

Console.WriteLine("DESCOBRIR IDADE");

Console.Write("Em que ano estamos? ");
Ano = int.Parse(Console.ReadLine());

Console.Write("Em que ano você nasceu? ");
AnoNascimento = int.Parse(Console.ReadLine());

Idade = Ano - AnoNascimento;

Console.WriteLine("Você tem " + Idade + " anos.");

if (Idade < 18)
{
    Console.WriteLine("Você ainda não atingiu a maioridade.");
}
else
{
    Console.WriteLine("Você já atingiu a maioridade.");
}
