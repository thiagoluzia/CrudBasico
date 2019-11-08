using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
    }
}
