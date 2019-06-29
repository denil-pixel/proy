using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Modelo.nativo
{
    public class DBModelo
    {
        //por el momento
        //pruebas

        private string cadenaConexion = "Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=producto;Integrated Security=True;";

        public SqlConnection conectar = new SqlConnection();
        public DBModelo() {
            cadenaConexion = ConfigurationManager.ConnectionStrings["miconexionPruebas"].ConnectionString;
            conectar = new SqlConnection(cadenaConexion);
        }
        public bool open() {
            try
            {
                conectar.Open();
                return true;
            }
            catch(Exception e){
                return false;
            }
        }
        public bool close() {
            conectar.Close();
            return true;
        }
        public System.Data.ConnectionState estado() {
            return conectar.State;
        }
        public string error { get; set; }
        public DataTable query(string query) {
            try
            {

                SqlCommand comand = new SqlCommand(query, conectar);
                //agregar parametro
                DataTable tabla = new DataTable();
                tabla.Load(comand.ExecuteReader());
                return tabla;
            }
            catch(Exception er) {
                error = er.Message;
            }
            return null;
        }
        public DataTable query(string query,List<SqlParameter> datos)
        {
            try
            {
                
                SqlCommand comand = new SqlCommand(query, conectar);
                //agregar parametro
                if(datos!=null)
                    comand.Parameters.AddRange(datos.ToArray());
                DataTable tabla = new DataTable();
                tabla.Load(comand.ExecuteReader());
                return tabla;
            }
            catch (Exception er)
            {
                error = er.Message;
            }
            return null;
        }

        public int? querySimple(string query, List<SqlParameter> datos)
        {
            try
            {
                //int ?p = 0;
                //p = null;
                SqlCommand comand = new SqlCommand(query, conectar);
                //agregar parametro
                comand.Parameters.AddRange(datos.ToArray());
                int? sal=(int?)comand.ExecuteScalar();
                return sal;
            }
            catch (Exception er)
            {
                error = er.Message;
            }
            return 0;
        }
    }
}
