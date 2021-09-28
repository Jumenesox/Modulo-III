using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc.TrilhaEspecialista.COO
{
    public class ContaCorrente
    {
        public String BancoConta { get; set; }
        protected float SaldoConta { get; set; }


        public void DepositaDinheiro(float valor)
        {
            SaldoConta += valor;
            Console.WriteLine($"Valor atual da conta {BancoConta}: R${SaldoConta}");
        }

        public void SacaDinheiro(float valor)
        {
            if (SaldoConta > valor)
                Console.WriteLine($"Valor atual da conta {BancoConta}: R${SaldoConta -= valor}");

            else
                Console.WriteLine($"Saldo insuficiente na conta {BancoConta}");

        }
    }
}
