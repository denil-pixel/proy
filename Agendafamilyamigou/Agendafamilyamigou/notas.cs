using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Agendafamilyamigou
{
    class notas
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=agenda;Integrated Security=True;");
      //  private SqlCommandBuilder cmb;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string elimina = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(elimina, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
 

    }
}
