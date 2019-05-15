using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPll3bi
{
    public class banco
    {


        SqlConnection com = new SqlConnection("Password = 93912; Persist Security Info=True;User ID = RA93912; Initial Catalog = RA93912; Data Source = 10.101.148.8");


        SqlCommand cmd = null;


        public void comandosql(string Sql)
        {
            //abre a conexão
            com.Open();

            //Inseri o comando SQL e atribuir a conexão do banco
            cmd = new SqlCommand(Sql, com);

            //executa o comando
            cmd.ExecuteNonQuery();

            //fecha a conexão
            com.Close();


        }

        public int proximocod()
        {
            com.Open();
            SqlDataAdapter da = new SqlDataAdapter("select (max(Codigo) + 1) as Codigo from LPII3bi", com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            com.Close();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() != "")
            {
                return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            else
            {
                return 1;
            }
        }

        public void consultar(DataGridView Dgv, string Sql)
        {
            com.Open();
            cmd = new SqlCommand(Sql, com);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Dgv.DataSource = dt;
            com.Close();
        }
    }

    
}
