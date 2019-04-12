using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDAO
{
    public class Cadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public String Mensagem;

        public Cadastro(String nome)
        {
            cmd.CommandText = "insert into cadastro (nome) values (@nome)";
            cmd.Parameters.AddWithValue("@nome",nome);

            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

                this.Mensagem = "Deu certo!";
            }
            catch (SqlException eeee)
            {
                this.Mensagem = "deu errado";
            }







        }
    }
}
