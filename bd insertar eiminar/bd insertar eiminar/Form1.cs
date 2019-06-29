using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bd_insertar_eiminar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion con = new Conexion();

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion op = new Conexion();
            op.open();
            MessageBox.Show(op.estado().ToString());
            DataTable aux = op.query("select * from juegos");
          MessageBox.Show("fila de resultado " +  aux.Rows.Count.ToString());
          op.close();
           dataGridView1.DataSource = aux;

        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            con.open();
            DataTable t = con.query(@"insert into juegos(nombre,genero,descripcion,foto,categoria_edad)     
                values ('" +
              
            textBox1.GetText + "','" +
              tbapellidos.GetText + "','" +
              tbci.GetText + "','" +
              tblogin.GetText + "','" +
              tbpass1.GetText + "',1)");
            bd.close();
            if (t == null)
            {

            }*/
        }
      
        
    }

