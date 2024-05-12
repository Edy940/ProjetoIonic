
using System.Data;
using todo.Model;

namespace todo.Data
{
    //Essa classe ListaTodoHomologData é crucial para a interação com o banco de dados e a manipulação dos dados relacionados à lista de "todos". Ela depende da classe ListaTodoHomologModel
    public class ListaTodoHomologData
    {
        public DataSet selectListaTodoHomolog()
        {
            string sql = String.Empty;
            DataSet dsLogin = new DataSet();
            conexao con = new conexao();

            sql = "SELECT * FROM ListaTodoHomolog ";
                 
            dsLogin = con.returnDados(sql);

            return dsLogin;

        }
        public DataSet selectListaTodoHomolog(int id)
        {
            string sql = String.Empty;
            DataSet dsLogin = new DataSet();
            conexao con = new conexao();

            sql = "SELECT * FROM ListaTodoHomolog where ID = "+id;

            dsLogin = con.returnDados(sql);

            return dsLogin;

        }

        public void insertTodoHomolog(ListaTodoHomologModel lista)
        {

            conexao con = new conexao();
            string sql = "INSERT INTO ListaTodoHomolog (NomeTarefa,DataCriacao,DataConclusao,Status) VALUES" +
                " ('"+ lista.NomeTarefa + "','"+ lista.DataCriacao + "','"+ lista.DataConclusao + "' ,'"+ lista.Status + "')";
            con.executeSQL(sql);

        }

        public void updateTodoHomolog(ListaTodoHomologModel lista)
        {

            conexao con = new conexao();
            string sql = "UPDATE ListaTodoHomolog SET NomeTarefa = '" + lista.NomeTarefa + "',  DataCriacao = '" + lista.DataCriacao + "'," +
                "  DataConclusao = '" + lista.DataConclusao + "',  Status = '" + lista.Status + "' WHERE ID = '" + lista.ID + "'";
            con.executeSQL(sql);

        }

        public DataSet  deleteListaTodoHomolog(int id)
        {
            string sql = String.Empty;
            DataSet dsLogin = new DataSet();
            conexao con = new conexao();

            sql = "DELETE FROM ListaTodoHomolog where ID = " + id;

            dsLogin = con.returnDados(sql);

            return dsLogin;

        }
    }
}
