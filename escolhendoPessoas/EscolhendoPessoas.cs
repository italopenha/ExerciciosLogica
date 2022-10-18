using System;

namespace EscolhendoPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // homens com mais de 18, castanho
            // mulheres entre 25 e 30, loiras

            char S;
            int I;
            char C;
            char R;
            int Homens = 0;
            int Mulheres = 0;

            do
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("   SELETOR DE PESSOAS  ");
                Console.WriteLine("-----------------------");

                Console.Write("Qual o sexo? [M/F]");
                S = char.Parse(Console.ReadLine());

                Console.Write("Qual a idade? ");
                I = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a cor do cabelo? ");
                Console.WriteLine("-----------------------");
                Console.WriteLine("[1] Preto");
                Console.WriteLine("[2] Castanho");
                Console.WriteLine("[3] Loiro");
                Console.WriteLine("[4] Ruivo");
                C = char.Parse(Console.ReadLine());

                if (S == 'm' && I >= 18 && C == '2')
                {
                    Homens++;
                }

                else if (S == 'f' && I >= 25 && I <= 30 && C == '3')
                {
                    Mulheres++;
                }

                Console.Write("Quer continuar? [S/N]");
                R = char.Parse(Console.ReadLine());

            } while (R != 'n');

            Console.WriteLine("------------------------------------------------------------"); 
            Console.WriteLine("Total de homens com mais de 18 e cabelos castanhos " + Homens);
            Console.WriteLine("Total de mulheres entre 25 e 30 e cabelos loiros " + Mulheres);

        }
    }
}