using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mostrar_datos_persona
{
    public partial class Person : UserControl
    {
         public enum TipoValidar { none =0,entero , letras, email, ip, ci };
        /// <summary>
        /// indica como validara el campo en el textbox
        /// </summary>
        ///
        public TipoValidar Tipo { get; set; }
        public String MsgError { get; set; }
          public Person()
        {
            InitializeComponent();
                 Tipo = TipoValidar.none;
                 Tipo_1 = TipoValidar.none;
                 Tipo_2 = TipoValidar.none;


                 Tipo_3 = TipoValidar.none;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;

     
            MsgError = "Dato no permitido";
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            switch (Tipo)
            {
                case TipoValidar.none: break;
                case TipoValidar.letras:
                    if (!ejemploValidaciones.ValidarDatos.isLetras(textBox1.Text))
                        errorProvider1.SetError(textBox1, MsgError);
                    break;
                case TipoValidar.ci:
                    if (ejemploValidaciones.ValidarDatos.isCi(textBox1.Text))
                        errorProvider1.SetError(textBox1, MsgError);
                    break;
                case TipoValidar.email:
                    if (ejemploValidaciones.ValidarDatos.isEmail(textBox1.Text))
                        errorProvider1.SetError(textBox1, MsgError); break;

                case TipoValidar.entero:
                    if (!ejemploValidaciones.ValidarDatos.isEntero(textBox1.Text))
                        errorProvider1.SetError(textBox1, MsgError); break;
               
            }
        }
   

        public string SetText
        {
            set { textBox1.Text = value; }
        
        }
        public object GetText
        {
            //canbiar
            get { return textBox1.Text; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
            switch (Tipo_1)
            {
                case TipoValidar.none: break;
                case TipoValidar.letras:
                    if (!ejemploValidaciones.ValidarDatos.isLetras(textBox2.Text))
                        errorProvider1.SetError(textBox2, MsgError);
                    break;
                case TipoValidar.ci:
                    if (ejemploValidaciones.ValidarDatos.isCi(textBox1.Text))
                        errorProvider1.SetError(textBox2, MsgError);
                    break;
                case TipoValidar.email:
                    if (ejemploValidaciones.ValidarDatos.isEmail(textBox1.Text))
                        errorProvider1.SetError(textBox2, MsgError); break;

                case TipoValidar.entero:
                    if (!ejemploValidaciones.ValidarDatos.isEntero(textBox1.Text))
                        errorProvider1.SetError(textBox2, MsgError); break;

            }
        }







        public TipoValidar Tipo_1 { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            String de = textBox1.Text;
            String fr = textBox2.Text;
            String fre = textBox3.Text;
            String frt = textBox4.Text;
            MessageBox.Show("Registro de" + "  " + de +  "   " + fr  +" edad de "+ " "+fre +" direccion" +"  "+ frt);

        }

        public TipoValidar Tipo_2 { get; set; }

        public TipoValidar Tipo_3 { get; set; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, "");
            switch (Tipo_2)
            {
                case TipoValidar.none: break;
                case TipoValidar.letras:
                    if (!ejemploValidaciones.ValidarDatos.isLetras(textBox3.Text))
                        errorProvider1.SetError(textBox3, MsgError);
                    break;
                case TipoValidar.ci:
                    if (ejemploValidaciones.ValidarDatos.isCi(textBox3.Text))
                        errorProvider1.SetError(textBox3, MsgError);
                    break;
                case TipoValidar.email:
                    if (ejemploValidaciones.ValidarDatos.isEmail(textBox3.Text))
                        errorProvider1.SetError(textBox3, MsgError); break;

                case TipoValidar.entero:
                    if (!ejemploValidaciones.ValidarDatos.isEntero(textBox3.Text))
                        errorProvider1.SetError(textBox3, MsgError); break;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox4, "");
            switch (Tipo_3)
            {
                case TipoValidar.none: break;
                case TipoValidar.letras:
                    if (!ejemploValidaciones.ValidarDatos.isLetras(textBox3.Text))
                        errorProvider1.SetError(textBox4, MsgError);
                    break;
                case TipoValidar.ci:
                    if (ejemploValidaciones.ValidarDatos.isCi(textBox4.Text))
                        errorProvider1.SetError(textBox4, MsgError);
                    break;
                case TipoValidar.email:
                    if (ejemploValidaciones.ValidarDatos.isEmail(textBox4.Text))
                        errorProvider1.SetError(textBox4, MsgError); break;

                case TipoValidar.entero:
                    if (!ejemploValidaciones.ValidarDatos.isEntero(textBox4.Text))
                        errorProvider1.SetError(textBox4, MsgError); break;

            }

        }
    }
}
