using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion_Bd
{
    class Conexion
    {
        string cadena = "Data Source =DESKTOP-9LD220N\\QLEXPRESS;Initial Catalog =desarrolo; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public Conexion()
        {
            conectarbd.ConnectionString = cadena;

        }
        public void  abrir()
        {
            try{
                conectarbd.Open();
                MessageBox.Show("conexion abierta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("errot al abri"+ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
