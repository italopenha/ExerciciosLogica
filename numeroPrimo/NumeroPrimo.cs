using System;

namespace NumeroPrimo
{
    internal class NumeroPrimo
    {
        static void Main(string[] args)
        {
            int C = 1;
            int N;
            int ContDiv = 0;

            Console.Write("Digite um número: ");
            N = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine(C);

                if (N % C == 0) {
                    ContDiv++;
                }
                C++;
            }

            while (C <= N);

            if (ContDiv > 2) {
                Console.WriteLine("O número " + N + " não é primo!");
            }
            else {
                Console.WriteLine("O número " + N + " é primo!");
            }


        }
    }
}
