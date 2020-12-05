namespace BuscaEmprego.Forms
{
    partial class LoginCandidato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCPFLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área do usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira os dados abaixo apra entrar no sistema";
            // 
            // txbCPFLogin
            // 
            this.txbCPFLogin.Location = new System.Drawing.Point(59, 70);
            this.txbCPFLogin.Name = "txbCPFLogin";
            this.txbCPFLogin.Size = new System.Drawing.Size(188, 20);
            this.txbCPFLogin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // txbSenhaLogin
            // 
            this.txbSenhaLogin.Location = new System.Drawing.Point(59, 96);
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Size = new System.Drawing.Size(188, 20);
            this.txbSenhaLogin.TabIndex = 4;
            this.txbSenhaLogin.UseSystemPasswordChar = true;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(59, 122);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(188, 34);
            this.btnLogar.TabIndex = 6;
            this.btnLogar.Text = "Acessar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Não possui cadastro? cloque no botão abaixo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(59, 175);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(188, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // LoginCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 217);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSenhaLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCPFLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCandidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCPFLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenhaLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
    }
}