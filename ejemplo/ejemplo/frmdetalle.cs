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
    public partial class frmdetalle : Form
    {
        public frmdetalle(persona p)
        {
            InitializeComponent();
            dataGridView1.DataSource = p.lista;
            dataGridView1.Columns["persona"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            Label titulo = new Label();
            titulo.Text = p.fullName;
            this.Controls.Add(titulo);
        }

      
    }
}
