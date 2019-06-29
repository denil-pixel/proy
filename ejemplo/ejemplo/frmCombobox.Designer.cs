namespace ejemplo
{
    partial class frmCombobox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombobox));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radiohombre = new System.Windows.Forms.RadioButton();
            this.radiomujer = new System.Windows.Forms.RadioButton();
            this.groupsexo = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-3, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 0;
  
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "c++";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radiohombre
            // 
            this.radiohombre.AutoSize = true;
            this.radiohombre.Location = new System.Drawing.Point(75, 11);
            this.radiohombre.Name = "radiohombre";
            this.radiohombre.Size = new System.Drawing.Size(62, 17);
            this.radiohombre.TabIndex = 2;
            this.radiohombre.TabStop = true;
            this.radiohombre.Text = "Hombre";
            this.radiohombre.UseVisualStyleBackColor = true;
            // 
            // radiomujer
            // 
            this.radiomujer.AutoSize = true;
            this.radiomujer.Location = new System.Drawing.Point(186, 9);
            this.radiomujer.Name = "radiomujer";
            this.radiomujer.Size = new System.Drawing.Size(51, 17);
            this.radiomujer.TabIndex = 3;
            this.radiomujer.TabStop = true;
            this.radiomujer.Text = "Mujer";
            this.radiomujer.UseVisualStyleBackColor = true;
            // 
            // groupsexo
            // 
            this.groupsexo.Controls.Add(this.radiomujer);
            this.groupsexo.Controls.Add(this.radiohombre);
            this.groupsexo.Location = new System.Drawing.Point(58, 140);
            this.groupsexo.Name = "groupsexo";
            this.groupsexo.Size = new System.Drawing.Size(291, 34);
            this.groupsexo.TabIndex = 4;
            this.groupsexo.TabStop = false;
            this.groupsexo.Text = "Sexo";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(157, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(39, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "c#";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(248, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "java";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(331, 97);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ll"});
            this.comboBox2.Location = new System.Drawing.Point(248, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // frmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 330);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupsexo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCombobox";
            this.Text = "frmCombobox";
            this.Load += new System.EventHandler(this.frmCombobox_Load);
            this.groupsexo.ResumeLayout(false);
            this.groupsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radiohombre;
        private System.Windows.Forms.RadioButton radiomujer;
        private System.Windows.Forms.GroupBox groupsexo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}