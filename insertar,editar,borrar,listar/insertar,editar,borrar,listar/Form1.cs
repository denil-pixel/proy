using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using modelo.nativo;

namespace insertar_editar_borrar_listar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tjuego = new modelo.juego();
            tjuego.insert();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            int cat;
            int.TryParse(textBox5.Text, out cat);
            
                categoria = cat ;
            descripcion =textBox4
            }*/
        }
    }


