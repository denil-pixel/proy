using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto con = new Producto();

        public void mostrarDatos()
        {
            con.consulta("select * from product", "product");
            dataGridView1.DataSource = con.ds.Tables["product"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into product values ('" + txtnombre.Text + "','" + txtcategoria.Text + "','" + txtcantidad.Text + "', '" +txtfecha.Text + "','" + txtprecio.Text + "')";
            //  string agregar = "insert into grupo values ( "+dataGridView1)";
            if (con.insert(agregar))
            {
                MessageBox.Show("datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al agregar");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            txtnombre.Text = dgv.Cells[0].Value.ToString();
            txtcategoria.Text = dgv.Cells[1].Value.ToString();
            txtcantidad.Text = dgv.Cells[2].Value.ToString();
            txtfecha.Text = dgv.Cells[3].Value.ToString();
            txtprecio.Text = dgv.Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "") dataGridView1.DataSource = con.Buscar(txtbuscar.Text);
            else mostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.listar("select * from product");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.txt1.Text = "Producto:" + "  " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + " \n   " + "Categoria" + "  " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString() + "  "
                + "Cantidad:" + " " + this.dataGridView1.CurrentRow.Cells[3].Value.ToString() + "  " + "Precio:" + "  " + this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
          //  f2.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.ShowDialog();
        }

      
        
      
    }
}
