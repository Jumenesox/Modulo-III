using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc.TrilhaEspecialista.COO
{
    class ContaPoupanca : ContaCorrente
    {
        public float PorcentagemRendimento { get; set; }

        public String NomeTitular { get; set; }


        public void CalculaRendimento(int anos)
        {
            SaldoConta += PorcentagemRendimento * anos;
            Console.WriteLine($"Daqui a {anos} anos você terá R${SaldoConta}");
        }

        public void TransfereTitularidade(string nome)
        {
            NomeTitular = nome;
            Console.WriteLine($"Novo titular da conta {BancoConta}: {NomeTitular}");
        }
    }
}
