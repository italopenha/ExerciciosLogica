int Soma1, Soma2;
int Subtracao1, Subtracao2;
int Multiplicacao1, Multiplicacao2;
int Divisao1, Divisao2;
int Resto1, Resto2;
float Soma;
float Subtracao;
float Multiplicacao;
float Divisao;
float Resto;

// Operador de soma (+)
Console.WriteLine("Soma");
Console.Write("Digite um número: "); 
Soma1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
Soma2 = Convert.ToInt32(Console.ReadLine());

Soma = Soma1 + Soma2;

Console.WriteLine("A soma dos dois números é: " + Soma + "\n");

// Operador de subtração (-)
Console.WriteLine("Subtração");
Console.Write("Digite um número: ");
Subtracao1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
Subtracao2 = Convert.ToInt32(Console.ReadLine());

Subtracao = Subtracao1 - Subtracao2;

Console.WriteLine("A subtração dos dois números é: " + Subtracao + "\n");

// Operador de multiplicação (*)
Console.WriteLine("Multiplicação");
Console.Write("Digite um número: ");
Multiplicacao1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
Multiplicacao2 = Convert.ToInt32(Console.ReadLine());

Multiplicacao = Multiplicacao1 * Multiplicacao2;

Console.WriteLine("A multiplicação dos dois números é: " + Multiplicacao + "\n");

// Operador de divisão (/)
Console.WriteLine("Divisão");
Console.Write("Digite um número: ");
Divisao1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
Divisao2 = Convert.ToInt32(Console.ReadLine());

Divisao = Divisao1 / Divisao2;

Console.WriteLine("A divisão dos dois números é: " + Divisao + "\n");

// Operador de resto (%)
Console.WriteLine("Resto");
Console.Write("Digite um número: ");
Resto1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
Resto2 = Convert.ToInt32(Console.ReadLine());

Resto = Resto1 % Resto2;

Console.WriteLine("O resto da divisão dos dois números é: " + Resto + "\n");







