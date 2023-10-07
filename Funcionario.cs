using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppBoteco
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string nome {get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string celular { get; set; }
        public string cargo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\AppBoteco\\DbBoteco.mdf;Integrated Security=True");

        public List<Funcionario> listafuncionario()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = (int)dr["id"];
                f.nome = dr["nome"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.bairro = dr["bairro"].ToString();
                f.cep = dr["cep"].ToString();
                f.celular = dr["celular"].ToString();
                f.cargo = dr["cargo"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void inserir(string nome, string cpf, string celular, 
            string endereco, string cidade, string bairro, string cep, string cargo)
        {
            string sql = "INSERT INTO Funcionario(nome,cpf,celular,endereco, cidade, bairro, cep, cargo) " +
                "VALUES ('" + nome + "','" + cpf + "','" + celular + "','" + endereco + "', " +
                "'"+cidade+"','"+bairro+"','"+cep+"','"+cargo+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void atualizar(int Id, string nome, string cpf, string celular, string endereco, 
            string cidade, string bairro, string cep, string cargo)
        {
            string sql = "UPDATE Funcionario SET nome='" + nome + "'," +
                "cpf='" + cpf + "',celular='" + celular + "',endereco='" + endereco + "'," +
                "cidade='" + cidade + "',bairro='" + bairro + "',cep='" + cep + "',cargo='" + cargo + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void excluir(int Id)
        {
            string sql = "DELETE FROM Funcionario WHERE id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void localizar(int Id)
        {
            string sql = "SELECT * FROM Funcionario WHERE id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                celular = dr["celular"].ToString();
                endereco = dr["endereco"].ToString() ;
                cep = dr["cep"].ToString();
                bairro = dr["bairro"].ToString();
                cidade = dr["cidade"].ToString();
                cargo = dr["cargo"].ToString();

            }
            dr.Close();
            con.Close();
            con.Close();

        }
        public void UltimoRegistro(int Id)
        {
            string sql = "";
        }

        public bool RegistroRepetido(string cpf)
        {
            string sql = "SELECT * FROM Funcionario WHERE cpf='" + cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
