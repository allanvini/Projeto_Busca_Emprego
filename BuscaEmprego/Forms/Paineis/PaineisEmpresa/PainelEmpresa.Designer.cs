namespace BuscaEmprego.Forms.Paineis.PaineisEmpresa
{
    partial class PainelEmpresa
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerVagas = new System.Windows.Forms.Button();
            this.btnVerCandidaturas = new System.Windows.Forms.Button();
            this.lblCNPJEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(27, 169);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(465, 47);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVerVagas
            // 
            this.btnVerVagas.Location = new System.Drawing.Point(27, 116);
            this.btnVerVagas.Name = "btnVerVagas";
            this.btnVerVagas.Size = new System.Drawing.Size(465, 47);
            this.btnVerVagas.TabIndex = 13;
            this.btnVerVagas.Text = "Minhas Vagas";
            this.btnVerVagas.UseVisualStyleBackColor = true;
            this.btnVerVagas.Click += new System.EventHandler(this.btnVerVagas_Click);
            // 
            // btnVerCandidaturas
            // 
            this.btnVerCandidaturas.Location = new System.Drawing.Point(27, 63);
            this.btnVerCandidaturas.Name = "btnVerCandidaturas";
            this.btnVerCandidaturas.Size = new System.Drawing.Size(465, 47);
            this.btnVerCandidaturas.TabIndex = 12;
            this.btnVerCandidaturas.Text = "Ver candidaturas";
            this.btnVerCandidaturas.UseVisualStyleBackColor = true;
            this.btnVerCandidaturas.Click += new System.EventHandler(this.btnVerCandidaturas_Click);
            // 
            // lblCNPJEmpresa
            // 
            this.lblCNPJEmpresa.AutoSize = true;
            this.lblCNPJEmpresa.Location = new System.Drawing.Point(115, 47);
            this.lblCNPJEmpresa.Name = "lblCNPJEmpresa";
            this.lblCNPJEmpresa.Size = new System.Drawing.Size(0, 13);
            this.lblCNPJEmpresa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CNPJ:";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(78, 9);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(0, 33);
            this.lblNomeEmpresa.TabIndex = 9;
            // 
            // PainelEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 233);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerVagas);
            this.Controls.Add(this.btnVerCandidaturas);
            this.Controls.Add(this.lblCNPJEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Name = "PainelEmpresa";
            this.Text = "PainelEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerVagas;
        private System.Windows.Forms.Button btnVerCandidaturas;
        private System.Windows.Forms.Label lblCNPJEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeEmpresa;
    }
}