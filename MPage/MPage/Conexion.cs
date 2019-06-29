using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MPage
{
    public class Conexion
    {
        public DataTable tabla { set; get; }
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        public String msg { set; get; }
        public Conexion()
        {
            //conexion
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "labCisco-04";
            csb.InitialCatalog = "bdWeb";
            csb.UserID = "PrograWeb";
            csb.Password = "Cl@v3";
            conexion = new SqlConnection(csb.ToString());

        }
        public void abrir()
        {
            conexion.Open();

        }
        public void cerrar()
        {
            conexion.Close();
        }
        public Boolean selectS(String sql, String campo , int valor)
        {
            try
            {
                //verdadero o falso si una consulta esta bien
                abrir();

                adaptador = new SqlDataAdapter();
                comando = new SqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sql;
                comando.Parameters.Add(campo, SqlDbType.Int).Value=valor;
                adaptador.SelectCommand = comando;
                tabla = new DataTable();
                adaptador.Fill(tabla);
                cerrar();
              
                if (tabla != null && tabla.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }
        public Boolean select(String sql)
        {
            try
            {
                //verdadero o falso si una consulta esta bien
                conexion.Open();

                adaptador = new SqlDataAdapter(sql, conexion);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                conexion.Close();

                if (tabla != null && tabla.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }
        public Boolean dml(String sql)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                Int32 n = comando.ExecuteNonQuery();
                conexion.Close();
                if (n > 0)
                    return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;


        }
    }
}