using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace porfacor
{
    public partial class de : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem Argentina = new ListItem("Argentina", "23");
                ListItem Venezuela = new ListItem("Venezuela", "24");
                ddlFrut.Items.Add(Argentina);
                ddlFrut.Items.Add(Venezuela);
            }
        }

        protected void BtnPruevas_Click(object sender, EventArgs e)
        {
            lblValor.Text = ddlFrut.SelectedIndex.ToString();
            lblSeleccionado.Text = ddlFrut.SelectedIndex.ToString();
           //lblSeleccionado.Text = ddlFrut.Items[ddlFrut.SelectedIndex].ToString();
        }
    }
}