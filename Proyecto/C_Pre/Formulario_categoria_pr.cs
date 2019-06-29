using C_Neg;
using System;
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
    public partial class Formulario_categoria_pr : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsModificar = false;

        public Formulario_categoria_pr()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre de la categoría");
        }

        //Para mostrar mensaje de confirmación
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdcategoria.Text = string.Empty;
        }

        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtNombre.ReadOnly = !Valor;
            this.txtDescripcion.ReadOnly = !Valor;
            this.txtIdcategoria.ReadOnly = !Valor;
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

        //Método Mostrar()

        private void Mostrar()
        {
            this.datalistado.DataSource = N_Cat.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        //Método BuscarNombre

        private void BuscarNombre()
        {
            this.datalistado.DataSource = N_Cat.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total Registros: " + Convert.ToString(datalistado.Rows.Count);
        }


        //Método Constructor
        private void Formulario_categoria_pr_Load(object sender, EventArgs e)
        {
             //Para ubicar al formulario en la parte superior del contenedor
            this.Top = 0;
            this.Left = 0;
            //Le decimos al DataGridView que no auto genere las columnas
            //Llenamos el DataGridView con la información
            //de todos nuestras categorías
            this.Mostrar();
            //Deshabilita los controles
            this.Habilitar(false);
            //Establece los botones
            this.Botones();
        }

       //Llamamos al Método Buscar

        private void btnbuscar_Click(object sender, EventArgs e)
        {
             this.BuscarNombre();
         }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta="";
                if(this.txtNombre.Text==string.Empty)
                {
                    MensajeError("Falta ingrese algunos datos , seran remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre");

                }
                else
                {
                    if(this.IsNuevo)
                    {
                        rpta=N_Cat.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        rpta=N_Cat.Editar(Convert.ToInt32(this.txtIdcategoria.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim());
                    }
                    if(rpta.Equals("OK"))
                    {
                        if(this.IsNuevo)
                        {
                        this.MensajeOK("Se inserto de forma correcta el registo");

                    }
                    else
                    {
                        this.MensajeOK("Se actualizo de forma correcta el registro");

                    }

                }
                else
                {
                    this.MensajeError(rpta);
                }
                this.IsNuevo= false;
                this.IsModificar= false;
                this.Botones();
                    this.Limpiar();
                    this.Mostrar();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message +ex.StackTrace);
            }
        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdcategoria.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["id_categoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre_categoria"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["descripcion"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!this.txtIdcategoria.Text.Equals(""))
            {
                this.IsModificar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar el registro a modificar");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsModificar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;

            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los registros", "Vendtly", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = N_Cat.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminjo coreectamete el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        
    }
}
  
