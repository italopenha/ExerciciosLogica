int Contador = 0;
int Valor;

Console.Write("Quer contar até quanto? ");
Valor = int.Parse(Console.ReadLine());

while (Contador <= Valor)
{
    Console.WriteLine(Contador);
    Contador++;
}