int N;
int C = 1;
int TotalNegativos = 0;

do {
    Console.Write("Digite um número: ");
    N = int.Parse(Console.ReadLine());
    if (N < 0) {
        TotalNegativos++;
    }
    C++;
}

while (C <= 5);

Console.WriteLine("Foram digitados " + TotalNegativos + " números negativos.");