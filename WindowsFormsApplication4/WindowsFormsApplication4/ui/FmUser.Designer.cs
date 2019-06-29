namespace ejemplo7.ui
{
    partial class FmUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnombre = new CreandoControles.TextBoxValida();
            this.tbapellidos = new CreandoControles.TextBoxValida();
            this.tbci = new CreandoControles.TextBoxValida();
            this.tblogin = new CreandoControles.TextBoxValida();
            this.tbpass1 = new CreandoControles.TextBoxValida();
            this.tbpass2 = new CreandoControles.TextBoxValida();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tberror = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Anadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repetir";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(12, 28);
            this.tbnombre.MsgError = "Dato No permitido";
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(274, 20);
            this.tbnombre.TabIndex = 15;
            this.tbnombre.Tipo = CreandoControles.TextBoxValida.TipoValidar.letras;
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(12, 64);
            this.tbapellidos.MsgError = "Dato No permitido";
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(274, 20);
            this.tbapellidos.TabIndex = 16;
            this.tbapellidos.Tipo = CreandoControles.TextBoxValida.TipoValidar.letras;
            // 
            // tbci
            // 
            this.tbci.Location = new System.Drawing.Point(12, 97);
            this.tbci.MsgError = "Dato No permitido";
            this.tbci.Name = "tbci";
            this.tbci.Size = new System.Drawing.Size(274, 20);
            this.tbci.TabIndex = 17;
            this.tbci.Tipo = CreandoControles.TextBoxValida.TipoValidar.ci;
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(12, 130);
            this.tblogin.MsgError = "Dato No permitido";
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(274, 20);
            this.tblogin.TabIndex = 18;
            this.tblogin.Tipo = CreandoControles.TextBoxValida.TipoValidar.none;
            // 
            // tbpass1
            // 
            this.tbpass1.Location = new System.Drawing.Point(12, 163);
            this.tbpass1.MsgError = "Dato No permitido";
            this.tbpass1.Name = "tbpass1";
            this.tbpass1.Size = new System.Drawing.Size(274, 20);
            this.tbpass1.TabIndex = 19;
            this.tbpass1.Tipo = CreandoControles.TextBoxValida.TipoValidar.none;
            // 
            // tbpass2
            // 
            this.tbpass2.Location = new System.Drawing.Point(12, 196);
            this.tbpass2.MsgError = "Dato No permitido";
            this.tbpass2.Name = "tbpass2";
            this.tbpass2.Size = new System.Drawing.Size(274, 20);
            this.tbpass2.TabIndex = 20;
            this.tbpass2.Tipo = CreandoControles.TextBoxValida.TipoValidar.none;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tberror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tberror
            // 
            this.tberror.Name = "tberror";
            this.tberror.Size = new System.Drawing.Size(35, 17);
            this.tberror.Text = "Listo.";
            // 
            // FmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbpass2);
            this.Controls.Add(this.tbpass1);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.tbci);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FmUser";
            this.Size = new System.Drawing.Size(304, 294);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CreandoControles.TextBoxValida tbnombre;
        private CreandoControles.TextBoxValida tbapellidos;
        private CreandoControles.TextBoxValida tbci;
        private CreandoControles.TextBoxValida tblogin;
        private CreandoControles.TextBoxValida tbpass1;
        private CreandoControles.TextBoxValida tbpass2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tberror;
    }
}
