using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace bd_insertar_eiminar
{
    class Conexion
    {

        private string cadenaConexion = "Server=DESKTOP-9LD220N\\SQLEXPRESS;Database=desarrolo; User Id=cliente;Password=cliente;";

        public SqlConnection conectar = new SqlConnection();
        public Conexion() {
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
       