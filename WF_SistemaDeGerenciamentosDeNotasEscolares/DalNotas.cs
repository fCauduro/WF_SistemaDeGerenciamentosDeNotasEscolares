using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_SistemaDeGerenciamentosDeNotasEscolares
{
   public class DalNotas
    {
        //endereco do banco de dados, o path se refere ao caminho aonde o banco esta
        public static string path = Directory.GetCurrentDirectory() + "\\banco.sqlite";
        private static SQLiteConnection sqliteConnection;


        //metodo conectar com o banco de dados
        private static SQLiteConnection DbConnection()
        {
            //procura o endereco
            sqliteConnection = new SQLiteConnection("Data Source =" + path);
            //abre o banco de dados
            sqliteConnection.Open();
            //retorna o endereco encontrado
            return sqliteConnection;
        }

        // criar banco dados
        public static void CriarBancoSQLite()
        {
            //try tratamento de execao 
            try
            {
                // se for falso q existe esse banco de dados  
                if (File.Exists(path) == false)
                {
                    //cria o banco
                    SQLiteConnection.CreateFile(path);
                }

            }
            //se nao nao faz nada
            catch
            {
                throw;
            }
        }

        //criat tabelas
        public static void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {




                    //Sab BOOLEAN NOT NULL CHECK (Sab IN (0, 1))
                    cmd.CommandText = @$"CREATE TABLE IF NOT EXISTS disciplina         (Id INTEGER PRIMARY KEY AUTOINCREMENT,   idDisciplina INTEGER , nomeDisciplina varchar(20), descricaoDisciplina varchar(50) , idNota int(11)  ); 
                                         CREATE TABLE IF NOT EXISTS usuario  (Id INTEGER PRIMARY KEY AUTOINCREMENT,   idUsuario INTEGER ,  nome varchar(30), vinculo enum('Professor','Aluno','Secretario') , cpf int(11), usuario varchar(11) ,  senha int(4), telefone varchar(11) , matricula int(11) , email varchar(30), endereco varchar(50)  );
                                         CREATE TABLE IF NOT EXISTS notas            (Id INTEGER PRIMARY KEY AUTOINCREMENT, idNota INTEGER , idNotaAluno int(11), idNotaDisciplina int(11),  nota1 decimal(5,2) , nota2` decimal(5,2) , nota3` decimal(5,2) , nota4 decimal(5,2) ,periodo enum('1º semestre','2º semestre') );
                                         ";

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
