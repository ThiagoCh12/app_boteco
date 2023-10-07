using AppBoteco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBoteco
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            List<Produto> produtos = produto.listaprodutos();
            dgvProduto.DataSource = produtos;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtQuantidade.Text == "" || txtTipo.Text == "" || txtValor.Text =="")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Produto produto = new Produto();
                if (produto.RegistroRepetido(txtNome.Text) == true)
                {
                    MessageBox.Show("Produto já existe em nossa base de dados!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    txtTipo.Text = "";
                    txtValor.Text = "";
                    return;
                }
                else
                {
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    
                    produto.Inserir(txtNome.Text, txtTipo.Text, quantidade, txtValor.Text);
                    MessageBox.Show("Produto inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Produto> produtos = produto.listaprodutos();
                    dgvProduto.DataSource = produtos;
                    txtNome.Text = "";
                    txtTipo.Text = "";
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor digite um Id para localizar!", "Sem ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                //int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
               
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Localizar(Id);
                txtNome.Text = produto.nome;
                txtTipo.Text = produto.tipo;
                txtQuantidade.Text = Convert.ToString(produto.quantidade);
                txtValor.Text = Convert.ToString(produto.preco);
                if (txtNome.Text != null)
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro - inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Atualizar(Id, txtNome.Text, txtTipo.Text, quantidade, txtValor.Text);
                MessageBox.Show("Produto atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaprodutos();
                dgvProduto.DataSource = produtos;
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro - Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Excluir(id);
                MessageBox.Show("Produto excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaprodutos();
                dgvProduto.DataSource = produtos;
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                this.ActiveControl = txtNome;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro - inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                this.dgvProduto.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].Value.ToString();
                txtValor.Text = row.Cells[4].Value.ToString();

            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
