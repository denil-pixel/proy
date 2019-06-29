using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace da
{
    public partial class pais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Lista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Lista1.SelectedIndex){

                case 0:
                    //ho
                    break;
                case 1:
                    imgMostrar.ImageUrl = "images/descarga(2).jpg";
                    break;

            }
        }
    }
}