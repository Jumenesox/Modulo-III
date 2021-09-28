using System;
using System.Collections.Generic;
using System.Text;

namespace TrilhaEspecialista.Modulo.LP
{
    class VetorNumerico
    {
        static void Main(string[] args)
        {
            ExecutaAtividade();
            
        }

        public static void ExecutaAtividade()
        {
            int i;
            int[] vetorNumerico = new int[10];

            for (i = 0; i < vetorNumerico.Length; i++)
            {
                Console.WriteLine("Insira um número");
                try
                {
                    vetorNumerico[i] = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ops, valor não permitido");
                    ExecutaAtividade();
                }
            }
            PesquisaNumero(vetorNumerico);
        }
            public static void PesquisaNumero(int[] vetorNumerico)
            {
            int valorProcurado;
            int j = 0;
            Console.WriteLine("Agora, insira um número a ser pesquisado");
                try
                {
                 valorProcurado = int.Parse(Console.ReadLine());
                 var retorno = Array.Exists(vetorNumerico, x => x == valorProcurado);

                    if (retorno)
                    {
                    Console.WriteLine($"O valor {valorProcurado} foi encontrado");
                    Console.Write(valorProcurado % 2 == 0 ? "E ele é par" : "E ele é ímpar");
                    Environment.Exit(0);
                    }
                    else
                    {
                    Console.WriteLine($"O valor {valorProcurado} não foi encontrado");
                    Environment.Exit(0);
                }
                }
                catch (Exception e)
                {
                Console.WriteLine("Ops, valor não permitido");
                PesquisaNumero(vetorNumerico);
                }
            }
        }

    }
