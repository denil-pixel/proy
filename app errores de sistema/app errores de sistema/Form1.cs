using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app_errores_de_sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        reportar con = new reportar();
        public void mostrarDatos()
        {
            con.consulta("select * from erroresa", "erroresa");
            dataGridView1.DataSource = con.ds.Tables["erroresa"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  con.conectar();
            mostrarDatos();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into erroresa values ('" + txtfecha.Text + "','" + txthora.Text + "','" + txtmodulo.Text + "','" + txtproblema.Text + "', '" + txtestado.Text + "')";
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
            txtfecha.Text = dgv.Cells[0].Value.ToString();
            txthora.Text = dgv.Cells[1].Value.ToString();
            txtmodulo.Text = dgv.Cells[2].Value.ToString();
            txtproblema.Text = dgv.Cells[3].Value.ToString();
            txtestado.Text = dgv.Cells[4].Value.ToString();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "") dataGridView1.DataSource = con.Buscar(txtbuscar.Text);
            else mostrarDatos();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.listar("select * from erroresa");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.textBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f3.ShowDialog();
            //   f2.txt1.Text = "Producto:" + "  " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + " \n   " + "Categoria" + "  " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString() + "  "
            //     + "Cantidad:" + " " + this.dataGridView1.CurrentRow.Cells[3].Value.ToString() + "  " + "Precio:" + "  " + this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //  f2.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //   f2.ShowDialog();
            //  Form2 f2 = new Form2();
            //    f2.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtfecha, "");
            if (!reportar.EsFecha(txtfecha.Text))
            {
              errorProvider1.SetError(txtfecha, "Ingresar formato correcto");
        }
        }

        private void txthora_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txthora, "");
            if (!reportar.EsFecha(txthora.Text))
            {
                errorProvider1.SetError(txthora, "Ingresar formato correcto");
            }
            
        }



    }
}