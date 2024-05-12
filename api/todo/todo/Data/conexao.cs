using System.Data;
using System.Data.SqlClient;

namespace todo.Data
{
    public class conexao
    {

        private string conexaoString { get { return "Server=DESKTOP-MG1307N\\SQLEXPRESS;Database=ListaTodoHomolog;User=sa;Password=edy128201;"; } }

        public DataSet returnDados(string query)
        {
            DataSet DS = null;
            DataSet ds = new DataSet();

            using (SqlConnection connec = new SqlConnection())
            {
                connec.ConnectionString = conexaoString;
                connec.Open();

                Dadp(query, connec).Fill(ds);
                DS = ds;

                connec.Close();

                if (DS.Tables[0].Rows.Count == 0) { DS = null; }

                return DS;
            }
        }

        private SqlDataAdapter Dadp(string sql, SqlConnection whichDb)
        {
            return new SqlDataAdapter(sql, whichDb);
        }

        public void executeSQL(string query)
        {
            using (SqlConnection connec = new SqlConnection())
            {
                connec.ConnectionString = conexaoString;
                connec.Open();

                SqlCommand command2005 = new SqlCommand(query, connec);
                command2005.ExecuteNonQuery();

                connec.Close();
            }
        }

        public string returnId(string query)
        {

            string sql = String.Empty;
            string id = "0";

            using (SqlConnection connec = new SqlConnection())
            {

                connec.ConnectionString = conexaoString;
                connec.Open();

                SqlCommand command2005 = new SqlCommand(query, connec);
                command2005.ExecuteNonQuery();


                string SQLid = "SELECT @@identity as ID";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(SQLid, connec);

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    id = ds.Tables[0].Rows[0][0].ToString();
                }

                connec.Close();
            }

            return id;

        }
    }
}
