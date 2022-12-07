using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoopt2
{
    internal class Cliente : Usuario
    {

        public double saldo { get; set; }
        public string placaVeiculo { get; set; }
        private double valorHoras {get;set;}
        public Cliente(string placaVeiculo, string nome, string cpf) : base(nome, cpf)
        {
            this.valorHoras = 5;
            this.placaVeiculo = placaVeiculo;
        }
            
        public override void pagarDiaria(double valorPago)
        {
            if (this.saldo < valorPago)
            {
                this.saldo = 0;
            }
            else
            {
                this.saldo = this.saldo-valorPago;
            }
        }
        public override void estacionar(double quantidadeDiaria)
        {
            this.saldo = (quantidadeDiaria * this.valorHoras) + this.valorHoras;
        }
    }
    
}
