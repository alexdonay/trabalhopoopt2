namespace trabalhopoopt2
{
    partial class FrmInicial
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
            this.BtnRegistrarDiaria = new System.Windows.Forms.Button();
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.BtnCadastrarUsuario = new System.Windows.Forms.Button();
            this.BtnTrocarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistrarDiaria
            // 
            this.BtnRegistrarDiaria.Location = new System.Drawing.Point(193, 53);
            this.BtnRegistrarDiaria.Name = "BtnRegistrarDiaria";
            this.BtnRegistrarDiaria.Size = new System.Drawing.Size(166, 23);
            this.BtnRegistrarDiaria.TabIndex = 0;
            this.BtnRegistrarDiaria.Text = "Registrar Diária";
            this.BtnRegistrarDiaria.UseVisualStyleBackColor = true;
            this.BtnRegistrarDiaria.Click += new System.EventHandler(this.BtnRegistrarDiaria_Click);
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(21, 53);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(166, 23);
            this.BtnCadastrarCliente.TabIndex = 1;
            this.BtnCadastrarCliente.Text = "Cadastrar Cliente";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = true;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // BtnReceber
            // 
            this.BtnReceber.Location = new System.Drawing.Point(365, 53);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(166, 23);
            this.BtnReceber.TabIndex = 2;
            this.BtnReceber.Text = "Receber";
            this.BtnReceber.UseVisualStyleBackColor = true;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // BtnCadastrarUsuario
            // 
            this.BtnCadastrarUsuario.Location = new System.Drawing.Point(21, 12);
            this.BtnCadastrarUsuario.Name = "BtnCadastrarUsuario";
            this.BtnCadastrarUsuario.Size = new System.Drawing.Size(166, 23);
            this.BtnCadastrarUsuario.TabIndex = 3;
            this.BtnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.BtnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.BtnCadastrarUsuario.Click += new System.EventHandler(this.BtnCadastrarUsuario_Click);
            // 
            // BtnTrocarUsuario
            // 
            this.BtnTrocarUsuario.Location = new System.Drawing.Point(365, 12);
            this.BtnTrocarUsuario.Name = "BtnTrocarUsuario";
            this.BtnTrocarUsuario.Size = new System.Drawing.Size(166, 23);
            this.BtnTrocarUsuario.TabIndex = 4;
            this.BtnTrocarUsuario.Text = "Trocar de Usuário";
            this.BtnTrocarUsuario.UseVisualStyleBackColor = true;
            this.BtnTrocarUsuario.Click += new System.EventHandler(this.BtnTrocarUsuario_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 93);
            this.Controls.Add(this.BtnTrocarUsuario);
            this.Controls.Add(this.BtnCadastrarUsuario);
            this.Controls.Add(this.BtnReceber);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Controls.Add(this.BtnRegistrarDiaria);
            this.Name = "FrmInicial";
            this.Text = "Controle de Estacionamento";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarDiaria;
        private System.Windows.Forms.Button BtnCadastrarCliente;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.Button BtnCadastrarUsuario;
        private System.Windows.Forms.Button BtnTrocarUsuario;
    }
}