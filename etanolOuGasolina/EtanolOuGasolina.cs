float Etanol;
float Gasolina;
float EficienciaEtanol = 0.7f;
float Resultado;

Console.Write("Qual o preço do etanol? ");
Etanol = float.Parse(Console.ReadLine());

Console.Write("Qual o preço da gasolina? ");
Gasolina = float.Parse(Console.ReadLine());

Resultado = Gasolina * EficienciaEtanol;

if (Etanol < Resultado)
{
    Console.Write("Abasteça com etanol.");
}

else
{
    Console.Write("Abasteça com gasolina.");
}
