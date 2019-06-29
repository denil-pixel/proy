using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication6
{
    public partial class Login : System.Web.UI.Page
    {
        DataTable tUsuarios= new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
                tUsuarios.Columns.Add("Nombre");
                tUsuarios.Columns.Add("Usuario");
                tUsuarios.Columns.Add("Clave");
                tUsuarios.Columns.Add("Cargo");
                tUsuarios.Rows.Add(new Object[] { "Juan ", "juanito", "jotas", "encargado de tramites" });
                tUsuarios.Rows.Add(new Object[] { "Jacinta cuelar", "jacinta", "cuelllar", "encargado de cajas" });
                tUsuarios.Rows.Add(new Object[] { "Pedro Vasques", "admin", "root", "Administrador de sistemas" });
                if (IsPostBack)
            {

            }
            else
            {
            }
        }
        protected void bloginClik(Object ob ,EventArgs ev)
        {
          if(tbUsuario.Text!= null && tbUsuario.Text.Length >0)
          {
           /*   DataRow[] filas = tUsuarios.Select("Usuario='" + tbUsuario.Text + "' AND Clave='"+tbClave.Text + "'");
              if(filas !=null && filas.Length >0)
              {
                  Session["Usuario"] = filas[0]["Nombre"].ToString();
                  Session["Cargo"] = filas[0]["Cargo"].ToString();
                  Response.Redirect("Principal.aspx");
              }
              /*
              for (Int32 i = 0; i < tUsuarios.Rows.Count; i++) 
              
              {
                  if(tUsuarios.Rows[i]["Usuario"].ToString() ==tbUsuario.Text)
                  {
                      if(tUsuarios.Rows[i]["Clave"].ToString() ==tbClave.Text)
                      {
                          Session["Usuario"] = tUsuarios.Rows[i]["Nombre"].ToString();
                          Session["Cargo"] = tUsuarios.Rows[i]["Cargo"].ToString();
                          Response.Redirect("Principal.aspx");

                      }
                  }
              }*/
              DataView vUsuario = new DataView(tUsuarios);
              vUsuario.RowFilter = "Usuario='" + tbUsuario.Text + "' AND Clave='" + tbClave.Text + "'";
              if(vUsuario.Count >0)
              {
                  Session["Usuario"] = vUsuario[0]["Nombre"].ToString();
                  Session["Cargo"] = vUsuario[0]["Cargo"].ToString();
                  Response.Redirect("Principal.aspx");
              }


          }

        }
    }
}