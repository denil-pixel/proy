using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agendafamilyamigou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        grupo con = new grupo();
        private void Form1_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            con.consulta("select * from grupos", "grupos");
            dataGridView1.DataSource = con.ds.Tables["grupos"];
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
          //  string agregar = "insert into juegos values (" + txtid.Text + ",'" + txtnombre.Text + "','" + txtgenero.Text + "','" + txtdescripcion.Text + "','" + txtfoto.Text + "'," + txtcategoria_Edad.Text + ")";
          string agregar = "insert into grupos values ('"+ txtnombre.Text + "','" + txtcantidad.Text + "','" + txtestado.Text + "')";
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
            txtcantidad.Text = dgv.Cells[1].Value.ToString();
            txtestado.Text = dgv.Cells[2].Value.ToString();
         
        }

       /* private void button3_Click(object sender, EventArgs e)
        {
            //if (con.eliminar("juegos", "id = " + txtid.Text))
            if (con.eliminar("grupo", "nombre = " + txtnombre.Text))
            {
                MessageBox.Show("datos eliminados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al eliminar");
            }
        }*/

        private void btneditar_Click(object sender, EventArgs e)
        {
            string actualizar = "nombre='" + txtnombre.Text  + "', notas= '" + txtcantidad.Text + "'";
            if (con.editar("grupos", actualizar, "estado=" + txtestado.Text))
            {
                MessageBox.Show("datos actualizados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al actualizar");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.txt1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.textBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();


            // f2.data2.DataSource = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //if (con.eliminar("juegos", "id = " + txtid.Text))
            if (con.eliminar("grupos", "estado = " + txtestado.Text))
            {
                MessageBox.Show("datos eliminados");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al eliminar");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            /*if(txtbuscar.Text !="" )
            {
                dataGridView1.CurrentCell = null;
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }
                 foreach(DataGridViewRow r in dataGridView1.Rows)
                 {
                     foreach(DataGridViewCell c in r.Cells)
                     {
                         if((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) ==0)
                         {
                             r.Visible = true;
                             break;
                         }
                     }
                 }

            }
            else{
                mostrarDatos();
            }*/
                if (txtbuscar.Text != "") dataGridView1.DataSource = con.Buscar(txtbuscar.Text);
            else mostrarDatos();
        
        }
    

      



    }
}
