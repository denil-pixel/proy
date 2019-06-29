using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Crudgame
{
    public class ConsultasSql
    {
        private SqlConnection conexion = new SqlConnection("Data Source =(local);Initial Catalog =desarrolo; Integrated Security = true");
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select id,nombre,genero,descripcion,foto,cat_edad from tbjuego where estado=1", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

      
    }
}
