using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo7.ui
{
    public partial class FmUser : UserControl
    {
        public FmUser()
        {
            InitializeComponent();
        }
        modelo.nativo.DBModelo bd = new modelo.nativo.DBModelo();
        private void Button1_Click(object sender, EventArgs e)
        {

            if (!tbpass1.GetText.Equals(tbpass2.GetText))
            {
                tberror.Text = "Los password son diferentes.";
            }
            else {
                tberror.Text = "Verificado";
            }
            bd.open();
            //OJOOOOOOOOOOOOO
            DataTable t=bd.query(@"insert into tbpersona(nombre,apellido,ci,login,password,estado)     
                values ('"+
                tbnombre.GetText+"','"+
                tbapellidos.GetText+"','"+
                tbci.GetText+"','"+
                tblogin.GetText+"','"+
                tbpass1.GetText+"',1)");
            bd.close();
            if (t == null) {

            }
        }
    }
}
