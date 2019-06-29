﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C_Neg;

namespace C_Pre
{
    public partial class frmCliente : Form
    {
        
         //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        //Constructor del formulario
        public frmCliente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre del Cliente");
            this.ttMensaje.SetToolTip(this.txtApellidos, "Ingrese Los Apellidos del Cliente");
            this.ttMensaje.SetToolTip(this.txtNum_Documento, "Ingrese el Documento del Cliente");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la Dirección del Cliente");

        }

        //Para mostrar mensaje de confirmación
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
           
            this.txtNombre.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtNum_Documento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTel.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtIdcliente.Text = string.Empty;
        }
        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
           
            this.txtNombre.ReadOnly = !Valor;
this.txtApellidos.ReadOnly = !Valor;
this.txtDireccion.ReadOnly = !Valor;
            this.cbTipo_Documento.Enabled = Valor;
            this.txtNum_Documento.Enabled = Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.txtTel.ReadOnly = !Valor;
            this.txtEmail.ReadOnly = !Valor;
            this.txtIdcliente.ReadOnly = !Valor;
        }
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsModificar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.datalistado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarApellidos()
        {
            this.datalistado.DataSource = NCliente.BuscarApellidos(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void BuscarNum_Documento()
        {
            this.datalistado.DataSource = NCliente.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }


     
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Apellidos"))
            {
                this.BuscarApellidos();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtTel.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if (this.txtTel.Text == string.Empty || this.txtApellidos.Text == string.Empty || txtNum_Documento.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtTel, "Ingrese un Valor");
                    errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un cliente 
                        Rpta = NCliente.Insertar(this.txtTel.Text.Trim().ToUpper(),
                        this.txtApellidos.Text.Trim().ToUpper(),cbSexo.Text,
                        dtFecha.Value,cbTipo_Documento.Text,
                        txtNum_Documento.Text,txtDireccion.Text,
                        txtTelefono.Text,txtEmail.Text);

                    }
                    else
                    {
                        //Vamos a modificar un Cliente
                        Rpta = NCliente.Editar(Convert.ToInt32(this.txtIdcliente.Text), this.txtTel.Text.Trim().ToUpper(),
                        this.txtApellidos.Text.Trim().ToUpper(), cbSexo.Text,
                        dtFecha.Value, cbTipo_Documento.Text,
                        txtNum_Documento.Text, txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text);
                    }
                    //Si la respuesta fue OK, fue porque se modifico 
                    //o inserto el Cliente
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsModificar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdcliente.Text = "";

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            } 
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Cliente no puede modificar
            if (!this.txtIdcliente.Text.Equals(""))
            {
                this.IsModificar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdcliente.Text = string.Empty;
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdcliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["idcliente"].Value);
            this.txtTel.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre"].Value);
            this.txtApellidos.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["apellidos"].Value);
            this.cbSexo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["sexo"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.cbTipo_Documento.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNum_Documento.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["email"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

       

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellidos.Text == string.Empty ||
                    this.txtNum_Documento.Text == string.Empty 
                    || this.txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un cliente 
                        Rpta = NCliente.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                        this.txtApellidos.Text.Trim().ToUpper(),
                        this.cbSexo.Text , dtFecha.Value,cbTipo_Documento.Text,
                        txtNum_Documento.Text,txtDireccion.Text,
                        txtTelefono.Text,txtEmail.Text);

                    }
                    else
                    {
                        //Vamos a modificar un Cliente
                        Rpta = NCliente.Editar(Convert.ToInt32(this.txtIdcliente.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                        this.txtApellidos.Text.Trim().ToUpper(),
                        this.cbSexo.Text, dtFecha.Value, cbTipo_Documento.Text,
                        txtNum_Documento.Text, txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text);
                    }
                    //Si la respuesta fue OK, fue porque se modifico 
                    //o inserto el Cliente
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsModificar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdcliente.Text = "";

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            } 
            
        }

        private void frmCliente_Load_1(object sender, EventArgs e)
        {
             //Para ubicar al formulario en la parte superior del contenedor
            this.Top = 0;
            this.Left = 0;
            //Le decimos al DataGridView que no auto genere las columnas
            //this.datalistado.AutoGenerateColumns = false;
            //Llenamos el DataGridView con la informacion
            //de todos nuestros Clientes
            this.Mostrar();
            //Deshabilita los controles
            this.Habilitar(false);
            //Establece los botones
            this.Botones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdcliente.Text.Equals(""))
            {
                this.IsModificar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }

        private void chkEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        

        }

        

        


    }

    
