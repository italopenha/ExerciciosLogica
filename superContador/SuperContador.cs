using System;

namespace SuperContador 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int C = 0;
            char N;

            Console.WriteLine("-----------------");
            Console.WriteLine("|     MENU      |");
            Console.WriteLine("-----------------");
            Console.WriteLine("| [1] De 1 a 10 |");
            Console.WriteLine("| [2] De 10 a 1 |");
            Console.WriteLine("| [3] Sair      |");
            Console.WriteLine("-----------------");

            Console.Write("Digite a opção desejada: ");
            N = char.Parse(Console.ReadLine());

            if (N == '1') {
                for (int i = 1; i <=10; i++)
                    Console.WriteLine(i);
                    Main(args);
            }
            else if (N == '2') {
                for (int i = 10; i >=1; i--)
                    Console.WriteLine(i);
                    Main(args);
            }
            else if (N == '3') {
                Console.Clear();
            }
        }
    }
}
