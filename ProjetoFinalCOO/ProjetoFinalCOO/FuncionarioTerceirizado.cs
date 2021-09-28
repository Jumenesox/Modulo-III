using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinalCOO
{
    class FuncionarioTerceirizado : Funcionario
    {
        private String _empresaOrigem;

        public String EmpresaOrigem
        {
            get
            {
                return _empresaOrigem;
            }
            set
            {
                if (value.Length > 3)
                {
                    _empresaOrigem = value;
                }
                else
                    Console.WriteLine("Nome de empresa inválido, tente novamente");
            }
        }

        public double TaxaServico { get; set; }

        public FuncionarioTerceirizado() { }

        public FuncionarioTerceirizado(String nome, int cargaHoraria, double valorHora, String empresaOrigem, double taxaServico)
            : base(nome, cargaHoraria, valorHora) 
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }


        public override double CalculaSalario()
        {
            double salarioBase = base.CalculaSalario();
            return salarioBase += salarioBase * (TaxaServico / 100);
        }

        public override void ImprimeDados()
        {
            base.ImprimeDados() ;
            Console.WriteLine("\nEmpresa do funcionário: " + EmpresaOrigem);
        }
    }
}
