using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MPage
{
    public partial class wfListaDepartamento : System.Web.UI.Page
    {
        Conexion con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Conexion();
            String sql = "SELECT *FROM deparatamento";
            if (Request.QueryString["id_p"] != null)
                sql += "WHERE id_pais=" + Request.QueryString["id_p"];
            if(con.select (sql))
            {
                gvDepto.DataSource = con.tabla;
                gvDepto.DataBind();
            }
        }
    }
}