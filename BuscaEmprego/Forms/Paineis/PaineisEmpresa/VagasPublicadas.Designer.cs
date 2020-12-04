namespace BuscaEmprego.Forms.Paineis.PaineisEmpresa
{
    partial class VagasPublicadas
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
            this.lblEmpresaID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVagaID = new System.Windows.Forms.TextBox();
            this.txbTituloVaga = new System.Windows.Forms.TextBox();
            this.txbDescricaoVaga = new System.Windows.Forms.TextBox();
            this.btnRemoverVaga = new System.Windows.Forms.Button();
            this.btnAdicionarVaga = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresaID
            // 
            this.lblEmpresaID.AutoSize = true;
            this.lblEmpresaID.Location = new System.Drawing.Point(70, 9);
            this.lblEmpresaID.Name = "lblEmpresaID";
            this.lblEmpresaID.Size = new System.Drawing.Size(0, 13);
            this.lblEmpresaID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vaga,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(15, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Vaga
            // 
            this.Vaga.HeaderText = "Vaga";
            this.Vaga.Name = "Vaga";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição";
            // 
            // txbVagaID
            // 
            this.txbVagaID.Enabled = false;
            this.txbVagaID.Location = new System.Drawing.Point(408, 194);
            this.txbVagaID.Name = "txbVagaID";
            this.txbVagaID.Size = new System.Drawing.Size(100, 20);
            this.txbVagaID.TabIndex = 8;
            // 
            // txbTituloVaga
            // 
            this.txbTituloVaga.Enabled = false;
            this.txbTituloVaga.Location = new System.Drawing.Point(54, 194);
            this.txbTituloVaga.Name = "txbTituloVaga";
            this.txbTituloVaga.Size = new System.Drawing.Size(324, 20);
            this.txbTituloVaga.TabIndex = 9;
            // 
            // txbDescricaoVaga
            // 
            this.txbDescricaoVaga.Enabled = false;
            this.txbDescricaoVaga.Location = new System.Drawing.Point(18, 238);
            this.txbDescricaoVaga.Multiline = true;
            this.txbDescricaoVaga.Name = "txbDescricaoVaga";
            this.txbDescricaoVaga.Size = new System.Drawing.Size(490, 94);
            this.txbDescricaoVaga.TabIndex = 10;
            // 
            // btnRemoverVaga
            // 
            this.btnRemoverVaga.Location = new System.Drawing.Point(356, 350);
            this.btnRemoverVaga.Name = "btnRemoverVaga";
            this.btnRemoverVaga.Size = new System.Drawing.Size(152, 42);
            this.btnRemoverVaga.TabIndex = 11;
            this.btnRemoverVaga.Text = "Remover Vaga";
            this.btnRemoverVaga.UseVisualStyleBackColor = true;
            this.btnRemoverVaga.Click += new System.EventHandler(this.btnRemoverVaga_Click);
            // 
            // btnAdicionarVaga
            // 
            this.btnAdicionarVaga.Location = new System.Drawing.Point(188, 350);
            this.btnAdicionarVaga.Name = "btnAdicionarVaga";
            this.btnAdicionarVaga.Size = new System.Drawing.Size(152, 42);
            this.btnAdicionarVaga.TabIndex = 12;
            this.btnAdicionarVaga.Text = "Adicionar Nova Vaga";
            this.btnAdicionarVaga.UseVisualStyleBackColor = true;
            this.btnAdicionarVaga.Click += new System.EventHandler(this.btnAdicionarVaga_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(18, 350);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 42);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // VagasPublicadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 409);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionarVaga);
            this.Controls.Add(this.btnRemoverVaga);
            this.Controls.Add(this.txbDescricaoVaga);
            this.Controls.Add(this.txbTituloVaga);
            this.Controls.Add(this.txbVagaID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEmpresaID);
            this.Controls.Add(this.label1);
            this.Name = "VagasPublicadas";
            this.Text = "VagasPublicadas";
            this.Load += new System.EventHandler(this.VagasPublicadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVagaID;
        private System.Windows.Forms.TextBox txbTituloVaga;
        private System.Windows.Forms.TextBox txbDescricaoVaga;
        private System.Windows.Forms.Button btnRemoverVaga;
        private System.Windows.Forms.Button btnAdicionarVaga;
        private System.Windows.Forms.Button btnAtualizar;
    }
}