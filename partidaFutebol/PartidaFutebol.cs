float Time1;
float Time2;
float DifGols;

Console.Write("Gols do time 1: ");
Time1 = float.Parse(Console.ReadLine());
Console.Write("Gols do time 2: ");
Time2 = float.Parse(Console.ReadLine());

DifGols = Time1 - Time2;

switch (DifGols)
{
    case > 0 and <= 3:
        Console.WriteLine("Diferença: " + DifGols);
        Console.WriteLine("Partida normal");
        break;
    case 0:
        Console.WriteLine("Diferença: " + DifGols);
        Console.WriteLine("Empate");
        break;
    case >= 4:
        Console.WriteLine("Diferença: " + DifGols);
        Console.WriteLine("Goleada");
        break;
}
