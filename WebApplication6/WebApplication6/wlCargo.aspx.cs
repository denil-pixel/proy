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
    public partial class wlCargo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bRegClik(object sender, EventArgs e)
        {
            if(tbCargo.Text.Length >0)
            {
                String sql = String.Format("INSERT INTO cargo Values {'{0}'}", tbCargo.Text);
                SqlConnection conex = new SqlConnection("Data source =(local);Initial Catalog=bdWeb;User ID=PrograWeb;Password=Cl@v3");
                conex.Open();
                if(conex.State == ConnectionState.Open)
                {
                    SqlCommand comando = new  SqlCommand(sql,conex);
                    Int32 n=comando.ExecuteNonQuery();
                    if(n>0)
                    {
                        lMensaje.Text="registrado";
                    }
                    else{
                        lMensaje.Text="error de registro";
                    }
                }
                conex.Close();
            }
        }

       
    }
}