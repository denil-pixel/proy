using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelo.nativo.DBModelo op = new modelo.nativo.DBModelo();
            op.open();
            MessageBox.Show(op.estado().ToString());
            DataTable aux = op.query("select * from tbpersona");
            MessageBox.Show("fila de resultado "+
                aux.Rows.Count.ToString());
            op.close();
            dataGridView1.DataSource =aux;

            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = aux;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
