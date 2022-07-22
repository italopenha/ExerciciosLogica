float Fahrenheit;
float Celsius;

Console.Write("Qual a temperatura em fahrenheit? ");
Fahrenheit = float.Parse(Console.ReadLine());

Celsius = (Fahrenheit - 32) / 1.8f;

Console.Write("A temperatura em celsius é " + Celsius + ".");
