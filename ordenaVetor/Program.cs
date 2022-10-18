int[] vet = new int [5];
int i, j;
int aux = 1;

for (i = 1; i <= 4; i++) {
    Console.Write("Digite um valor: ");
    vet[i] = int.Parse(Console.ReadLine());
}

for (i = 1; i <= 3; i++) {
    for (j = i + 1; j <= 4; j++) {
        if (vet[i] > vet[j]) {
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }
    }
}

for (i = 1; i <= 4; i++) {
    Console.Write("{" + vet[i] + "}");
}
