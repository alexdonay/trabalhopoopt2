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
    public partial class FrmCadastroCliente : Form
    {
        BancoDados dados = BancoDados.getInstance();
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxPlacaVeiculo.Text ==""|| TxCPF.Text==""|| TxNome.Text=="") {
                    MessageBox.Show("Faltam Dados");
                }
                else
                {
                    Cliente cliente = new Cliente(TxPlacaVeiculo.Text, TxNome.Text, TxCPF.Text);
                    dados.clientes.Add(cliente);
                    MessageBox.Show("Cliente Cadastrado Com Sucesso");
                    TxPlacaVeiculo.Text = "";
                    TxCPF.Text = "";
                    TxNome.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
