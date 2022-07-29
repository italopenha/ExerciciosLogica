float Nota1, Nota2, Nota3, Nota4;
float Media;

Console.Write("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
Nota2 = float.Parse(Console.ReadLine());
Console.Write("Digite a terceira nota: ");
Nota3 = float.Parse(Console.ReadLine());
Console.Write("Digite a quarta nota: ");
Nota4 = float.Parse(Console.ReadLine());

Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

Console.WriteLine("A média é: " + Media);

if (Media >= 7)
{
    Console.WriteLine("Você foi aprovado!");
}
else if (Media >= 5 && Media < 7)
{
    Console.WriteLine("Você está de recuperação!");
}
else
{
    Console.WriteLine("Você foi reprovado!");
}

switch (Media)
{
    case < 5:
        Console.WriteLine("Aproveitamento: F");
        break;
    case > 5 and < 6:
        Console.WriteLine("Aproveitamento: E");
        break;
    case > 6 and < 7:
        Console.WriteLine("Aproveitamento: D");
        break;
    case > 7 and < 8:
        Console.WriteLine("Aproveitamento: C");
        break;
    case > 8 and < 9:
        Console.WriteLine("Aproveitamento: B");
        break;
    case > 9:
        Console.WriteLine("Aproveitamento: A");
        break;
}