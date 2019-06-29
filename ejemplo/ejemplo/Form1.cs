using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void btnca_Click(object sender, EventArgs e)
        {
        decimal a, b, c;
            if (!decimal.TryParse(txta.Text, out a))
            {
                MessageBox.Show("no se puede convertir ");
                error.SetError(txta, "solo numeros");
            }
            else
            
            error.SetError(txta,"");
            if (!decimal.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("no se puede convertir ");
                error.SetError(txtb, "solo numeros");
            }
            else

                error.SetError(txtb, " ");
            if (!decimal.TryParse(txtc.Text, out c))
            {
                MessageBox.Show("no se puede convertir ");
                error.SetError(txtc, "solo numeros");
            }
            else

                error.SetError(txtc, "");
            try {
                decimal r = a + b +c ;
                lblresultado.Text = r.ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally{
            
             MessageBox.Show("termino todo ");
        
        }
       
    }






        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            error.SetError(txta, null);
            error.SetError(txtb, null);
            error.SetError(txtc, null);
            txta.ResetText();
            txtb.ResetText();
            txtc.ResetText();
            lblresultado.ResetText();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            //para llamar al formulario
            frmCombobox frm = new frmCombobox();
            //para mostrar el formulario y bloquea las demas ventanas
            //frm.ShowDialog();
            //no bloquea
            frm.Show();

        }

       

       
    }
}
