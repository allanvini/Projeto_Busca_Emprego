namespace BuscaEmprego.Forms.Paineis.PaineisCandidato
{
    partial class PainelCandidato
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
            this.lblNomeCandidato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPFCandidato = new System.Windows.Forms.Label();
            this.btnVerCandidaturas = new System.Windows.Forms.Button();
            this.btnVerVagas = new System.Windows.Forms.Button();
            this.btnVerConvites = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCandidato
            // 
            this.lblNomeCandidato.AutoSize = true;
            this.lblNomeCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCandidato.Location = new System.Drawing.Point(63, 9);
            this.lblNomeCandidato.Name = "lblNomeCandidato";
            this.lblNomeCandidato.Size = new System.Drawing.Size(0, 33);
            this.lblNomeCandidato.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // lblCPFCandidato
            // 
            this.lblCPFCandidato.AutoSize = true;
            this.lblCPFCandidato.Location = new System.Drawing.Point(102, 42);
            this.lblCPFCandidato.Name = "lblCPFCandidato";
            this.lblCPFCandidato.Size = new System.Drawing.Size(0, 13);
            this.lblCPFCandidato.TabIndex = 3;
            // 
            // btnVerCandidaturas
            // 
            this.btnVerCandidaturas.Location = new System.Drawing.Point(21, 58);
            this.btnVerCandidaturas.Name = "btnVerCandidaturas";
            this.btnVerCandidaturas.Size = new System.Drawing.Size(465, 47);
            this.btnVerCandidaturas.TabIndex = 4;
            this.btnVerCandidaturas.Text = "Minhas candidaturas";
            this.btnVerCandidaturas.UseVisualStyleBackColor = true;
            this.btnVerCandidaturas.Click += new System.EventHandler(this.btnVerCandidaturas_Click);
            // 
            // btnVerVagas
            // 
            this.btnVerVagas.Location = new System.Drawing.Point(21, 111);
            this.btnVerVagas.Name = "btnVerVagas";
            this.btnVerVagas.Size = new System.Drawing.Size(465, 47);
            this.btnVerVagas.TabIndex = 5;
            this.btnVerVagas.Text = "Ver vagas";
            this.btnVerVagas.UseVisualStyleBackColor = true;
            this.btnVerVagas.Click += new System.EventHandler(this.btnVerVagas_Click);
            // 
            // btnVerConvites
            // 
            this.btnVerConvites.Location = new System.Drawing.Point(21, 164);
            this.btnVerConvites.Name = "btnVerConvites";
            this.btnVerConvites.Size = new System.Drawing.Size(465, 47);
            this.btnVerConvites.TabIndex = 6;
            this.btnVerConvites.Text = "Meus convites";
            this.btnVerConvites.UseVisualStyleBackColor = true;
            this.btnVerConvites.Click += new System.EventHandler(this.btnVerConvites_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(21, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(465, 47);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PainelCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerConvites);
            this.Controls.Add(this.btnVerVagas);
            this.Controls.Add(this.btnVerCandidaturas);
            this.Controls.Add(this.lblCPFCandidato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeCandidato);
            this.Name = "PainelCandidato";
            this.Text = "PainelCandidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCandidato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPFCandidato;
        private System.Windows.Forms.Button btnVerCandidaturas;
        private System.Windows.Forms.Button btnVerVagas;
        private System.Windows.Forms.Button btnVerConvites;
        private System.Windows.Forms.Button btnSair;
    }
}