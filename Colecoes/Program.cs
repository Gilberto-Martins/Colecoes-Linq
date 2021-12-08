using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */



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



            //Ordenado Arrays

            int[] array = new int[5] {5, 3, 8, 1, 9};
            int[] arrayCopy = new int[10];

            OperacoesArray op = new OperacoesArray();

            

            int valor = 8;

            Console.Clear();

            int indece = op.ObterIndece(array, valor);

            if(indece > -1)
            {
                Console.WriteLine("O indece do elelemto {0} é {1}",valor, indece);
            }
            else
            {
                Console.WriteLine("O valor não existente");
            }

            // int valorAchando = op.ObterValor(array, valor);

            // if(valorAchando > 0)
            // {
            //     Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     Console.WriteLine("Valor não encontrado");
            // }




            // bool todos = op.TodosMaior(array, valor);

            // Console.Clear();

            // if(todos)
            // {
            //     Console.WriteLine("Todos maior que {0}", valor);
            // }
            // else
            // {
            //     Console.WriteLine("Nem todos maior que {0}", valor);
            // }

            //bool existe = op.Existe(array, valor);

            //Console.Clear();

            //if(existe)
            //{
            //    Console.WriteLine("existe");
            //}
            //else
            //{
            //    Console.WriteLine("não exite");
            //}
            
            //Console.WriteLine("Array original");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);

            // Console.WriteLine("Array antes de copiar:");
            // op.ImprimirArray(arrayCopy);

            // op.Copiar(ref array, ref arrayCopy);
            // Console.WriteLine(" ");
            // Console.WriteLine("Array copiado:");
            // op.ImprimirArray(arrayCopy);



        }
    }
}
