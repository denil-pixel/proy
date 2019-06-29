namespace repaso_pregunta_1
{
    partial class frmtraje
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txthombros = new System.Windows.Forms.TextBox();
            this.txtcintura = new System.Windows.Forms.TextBox();
            this.txtbrazos = new System.Windows.Forms.TextBox();
            this.txtpiernas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsigui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthombros
            // 
            this.txthombros.Location = new System.Drawing.Point(108, 40);
            this.txthombros.Name = "txthombros";
            this.txthombros.Size = new System.Drawing.Size(100, 20);
            this.txthombros.TabIndex = 0;
            // 
            // txtcintura
            // 
            this.txtcintura.Location = new System.Drawing.Point(108, 66);
            this.txtcintura.Name = "txtcintura";
            this.txtcintura.Size = new System.Drawing.Size(100, 20);
            this.txtcintura.TabIndex = 1;
            // 
            // txtbrazos
            // 
            this.txtbrazos.Location = new System.Drawing.Point(108, 110);
            this.txtbrazos.Name = "txtbrazos";
            this.txtbrazos.Size = new System.Drawing.Size(100, 20);
            this.txtbrazos.TabIndex = 2;
            // 
            // txtpiernas
            // 
            this.txtpiernas.Location = new System.Drawing.Point(108, 149);
            this.txtpiernas.Name = "txtpiernas";
            this.txtpiernas.Size = new System.Drawing.Size(100, 20);
            this.txtpiernas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hombros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cintura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "brazos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "piernas";
            // 
            // btnsigui
            // 
            this.btnsigui.Location = new System.Drawing.Point(184, 215);
            this.btnsigui.Name = "btnsigui";
            this.btnsigui.Size = new System.Drawing.Size(75, 23);
            this.btnsigui.TabIndex = 8;
            this.btnsigui.Text = "siguiente";
            this.btnsigui.UseVisualStyleBackColor = true;
            this.btnsigui.Click += new System.EventHandler(this.btnsigui_Click);
            // 
            // frmtraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsigui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpiernas);
            this.Controls.Add(this.txtbrazos);
            this.Controls.Add(this.txtcintura);
            this.Controls.Add(this.txthombros);
            this.Name = "frmtraje";
            this.Text = "frmtraje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthombros;
        private System.Windows.Forms.TextBox txtcintura;
        private System.Windows.Forms.TextBox txtbrazos;
        private System.Windows.Forms.TextBox txtpiernas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsigui;
    }
}