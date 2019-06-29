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
    public partial class Form1 : Form
    {
       public struct da
        {
            public List<string> lista;
        }
        public struct re
        {
            public List<string> lista;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            da datos;
            datos.lista = new List<string>(new string[] { txtnombre.Text,txtapellidos.Text,txtci.Text });
            frmtraje frm = new frmtraje();
           // informacion rt = new informacion();
            
            frm.ShowDialog();
          re rela;
           rela.lista = new List<string>(new string[] { txtnombre.Text, txtapellidos.Text, txtci.Text ,txtdireccion.Text});
            informacion fr = new informacion(rela);
           fr.ShowDialog();
           // rt.ShowDialog();
           // frminfo frm = new frminfo(info);
            //para mostrar el formulario y bloquea las demas ventanas
            //frm.ShowDialog();
            //mostrar();
        }
    }
}
