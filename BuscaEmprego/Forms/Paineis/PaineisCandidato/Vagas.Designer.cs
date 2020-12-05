namespace BuscaEmprego.Forms.Paineis.PaineisCandidato
{
    partial class Vagas
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
            this.VagaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCandidatoID = new System.Windows.Forms.Label();
            this.txbIDVaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txbTituloVaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCandidata = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.txbEmpresaID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VagaID,
            this.Empresa,
            this.CNPJ,
            this.TituloVaga,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // VagaID
            // 
            this.VagaID.HeaderText = "ID";
            this.VagaID.Name = "VagaID";
            this.VagaID.Width = 50;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Width = 150;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // TituloVaga
            // 
            this.TituloVaga.HeaderText = "Titulo";
            this.TituloVaga.Name = "TituloVaga";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao da Vaga";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 450;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // lblCandidatoID
            // 
            this.lblCandidatoID.AutoSize = true;
            this.lblCandidatoID.Location = new System.Drawing.Point(78, 13);
            this.lblCandidatoID.Name = "lblCandidatoID";
            this.lblCandidatoID.Size = new System.Drawing.Size(0, 13);
            this.lblCandidatoID.TabIndex = 2;
            // 
            // txbIDVaga
            // 
            this.txbIDVaga.Enabled = false;
            this.txbIDVaga.Location = new System.Drawing.Point(40, 217);
            this.txbIDVaga.Name = "txbIDVaga";
            this.txbIDVaga.Size = new System.Drawing.Size(69, 20);
            this.txbIDVaga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empresa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbNomeEmpresa
            // 
            this.txbNomeEmpresa.Enabled = false;
            this.txbNomeEmpresa.Location = new System.Drawing.Point(312, 218);
            this.txbNomeEmpresa.Name = "txbNomeEmpresa";
            this.txbNomeEmpresa.Size = new System.Drawing.Size(163, 20);
            this.txbNomeEmpresa.TabIndex = 6;
            // 
            // txbTituloVaga
            // 
            this.txbTituloVaga.Enabled = false;
            this.txbTituloVaga.Location = new System.Drawing.Point(520, 218);
            this.txbTituloVaga.Name = "txbTituloVaga";
            this.txbTituloVaga.Size = new System.Drawing.Size(385, 20);
            this.txbTituloVaga.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Titulo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Enabled = false;
            this.txbDescricao.Location = new System.Drawing.Point(19, 267);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(886, 104);
            this.txbDescricao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição da vaga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCandidata
            // 
            this.btnCandidata.Location = new System.Drawing.Point(19, 393);
            this.btnCandidata.Name = "btnCandidata";
            this.btnCandidata.Size = new System.Drawing.Size(290, 40);
            this.btnCandidata.TabIndex = 11;
            this.btnCandidata.Text = "Candidatar-se";
            this.btnCandidata.UseVisualStyleBackColor = true;
            this.btnCandidata.Click += new System.EventHandler(this.btnCandidata_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(611, 393);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(294, 40);
            this.btnFecha.TabIndex = 12;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // txbEmpresaID
            // 
            this.txbEmpresaID.Enabled = false;
            this.txbEmpresaID.Location = new System.Drawing.Point(183, 218);
            this.txbEmpresaID.Name = "txbEmpresaID";
            this.txbEmpresaID.Size = new System.Drawing.Size(69, 20);
            this.txbEmpresaID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Empresa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(315, 393);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(290, 40);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Vagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 460);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbEmpresaID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCandidata);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTituloVaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNomeEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDVaga);
            this.Controls.Add(this.lblCandidatoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vagas";
            this.Load += new System.EventHandler(this.Vagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCandidatoID;
        private System.Windows.Forms.TextBox txbIDVaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeEmpresa;
        private System.Windows.Forms.TextBox txbTituloVaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCandidata;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.TextBox txbEmpresaID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn VagaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}