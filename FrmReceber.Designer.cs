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
            this.LblPlacaVeiculo = new System.Windows.Forms.Label();
            this.CbPlaca = new System.Windows.Forms.ComboBox();
            this.LblSaldoPagar = new System.Windows.Forms.Label();
            this.TxSaldo = new System.Windows.Forms.TextBox();
            this.LblValorPago = new System.Windows.Forms.Label();
            this.TxValorPago = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPlacaVeiculo
            // 
            this.LblPlacaVeiculo.AutoSize = true;
            this.LblPlacaVeiculo.Location = new System.Drawing.Point(45, 47);
            this.LblPlacaVeiculo.Name = "LblPlacaVeiculo";
            this.LblPlacaVeiculo.Size = new System.Drawing.Size(93, 13);
            this.LblPlacaVeiculo.TabIndex = 1;
            this.LblPlacaVeiculo.Text = "Placa do Veiculo: ";
            // 
            // CbPlaca
            // 
            this.CbPlaca.FormattingEnabled = true;
            this.CbPlaca.Location = new System.Drawing.Point(48, 77);
            this.CbPlaca.Name = "CbPlaca";
            this.CbPlaca.Size = new System.Drawing.Size(75, 21);
            this.CbPlaca.TabIndex = 1;
            this.CbPlaca.SelectedIndexChanged += new System.EventHandler(this.comboPlaca_SelectedIndexChanged);
            // 
            // LblSaldoPagar
            // 
            this.LblSaldoPagar.AutoSize = true;
            this.LblSaldoPagar.Location = new System.Drawing.Point(46, 114);
            this.LblSaldoPagar.Name = "LblSaldoPagar";
            this.LblSaldoPagar.Size = new System.Drawing.Size(77, 13);
            this.LblSaldoPagar.TabIndex = 3;
            this.LblSaldoPagar.Text = "Saldo a Pagar:";
            // 
            // TxSaldo
            // 
            this.TxSaldo.Location = new System.Drawing.Point(48, 154);
            this.TxSaldo.Name = "TxSaldo";
            this.TxSaldo.Size = new System.Drawing.Size(75, 20);
            this.TxSaldo.TabIndex = 2;
            // 
            // LblValorPago
            // 
            this.LblValorPago.AutoSize = true;
            this.LblValorPago.Location = new System.Drawing.Point(45, 199);
            this.LblValorPago.Name = "LblValorPago";
            this.LblValorPago.Size = new System.Drawing.Size(61, 13);
            this.LblValorPago.TabIndex = 5;
            this.LblValorPago.Text = "Valor pago:";
            // 
            // TxValorPago
            // 
            this.TxValorPago.Location = new System.Drawing.Point(48, 235);
            this.TxValorPago.Name = "TxValorPago";
            this.TxValorPago.Size = new System.Drawing.Size(75, 20);
            this.TxValorPago.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(48, 286);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 341);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxValorPago);
            this.Controls.Add(this.LblValorPago);
            this.Controls.Add(this.TxSaldo);
            this.Controls.Add(this.LblSaldoPagar);
            this.Controls.Add(this.CbPlaca);
            this.Controls.Add(this.LblPlacaVeiculo);
            this.Name = "FrmReceber";
            this.Text = "Recebimento";
            this.Load += new System.EventHandler(this.FrmReceber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPlacaVeiculo;
        private System.Windows.Forms.ComboBox CbPlaca;
        private Label LblSaldoPagar;
        private TextBox TxSaldo;
        private Label LblValorPago;
        private TextBox TxValorPago;
        private Button btnSalvar;
    }
}