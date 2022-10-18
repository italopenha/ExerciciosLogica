string[] nome = new string[5];
float[] n1 = new float[5];
float[] n2 = new float[5];
float[] m = new float[5];
int c, tot = 0;
float SM = 0, MT;

for (c = 1; c <= 4; c++) {
    Console.WriteLine("ALUNO " + c);
    Console.Write("Nome: ");
    nome[c] = Console.ReadLine();

    Console.Write("Primeira Nota: ");
    n1[c] = int.Parse(Console.ReadLine());
    Console.Write("Segunda Nota: ");
    n2[c] = int.Parse(Console.ReadLine());

    m[c] = (n1[c] + n2[c]) / 2;
    SM = SM + m[c];
}

MT = SM / 4;

Console.Clear();

Console.WriteLine("LISTAGEM DE ALUNOS");
Console.WriteLine("------------------");

for (c = 1; c <= 4; c++) {
    Console.WriteLine(nome[c] + " " + m[c]);

    if (m[c] > MT) {
        tot = tot + 1;
    }
}

Console.WriteLine("Ao todo temos " + tot + " alunos acima da média que é " + MT);