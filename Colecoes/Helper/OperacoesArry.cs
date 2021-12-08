using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int a = 0; a < array.Length - 1; a++)
                {
                    if(array[a] > array[a + 1])
                    {
                        temp = array[a + 1];
                        array[a + 1] = array[a];
                        array[a] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            Console.WriteLine(linha);
        }
    }
}