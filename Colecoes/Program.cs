using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 2]
            {
                {8, 8},
                {10, 20},
                {50, 100},
                {90, 200}
            };

            //linhas
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int a = 0; a <matriz.GetLength(1); a++)
                {
                    Console.WriteLine(matriz[i, a]);
                }
            }



            /*
            int[] ArrayInteiros = new int[3];

            ArrayInteiros[0] = 10;
            ArrayInteiros[1] = 20;
            ArrayInteiros[2] = 30;

            Console.WriteLine("For");
            for(int i = 0; i < ArrayInteiros.Length; i++)
            {
                Console.WriteLine(ArrayInteiros[i]);
            }

            Console.WriteLine("Foreach");
            foreach (int item in ArrayInteiros)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
