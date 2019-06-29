using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 con = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();

        }
        public void mostrarDatos()
        {
            con.consulta("select * from juegos", "juegos");
            dataGridView1.DataSource = con.ds.Tables["juegos"];
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into juegos values (" +txtid.Text+",'" + txtnombre.Text + "','" + txtgenero.Text + "','" + txtdescripcion.Text + "','" + txtfoto.Text + "'," + txtcategoria_Edad.Text + ")";
            if(con.insert(agregar))
            {
                MessageBox.Show("datos agregados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al agregar");
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (con.eliminar("juegos", "id = " + txtid.Text))
            {
                MessageBox.Show ("datos eliminados");
                mostrarDatos();
            }
            else{
                MessageBox.Show("error al eliminar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            txtid.Text = dgv.Cells[0].Value.ToString();
            txtnombre.Text = dgv.Cells[1].Value.ToString();
            txtgenero.Text = dgv.Cells[2].Value.ToString();
            txtdescripcion.Text = dgv.Cells[3].Value.ToString();
            txtfoto.Text = dgv.Cells[4].Value.ToString();
            txtcategoria_Edad.Text = dgv.Cells[5].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string actualizar = "nombre='" + txtnombre.Text + "', genero= '" + txtgenero.Text + "', descripcion= '"+ txtdescripcion.Text + "',foto= '"+ txtfoto.Text + "',categoria_Edad= '"+txtcategoria_Edad.Text +"'";
            if(con.actualizar("juegos",actualizar, "id="+ txtid.Text))
            {
                MessageBox.Show("datos actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al actualizar");
            }
        }

     
      
    }
}
