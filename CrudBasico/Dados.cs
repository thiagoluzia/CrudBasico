using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CrudBasico
{
    public class Dados
    {
        //Variavel que recebera a string de conexao
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //variaveis constantes que conteram as instrucoes sql para o crud
        public const string strInsert = "INSERT INTO Clientes VALUES (@Nome, @Endereco, @Telefone, @Sexo, @Ativo, @DataCadastro";
        public const string strDelete = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
        public const string strUpdate = "UPDATE Clientes SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Sexo = @Sexo, Ativo = @Ativo, DataCadastro = @DataCadastro WHERE IdCliente = @IdCliente";
        public const string strSelect = "SELECT * FROM Clientes";

        public void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {
            using (SqlConnection objetoConexao = new SqlConnection(strConexao))
            {
                using(SqlCommand objetoComando = new SqlCommand(strInsert, objetoConexao))
                {
                    objetoComando.Parameters.AddWithValue("@Nome", Nome);
                    objetoComando.Parameters.AddWithValue("@Endereco", Endereco);
                    objetoComando.Parameters.AddWithValue("@Telefone", Telefone);
                    objetoComando.Parameters.AddWithValue("@Sexo", Sexo);
                    objetoComando.Parameters.AddWithValue("@Ativo", Ativo);
                    objetoComando.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objetoConexao.Open();
                    objetoComando.ExecuteNonQuery();
                    objetoConexao.Close();
                }
            }
        }
        public void Atualizar(int IdCliente,string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {
            using (SqlConnection objetoConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objetoComando = new SqlCommand(strUpdate, objetoConexao))
                {
                    objetoComando.Parameters.AddWithValue("@IdCliente", IdCliente);
                    objetoComando.Parameters.AddWithValue("@Nome", Nome);
                    objetoComando.Parameters.AddWithValue("@Endereco", Endereco);
                    objetoComando.Parameters.AddWithValue("@Telefone", Telefone);
                    objetoComando.Parameters.AddWithValue("@Sexo", Sexo);
                    objetoComando.Parameters.AddWithValue("@Ativo", Ativo);
                    objetoComando.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objetoConexao.Open();
                    objetoComando.ExecuteNonQuery();
                    objetoConexao.Close();
                }
            }
        }
        public void Excluir(int IdCliente)
        {
            using (SqlConnection objetoConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objetoComando = new SqlCommand(strDelete, objetoConexao))
                {
                    objetoComando.Parameters.AddWithValue("@idCliente", IdCliente);

                    objetoConexao.Open();
                    objetoComando.ExecuteNonQuery();
                    objetoConexao.Close();
                }
            }
        }
    }
}
