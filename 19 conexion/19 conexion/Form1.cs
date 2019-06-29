using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19_conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Modelo.Nativo.DBmodelo op = new Modelo.Nativo.DBmodelo();
         op.open();
            MessageBox.Show(op.estado().ToString());
            DataTable aux = op.query("select * from tbpersona");
            MessageBox.Show("fila de resultado" +
                aux.Rows.Count.ToString());
            op.close();
            dataGridView1.DataSource = aux;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
