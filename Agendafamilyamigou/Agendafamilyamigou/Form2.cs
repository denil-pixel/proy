using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agendafamilyamigou
{
    public partial class Form2 : Form
    {
 //       SqlConnection con = new SqlConnection(Properties.Settings.Default.ToString);
        public Form2()
        {
            InitializeComponent();
        }
        notas con = new notas();
        private void Form2_Load(object sender, EventArgs e)
        {

          //  mostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     //textBox1
            //if (con.eliminar("juegos", "id = " + txtid.Text))
            if (con.eliminar("grupos", "notas = " +  textBox1.Text))
            {
                MessageBox.Show("datos eliminados");
              //  mostrarDatos();
            }
            else
            {
                MessageBox.Show("error al eliminar");
            }
        }

  
    
        }

       
       /* public void mostrarDatos()
        {
            con.consulta("select * from notas", "notas");
            data2.DataSource = con.ds.Tables["notas"];
        }*/
   


    }

