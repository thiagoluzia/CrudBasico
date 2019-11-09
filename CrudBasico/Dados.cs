using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace CrudBasico
{
    public class Dados
    {
        #region String de Conexao
        //Variavel que recebera a string de conexao
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        #endregion

        #region Codigo SQL
        //variaveis constantes que conteram as instrucoes sql para o crud
        public const string strInsert = "INSERT INTO Clientes VALUES (@Nome, @Endereco, @Telefone, @Sexo, @Ativo, @DataCadastro)";
        public const string strDelete = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
        public const string strUpdate = "UPDATE Clientes SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Sexo = @Sexo, Ativo = @Ativo, DataCadastro = @DataCadastro WHERE IdCliente = @IdCliente";
        public const string strSelect = "SELECT IdCliente, Nome, Endereco, Telefone, Sexo, Ativo, DataCadastro FROM Clientes";
        public const string strSelectLogin = "SELECT IdLogin, Login, Senha FROM Login WHERE Login = @Login AND Senha = @Senha";
        #endregion

        public class Clientes
        {
            public int IdCliente { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string Sexo { get; set; }
            public string Ativo { get; set; }
            public DateTime DataCadastro { get; set; }
        }

        public class Login
        {
            public int IdLogin { get; set; }
            public string LoginUsuario { get; set; }
            public string Senha { get; set; }
        }

        #region Gravar
        public void Gravar(string Nome, string Endereco, string Telefone, string Sexo, string Ativo, DateTime DataCadastro)
        {
            try
            {
                using (SqlConnection objetoConexao = new SqlConnection(strConexao))
                {
                    using (SqlCommand objetoComando = new SqlCommand(strInsert, objetoConexao))
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Consultar
        public List<Clientes> Consultar()
        {
            List<Clientes> lstClientes = new List<Clientes>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();

                    SqlDataReader objDataReader = objComando.ExecuteReader();
                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            var objClientes = new Clientes();
                            objClientes.IdCliente = Convert.ToInt32(objDataReader["IdCliente"].ToString());
                            objClientes.Nome = objDataReader["Nome"].ToString();
                            objClientes.Endereco = objDataReader["Endereco"].ToString();
                            objClientes.Telefone = objDataReader["Telefone"].ToString();
                            objClientes.Sexo = objDataReader["Sexo"].ToString();
                            objClientes.Ativo = objDataReader["Ativo"].ToString();

                            objClientes.DataCadastro = Convert.ToDateTime(objDataReader["DataCadastro"].ToString());

                            lstClientes.Add(objClientes);
                        }
                        objDataReader.Close();
                    }
                    objConexao.Close();
                }
            }

            return lstClientes;
        }
        public List<Login> ConsultarLogin(string Login, string Senha)
        {
            List<Login> lstLogin = new List<Login>();

            using(SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using(SqlCommand objComando = new SqlCommand(strSelectLogin, objConexao))
                {
                    objComando.Parameters.AddWithValue("@Login", Login);
                    objComando.Parameters.AddWithValue("@Senha", Senha);
                    objConexao.Open();

                    SqlDataReader objDataReader = objComando.ExecuteReader();
                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            var objLogin = new Login();
                            objLogin.IdLogin = Convert.ToInt32(objDataReader["IdLogin"].ToString());
                            objLogin.LoginUsuario = objDataReader["Login"].ToString();
                            objLogin.Senha = objDataReader["Senha"].ToString();

                            lstLogin.Add(objLogin);
                        }
                    }
                    objDataReader.Close();
                }
                objConexao.Close();
            }
            return lstLogin;
        }
        #endregion

        #region Atualizar
        public void Atualizar(int IdCliente, string Nome, string Endereco, string Telefone, string Sexo, string Ativo, DateTime DataCadastro)
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
        #endregion

        #region Excluir
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
        #endregion
    }
}
