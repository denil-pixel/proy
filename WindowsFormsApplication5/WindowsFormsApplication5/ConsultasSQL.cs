using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication5
{
    class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-9LD220N\\QLEXPRESS;Initial Catalog =desarrolo; Integrated Security=True");
        private DataSet ds;
        public DataTable MostrarDatos()
        {
           // conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from juegos", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
    }
}
