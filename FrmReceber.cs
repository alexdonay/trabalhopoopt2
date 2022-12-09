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
    public partial class FrmReceber : Form
    {
        BancoDados dados = BancoDados.getInstance();

        public FrmReceber()
        {
            InitializeComponent();
            foreach (Cliente cliente in dados.Clientes)
            {
               comboPlaca.Items.Add(cliente.placaVeiculo);
            }

        }

        private void comboPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            textPagar.Text = dados.Clientes.Where(x => x.placaVeiculo == comboPlaca.Text).Select(y => y.saldo.ToString("C")).FirstOrDefault();
        }
    }
}
