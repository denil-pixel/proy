using Modelo.nativo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agen
{
    public partial class Form1 : Form
    {
        Modelo.nativo.producto grupo = new Modelo.nativo.producto();
        DBModelo conex = new DBModelo();
        private void refresh()
        {
            dataGridView1.DataSource = grupo.Select(conex);
            dataGridView1.Columns["id"].Visible = false;
          //  dataGridView1.Columns["estado"].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            refresh();
        }

     
    }
}
