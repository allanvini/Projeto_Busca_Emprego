namespace BuscaEmprego.Forms
{
    partial class LoginEmpresa
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenhaLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCNPJLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(57, 177);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(188, 34);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Não possui cadastro? cloque no botão abaixo";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(57, 124);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(188, 34);
            this.btnLogar.TabIndex = 15;
            this.btnLogar.Text = "Acessar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            // 
            // txbSenhaLogin
            // 
            this.txbSenhaLogin.Location = new System.Drawing.Point(57, 98);
            this.txbSenhaLogin.Name = "txbSenhaLogin";
            this.txbSenhaLogin.Size = new System.Drawing.Size(188, 20);
            this.txbSenhaLogin.TabIndex = 13;
            this.txbSenhaLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNPJ";
            // 
            // txbCNPJLogin
            // 
            this.txbCNPJLogin.Location = new System.Drawing.Point(57, 72);
            this.txbCNPJLogin.Name = "txbCNPJLogin";
            this.txbCNPJLogin.Size = new System.Drawing.Size(188, 20);
            this.txbCNPJLogin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insira os dados abaixo apra entrar no sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Área da empresa";
            // 
            // LoginEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 220);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSenhaLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCNPJLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenhaLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCNPJLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}