using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agenda
{
    public partial class frminfo : Form
    {
        public frminfo(Form1.da info)
        {
            InitializeComponent();
            txteste.Text = info.lista[0];
            
        }

       
    }
}
