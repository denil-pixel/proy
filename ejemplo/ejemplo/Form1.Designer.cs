namespace ejemplo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txta = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.btnca = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(97, 49);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(42, 20);
            this.txta.TabIndex = 0;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(97, 132);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(42, 20);
            this.txtc.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(97, 94);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(42, 20);
            this.txtb.TabIndex = 2;
            // 
            // btnca
            // 
            this.btnca.Image = ((System.Drawing.Image)(resources.GetObject("btnca.Image")));
            this.btnca.Location = new System.Drawing.Point(178, 188);
            this.btnca.Name = "btnca";
            this.btnca.Size = new System.Drawing.Size(75, 23);
            this.btnca.TabIndex = 3;
            this.btnca.Text = "calcular";
            this.btnca.UseVisualStyleBackColor = true;
            this.btnca.Click += new System.EventHandler(this.btnca_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(97, 188);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(88, 168);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(29, 13);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "resul";
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(0, 188);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(107, 23);
            this.btnir.TabIndex = 6;
            this.btnir.Text = "ir a Co&mando";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnca);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnca;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnir;
    }
}

