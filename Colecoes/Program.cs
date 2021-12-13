using System;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            int[] arrayNumeros = new int[10]{ 100, 1, 4, 8, 15, 19, 0, 19, 4, 100 };

            var mine = arrayNumeros.Min();//minimo
            var max = arrayNumeros.Max();//maximo
            var medio = arrayNumeros.Average();//media
            var soma = arrayNumeros.Sum();//somar todos os valores do array
            var arrayUnico = arrayNumeros.Distinct().ToArray();//ira oegar o valor uma unica ves, não ira pegar repetidos

            Console.Clear();
            Console.WriteLine($"Valor minimo: {mine}");
            Console.WriteLine($"Valor maximo: {max}");
            Console.WriteLine($"Valor medio: {medio}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Array original: {string.Join(",", arrayNumeros)}");
            Console.WriteLine($"Array distinto: {string.Join(",",arrayUnico)}");
            


            // var numerosPar = 
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;
            

            // var numerosParMenor = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // Console.WriteLine("Numeros pares query: "+ string.Join(",", numerosPar));
            // Console.WriteLine("Numeros pares metodo: "+ string.Join(",", numerosParMenor));





            //o primeiro string é a chave o segundo é o valor
            // Dictionary<string, string> estados = new Dictionary<string, string>();
            // estados.Add("PE", "Pernambuco");
            // estados.Add("SP", "São Paulo");
            // estados.Add("RJ", "Rio De Janero");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // Console.Clear();
            // // foreach (KeyValuePair<string, string> item in estados)
            // // {
            // //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // // }

            // // Console.WriteLine("----------------------------");
            // // Console.WriteLine("Digite 1 para alterar o valor de PE");
            // // Console.WriteLine("Digite 2 Para alterar o valor de SP");
            // // Console.WriteLine("Digite 3 para alterar o valor de RJ");
            // // Console.WriteLine("Digite 4 para alterar o valor de MG");
            // // Console.WriteLine("Digite 5 para alterar o valor de BA");
            // // int valor = 0;
            // // valor = Convert.ToInt32(Console.ReadLine());

            // // switch (valor)
            // // {
            // //     case 1:
            // //         estados["PE"] = "Recife";
            // //         break;
                
            // //     case 2:
            // //         estados["SP"] = "Ribeirão Preto";
            // //         break;

            // //     case 3:
            // //         estados["RJ"] = "Petrópolis";
            // //         break;

            // //     case 4:
            // //         estados["MG"] = "Belo Horizonte";
            // //         break;
                
            // //     case 5:
            // //         estados["BA"] = "Salvador";
            // //         break;

            // //     default:
            // //         Console.WriteLine("Opção não encontrada");
            // //         break;
            // // }
            // // Console.WriteLine("----------------------------");

            // // foreach (KeyValuePair<string, string> item in estados)
            // // {
            // //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // // }
            // // Console.WriteLine();

            // string valor = "SC";

            // // var test = estados["SC"];

            // if(estados.TryGetValue(valor, out string estadoEncontrado))
            // {
            //     Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     Console.WriteLine($"Chave {estadoEncontrado} não existe no dicionário.");
            // }


            // Console.WriteLine("Removendo valor de BA");
            // estados.Remove("BA");
            // Console.WriteLine();
            
            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            



            //Coleções Específicas
            //Stack

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET"); // metodo push adiciona
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo limpo");


            // Console.Clear();
            // Console.WriteLine($"Livros para ler: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     Console.WriteLine("------------------------------");
            //     Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
            //     Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso"); // metodo pop remove
            //     Console.WriteLine("------------------------------");
            // }

            // Console.WriteLine($"Livros para ler: {pilhaLivros.Count}");





            //Fila
            // Queue<string> fila = new Queue<string>();

            // Console.Clear();
            // fila.Enqueue("Fulano"); // metodo Enqueue adiciona elementos na fila
            // fila.Enqueue("Eduarda");
            // fila.Enqueue("Paula");
            // fila.Enqueue("Neto");

            // Console.WriteLine($"Pessoas na Fila: {fila.Count}");
            // while (fila.Count > 0) // metodo Count é o tamanho da fila
            // {
            //     Console.WriteLine($"Vez de : {fila.Peek()}"); // metodo Peek pretorna o primeiro elemento da fila
            //     Console.WriteLine($"{fila.Dequeue()} atendido");// metodo Dequeue vai pega o primeiro elemento da fila retorna e removela
            // }

            // Console.WriteLine($"Pessoas na fila: {fila.Count}");


            // OperacoesList op = new OperacoesList();
            // List<string> estados = new List<string>{"SP","MG","PE"};
            // string[] estadosArray = new string[2] {"SC","MT"};

            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("PE");

            // Console.Clear();
            // Console.WriteLine("Quantidade de ele mentos na lista: {0}",estados.Count);

            

            // op.ImprimirListString(estados);
            // Console.WriteLine("---------");
            // Console.WriteLine("------------");
            // estados.Remove("MG");
            // op.ImprimirListString(estados);

            //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // op.ImprimirListString(estados);
            
            
            
            
            
            
            
            // foreach (var item in estados)
            // {
            //     Console.WriteLine(item);
            // }
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

            // int[] array = new int[5] {5, 3, 8, 1, 9};
            // int[] arrayCopy = new int[10];

            // OperacoesArray op = new OperacoesArray();

            // string[] arrayString = op.ConverteParaArrauString(array);

            

            //int valor = 8;

            // Console.Clear();

            // Console.WriteLine("Capacidade atural do array {0}",array.Length);

            // op.RedimencionarArray(ref array, array.Length * 2);

            // Console.WriteLine("Nova Capacidade do array {0}", array.Length);

            // int indece = op.ObterIndece(array, valor);

            // if(indece > -1)
            // {
            //     Console.WriteLine("O indece do elelemto {0} é {1}",valor, indece);
            // }
            // else
            // {
            //     Console.WriteLine("O valor não existente");
            // }

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
