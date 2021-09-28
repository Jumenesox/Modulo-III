using System;

namespace ProjetoFinalCOO
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int cargaHoraria;
            double valorHora;

            Console.WriteLine("Informe o nome do funcionário");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a jornada em horas do funcionário: " + nome);
            cargaHoraria = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora do funcionário: " + nome);
            valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("O funcionário " + nome + " é terceirizado? (S/N)");   
            switch(Console.ReadLine())
            {
                case "S":
                    Console.WriteLine("Informe o nome da empresa em que " + nome + " trabalha");
                    String nomeEmpresa = Console.ReadLine();
                    Console.WriteLine("Informe a taxa de serviço que a " + nomeEmpresa + " cobra (em porcentagem)");
                    double taxaServico = double.Parse(Console.ReadLine());
                    Funcionario funcionarioTerceirizado = new FuncionarioTerceirizado(nome, cargaHoraria, valorHora, nomeEmpresa, taxaServico);
                    funcionarioTerceirizado.ImprimeDados();
                    break;
                case "N":
                    Funcionario funcionarioComum = new Funcionario(nome, cargaHoraria, valorHora);
                    funcionarioComum.ImprimeDados();
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
                    
            }
        }
    }
}
