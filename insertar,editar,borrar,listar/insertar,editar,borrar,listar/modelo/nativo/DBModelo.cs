
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace modelo.nativo
{
    class DBModelo
    {
        //por el momento
        //pruebas

        private string cadenaConexion = "Data Source =DESKTOP-9LD220N\\QLEXPRESS;Initial Catalog =desarrolo; Integrated Security=True";

        public SqlConnection conectar = new SqlConnection();
        public DBModelo() {

            cadenaConexion = ConfigurationManager.ConnectionStrings["miconexion"].ConnectionString;
            conectar = new SqlConnection(cadenaConexion);
        }
        public bool open() {
            try
            {
                conectar.Open();
                return true;
            }
            catch {
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
             //   comand.Parameters.AddRange(datos.ToArray());
                DataTable tabla = new DataTable();
                tabla.Load(comand.ExecuteReader());
                return tabla;
            }
            catch(Exception er) {
                error = er.Message;
            }
            return null;
        }


       
    }
}
