﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace insert_edit
{
    class conex
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-9LD220N\\QLEXPRESS;Initial Catalog =desarrolo; Integrated Security=True");
        //  public SqlConnection conectarbd = new SqlConnection();

        public void conectar()
        {
            try
            {
                con.Open();

                MessageBox.Show("conexion abierta");
            }
            catch
            {
                MessageBox.Show("errotr");
            }
            finally
            {
                con.Close();
            }
        }

    }
}