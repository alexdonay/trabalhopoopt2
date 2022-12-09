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
    public partial class FrmLogin : Form

    {
        BancoDados dados = BancoDados.getInstance();
        public FrmLogin()
        {
            InitializeComponent();
            foreach (Funcionario funcionario in dados.funcionarios)
            {
                CbLogin.Items.Add(funcionario.login);
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string senha = dados.funcionarios.Where(x => x.login == CbLogin.Text).Select(y => y.password.ToString()).FirstOrDefault();
            if (TxSenha.Text == ""|| CbLogin.Text =="")
            {
                MessageBox.Show("Preencha a senha e usuário");
            }
            else
            {
                if (TxSenha.Text != senha.ToString())
                {
                    MessageBox.Show($"Senha incorreta {TxSenha.Text} {senha}");
                }
                else
                {
                    MessageBox.Show($"logado {CbLogin.Text}");
                }
            }

        }
    }
}
