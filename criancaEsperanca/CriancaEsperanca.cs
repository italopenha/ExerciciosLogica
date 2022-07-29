char D;
float Valor;

Console.WriteLine("----------------------------------");
Console.WriteLine("        CRIANÇA ESPERANÇA         ");
Console.WriteLine("----------------------------------");
Console.WriteLine(" [1] para doar R$10 ");
Console.WriteLine(" [2] para doar R$25 ");
Console.WriteLine(" [3] para doar R$50 ");
Console.WriteLine(" [4] para doar outros valores ");
Console.WriteLine(" [5] para cancelar ");

D = Console.ReadKey().KeyChar;

switch (D)
{
    case '1':
        Valor = 10;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Você doou R$" + Valor      );
        Console.WriteLine("        Muito obrigado!           ");
        break;

    case '2':
        Valor = 25;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Você doou R$" + Valor      );
        Console.WriteLine("        Muito obrigado!           ");
        break;

    case '3':
        Valor = 50;
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Você doou R$" + Valor      );
        Console.WriteLine("        Muito obrigado!           ");
        break;

    case '4':
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Qual o valor da doação?   ");
        Valor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("        Você doou R$" + Valor      );
        Console.WriteLine("        Muito obrigado!           ");
        break;

    case '5':
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Você cancelou a doação!   ");
        break;

    default:
        Console.WriteLine("        Opção inválida!            ");
        break;
}








