string Nome;
float Sal;
int Dep;
float NSal;

Console.Write("Qual o nome do funcionário? ");
Nome = Console.ReadLine();

Console.Write("Qual o salário do funcionário? R$");
Sal = float.Parse(Console.ReadLine());

Console.Write("Qual a quantidade de dependentes? ");
Dep = int.Parse(Console.ReadLine());

switch (Dep)
{
    case 0:
        NSal = Sal + (Sal * 5/100);
        Console.WriteLine("O novo salário de " + Nome + " é R$ " + NSal);
        break;
    case 1 or 2 or 3:
        NSal = Sal + (Sal * 10/100);
        Console.WriteLine("O novo salário de " + Nome + " é R$ " + NSal);
        break;
    case 4 or 5 or 6:
        NSal = Sal + (Sal * 15/100);
        Console.WriteLine("O novo salário de " + Nome + " é R$ " + NSal);
        break;
    case 7 or 8 or 9:
        NSal = Sal + (Sal * 18/100);
        Console.WriteLine("O novo salário de " + Nome + " é R$ " + NSal);
        break;
    default:
        break;
}

