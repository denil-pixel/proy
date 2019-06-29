using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
        }

        private void frmCombobox_Load(object sender, EventArgs e)
        {
            List<string> datos= new List<string>();
            datos.Add("c++");
            datos.Add("python");
            datos.Add("java");
            datos.Add("php");
            datos.Add("django");
            datos.Add("nodejs");


            comboBox1.DataSource = datos;


            List<persona> listaPersona = new List<persona>();
            listaPersona.Add(new persona() {
                apellidos = "portillo",
            Nombre ="Juanito",
            ID=1,
                lista = new List<Compras>()
                {
                    new Compras() {descripcion="mani",fecha =DateTime.Now, ID=1, precioTotal=25.5m },
                    new Compras() {descripcion="oreo",fecha =DateTime.Now, ID=2, precioTotal=5.5m },
                    new Compras() {descripcion="coca cola 3lt",fecha =DateTime.Now, ID=3, precioTotal=12.5m },
                }
        });
              listaPersona.Add(new persona() {
                apellidos = "jefa",
            Nombre ="Martha",
            ID=2,
            lista = new List<Compras>()
            {
            new Compras() {descripcion="teit",fecha =DateTime.Now, ID=1, precioTotal=2.5m },
            new Compras() {descripcion="mate",fecha =DateTime.Now, ID=2, precioTotal=6.5m },
            new Compras() {descripcion="arroz",fecha =DateTime.Now, ID=3, precioTotal=15.5m },
            }
        });
              listaPersona.Add(new persona() {
                apellidos = "mamani",
            Nombre ="Pancho",
            ID=3,
                lista = new List<Compras>()
            {
            new Compras() {descripcion="leche",fecha =DateTime.Now, ID=1, precioTotal=22.5m },
            new Compras() {descripcion="refresco",fecha =DateTime.Now, ID=2, precioTotal=6.5m },
            new Compras() {descripcion="pan",fecha =DateTime.Now, ID=3, precioTotal=.5m },
            }

        });
            comboBox2.DisplayMember = "fullName";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource= listaPersona;
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            dataGridView1.DataSource = comboBox2.DataSource;
            dataGridView1.Columns["fullName"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["apellidos"].HeaderText = "Apellidos";
        }

       

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("cell");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("cell");
            //databound devuelve 
            //rowsindex 
           
            persona paux = (persona)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //2forma
            persona paux1 = dataGridView1.Rows[e.RowIndex].DataBoundItem as persona;
            frmdetalle det = new frmdetalle(paux);
            //para mostrar
            det.ShowDialog();

        }


    

  


        }
    }

