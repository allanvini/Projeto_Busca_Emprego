namespace BuscaEmprego.Forms.Paineis.PaineisCandidato
{
    partial class Candidaturas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CandidaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCandidatoID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCandidaturaID = new System.Windows.Forms.TextBox();
            this.txbEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbVaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.btnRemoverCandidatura = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbVagaID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidaturaID,
            this.IDVaga,
            this.Empresa,
            this.Vaga,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(15, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CandidaturaID
            // 
            this.CandidaturaID.HeaderText = "ID Candidatura";
            this.CandidaturaID.Name = "CandidaturaID";
            this.CandidaturaID.Width = 50;
            // 
            // IDVaga
            // 
            this.IDVaga.HeaderText = "ID Vaga";
            this.IDVaga.Name = "IDVaga";
            this.IDVaga.Width = 50;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Width = 150;
            // 
            // Vaga
            // 
            this.Vaga.HeaderText = "Vaga";
            this.Vaga.Name = "Vaga";
            this.Vaga.Width = 150;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 450;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // lblCandidatoID
            // 
            this.lblCandidatoID.AutoSize = true;
            this.lblCandidatoID.Location = new System.Drawing.Point(79, 24);
            this.lblCandidatoID.Name = "lblCandidatoID";
            this.lblCandidatoID.Size = new System.Drawing.Size(0, 13);
            this.lblCandidatoID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidatura:";
            // 
            // txbCandidaturaID
            // 
            this.txbCandidaturaID.Enabled = false;
            this.txbCandidaturaID.Location = new System.Drawing.Point(85, 211);
            this.txbCandidaturaID.Name = "txbCandidaturaID";
            this.txbCandidaturaID.Size = new System.Drawing.Size(70, 20);
            this.txbCandidaturaID.TabIndex = 4;
            // 
            // txbEmpresa
            // 
            this.txbEmpresa.Enabled = false;
            this.txbEmpresa.Location = new System.Drawing.Point(347, 211);
            this.txbEmpresa.Name = "txbEmpresa";
            this.txbEmpresa.Size = new System.Drawing.Size(200, 20);
            this.txbEmpresa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empresa";
            // 
            // txbVaga
            // 
            this.txbVaga.Enabled = false;
            this.txbVaga.Location = new System.Drawing.Point(591, 211);
            this.txbVaga.Name = "txbVaga";
            this.txbVaga.Size = new System.Drawing.Size(318, 20);
            this.txbVaga.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vaga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Enabled = false;
            this.txbDescricao.Location = new System.Drawing.Point(15, 255);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(894, 95);
            this.txbDescricao.TabIndex = 10;
            // 
            // btnRemoverCandidatura
            // 
            this.btnRemoverCandidatura.Location = new System.Drawing.Point(303, 356);
            this.btnRemoverCandidatura.Name = "btnRemoverCandidatura";
            this.btnRemoverCandidatura.Size = new System.Drawing.Size(321, 43);
            this.btnRemoverCandidatura.TabIndex = 11;
            this.btnRemoverCandidatura.Text = "Desistir";
            this.btnRemoverCandidatura.UseVisualStyleBackColor = true;
            this.btnRemoverCandidatura.Click += new System.EventHandler(this.btnRemoverCandidatura_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(630, 356);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(279, 43);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbVagaID
            // 
            this.txbVagaID.Enabled = false;
            this.txbVagaID.Location = new System.Drawing.Point(215, 211);
            this.txbVagaID.Name = "txbVagaID";
            this.txbVagaID.Size = new System.Drawing.Size(72, 20);
            this.txbVagaID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "VagaID";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(18, 356);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(279, 43);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Candidaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 411);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbVagaID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemoverCandidatura);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbVaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCandidaturaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCandidatoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Candidaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidaturas";
            this.Load += new System.EventHandler(this.Candidaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCandidatoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCandidaturaID;
        private System.Windows.Forms.TextBox txbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbVaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Button btnRemoverCandidatura;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbVagaID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Button btnAtualizar;
    }
}