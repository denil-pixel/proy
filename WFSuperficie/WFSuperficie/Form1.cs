using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSuperficie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void bcalcu_Click(object sender, EventArgs e)
        {
            Int32 a = Convert.ToInt32(lAltura.Text);
            Int32 b = Convert.ToInt32(lBase.Text);
            Areas ar = new Areas(b, a);
            lTriangulo.Text = ar.Triangulo().ToString();
            lRectangulo.Text = ar.Rectangulo().ToString();
        }

    
     
    }
}
