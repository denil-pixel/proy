using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using  CapaEntidades;
using System.Data;

namespace CapaAccesoDatos
{
   public class Emplead
   {
       #region "PATRON SINGLETON"
       private static Emplead daoEmpleado = null;
       private Emplead() { }
       public static Emplead getInstance()
       {
           if(daoEmpleado == null)
           {
               daoEmpleado = new Emplead();
           }
           return daoEmpleado;
       }
       #endregion

       public Emplead AccesoSistema(String user , String pass)
       {
           SqlConnection conexion = null;
           SqlCommand cmd = null;
           Emplead objEmpleado = null;
           SqlDataReader dr = null;
           try
           {
               conexion= Conexion.getInstance().ConexionBD();
               cmd = new SqlCommand("spAccesoSistema", conexion);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@prmUser", user);
               cmd.Parameters.AddWithValue("@prmPass", pass);
               conexion.Open();
               dr = cmd.ExecuteReader();
               if(dr.Read())
               {
                   objEmpleado = new Emplead();
                   objEmpleado.ID = Convert.ToInt32(dr["idEmplead"].ToString());
                   objEmpleado.Usuario = dr["Usuario"].ToString();
                   objEmpleado.Clave = dr["clave"].ToString();
               }
           }
           catch(Exception ex)
           {
               objEmpleado = null;
               throw ex;
           }
           finally
           {
               conexion.Close();
           }
           return objEmpleado;
       }

       public int ID { get; set; }

       public string Usuario { get; set; }

       public string Clave { get; set; }
   }
}
