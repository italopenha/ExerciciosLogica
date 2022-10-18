int I = 0;
string N, Pesado = null;
float P, Mai = 0;

void Topo()
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("-------- Detector de Pesado -------");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Maior peso até agora: " + Mai + "Kg");
}

for (I = 1; I <= 5; I++)
{
    Topo();

    Console.Write("Digite seu nome: ");
    N = (Console.ReadLine());
    Console.Write("Digite o peso de " + N + ": ");
    P = float.Parse(Console.ReadLine());

    if (P > Mai)
    {
        Mai = P;
        Pesado = N;
    }

    Console.Clear();
}

Topo();

Console.WriteLine("A pessoa mais pesada foi " + Pesado + ", com " + Mai + " quilos.");
