using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 2, 5, 0, 8, 9, 12, 9, 8, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var unicos = arrayNumeros.Distinct().ToArray();


            System.Console.WriteLine($"Valor Mínimo: {minimo}");
            System.Console.WriteLine($"Valor Máximo: {maximo}");
            System.Console.WriteLine($"Valor Médio: {medio}");
            System.Console.WriteLine($"Soma dos valore: {soma}");

            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array com números distintos: {string.Join(", ", unicos)}");





            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 ==0
            //         orderby num
            //         select num;
            // System.Console.WriteLine("Numeros pares Query " + string.Join(", ",numerosParesQuery));


            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            // System.Console.WriteLine("Numeros pares Método " + string.Join(", ",numerosParesMetodo));



                        //Dicionarios
            // Dictionary <string, string> estados =  new Dictionary <string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("PE", "Pernambuco");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     // System.Console.WriteLine($"Chave: {item.Key}, {item.Value}");
            // }

            //string valorProcurado = "PE";
            //var teste = estados["RJ"];


            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave: {valorProcurado} não existe no dicionário");
            // }



            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, {item.Value}");
            // }

            // System.Console.WriteLine("Valor original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualização dicionario";

            // System.Console.WriteLine("Valor atualização dicionario: ");
            // System.Console.WriteLine(estados[valorProcurado]);



                        //Stack(pilha) LiFo
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push("Orgulho e Preconceito");
            // pilhaLivros.Push("1984");
            // pilhaLivros.Push("Dom Quixote de la Mancha");



            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para ler: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");



                    //Queue(fila) FiFo
            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Ana");
            // fila.Enqueue("Carolina");
            // fila.Enqueue("Beatriz");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count >0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()}, atendida");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");



                         //Colecoes Genéricas
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>();
            // string[] estadosArray = new string[3] {"PE", "PB", "RN"};

            // estados.Add("AL");
            // estados.Add("SE");
            // estados.Add("BA");

            // System.Console.WriteLine($"Quantidade de elementos na Lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // // System.Console.WriteLine("Removendo o elemento: ");
            // // estados.Remove("AL");

            // //estados.AddRange(estadosArray);
            // estados.Insert(2, "CE");

            // opLista.ImprimirListaString(estados);

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Indice {i}, Valor: {estados[i]}");
            // }


                         //ARRAYS - Manipulação
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {8, 9, 4, 6, 3};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // //int ValorProcurado = 6;


            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade do array após redimencionar: {array.Length}");

            // int indice = op.ObterIndice(array, ValorProcurado);
            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"O Índice do elemento {ValorProcurado} é {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }

            // int ValorAchado = op.ObterValor(array, ValorProcurado);

            // if(ValorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", ValorAchado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", ValorProcurado);
            // }
            // bool todosMaiorQue = op.TodosMaiorQue(array, ValorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos são maiores que {0}", ValorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe(m) valor(es) que não é/são maior(es) que {0}", ValorProcurado);
            // }


            // bool existe = op.Existe(array, ValorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", ValorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", ValorProcurado);
            // }

            // System.Console.WriteLine("Array Original: ");
            // op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.WriteLine("Array Ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da Cópia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array depois da cópia: ");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4, 2]
            // {
            //     {2, 4},
            //     {10, 12},
            //     {24, 48},
            //     {60, 120}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            //matriz[0, 0] = 5;

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;


            // System.Console.WriteLine("Percorrendo arrays pelo For:");
            // for (int i = 0; i < arrayInteiros.Length ; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}