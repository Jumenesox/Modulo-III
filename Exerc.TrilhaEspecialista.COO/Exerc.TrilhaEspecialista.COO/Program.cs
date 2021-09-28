using System;

namespace Exerc.TrilhaEspecialista.COO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente() { BancoConta = "Nubank"};
            ContaPoupanca contaPoupanca = new ContaPoupanca() { BancoConta = "Itaú", NomeTitular = "Guilherme", PorcentagemRendimento = 5 };

            contaCorrente.DepositaDinheiro(500);
            contaCorrente.SacaDinheiro(250);

            Console.WriteLine($"A conta poupança: {contaPoupanca.BancoConta} pertence a {contaPoupanca.NomeTitular} e rende {contaPoupanca.PorcentagemRendimento}% ao ano");
            contaPoupanca.DepositaDinheiro(800);
            contaPoupanca.SacaDinheiro(900);         
            contaPoupanca.CalculaRendimento(15);
            contaPoupanca.TransfereTitularidade("Erick");
        }
    }
}


