using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class wfDelDepto : System.Web.UI.Page
    {
     
               Conexion con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
            else
            {
                con = new Conexion();
                 if (Request.QueryString["id"] != null && Request.QueryString["id"].Length > 0)
                {
                    if (con.select("SELECT *FROM departamento WHERE id= " + Request.QueryString["id"]))
                    {
                        hfCod.Value = con.tabla.Rows[0]["id"].ToString();
                        tbDepto.Text = con.tabla.Rows[0]["departamento"].ToString();
                        ddlPais.SelectedValue = con.tabla.Rows[0]["id_pais"].ToString();


                    }
                }

                }
            }
        
        }
    }
}