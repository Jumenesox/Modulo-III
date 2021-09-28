using System;
using System.Collections.Generic;
using System.Text;

namespace ExercComplementar01
{
    class ReajusteDeSalario
    {
        static void Main(string[] args)
        {
            float[,] matrizSalarios = new float[10, 2];
            matrizSalarios = insereFuncionarios();
        }

        public static float[,] insereFuncionarios()
        {
            int j = 0;
           
            float[,] salarioTempoCasa = new float[10,2];

            for (int i = 0; i < 10; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(j % 2 == 0 ? $"Insira o salário atual do funcionário {i + 1}" : $"Insira o tempo de casa do funcionário {i + 1}");
                    salarioTempoCasa[i, j] = float.Parse(Console.ReadLine());
                    if (j % 2 != 0)
                    {

                        if (salarioTempoCasa[i, 1] < 5)
                        {
                            Console.WriteLine("Sem ajustes");
                        }
                        else if (salarioTempoCasa[i, 1] == 5)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.20f}");
                        }
                        else if (salarioTempoCasa[i, 1] == 6)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.25f}");
                        }
                        else if (salarioTempoCasa[i, 1] == 7)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.30f}");
                        }
                        else if (salarioTempoCasa[i, 1] == 8)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.40f}");
                        }
                        else if (salarioTempoCasa[i, 1] == 9)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.50f}");
                        }
                        else if (salarioTempoCasa[i, 1] >= 10)
                        {
                            Console.WriteLine($"Novo salário: {salarioTempoCasa[i, 0] += salarioTempoCasa[i, 0] * 0.60f}");
                        }
                    }
                }           
            }

            return salarioTempoCasa;
        }

    }
}
