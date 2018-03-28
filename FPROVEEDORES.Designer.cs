namespace CUENTAS_POR_PAGAR
{
    partial class FPROVEEDORES
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
            this.DGVPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.BTNAGREGAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.TXTCIUDAD = new System.Windows.Forms.TextBox();
            this.TXTDIRECCION = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDOS = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPROVEEDORES
            // 
            this.DGVPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROVEEDORES.Location = new System.Drawing.Point(1, 58);
            this.DGVPROVEEDORES.Name = "DGVPROVEEDORES";
            this.DGVPROVEEDORES.Size = new System.Drawing.Size(577, 428);
            this.DGVPROVEEDORES.TabIndex = 0;
            // 
            // BTNAGREGAR
            // 
            this.BTNAGREGAR.Location = new System.Drawing.Point(33, 29);
            this.BTNAGREGAR.Name = "BTNAGREGAR";
            this.BTNAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BTNAGREGAR.TabIndex = 1;
            this.BTNAGREGAR.Text = "AGREGAR";
            this.BTNAGREGAR.UseVisualStyleBackColor = true;
            this.BTNAGREGAR.Click += new System.EventHandler(this.BTNAGREGAR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(229, 29);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICAR.TabIndex = 2;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(465, 29);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR PROVEEDORES POR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXTTELEFONO);
            this.panel1.Controls.Add(this.TXTCIUDAD);
            this.panel1.Controls.Add(this.TXTDIRECCION);
            this.panel1.Controls.Add(this.TXTAPELLIDOS);
            this.panel1.Controls.Add(this.TXTNOMBRE);
            this.panel1.Controls.Add(this.TXTCODIGO);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(584, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 251);
            this.panel1.TabIndex = 5;
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(118, 197);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(148, 20);
            this.TXTTELEFONO.TabIndex = 11;
            // 
            // TXTCIUDAD
            // 
            this.TXTCIUDAD.Location = new System.Drawing.Point(118, 163);
            this.TXTCIUDAD.Name = "TXTCIUDAD";
            this.TXTCIUDAD.Size = new System.Drawing.Size(148, 20);
            this.TXTCIUDAD.TabIndex = 10;
            this.TXTCIUDAD.TextChanged += new System.EventHandler(this.TXTCIUDAD_TextChanged);
            // 
            // TXTDIRECCION
            // 
            this.TXTDIRECCION.Location = new System.Drawing.Point(118, 131);
            this.TXTDIRECCION.Name = "TXTDIRECCION";
            this.TXTDIRECCION.Size = new System.Drawing.Size(148, 20);
            this.TXTDIRECCION.TabIndex = 9;
            this.TXTDIRECCION.TextChanged += new System.EventHandler(this.TXTDIRECCION_TextChanged);
            // 
            // TXTAPELLIDOS
            // 
            this.TXTAPELLIDOS.Location = new System.Drawing.Point(118, 95);
            this.TXTAPELLIDOS.Name = "TXTAPELLIDOS";
            this.TXTAPELLIDOS.Size = new System.Drawing.Size(148, 20);
            this.TXTAPELLIDOS.TabIndex = 8;
            this.TXTAPELLIDOS.TextChanged += new System.EventHandler(this.TXTAPELLIDOS_TextChanged);
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(118, 57);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(148, 20);
            this.TXTNOMBRE.TabIndex = 7;
            this.TXTNOMBRE.TextChanged += new System.EventHandler(this.TXTNOMBRE_TextChanged);
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(118, 26);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.Size = new System.Drawing.Size(148, 20);
            this.TXTCODIGO.TabIndex = 6;
            this.TXTCODIGO.TextChanged += new System.EventHandler(this.TXTCODIGO_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CIUDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO";
            // 
            // FPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNAGREGAR);
            this.Controls.Add(this.DGVPROVEEDORES);
            this.Name = "FPROVEEDORES";
            this.Text = "MANTENIMIENTO DE PROVEEDORES";
            this.Load += new System.EventHandler(this.FPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPROVEEDORES;
        private System.Windows.Forms.Button BTNAGREGAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.TextBox TXTCIUDAD;
        private System.Windows.Forms.TextBox TXTDIRECCION;
        private System.Windows.Forms.TextBox TXTAPELLIDOS;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTCODIGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}