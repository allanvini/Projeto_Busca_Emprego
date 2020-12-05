namespace BuscaEmprego.Forms.CadastroForms
{
    partial class CadastroCandidato
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCurriculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(91, 351);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(278, 60);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(91, 162);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(278, 20);
            this.txbSenha.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Senha";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(91, 129);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(278, 20);
            this.txbIdade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Idade";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(91, 96);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(278, 20);
            this.txbNome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(91, 61);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(278, 20);
            this.txbCPF.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Formulário de cadastro de candidato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCurriculo
            // 
            this.txbCurriculo.Location = new System.Drawing.Point(91, 194);
            this.txbCurriculo.MaxLength = 255;
            this.txbCurriculo.Multiline = true;
            this.txbCurriculo.Name = "txbCurriculo";
            this.txbCurriculo.Size = new System.Drawing.Size(278, 140);
            this.txbCurriculo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Curriculo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 445);
            this.Controls.Add(this.txbCurriculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastroCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurriculo;
        private System.Windows.Forms.Label label6;
    }
}