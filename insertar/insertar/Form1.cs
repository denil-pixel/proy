using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crudgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConsultasSql sql = new ConsultasSql();
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            tbid.Text = Convert.ToString(fila.Cells[0].Value);
            tbnombre.Text = Convert.ToString(fila.Cells[1].Value);
            tbgenero.Text = Convert.ToString(fila.Cells[2].Value);
            tbdescripcion.Text = Convert.ToString(fila.Cells[3].Value);
            tbfoto.Text = Convert.ToString(fila.Cells[4].Value);
            tbcat.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarDatos();
        }

      /*  private void Btnagregar_Click(object sender, EventArgs e)
        {
            
            if (sql.Insertar(tbnombre.Text, tbgenero.Text, tbdescripcion.Text, tbfoto.Text, tbcat.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView1.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido insertar los datos");
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            
            if (sql.Eliminar(tbid.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(tbid.Text, tbnombre.Text, tbgenero.Text, tbdescripcion.Text, tbfoto.Text, tbcat.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView1.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbbuscar.Text != "") dataGridView1.DataSource = sql.Buscar(tbbuscar.Text);
            else dataGridView1.DataSource = sql.MostrarDatos();
        }*/
    }
}
