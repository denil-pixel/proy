using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class wfUpDepto : System.Web.UI.Page
    {
        Conexion con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                con = new Conexion();
                if (con.select("SELECT *FROM pais"))
                {
                    ddlPais.DataSource = con.tabla;
                    ddlPais.DataValueField = "id";
                    ddlPais.DataTextField = "pais";
                    ddlPais.DataBind();


                }
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
        protected void bActualizar_Click(object sender, EventArgs e)
        {
            con = new Conexion();
            if (con.dml(String.Format("UPDATE departamento SET id_pais={1},departamento='{0}' WHERE id={2}"
                , tbDepto.Text, ddlPais.SelectedValue, hfCod.Value)))
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