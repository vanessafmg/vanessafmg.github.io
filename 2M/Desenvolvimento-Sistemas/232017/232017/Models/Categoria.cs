using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace _232017.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public void Incluir()
        {
            try
            {
                //Abre a cibexão com o banco
                Banco.AbrirConexao();
                //Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO categorias (categoria) VALUES (@categoria)", 
                    Banco.Conexao);
                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria); //Parâmetro String
                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Alterar()
        {
            try
            {
                //Abre a cibexão com o banco
                Banco.AbrirConexao();
                //Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("Update categorias set categoria = @categoria" +
                    " where id = @id", Banco.Conexao);
                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria); //Parâmetro String
                Banco.Comando.Parameters.AddWithValue("@id", id);
                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excluir()
        {
            try
            {
                //Abre a cibexão com o banco
                Banco.AbrirConexao();
                //Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("delete from categorias where id = @id", Banco.Conexao);
                //Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@id", id);
                //Executa o Comando, no MYSQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Categorias where categoria like @Categoria " +
                                                                "order by categoria", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Categoria", categoria + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

