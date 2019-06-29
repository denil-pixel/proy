namespace Parabola
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfig = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnme = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn1.Controls.Add(this.label2);
            this.pn1.Controls.Add(this.label1);
            this.pn1.Location = new System.Drawing.Point(42, 84);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(332, 211);
            this.pn1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // btnfig
            // 
            this.btnfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfig.Location = new System.Drawing.Point(285, 314);
            this.btnfig.Name = "btnfig";
            this.btnfig.Size = new System.Drawing.Size(75, 23);
            this.btnfig.TabIndex = 1;
            this.btnfig.Text = "Generar";
            this.btnfig.UseVisualStyleBackColor = false;
            this.btnfig.Click += new System.EventHandler(this.btnfig_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnme
            // 
            this.btnme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnme.BackColor = System.Drawing.Color.Silver;
            this.btnme.Location = new System.Drawing.Point(270, 37);
            this.btnme.Name = "btnme";
            this.btnme.Size = new System.Drawing.Size(33, 29);
            this.btnme.TabIndex = 2;
            this.btnme.Text = "-";
            this.btnme.UseVisualStyleBackColor = false;
            this.btnme.Click += new System.EventHandler(this.btnme_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmax.BackColor = System.Drawing.Color.Yellow;
            this.btnmax.Location = new System.Drawing.Point(309, 37);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(29, 29);
            this.btnmax.TabIndex = 3;
            this.btnmax.Text = "+";
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnx
            // 
            this.btnx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.Location = new System.Drawing.Point(344, 37);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(30, 29);
            this.btnx.TabIndex = 4;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(404, 349);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnme);
            this.Controls.Add(this.btnfig);
            this.Controls.Add(this.pn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Button btnfig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnme;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnx;
    }
}

