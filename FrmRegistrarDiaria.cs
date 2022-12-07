using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhopoopt2
{
    public partial class FrmRegistrarDiaria : Form
    {
        BancoDados dados = BancoDados.getInstance();

        public FrmRegistrarDiaria()
        {
            InitializeComponent();
        }

        private void FrmRegistrarDiaria_Load(object sender, EventArgs e)
        {
            

            foreach(Cliente cliente in dados.Clientes)
            {
                CbCliente.Items.Add(cliente.placaVeiculo);
            }
            

        }

        private void BtnRegistraDiaria_Click(object sender, EventArgs e)
        {
            dados.Clientes.Where(cl => cl.placaVeiculo == CbCliente.Text).Select(sr => sr.saldo++);
            dados.Clientes.FirstOrDefault(n => n.placaVeiculo == CbCliente.Text).saldo = 12;
            var d = dados.Clientes.FirstOrDefault(n => n.placaVeiculo == CbCliente.Text).saldo;
            MessageBox.Show(d.ToString());


         }
    }
}
