namespace AppBoteco
{
    partial class FrmFuncionario
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
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCep = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.dgvFuncionario = new System.Windows.Forms.DataGridView();
			this.cbxCargo = new System.Windows.Forms.ComboBox();
			this.btnBuscaCep = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.ForeColor = System.Drawing.Color.Black;
			this.btnLocalizar.Location = new System.Drawing.Point(311, 5);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(118, 36);
			this.btnLocalizar.TabIndex = 10;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(92, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(213, 20);
			this.txtId.TabIndex = 0;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(92, 71);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(337, 20);
			this.txtNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome";
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(92, 97);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(337, 20);
			this.txtCpf.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cpf";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(92, 244);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(280, 20);
			this.txtEndereco.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Endereço";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(92, 194);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(280, 20);
			this.txtCidade.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Cidade";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(92, 220);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(280, 20);
			this.txtBairro.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Bairro";
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(92, 274);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(280, 20);
			this.txtCelular.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 274);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 13;
			this.label7.Text = "Celular";
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(92, 143);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(201, 20);
			this.txtCep.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 143);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "Cep";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 302);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 16);
			this.label9.TabIndex = 17;
			this.label9.Text = "Cargo";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(440, 163);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 61);
			this.button2.TabIndex = 11;
			this.button2.Text = "INSERIR";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.Black;
			this.btnExcluir.Location = new System.Drawing.Point(440, 301);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(149, 61);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Cyan;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.Black;
			this.btnEditar.Location = new System.Drawing.Point(440, 233);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(149, 61);
			this.btnEditar.TabIndex = 12;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Black;
			this.btnSair.Location = new System.Drawing.Point(440, 382);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(149, 61);
			this.btnSair.TabIndex = 14;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// dgvFuncionario
			// 
			this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionario.Location = new System.Drawing.Point(595, 23);
			this.dgvFuncionario.Name = "dgvFuncionario";
			this.dgvFuncionario.Size = new System.Drawing.Size(507, 432);
			this.dgvFuncionario.TabIndex = 18;
			this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
			// 
			// cbxCargo
			// 
			this.cbxCargo.FormattingEnabled = true;
			this.cbxCargo.Location = new System.Drawing.Point(92, 301);
			this.cbxCargo.Name = "cbxCargo";
			this.cbxCargo.Size = new System.Drawing.Size(280, 21);
			this.cbxCargo.TabIndex = 8;
			// 
			// btnBuscaCep
			// 
			this.btnBuscaCep.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBuscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscaCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscaCep.Location = new System.Drawing.Point(299, 134);
			this.btnBuscaCep.Name = "btnBuscaCep";
			this.btnBuscaCep.Size = new System.Drawing.Size(114, 37);
			this.btnBuscaCep.TabIndex = 19;
			this.btnBuscaCep.Text = "BUSCA CEP";
			this.btnBuscaCep.UseVisualStyleBackColor = false;
			this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(776, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(167, 16);
			this.label10.TabIndex = 20;
			this.label10.Text = "DADOS FUNCIONARIO";
			// 
			// FrmFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gold;
			this.ClientSize = new System.Drawing.Size(1101, 450);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnBuscaCep);
			this.Controls.Add(this.cbxCargo);
			this.Controls.Add(this.dgvFuncionario);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLocalizar);
			this.Name = "FrmFuncionario";
			this.Text = "FrmFuncionario";
			this.Load += new System.EventHandler(this.FrmFuncionario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.ComboBox cbxCargo;
		private System.Windows.Forms.Button btnBuscaCep;
		private System.Windows.Forms.Label label10;
	}
}