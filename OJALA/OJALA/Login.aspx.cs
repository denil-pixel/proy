using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaLogicaNegocios;


namespace OJALA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender ,EventArgs e)
        {
            Emplead  objEmpleado = EmpleadoLN.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);
         
            if(objEmpleado != null)
            {
                Response.Write("<script>alert('USUARIO CORRECTO .')</script>");

            }
            else
            {
                Response.Write("<script>alert('USUARIO inCORRECTO .')</script>");

            }
        }
    }
}