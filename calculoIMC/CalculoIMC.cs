float Massa;
float Altura;
float IMC;

Console.Write("Digite a massa (Kg): ");
Massa = float.Parse(Console.ReadLine());

Console.Write("Digite a altura (m): ");
Altura = float.Parse(Console.ReadLine());

IMC = Massa / (Altura * Altura);

Console.WriteLine("O IMC é: " + IMC);

if (IMC < 17)
{
    Console.WriteLine("Muito abaixo do peso!");
}
else if (IMC >= 17 && IMC <= 18.5)
{
    Console.WriteLine("Abaixo do peso!");
}
else if (IMC >= 18.5 && IMC < 25)
{
    Console.WriteLine("Peso ideal!");
}
else if (IMC >= 25 && IMC < 30)
{
    Console.WriteLine("Sobrepeso!");
}
else if (IMC >= 30 && IMC < 35)
{
    Console.WriteLine("Obesidade!");
}
else if (IMC >= 35 && IMC < 40)
{
    Console.WriteLine("Obesidade severa!");
}
if (IMC > 40)
{
    Console.WriteLine("Obesidade mórbida!");
}



