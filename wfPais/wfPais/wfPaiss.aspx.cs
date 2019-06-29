using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wfPais
{
    public partial class wfPaiss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                bdWebEntities ef = new bdWebEntities();
                var paises = (from p in ef.pais select p).ToList();

            }
        }
    }
}