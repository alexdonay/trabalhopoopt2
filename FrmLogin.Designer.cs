namespace trabalhopoopt2
{
    partial class FrmLogin
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
            this.CbLogin = new System.Windows.Forms.ComboBox();
            this.TxSenha = new System.Windows.Forms.TextBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbLogin
            // 
            this.CbLogin.FormattingEnabled = true;
            this.CbLogin.Location = new System.Drawing.Point(56, 53);
            this.CbLogin.Name = "CbLogin";
            this.CbLogin.Size = new System.Drawing.Size(121, 21);
            this.CbLogin.TabIndex = 0;
            // 
            // TxSenha
            // 
            this.TxSenha.Location = new System.Drawing.Point(56, 113);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.PasswordChar = '*';
            this.TxSenha.Size = new System.Drawing.Size(121, 20);
            this.TxSenha.TabIndex = 1;
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(56, 153);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(121, 23);
            this.BtLogin.TabIndex = 2;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(53, 22);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(43, 13);
            this.LblLogin.TabIndex = 3;
            this.LblLogin.Text = "Usuário";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(53, 85);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 211);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TxSenha);
            this.Controls.Add(this.CbLogin);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbLogin;
        private System.Windows.Forms.TextBox TxSenha;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
    }
}