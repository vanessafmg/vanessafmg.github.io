using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace _232017
{
    public class Banco
    {
        //criando as variáveis publicas para conexão e consulta serão usadas em todo o projeto
        //Connection responsável pela conexão com o MySQL
        public static MySqlConnection Conexao;
        //Command responsável pelas instruções SQL a serem executadas
        public static MySqlCommand Comando;
        //Adapter responsável por inserir dados em um dataTable
        public static MySqlDataAdapter Adaptador;
        //DataTable responsável por ligar o banco em controles com a propriedade Datasource
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                //estabelece os parâmetros para a conexão com o banco
                Conexao = new MySqlConnection("server=localhost;port=3308;uid=root;pwd=etecjau");

                //abre a conexão com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            
            {
                MessageBox.Show(e.Message,"Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao() 
        {
            try
            {
                //fecha conexão com o banco de dados
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                //chama a função para abertura de conexão com o banco
                AbrirConexao();

                //informa a instrução SQL
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                //executa a Query no MySQL (Raio do Workbench)
                Comando.ExecuteNonQuery();

                //criar tabela cidades
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades" + 
                                           "(id integer auto_increment primary key, " +
                                           "nome char (40), " + "uf char(02))", Conexao);
                //executa a Query no MySQL 
                Comando.ExecuteNonQuery();

                //criar tabela marcas
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                                           "(id integer auto_increment primary key, " +
                                           "marca char (20))", Conexao);
                //executa a Query no MySQL 
                Comando.ExecuteNonQuery();

                //criar tabela categorias
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                                           "(id integer auto_increment primary key, " +
                                           "categoria char (20))", Conexao);
                //executa a Query no MySQL 
                Comando.ExecuteNonQuery();

                //tabela clientes 
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes " +
                                           "(Id integer auto_increment primary key, " +
                                           "nome char (40), " +
                                           "idCidade integer," + 
                                           "dataNasc date," +
                                           "renda decimal(10,2), " + 
                                           "cpf char(14), " + 
                                           "foto varchar(100), " + 
                                           "venda boolean)", Conexao);
                //executa a Query no MySQL 
                Comando.ExecuteNonQuery();


                //chama a função para fechar a conexão com o bando
                FecharConexao();
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
