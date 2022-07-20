
int saldo = 0;
string mensagem = "";

Console.WriteLine("Quanto você tem?: ");
saldo = int.Parse(Console.ReadLine());

if (saldo > 0) {
    mensagem = "Saldo Positivo!";
} else if (saldo == 0) {
    mensagem = "Saldo Zero!";
}
else {
    mensagem = "Saldo Negativo!";
}

Console.WriteLine(mensagem);
