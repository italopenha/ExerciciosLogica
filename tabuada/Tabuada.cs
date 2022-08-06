int C = 1;
int N;
int R;

Console.Write("Quer ver a tabuada de qual número? ");
N = int.Parse(Console.ReadLine());

do
{
    R = C * N;
    Console.WriteLine(N + " x " + C + " = " + R);
    C++;
}

while (C <= 10);

