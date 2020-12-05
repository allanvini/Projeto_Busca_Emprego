namespace BuscaEmprego
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCandidatoLogin = new System.Windows.Forms.Button();
            this.btnEmpresaLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca Emprego";
            // 
            // btnCandidatoLogin
            // 
            this.btnCandidatoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatoLogin.Location = new System.Drawing.Point(33, 105);
            this.btnCandidatoLogin.Name = "btnCandidatoLogin";
            this.btnCandidatoLogin.Size = new System.Drawing.Size(188, 75);
            this.btnCandidatoLogin.TabIndex = 1;
            this.btnCandidatoLogin.Text = "Candidato";
            this.btnCandidatoLogin.UseVisualStyleBackColor = true;
            this.btnCandidatoLogin.Click += new System.EventHandler(this.btnCandidatoLogin_Click);
            // 
            // btnEmpresaLogin
            // 
            this.btnEmpresaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresaLogin.Location = new System.Drawing.Point(227, 105);
            this.btnEmpresaLogin.Name = "btnEmpresaLogin";
            this.btnEmpresaLogin.Size = new System.Drawing.Size(188, 75);
            this.btnEmpresaLogin.TabIndex = 2;
            this.btnEmpresaLogin.Text = "Empresa";
            this.btnEmpresaLogin.UseVisualStyleBackColor = true;
            this.btnEmpresaLogin.Click += new System.EventHandler(this.btnEmpresaLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione uma das opções abaixo";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmpresaLogin);
            this.Controls.Add(this.btnCandidatoLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCandidatoLogin;
        private System.Windows.Forms.Button btnEmpresaLogin;
        private System.Windows.Forms.Label label2;
    }
}

