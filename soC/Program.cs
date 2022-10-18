string nome;
string[] soC = new string[11];
int c, tot = 0;

for (c = 1; c <= 10; c++) {
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    if (nome.Contains("C")) {
        tot = tot + 1;
        soC[tot] = nome;
    }
}

Console.Clear();

Console.WriteLine("LISTAGEM FINAL");

for (c = 1; c <= tot; c++) {
    Console.WriteLine(soC[c]);
}