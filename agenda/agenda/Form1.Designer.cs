namespace agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnredactAR = new System.Windows.Forms.Button();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnir = new System.Windows.Forms.Button();
            this.txts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfecha.Location = new System.Drawing.Point(314, 34);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(220, 20);
            this.txtfecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(235, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // btnredactAR
            // 
            this.btnredactAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnredactAR.Image = ((System.Drawing.Image)(resources.GetObject("btnredactAR.Image")));
            this.btnredactAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnredactAR.Location = new System.Drawing.Point(216, 276);
            this.btnredactAR.Name = "btnredactAR";
            this.btnredactAR.Size = new System.Drawing.Size(165, 56);
            this.btnredactAR.TabIndex = 3;
            this.btnredactAR.Text = "Redactar";
            this.btnredactAR.UseVisualStyleBackColor = true;
            this.btnredactAR.Click += new System.EventHandler(this.btnredactAR_Click);
            // 
            // txthora
            // 
            this.txthora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthora.Location = new System.Drawing.Point(314, 86);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(220, 20);
            this.txthora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(242, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora";
            // 
            // btnir
            // 
            this.btnir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnir.Image = ((System.Drawing.Image)(resources.GetObject("btnir.Image")));
            this.btnir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnir.Location = new System.Drawing.Point(407, 276);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(159, 56);
            this.btnir.TabIndex = 8;
            this.btnir.Text = "Aceptar";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // txts
            // 
            this.txts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txts.Location = new System.Drawing.Point(197, 131);
            this.txts.Multiline = true;
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(337, 107);
            this.txts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(110, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(4, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 146);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(638, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.btnredactAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnredactAR;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

