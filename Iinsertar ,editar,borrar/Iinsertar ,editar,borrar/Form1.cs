﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iinsertar__editar_borrar
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
            con.conectar();
        }
    }
}