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
        public FrmInicial()
        {
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
    }
}
