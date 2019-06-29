using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuario"]!=null && Session["usuario"].ToString().Length >0)
            {
                Response.Write(Session["usuario"] + "<br/><a href='Salir.aspx'>Cerrar sesion</a>");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}