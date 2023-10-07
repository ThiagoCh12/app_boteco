namespace AppBoteco
{
    partial class FrmProduto
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvProduto = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(11, 88);
			this.txtNome.Margin = new System.Windows.Forms.Padding(2);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(283, 20);
			this.txtNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "NOME PRODUTO";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(11, 35);
			this.txtId.Margin = new System.Windows.Forms.Padding(2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 20);
			this.txtId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID";
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Black;
			this.btnSair.Location = new System.Drawing.Point(669, 194);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(119, 43);
			this.btnSair.TabIndex = 10;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.Black;
			this.btnEditar.Location = new System.Drawing.Point(669, 64);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(119, 43);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.Black;
			this.btnExcluir.Location = new System.Drawing.Point(669, 116);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(119, 43);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.ForeColor = System.Drawing.Color.Black;
			this.btnInserir.Location = new System.Drawing.Point(669, 12);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(119, 43);
			this.btnInserir.TabIndex = 7;
			this.btnInserir.Text = "INSERIR";
			this.btnInserir.UseVisualStyleBackColor = false;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.ForeColor = System.Drawing.Color.Black;
			this.btnLocalizar.Location = new System.Drawing.Point(189, 22);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(105, 43);
			this.btnLocalizar.TabIndex = 6;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(11, 176);
			this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(283, 20);
			this.txtQuantidade.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 157);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 15);
			this.label3.TabIndex = 21;
			this.label3.Text = "QUANTIDADE";
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(11, 129);
			this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(283, 20);
			this.txtTipo.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 110);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 23;
			this.label4.Text = "TIPO";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(11, 227);
			this.txtValor.Margin = new System.Windows.Forms.Padding(2);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(283, 20);
			this.txtValor.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 208);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 15);
			this.label5.TabIndex = 25;
			this.label5.Text = "VALOR";
			// 
			// dgvProduto
			// 
			this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduto.Location = new System.Drawing.Point(0, 261);
			this.dgvProduto.Name = "dgvProduto";
			this.dgvProduto.Size = new System.Drawing.Size(799, 189);
			this.dgvProduto.TabIndex = 11;
			this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
			// 
			// FrmProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvProduto);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "FrmProduto";
			this.Text = "FrmProduto";
			this.Load += new System.EventHandler(this.FrmProduto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProduto;
    }
}