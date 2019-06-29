namespace Creando_Controles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texBboxValida1 = new Creando_Controles.TexBboxValida();
            this.SuspendLayout();
            // 
            // texBboxValida1
            // 
            this.texBboxValida1.Location = new System.Drawing.Point(21, 21);
            this.texBboxValida1.MsgError = "Dato no permitido";
            this.texBboxValida1.Name = "texBboxValida1";
            this.texBboxValida1.Size = new System.Drawing.Size(216, 27);
            this.texBboxValida1.TabIndex = 0;
            this.texBboxValida1.Tipo = Creando_Controles.TexBboxValida.TipoValidar.entero;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.texBboxValida1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TexBboxValida texBboxValida1;

    }
}

