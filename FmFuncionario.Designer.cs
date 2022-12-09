namespace trabalhopoopt2
{
    partial class FrmFuncionario
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
            this.TxNome = new System.Windows.Forms.TextBox();
            this.TxCPF = new System.Windows.Forms.TextBox();
            this.TxLogin = new System.Windows.Forms.TextBox();
            this.TxSenha = new System.Windows.Forms.TextBox();
            this.TxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblConfirmaSenha = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(71, 76);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(100, 20);
            this.TxNome.TabIndex = 0;
            // 
            // TxCPF
            // 
            this.TxCPF.Location = new System.Drawing.Point(71, 136);
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(100, 20);
            this.TxCPF.TabIndex = 1;
            // 
            // TxLogin
            // 
            this.TxLogin.Location = new System.Drawing.Point(71, 199);
            this.TxLogin.Name = "TxLogin";
            this.TxLogin.Size = new System.Drawing.Size(100, 20);
            this.TxLogin.TabIndex = 2;
            // 
            // TxSenha
            // 
            this.TxSenha.Location = new System.Drawing.Point(71, 260);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.Size = new System.Drawing.Size(100, 20);
            this.TxSenha.TabIndex = 3;
            // 
            // TxConfirmarSenha
            // 
            this.TxConfirmarSenha.Location = new System.Drawing.Point(71, 314);
            this.TxConfirmarSenha.Name = "TxConfirmarSenha";
            this.TxConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.TxConfirmarSenha.TabIndex = 4;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(71, 60);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome:";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(71, 120);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(30, 13);
            this.LblCPF.TabIndex = 6;
            this.LblCPF.Text = "CPF:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(71, 183);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(92, 13);
            this.LblLogin.TabIndex = 7;
            this.LblLogin.Text = "Nome de Usuário:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(71, 244);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 8;
            this.LblSenha.Text = "Senha";
            // 
            // LblConfirmaSenha
            // 
            this.LblConfirmaSenha.AutoSize = true;
            this.LblConfirmaSenha.Location = new System.Drawing.Point(71, 298);
            this.LblConfirmaSenha.Name = "LblConfirmaSenha";
            this.LblConfirmaSenha.Size = new System.Drawing.Size(88, 13);
            this.LblConfirmaSenha.TabIndex = 9;
            this.LblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(74, 393);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(97, 23);
            this.BtnGravar.TabIndex = 10;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.LblConfirmaSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxConfirmarSenha);
            this.Controls.Add(this.TxSenha);
            this.Controls.Add(this.TxLogin);
            this.Controls.Add(this.TxCPF);
            this.Controls.Add(this.TxNome);
            this.Name = "FrmFuncionario";
            this.Text = "Cadastro de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.TextBox TxCPF;
        private System.Windows.Forms.TextBox TxLogin;
        private System.Windows.Forms.TextBox TxSenha;
        private System.Windows.Forms.TextBox TxConfirmarSenha;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblConfirmaSenha;
        private System.Windows.Forms.Button BtnGravar;
    }
}