namespace trabalhopoopt2
{
    partial class FrmCadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxCPF = new System.Windows.Forms.TextBox();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.LblPlacaVeiculo = new System.Windows.Forms.Label();
            this.TxPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxCPF
            // 
            this.TxCPF.Location = new System.Drawing.Point(30, 107);
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(100, 20);
            this.TxCPF.TabIndex = 2;
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(30, 146);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(100, 20);
            this.TxNome.TabIndex = 3;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(27, 81);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(30, 13);
            this.LblCPF.TabIndex = 2;
            this.LblCPF.Text = "CPF:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(27, 130);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(30, 202);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(100, 23);
            this.Cadastrar.TabIndex = 4;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // LblPlacaVeiculo
            // 
            this.LblPlacaVeiculo.AutoSize = true;
            this.LblPlacaVeiculo.Location = new System.Drawing.Point(27, 42);
            this.LblPlacaVeiculo.Name = "LblPlacaVeiculo";
            this.LblPlacaVeiculo.Size = new System.Drawing.Size(72, 13);
            this.LblPlacaVeiculo.TabIndex = 6;
            this.LblPlacaVeiculo.Text = "Placa Veiculo";
            // 
            // TxPlacaVeiculo
            // 
            this.TxPlacaVeiculo.Location = new System.Drawing.Point(30, 58);
            this.TxPlacaVeiculo.Name = "TxPlacaVeiculo";
            this.TxPlacaVeiculo.Size = new System.Drawing.Size(100, 20);
            this.TxPlacaVeiculo.TabIndex = 1;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 259);
            this.Controls.Add(this.LblPlacaVeiculo);
            this.Controls.Add(this.TxPlacaVeiculo);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.TxNome);
            this.Controls.Add(this.TxCPF);
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxCPF;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label LblPlacaVeiculo;
        private System.Windows.Forms.TextBox TxPlacaVeiculo;
    }
}

