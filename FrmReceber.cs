using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            foreach (Cliente cliente in dados.clientes)
            {
               CbPlaca.Items.Add(cliente.placaVeiculo);
            }

        }

        private void comboPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxSaldo.Text = dados.clientes.Where(x => x.placaVeiculo == CbPlaca.Text).Select(y => y.saldo.ToString("C")).FirstOrDefault();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(CbPlaca.Text != "" || TxSaldo.Text != "" || TxValorPago.Text != "")
            {
                dados.receber(CbPlaca.Text, double.Parse(TxValorPago.Text));
                string saldo = dados.retornaSaldo(CbPlaca.Text).ToString();
                MessageBox.Show($"valor recebido e o saldo atual é: {saldo}");
                CbPlaca.Text = "";
                TxSaldo.Text = "";
                TxValorPago.Text = "";
            }
        }

        private void FrmReceber_Load(object sender, EventArgs e)
        {

        }
    }
}
