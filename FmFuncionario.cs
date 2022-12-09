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
    public partial class FrmFuncionario : Form
    {
        BancoDados dados = BancoDados.getInstance();
        public FrmFuncionario()
        {
            InitializeComponent();
          
        }

      

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (TxCPF.Text == "" || TxLogin.Text == "" || TxNome.Text == "" || TxSenha.Text ==""|| TxConfirmarSenha.Text == ""|| TxSenha.Text != TxConfirmarSenha.Text)
            {
                MessageBox.Show("Faltam dados ou a senha de confirmação não é igual a senha");
            }
            else
            {
                Funcionario func = new Funcionario(TxCPF.Text,TxNome.Text,TxLogin.Text, TxSenha.Text);
                dados.funcionarios.Add(func);
                MessageBox.Show("Funcionário cadastrado com sucesso");
            }
        }
    }
}
