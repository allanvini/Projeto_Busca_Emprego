namespace BuscaEmprego.Forms.Paineis.PaineisEmpresa
{
    partial class CandidaturasRecebidas
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
            this.lblEmpresaID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Candidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curriculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCandidaturaID = new System.Windows.Forms.TextBox();
            this.txbVagaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCandidatoID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCurriculo = new System.Windows.Forms.TextBox();
            this.btnAprovaCandidato = new System.Windows.Forms.Button();
            this.btnReprovaCandidato = new System.Windows.Forms.Button();
            this.btnAtualizaLista = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbCandidato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro:";
            // 
            // lblEmpresaID
            // 
            this.lblEmpresaID.AutoSize = true;
            this.lblEmpresaID.Location = new System.Drawing.Point(71, 13);
            this.lblEmpresaID.Name = "lblEmpresaID";
            this.lblEmpresaID.Size = new System.Drawing.Size(0, 13);
            this.lblEmpresaID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vaga,
            this.ID_Vaga,
            this.Candidato,
            this.CPF_Candidato,
            this.Curriculo});
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID_Candidatura";
            this.ID.Name = "ID";
            // 
            // Vaga
            // 
            this.Vaga.HeaderText = "Vaga";
            this.Vaga.Name = "Vaga";
            // 
            // ID_Vaga
            // 
            this.ID_Vaga.HeaderText = "ID_Vaga";
            this.ID_Vaga.Name = "ID_Vaga";
            // 
            // Candidato
            // 
            this.Candidato.HeaderText = "Candidato";
            this.Candidato.Name = "Candidato";
            // 
            // CPF_Candidato
            // 
            this.CPF_Candidato.HeaderText = "CPF_Candidato";
            this.CPF_Candidato.Name = "CPF_Candidato";
            // 
            // Curriculo
            // 
            this.Curriculo.HeaderText = "Curriculo";
            this.Curriculo.Name = "Curriculo";
            this.Curriculo.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Candidatura";
            // 
            // txbCandidaturaID
            // 
            this.txbCandidaturaID.Enabled = false;
            this.txbCandidaturaID.Location = new System.Drawing.Point(97, 210);
            this.txbCandidaturaID.Name = "txbCandidaturaID";
            this.txbCandidaturaID.Size = new System.Drawing.Size(100, 20);
            this.txbCandidaturaID.TabIndex = 4;
            // 
            // txbVagaID
            // 
            this.txbVagaID.Enabled = false;
            this.txbVagaID.Location = new System.Drawing.Point(255, 210);
            this.txbVagaID.Name = "txbVagaID";
            this.txbVagaID.Size = new System.Drawing.Size(100, 20);
            this.txbVagaID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Vaga";
            // 
            // txbCandidatoID
            // 
            this.txbCandidatoID.Enabled = false;
            this.txbCandidatoID.Location = new System.Drawing.Point(88, 236);
            this.txbCandidatoID.Name = "txbCandidatoID";
            this.txbCandidatoID.Size = new System.Drawing.Size(95, 20);
            this.txbCandidatoID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Candidato";
            // 
            // txbVaga
            // 
            this.txbVaga.Enabled = false;
            this.txbVaga.Location = new System.Drawing.Point(51, 262);
            this.txbVaga.Name = "txbVaga";
            this.txbVaga.Size = new System.Drawing.Size(304, 20);
            this.txbVaga.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vaga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Curriculo";
            // 
            // txbCurriculo
            // 
            this.txbCurriculo.Enabled = false;
            this.txbCurriculo.Location = new System.Drawing.Point(12, 312);
            this.txbCurriculo.Multiline = true;
            this.txbCurriculo.Name = "txbCurriculo";
            this.txbCurriculo.Size = new System.Drawing.Size(343, 94);
            this.txbCurriculo.TabIndex = 12;
            // 
            // btnAprovaCandidato
            // 
            this.btnAprovaCandidato.Location = new System.Drawing.Point(425, 213);
            this.btnAprovaCandidato.Name = "btnAprovaCandidato";
            this.btnAprovaCandidato.Size = new System.Drawing.Size(384, 43);
            this.btnAprovaCandidato.TabIndex = 13;
            this.btnAprovaCandidato.Text = "Aprovar Candidato";
            this.btnAprovaCandidato.UseVisualStyleBackColor = true;
            this.btnAprovaCandidato.Click += new System.EventHandler(this.btnAprovaCandidato_Click);
            // 
            // btnReprovaCandidato
            // 
            this.btnReprovaCandidato.Location = new System.Drawing.Point(425, 262);
            this.btnReprovaCandidato.Name = "btnReprovaCandidato";
            this.btnReprovaCandidato.Size = new System.Drawing.Size(384, 45);
            this.btnReprovaCandidato.TabIndex = 14;
            this.btnReprovaCandidato.Text = "Reprovar Candidato";
            this.btnReprovaCandidato.UseVisualStyleBackColor = true;
            this.btnReprovaCandidato.Click += new System.EventHandler(this.btnReprovaCandidato_Click);
            // 
            // btnAtualizaLista
            // 
            this.btnAtualizaLista.Location = new System.Drawing.Point(425, 313);
            this.btnAtualizaLista.Name = "btnAtualizaLista";
            this.btnAtualizaLista.Size = new System.Drawing.Size(384, 44);
            this.btnAtualizaLista.TabIndex = 15;
            this.btnAtualizaLista.Text = "Atualizar Lista";
            this.btnAtualizaLista.UseVisualStyleBackColor = true;
            this.btnAtualizaLista.Click += new System.EventHandler(this.btnAtualizaLista_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(425, 363);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(384, 43);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbCandidato
            // 
            this.txbCandidato.Enabled = false;
            this.txbCandidato.Location = new System.Drawing.Point(250, 236);
            this.txbCandidato.Name = "txbCandidato";
            this.txbCandidato.Size = new System.Drawing.Size(105, 20);
            this.txbCandidato.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Candidato";
            // 
            // CandidaturasRecebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 425);
            this.Controls.Add(this.txbCandidato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizaLista);
            this.Controls.Add(this.btnReprovaCandidato);
            this.Controls.Add(this.btnAprovaCandidato);
            this.Controls.Add(this.txbCurriculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbVaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCandidatoID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbVagaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCandidaturaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEmpresaID);
            this.Controls.Add(this.label1);
            this.Name = "CandidaturasRecebidas";
            this.Text = "CandidaturasRecebidas";
            this.Load += new System.EventHandler(this.CandidaturasRecebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpresaID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Vaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Candidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curriculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCandidaturaID;
        private System.Windows.Forms.TextBox txbVagaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCandidatoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCurriculo;
        private System.Windows.Forms.Button btnAprovaCandidato;
        private System.Windows.Forms.Button btnReprovaCandidato;
        private System.Windows.Forms.Button btnAtualizaLista;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbCandidato;
        private System.Windows.Forms.Label label7;
    }
}