using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wfPais
{
    public partial class wfRegPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bRegistrar_Click(Object ob,EventArgs ev)
        {
            bdWebEntities ef = new bdWebEntities();
            try
            {
                pais p = new pais();
                p.pais1 = tbPais.Text;
                ef.pais.Add(p);
                ef.SaveChanges();
                Response.Redirect("wfPais.aspx");

            }
            catch(Exception ex)
            {
                lMsg.Text = "Error " + ex.Message;
            }
        }
    }
}