Random valorAleatorio = new Random();

int valorInteiro = valorAleatorio.Next(1, 10);
int chuteUsuario;
bool funcionando = true;

while (funcionando)
{
    Console.Write("Digite um valor de 1 a 10: ");
    chuteUsuario = int.Parse(Console.ReadLine());

    if (chuteUsuario > valorInteiro)
    {
        Console.WriteLine("Valor maior! Digite um número menor do que " + chuteUsuario);
    }
    else if (chuteUsuario < valorInteiro)
    {
        Console.WriteLine("Valor menor! Digite um número maior do que " + chuteUsuario);
    }
    else if (chuteUsuario == valorInteiro)
    {
        Console.Write("Acertou!");
        funcionando = false;
    }
}
