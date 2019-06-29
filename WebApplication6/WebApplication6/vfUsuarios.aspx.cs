using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class vfUsuarios : System.Web.UI.Page
    {
        DataTable tCargo ;
        DataTable tDepartamento;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                tDepartamento = new DataTable();
                SqlConnection conexion =new SqlConnection("Data Source=LABCISCO-04;Initial Catalog=dbWeb;User ID=PrograWeb;Password=Cl@v3);
                    conexion.Open();
                if(conexion.State == ConnectionState.Open)
                {
                    String sql ="SELECT *FROM departamento WHERE id_pais=2";
                    SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion );

                    adaptador.Fill(tDepartamento);
                    if(tDepartamento !=null && tDepartamento.Rows.Count >0)
                    {
                        ddlDepartamento.DataSource= tDepartamento;
                        ddlDepartamento.DataValueField= "id";
                        ddlDepartamento.DataTextField= "departamento";
                        ddlDepartamento.DataBin();
                    }
                }
                else
                    Response.Write("error de conexion ");
            }
            tCargo.Columns.Add(new DataColumn("codigo", System.Type.GetType("System.Int32")));
            tCargo.Columns.Add(new DataColumn("Nombre_cargo", System.Type.GetType("System.String")));
            tCargo.Rows.Add(new Object[] { 1, "Administrador" });
            tCargo.Rows.Add(new Object[] { 2, "Cajero" });
            tCargo.Rows.Add(new Object[] { 3, "Auditor" });
            tCargo.Rows.Add(new Object[] { 4, "Secretari@" });
            ddlCargo.DataSource = tCargo;
            ddlCargo.DataValueField = "codigo";
            ddlCargo.DataTextField = "nombre_cargo";
            ddlCargo.DataBind();
            
        }
        protected void bRegistrarClick(Object ob, EventArgs ev)
        {
            Response.Write(ddlCargo.SelectedValue);
        }
    }
}
