using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication6
{
    class Class1
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=desarrolo;Integrated Security=True;");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void conectar ()
        {
            try
            {
             con.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("error al conectar");
            }
            finally
            {
                con.Close();
            }
        }
        public void consulta (string sql ,string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql,con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
          public bool insert (string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
              if(i > 0)
              {
                  return true;
              }
              else
              {
                  return false;
              }
        }
        public bool eliminar (string tabla ,string condicion)
          {
              con.Open();
              string elimina = "delete from " + tabla + " where " + condicion;
              comando = new SqlCommand(elimina, con);
              int i = comando.ExecuteNonQuery();
              con.Close();
            if( i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
          }
        public bool actualizar (string tabla ,string campos ,string condicion)
        {
            con.Open();
            string actulizar = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(actulizar,con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if(i > 0)
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
