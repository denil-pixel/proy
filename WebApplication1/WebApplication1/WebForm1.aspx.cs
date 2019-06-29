using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Areas a = new Areas();
            a.Base = 50;
            a.Altura = 77;
            Response.Write("El area del rectangulo es:" + a.Rectangulo().ToString());
        }
    }
}