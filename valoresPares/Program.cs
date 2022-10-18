int [] val = new int [8];
int i, TotPar = 0;

for(i = 1; i <= 7; i++) {
    Console.Write("Digite o " + i + "º valor: ");
    val[i] = int.Parse(Console.ReadLine());
}

for (i = 1; i <= 7; i++) {
    if (val[i] % 2 == 0) {
        TotPar = TotPar + 1;
        Console.WriteLine("Valor PAR na posição " + i);
    }
}

Console.WriteLine("O total de pares foi " + TotPar);
