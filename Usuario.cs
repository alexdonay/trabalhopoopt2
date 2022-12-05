using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoopt2
{
    internal abstract class Usuario : IPessoa
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public Usuario(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }
        public virtual void pagarDiaria(double valorPago) { }
        public virtual void estacionar(double quantidadeDiaria) { }
    }
}
