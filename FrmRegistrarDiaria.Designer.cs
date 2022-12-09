namespace trabalhopoopt2
{
    partial class FrmRegistrarDiaria
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
            this.LblCliente = new System.Windows.Forms.Label();
            this.CbCliente = new System.Windows.Forms.ComboBox();
            this.BtnRegistraDiaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(87, 47);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(42, 13);
            this.LblCliente.TabIndex = 1;
            this.LblCliente.Text = "Cliente:";
            // 
            // CbCliente
            // 
            this.CbCliente.FormattingEnabled = true;
            this.CbCliente.Location = new System.Drawing.Point(90, 73);
            this.CbCliente.Name = "CbCliente";
            this.CbCliente.Size = new System.Drawing.Size(121, 21);
            this.CbCliente.TabIndex = 1;
            // 
            // BtnRegistraDiaria
            // 
            this.BtnRegistraDiaria.Location = new System.Drawing.Point(90, 117);
            this.BtnRegistraDiaria.Name = "BtnRegistraDiaria";
            this.BtnRegistraDiaria.Size = new System.Drawing.Size(121, 23);
            this.BtnRegistraDiaria.TabIndex = 2;
            this.BtnRegistraDiaria.Text = "Registra Diária";
            this.BtnRegistraDiaria.UseVisualStyleBackColor = true;
            this.BtnRegistraDiaria.Click += new System.EventHandler(this.BtnRegistraDiaria_Click);
            // 
            // FrmRegistrarDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.BtnRegistraDiaria);
            this.Controls.Add(this.CbCliente);
            this.Controls.Add(this.LblCliente);
            this.Name = "FrmRegistrarDiaria";
            this.Text = "Registra Diária";
            this.Load += new System.EventHandler(this.FrmRegistrarDiaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.ComboBox CbCliente;
        private System.Windows.Forms.Button BtnRegistraDiaria;
    }
}