using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paises
{
    public partial class enlazar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Lista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Lista1.SelectedIndex){
                case 0:
                    //sin codigo.
                    break;

                case 1:
                    imgMostrar.ImageUrl = "images/lobo.jpg";
                    break;

            }
        }
    }
}