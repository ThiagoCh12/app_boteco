using AppBoteco.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBoteco
{
    internal class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set;}

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\AppBoteco\\DbBoteco.mdf;Integrated Security=True");
    
        public List<Produto> listaprodutos()
        {

            List<Produto> li = new List<Produto>();
            string sql = "SELECT * FROM Produto";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                Produto c = new Produto();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.tipo = dr["tipo"].ToString();
                c.quantidade = (int)dr["quantidade"];
                c.preco = (decimal)dr["preco"];
                li.Add(c);
            }

            dr.Close();
            con.Close();
            return li;

        }
        public void Inserir(string nome, string tipo, int quantidade, string preco)
        {

            decimal final = Convert.ToDecimal(preco)/100;
            string sql = "INSERT INTO Produto(nome,tipo, quantidade, preco)" +
                " VALUES ('" + nome + "','" + tipo + "','" + quantidade + "', @preco)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@preco", System.Data.SqlDbType.Decimal).Value = final;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public void Atualizar(int Id, string nome, string tipo, int quantidade, string preco)
        {
            decimal final = Convert.ToDecimal(preco) / 100;
            string sql = "UPDATE Produto SET nome='" + nome + "',tipo='" + tipo + "',quantidade='" + quantidade + "', preco = @preco WHERE Id = '"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
			
			cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = final;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Produto WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {

            string sql = "SELECT * FROM Produto WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                tipo = dr["tipo"].ToString();
                quantidade = (int)dr["quantidade"];
                preco = (decimal)dr["preco"];
            }
            dr.Close();
            con.Close();
        }
        public void UltimoRegistro(int Id)
        {
            string sql = "";
        }

        public bool RegistroRepetido(string nome)
        {
            string sql = "SELECT * FROM Produto WHERE nome='" + nome + "'";
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
