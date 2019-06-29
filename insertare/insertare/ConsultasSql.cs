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
        private SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-DEAHU5FH; Initial Catalog = games; Integrated Security = true");
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

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbjuego where nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public bool Insertar(string nombre, string genero, string descripcion, string foto , string cat_edad)
        { 
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into tbjuego (nombre,genero,descripcion,foto,cat_edad) values ('{0}', '{1}', '{2}','{3}', '{4}')", new string[] {  nombre, genero, descripcion, foto, cat_edad }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string id)
        {
            conexion.Open();
            //SqlCommand cmd = new SqlCommand(string.Format("delete from tbjuego where ID = {0}", id), conexion);
            SqlCommand cmd = new SqlCommand("update tbjuego set estado=0 where id=@id", conexion);
            cmd.Parameters.AddWithValue("@id",id);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id, string nombre, string genero, string descripcion, string foto, string cat_edad)
        {
            //string cad = catedad;
            string query = "update tbjuego set nombre=@nombre, genero=@genero, descripcion=@descripcion, foto=@foto, cat_edad=@cat_edad where id=@id";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@foto", foto);
            cmd.Parameters.AddWithValue("cat_edad", cat_edad);
            cmd.Parameters.AddWithValue("@id",id);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
    }
}
