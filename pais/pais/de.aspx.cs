using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pais
{
    public partial class de : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                switch (nacion.SelectedValue)
                {
                    case "1":
                        {
                            den.Items.Clear();
                            Departamento.Text = "Departamento: ";
                            den.Items.Add("Beni");
                            den.Items.Add("Chuquisaca");
                            den.Items.Add("Cochabamba");
                            den.Items.Add("La Paz");
                            den.Items.Add("Oruro");
                            den.Items.Add("Pando");
                            den.Items.Add("Potosi");
                            den.Items.Add("Santa Cruz");
                            den.Items.Add("Tarija");
                            break;
                        }
                    case "2":
                        {
                            den.Items.Clear();
                            Departamento.Text = "Estado: ";
                            den.Items.Add("Amazonas");
                            den.Items.Add("Anzoategui");
                            den.Items.Add("Apure");
                            den.Items.Add("Aragua");
                            den.Items.Add("Barinas");
                            den.Items.Add("Bolivar");
                            den.Items.Add("Carabobo");
                            den.Items.Add("Cojedes");
                            den.Items.Add("Delta Amacuro");
                            den.Items.Add("Distrito Capital");
                            den.Items.Add("Falcon");
                            den.Items.Add("Guarico");
                           
                            break;

                        }
                    case "3":
                        {


                            den.Items.Clear();
                            Departamento.Text = "Provincia: ";
                            den.Items.Add("Buenos Aires");
                            den.Items.Add("Catamarca");
                            den.Items.Add("Chaco");
                            den.Items.Add("Chubut");
                            den.Items.Add("Cordova");
                            den.Items.Add("Corrientes");
                            den.Items.Add("Entre Rios");
                            den.Items.Add("Formosa");
                            den.Items.Add("Jujuy");
                            den.Items.Add("La Pampa");
                            den.Items.Add("La Rioja");
                            den.Items.Add("Mendoza");
                            den.Items.Add("Misiones");
                            den.Items.Add("Neuquen");
                           
                            break;
                        }
                    case "4":
                        {
                            den.Items.Clear();
                            Departamento.Text = "Provincia: ";
                            den.Items.Add("Azuay");
                            den.Items.Add("Bolivar");
                            den.Items.Add("Cañar");
                            den.Items.Add("Carchi");
                            den.Items.Add("Chimborazo");
                            den.Items.Add("Cotopaxi");
                            den.Items.Add("El Oro");
                            den.Items.Add("Esmeraldas");
                            den.Items.Add("Galapagos");
                            den.Items.Add("Guayas");
                            den.Items.Add("Imbabura");
                            
                            break;

                        }



                    case "5":
                        {

                            den.Items.Clear();
                            Departamento.Text = "Provincia: ";
                            den.Items.Add("Buenos Aires");
                            den.Items.Add("Catamarca");
                            den.Items.Add("Chaco");
                            den.Items.Add("Chubut");
                            den.Items.Add("Cordova");
                            den.Items.Add("Corrientes");
                            den.Items.Add("Entre Rios");
                            den.Items.Add("Formosa");
                            den.Items.Add("Jujuy");
                            
                            break;
                        }
                }
            }
        }
                
              
                        
                   
     
      
    }
    
}
  