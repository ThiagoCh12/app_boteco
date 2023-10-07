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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //insert button
        {
            if (txtNome.Text == "" || txtCpf.Text == "" || txtCelular.Text == "" || txtEndereco.Text =="" || txtBairro.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(txtCpf.Text) == true)
                {
                    MessageBox.Show("Funcionario já existe em nossa base de dados!", "Funcionario Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtCelular.Text = "";
                    return;
                }
                else
                {
                    funcionario.inserir(txtNome.Text, txtCpf.Text, txtCelular.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEndereco.Text, cbxCargo.Text);
                    MessageBox.Show("Funcionario inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtCelular.Text = "";
                    txtEndereco.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cbxCargo.Text = "";
                    txtCep.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> funcionarios = funcionario.listafuncionario();
            dgvFuncionario.DataSource = funcionarios;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                
                {
                    funcionario.atualizar(Id,txtNome.Text, txtCpf.Text, txtCelular.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEndereco.Text, cbxCargo.Text);
                    MessageBox.Show("Funcionario atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtCelular.Text = "";
                    txtEndereco.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cbxCargo.Text = "";
                    txtCep.Text = "";
                    this.txtNome.Focus();
                }
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
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();

                {
                    funcionario.excluir(Id);
                    MessageBox.Show("Funcionario excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> funcionarios = funcionario.listafuncionario();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtCelular.Text = "";
                    txtEndereco.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cbxCargo.Text = "";
                    txtCep.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.localizar(Id);
                txtNome.Text = funcionario.nome;
                txtCpf.Text = funcionario.cpf;
                txtCelular.Text = funcionario.celular;
                txtEndereco.Text = funcionario.endereco;
                txtBairro.Text = funcionario.bairro;
                txtCidade.Text = funcionario.cidade;
                cbxCargo.Text = funcionario.cargo;
                txtCep.Text = funcionario.cep;
                if (txtNome.Text != null)
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Localização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                this.dgvFuncionario.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCpf.Text = row.Cells[2].Value.ToString();
                txtCelular.Text = row.Cells[3].Value.ToString();
                txtEndereco.Text = row.Cells[4].Value.ToString();
                txtBairro.Text = row.Cells[5].Value.ToString();
                txtCidade.Text = row.Cells[6].Value.ToString();
                cbxCargo.Text = row.Cells[7].Value.ToString();
                txtCep.Text = row.Cells[8].Value.ToString();

            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

		private async void btnBuscaCep_Click(object sender, EventArgs e)
		{
			string cep = txtCep.Text;

			var busca = new BuscaCep();
			var endereco = await busca.BuscarEnderecoPorCepAsync(cep);

			if (endereco != null)
			{
				txtEndereco.Text = endereco.Logradouro;
				txtBairro.Text = endereco.Bairro;
				txtCidade.Text = endereco.Localidade;
				
			}
			else
			{
				MessageBox.Show("CEP não encontrado.");
			}
		}
	}
}
