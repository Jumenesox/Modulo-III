using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoFinalCOO
{
    class Funcionario
    {
        private String _nome;
        private int _cargaHoraria;
        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome inválido");
                }
                else
                    _nome = value;
            }
        }


        public int CargaHoraria
        {
            get
            {
                return _cargaHoraria;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Valor inválido");
                else
                    _cargaHoraria = value;
            }
        }

        private double ValorHora { get; set; }


        public Funcionario(String nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }

        public Funcionario() { }

        public virtual double CalculaSalario()
        {
            if (CargaHoraria > 0 && ValorHora > 0)
            {

                return ValorHora * CargaHoraria;
            }
            else
            {
                Console.WriteLine("\nO salário não pôde ser calculado, por favor, tente novamente");
                return 0;
            }
        }

        public virtual void ImprimeDados()
        {
            if (Nome != null && CargaHoraria > 0 && ValorHora > 0)
            {
                Console.WriteLine("\nNome do funcionário: " + Nome +
                "\nSalário: R$" + CalculaSalario());
            }
            else
            {
                Console.WriteLine("Um dos valores não pôde ser carregado, por favor, tente novamente");
            }
        }
    }
}
