using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class LoginCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {


                if (Request.Form["tbUsuario"] != null && Request.Form["tbUsuario"].ToString().Length > 3)
                {
                    Conexion con = new Conexion();
                    if (con.select(String.Format("SELECT u.*, p.nombres+' ' +p.ap_pat+' '+p.ap_mat nombre,p.ci FROM usuario u INNER JOIN "
                        + "persona  p ON u.cod_p=p.cod_p WHERE u.usuario='{0}' AND u.activo=1", Request.Form["tbUsuario"])))
                    {
                        if (con.tabla.Rows.Count == 1)
                        {
                            if (con.tabla.Rows[0]["clave"].ToString() == Request.Form["tbClave"])
                            {
                                Session["usuario"] = con.tabla.Rows[0]["nombre"].ToString();
                                Session["codigo"] = con.tabla.Rows[0]["id"].ToString();
                                Response.Redirect("main.aspx");
                            }

                        }
                    }
                    else
                    {
                        Response.Redirect("Login.aspx");

                    }

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
        }
    }
}