using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace espero
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem Bolivia = new ListItem("Bolivia", "70");
                ListItem naranja = new ListItem("Naranaja", "5");
                ddlFrutas.Items.Add(Bolivia);
                ddlFrutas.Items.Add(naranja);

            }
        }

        protected void btnPrueba_Click(object sender, EventArgs e)
        {
            lblIndice.Text = ddlFrutas.SelectedItem.ToString();
            lblValor.Text = ddlFrutas.SelectedIndex.ToString();
            lblSeleccionado.Text = ddlFrutas.SelectedItem.ToString();
        }
        
    }
}