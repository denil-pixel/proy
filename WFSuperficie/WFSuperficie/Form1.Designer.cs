namespace WFSuperficie
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
            this.tbBas = new System.Windows.Forms.TextBox();
            this.tbAltu = new System.Windows.Forms.TextBox();
            this.lBase = new System.Windows.Forms.Label();
            this.lAltura = new System.Windows.Forms.Label();
            this.ar_Triangulo = new System.Windows.Forms.Label();
            this.ar_Rectangulo = new System.Windows.Forms.Label();
            this.lTriangulo = new System.Windows.Forms.Label();
            this.lRectangulo = new System.Windows.Forms.Label();
            this.bcalcu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBas
            // 
            this.tbBas.Location = new System.Drawing.Point(113, 40);
            this.tbBas.Name = "tbBas";
            this.tbBas.Size = new System.Drawing.Size(111, 20);
            this.tbBas.TabIndex = 0;
            // 
            // tbAltu
            // 
            this.tbAltu.Location = new System.Drawing.Point(113, 87);
            this.tbAltu.Name = "tbAltu";
            this.tbAltu.Size = new System.Drawing.Size(111, 20);
            this.tbAltu.TabIndex = 1;
            // 
            // lBase
            // 
            this.lBase.AutoSize = true;
            this.lBase.Location = new System.Drawing.Point(70, 41);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(31, 13);
            this.lBase.TabIndex = 3;
            this.lBase.Text = "Base";
            // 
            // lAltura
            // 
            this.lAltura.AutoSize = true;
            this.lAltura.Location = new System.Drawing.Point(70, 94);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(34, 13);
            this.lAltura.TabIndex = 4;
            this.lAltura.Text = "Altura";
            // 
            // ar_Triangulo
            // 
            this.ar_Triangulo.AutoSize = true;
            this.ar_Triangulo.Location = new System.Drawing.Point(43, 135);
            this.ar_Triangulo.Name = "ar_Triangulo";
            this.ar_Triangulo.Size = new System.Drawing.Size(51, 13);
            this.ar_Triangulo.TabIndex = 5;
            this.ar_Triangulo.Text = "Triangulo";
            // 
            // ar_Rectangulo
            // 
            this.ar_Rectangulo.AutoSize = true;
            this.ar_Rectangulo.Location = new System.Drawing.Point(43, 168);
            this.ar_Rectangulo.Name = "ar_Rectangulo";
            this.ar_Rectangulo.Size = new System.Drawing.Size(62, 13);
            this.ar_Rectangulo.TabIndex = 6;
            this.ar_Rectangulo.Text = "Rectangulo";
            // 
            // lTriangulo
            // 
            this.lTriangulo.AutoSize = true;
            this.lTriangulo.Location = new System.Drawing.Point(124, 135);
            this.lTriangulo.Name = "lTriangulo";
            this.lTriangulo.Size = new System.Drawing.Size(13, 13);
            this.lTriangulo.TabIndex = 7;
            this.lTriangulo.Text = "0";
            // 
            // lRectangulo
            // 
            this.lRectangulo.AutoSize = true;
            this.lRectangulo.Location = new System.Drawing.Point(124, 168);
            this.lRectangulo.Name = "lRectangulo";
            this.lRectangulo.Size = new System.Drawing.Size(13, 13);
            this.lRectangulo.TabIndex = 8;
            this.lRectangulo.Text = "0";
            // 
            // bcalcu
            // 
            this.bcalcu.Location = new System.Drawing.Point(106, 195);
            this.bcalcu.Name = "bcalcu";
            this.bcalcu.Size = new System.Drawing.Size(118, 29);
            this.bcalcu.TabIndex = 9;
            this.bcalcu.Text = "Calcular";
            this.bcalcu.UseVisualStyleBackColor = true;
            this.bcalcu.Click += new System.EventHandler(this.bcalcu_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bcalcu);
            this.Controls.Add(this.lRectangulo);
            this.Controls.Add(this.lTriangulo);
            this.Controls.Add(this.ar_Rectangulo);
            this.Controls.Add(this.ar_Triangulo);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lBase);
            this.Controls.Add(this.tbAltu);
            this.Controls.Add(this.tbBas);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBas;
        private System.Windows.Forms.TextBox tbAltu;
        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Label ar_Triangulo;
        private System.Windows.Forms.Label ar_Rectangulo;
        private System.Windows.Forms.Label lTriangulo;
        private System.Windows.Forms.Label lRectangulo;
        private System.Windows.Forms.Button bcalcu;
    }
}

