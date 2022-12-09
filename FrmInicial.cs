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
    public partial class FrmInicial : Form
    {
        BancoDados dados = BancoDados.getInstance();
        public FrmInicial()
        {
            if(dados.funcionarios.Count== 0)
            {
                MessageBox.Show("Cadastro de funcionários vazio iniciando com o usuário gerente");
            }
            InitializeComponent();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form frm = new FrmCadastroCliente();
            frm.Show();
        }

        private void BtnRegistrarDiaria_Click(object sender, EventArgs e)
        {
            Form frmrg= new FrmRegistrarDiaria();
            frmrg.Show();
        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {

            Form frmrg = new FrmReceber();
            frmrg.Show();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {

        }

        private void BtnTrocarUsuario_Click(object sender, EventArgs e)
        {
            Form frmrg = new FrmLogin();
            frmrg.Show();
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Form frmrg = new FrmFuncionario();
            frmrg.Show();
        }
    }
}
