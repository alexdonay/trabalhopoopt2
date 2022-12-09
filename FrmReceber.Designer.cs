using System.Windows.Forms;

namespace trabalhopoopt2
{
    partial class FrmReceber :  Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlacaDoVeiculo = new System.Windows.Forms.Label();
            this.comboPlaca = new System.Windows.Forms.ComboBox();
            this.saldoPagar = new System.Windows.Forms.Label();
            this.textPagar = new System.Windows.Forms.TextBox();
            this.saldoAReceber = new System.Windows.Forms.Label();
            this.valorPago = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlacaDoVeiculo
            // 
            this.PlacaDoVeiculo.AutoSize = true;
            this.PlacaDoVeiculo.Location = new System.Drawing.Point(318, 42);
            this.PlacaDoVeiculo.Name = "PlacaDoVeiculo";
            this.PlacaDoVeiculo.Size = new System.Drawing.Size(93, 13);
            this.PlacaDoVeiculo.TabIndex = 1;
            this.PlacaDoVeiculo.Text = "Placa do Veiculo: ";
            // 
            // comboPlaca
            // 
            this.comboPlaca.FormattingEnabled = true;
            this.comboPlaca.Location = new System.Drawing.Point(321, 76);
            this.comboPlaca.Name = "comboPlaca";
            this.comboPlaca.Size = new System.Drawing.Size(121, 21);
            this.comboPlaca.TabIndex = 2;
            this.comboPlaca.SelectedIndexChanged += new System.EventHandler(this.comboPlaca_SelectedIndexChanged);
            // 
            // saldoPagar
            // 
            this.saldoPagar.AutoSize = true;
            this.saldoPagar.Location = new System.Drawing.Point(321, 123);
            this.saldoPagar.Name = "saldoPagar";
            this.saldoPagar.Size = new System.Drawing.Size(79, 13);
            this.saldoPagar.TabIndex = 3;
            this.saldoPagar.Text = "Saldo  a pagar:";
            // 
            // textPagar
            // 
            this.textPagar.Location = new System.Drawing.Point(321, 155);
            this.textPagar.Name = "textPagar";
            this.textPagar.Size = new System.Drawing.Size(100, 20);
            this.textPagar.TabIndex = 4;
            this.textPagar.TextChanged += new System.EventHandler(this.textPagar_TextChanged);
            // 
            // saldoAReceber
            // 
            this.saldoAReceber.AutoSize = true;
            this.saldoAReceber.Location = new System.Drawing.Point(321, 204);
            this.saldoAReceber.Name = "saldoAReceber";
            this.saldoAReceber.Size = new System.Drawing.Size(61, 13);
            this.saldoAReceber.TabIndex = 5;
            this.saldoAReceber.Text = "Valor pago:";
            // 
            // valorPago
            // 
            this.valorPago.Location = new System.Drawing.Point(321, 236);
            this.valorPago.Name = "valorPago";
            this.valorPago.Size = new System.Drawing.Size(100, 20);
            this.valorPago.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(336, 287);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.valorPago);
            this.Controls.Add(this.saldoAReceber);
            this.Controls.Add(this.textPagar);
            this.Controls.Add(this.saldoPagar);
            this.Controls.Add(this.comboPlaca);
            this.Controls.Add(this.PlacaDoVeiculo);
            this.Name = "FrmReceber";
            this.Text = "FrmReceber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PlacaDoVeiculo;
        private System.Windows.Forms.ComboBox comboPlaca;
        private Label saldoPagar;
        private TextBox textPagar;
        private Label saldoAReceber;
        private TextBox valorPago;
        private Button btnSalvar;
    }
}