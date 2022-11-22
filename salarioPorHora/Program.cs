double SalarioMensal;
double HorasPorMes;
double SalarioPorHora;

Console.Write("Qual o seu salário mensal? ");
SalarioMensal = double.Parse(Console.ReadLine());

Console.Write("Quantas horas você trabalha por mês? ");
HorasPorMes = double.Parse(Console.ReadLine());

SalarioPorHora = SalarioMensal / HorasPorMes;

Console.WriteLine("O seu salário por horas é igual a: " + SalarioPorHora);
