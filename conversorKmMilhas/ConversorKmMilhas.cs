float Km;
float Mi;

Console.Write("Quantos Km? ");
Km = float.Parse(Console.ReadLine());

Mi = Km / 1.609f;

Console.Write("São " + Mi + " em milhas.");
