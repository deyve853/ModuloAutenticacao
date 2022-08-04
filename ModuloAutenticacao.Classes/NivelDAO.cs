using ModuloAutenticacao.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAuteticacao.Classes
{
    public class NivelDAO
    {
        public string Inserir(string nome)
        {   //abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DML
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adicioando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo pronto! Vamos executar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Dados inseridos com sucesso!";

        }
        public string Atualizar()
        {
            return "Vou atualizar";
        }
        public DataTable Pesquisar()
        {
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DML
            comando.CommandText = "select * from Nivel";

            //DataTable (banco de dados na memória)
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }

        public string Pesquisar(string v)
        {
            throw new NotImplementedException();
        }

        public string Deletar()
        {

            return "Vou deletar o registro";
        }
        //sobrecarga de metódo-mesmo nome 
        //overLoad
        public string PesquisarPorNome(string nome) 
        {
        return "Vou pesquisar por nome";
        }


    }
}