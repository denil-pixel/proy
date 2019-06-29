using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace repaso_pregunta_1
{
    public partial class frmtraje : Form
    {
         public struct da
        {
            public List<string> lista;
        }
        public frmtraje()
        {
            InitializeComponent();
        }

        private void btnsigui_Click(object sender, EventArgs e)
        {
            da info;
            info.lista = new List<string>(new string[] {txthombros.Text,txtcintura.Text,txtbrazos.Text,txtpiernas.Text});

            informacion frmul = new informacion(info);
            frmul.ShowDialog();
        }
    }
}
