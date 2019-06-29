using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatos();
        }
    }
}
