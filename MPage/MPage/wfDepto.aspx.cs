using System;
using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class wfDepto : System.Web.UI.Page
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
                if(con.select("SELECT *FROM pais"))
                {
                    ddlPais.DataSource = con.tabla;
                    ddlPais.DataValueField = "id";
                    ddlPais.DataTextField = "pais";
                    ddlPais.DataBind();


                }

                }
            }
        
    
        protected void bRegistrar_Click(object sender ,EventArgs e)
        {
            con = new Conexion();
            if(con.dml(String.Format("INSERT INTO departamento VALUES ('{0}',{1})",tbDepto.Text,ddlPais.SelectedValue)))
            {
                Response.Redirect("wfListaDepartamento.asp?id_p=" + ddlPais.SelectedValue);

            }
            else
            {
                Response.Write("Error");
            }
        }

    }
}