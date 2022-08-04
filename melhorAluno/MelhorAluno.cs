int QuantAlunos;
int Contador = 1;
string NomeAluno;
string MelhorAluno = "";
float NotaAluno;
string MenorAluno;
float MelhorNota = 0;
float MenorNota;


Console.WriteLine("Melhor Aluno");
Console.WriteLine("------------");

Console.Write("Quantos alunos a turma tem? ");
QuantAlunos = int.Parse(Console.ReadLine());

while (Contador <= QuantAlunos)
{
    Console.WriteLine("------------");
    Console.WriteLine(" Aluno " + Contador);
    Console.Write("Nome: ");
    NomeAluno = Console.ReadLine();
    Console.Write("Nota: ");
    NotaAluno = float.Parse(Console.ReadLine());

    if (NotaAluno > MelhorNota)
    {
        MelhorNota = NotaAluno;
        MelhorAluno = NomeAluno;
    }
    else 
    {
        MenorNota = NotaAluno;
        MenorAluno = NomeAluno;
    }
    Contador = Contador + 1;
}

Console.WriteLine("O melhor aluno(a) foi " + MelhorAluno + " com nota " + MelhorNota + "!");



    




