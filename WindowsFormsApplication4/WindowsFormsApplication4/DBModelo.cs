using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ejemplo7.modelo.nativo
{
    class DBModelo
    {
        //por el momento
        //pruebas

        private string cadenaConexion = "Server=192.168.20.108;Database=desarrollo;User Id=cliente;Password=123456;";

        public SqlConnection conectar = new SqlConnection();
        public DBModelo() {
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
