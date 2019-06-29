using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autosugerencia_Contr
{
    public partial class UserControl1 : UserControl
    {
         public enum TipoValidar { none =0, letras };
        /// <summary>
        /// indica como validara el campo en el textbox
        /// </summary>
        ///
        public TipoValidar Tipo { get; set; }
        public String MsgError { get; set; }
        public UserControl1()
        {
            InitializeComponent();
             Tipo = TipoValidar.none;
            textBox1.TextChanged += textBox1_TextChanged;
            MsgError = "Dato no permitido";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
            errorProvider1.SetError(textBox1, "");
            switch (Tipo)
            {
                case TipoValidar.none: break;
                case TipoValidar.letras:
                    if (ejemploValidaciones.ValidarDatos.isLetras(textBox1.Text))
                        errorProvider1.SetError(textBox1, MsgError);
                    break;
                
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

    
      
    }
}
