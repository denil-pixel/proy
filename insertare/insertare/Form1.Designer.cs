namespace Crudgame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbgenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfoto = new System.Windows.Forms.TextBox();
            this.Foto = new System.Windows.Forms.Label();
            this.tbcat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(91, 27);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 22);
            this.tbnombre.TabIndex = 1;
            // 
            // tbgenero
            // 
            this.tbgenero.Location = new System.Drawing.Point(267, 27);
            this.tbgenero.Name = "tbgenero";
            this.tbgenero.Size = new System.Drawing.Size(100, 22);
            this.tbgenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(464, 24);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(232, 22);
            this.tbdescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // tbfoto
            // 
            this.tbfoto.Location = new System.Drawing.Point(91, 79);
            this.tbfoto.Name = "tbfoto";
            this.tbfoto.Size = new System.Drawing.Size(79, 22);
            this.tbfoto.TabIndex = 7;
            // 
            // Foto
            // 
            this.Foto.AutoSize = true;
            this.Foto.Location = new System.Drawing.Point(49, 82);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(36, 17);
            this.Foto.TabIndex = 6;
            this.Foto.Text = "Foto";
            // 
            // tbcat
            // 
            this.tbcat.Location = new System.Drawing.Point(323, 82);
            this.tbcat.Name = "tbcat";
            this.tbcat.Size = new System.Drawing.Size(88, 22);
            this.tbcat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria(Edad)";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(51, 151);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(140, 39);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(284, 151);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(174, 39);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(518, 151);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(178, 39);
            this.btnactualizar.TabIndex = 12;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.Btnactualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 207);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(103, 232);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(138, 22);
            this.tbbuscar.TabIndex = 15;
            this.tbbuscar.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Listar";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(12, 24);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(10, 22);
            this.tbid.TabIndex = 16;
            this.tbid.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 509);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.tbcat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbfoto);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbgenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbgenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfoto;
        private System.Windows.Forms.Label Foto;
        private System.Windows.Forms.TextBox tbcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbid;
    }
}

