using System.Collections.Generic;
using System.Linq;
namespace trabalhopoopt2
{

    sealed class BancoDados
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Funcionario> funcionarios= new List<Funcionario>(); 
        private BancoDados() { }
        private static BancoDados _instance;
        public void updateClienteSaldo(string placa)
        {
            this.clientes.FirstOrDefault(n => n.placaVeiculo == placa).estacionar(1);
        }
        public void receber(string placa, double valor)
        {
            this.clientes.FirstOrDefault(n => n.placaVeiculo == placa).pagarDiaria(valor);
        }
        public double retornaSaldo(string placa)
        {
            return this.clientes.FirstOrDefault(n => n.placaVeiculo == placa).saldo;
        }
        public static BancoDados getInstance()
        {
            if (_instance == null)
            {
                _instance = new BancoDados();
            }
            return _instance;
        }

    }
}
