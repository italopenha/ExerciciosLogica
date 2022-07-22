int AnoAtual;
int AnoNascimento;
int Idade;

Console.Write("Em que ano nós estamos? ");
AnoAtual = int.Parse(Console.ReadLine());

Console.Write("Em que ano você nasceu? ");
AnoNascimento = int.Parse(Console.ReadLine());

Idade = AnoAtual - AnoNascimento;

Console.Write("Você tem " + Idade + " anos.");
