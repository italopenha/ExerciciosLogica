namespace Fatorial
{
    class Fatorial
    {

        static void Main(string[] args)
        {

            int C;
            int N;
            int F = 1;
            char R;

            Console.WriteLine("DESCOBRIR FATORIAL");
            Console.WriteLine("-----------------");
            Console.Write("Digite um valor: ");
            N = int.Parse(Console.ReadLine());

            C = N;

            do
            {
                Console.Write(C + " x ");
                F = F * C;
                C--;
            }

            while (C >= 1);

            Console.WriteLine("\n" + "O valor fatorial de " + N + " é " + F);

            Console.Write("Fazer novamente? (S/N) ");
            R = char.Parse(Console.ReadLine());

            if (R == 'S' || R == 's')
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("\n" + "Obrigado por usar o programa!");
            }
        }
    }
}