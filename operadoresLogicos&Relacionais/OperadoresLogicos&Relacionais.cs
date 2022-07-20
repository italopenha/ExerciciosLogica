float L1, L2, L3;
bool EQ, ES, TRI;

Console.Write("Digite o primeiro lado: ");
L1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo lado: ");
L2 = float.Parse(Console.ReadLine());

Console.Write("Digite o terceiro lado: ");
L3 = float.Parse(Console.ReadLine());

TRI = (L1 < L2 + L3) && (L2 < L1 + L3) && (L3 < L1 + L2);
EQ = (L1 == L2) && (L2 == L3);
ES = (L1 != L2) && (L2 != L3) && (L1 != L3);

Console.Write("Pode formar um triangulo? " + TRI + "\n");
Console.Write("O triângulo é equilátero? " + EQ + "\n");
Console.Write("O triângulo é escaleno? " + ES + "\n");