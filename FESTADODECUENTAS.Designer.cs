namespace CUENTAS_POR_PAGAR
{
    partial class FESTADODECUENTAS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCODIGODELPROV = new System.Windows.Forms.TextBox();
            this.TXTNUMFACT = new System.Windows.Forms.TextBox();
            this.BTNVERTODOS = new System.Windows.Forms.Button();
            this.DGVESTADOSDCTAS = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADOSDCTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNVERTODOS);
            this.groupBox1.Controls.Add(this.TXTNUMFACT);
            this.groupBox1.Controls.Add(this.TXTCODIGODELPROV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR POR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO DEL PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // TXTCODIGODELPROV
            // 
            this.TXTCODIGODELPROV.Location = new System.Drawing.Point(156, 44);
            this.TXTCODIGODELPROV.Name = "TXTCODIGODELPROV";
            this.TXTCODIGODELPROV.Size = new System.Drawing.Size(114, 20);
            this.TXTCODIGODELPROV.TabIndex = 2;
            this.TXTCODIGODELPROV.TextChanged += new System.EventHandler(this.TXTCODIGODELPROV_TextChanged);
            // 
            // TXTNUMFACT
            // 
            this.TXTNUMFACT.Location = new System.Drawing.Point(406, 44);
            this.TXTNUMFACT.Name = "TXTNUMFACT";
            this.TXTNUMFACT.Size = new System.Drawing.Size(109, 20);
            this.TXTNUMFACT.TabIndex = 3;
            this.TXTNUMFACT.TextChanged += new System.EventHandler(this.TXTNUMFACT_TextChanged);
            // 
            // BTNVERTODOS
            // 
            this.BTNVERTODOS.Location = new System.Drawing.Point(591, 42);
            this.BTNVERTODOS.Name = "BTNVERTODOS";
            this.BTNVERTODOS.Size = new System.Drawing.Size(100, 23);
            this.BTNVERTODOS.TabIndex = 4;
            this.BTNVERTODOS.Text = "VER TODOS";
            this.BTNVERTODOS.UseVisualStyleBackColor = true;
            this.BTNVERTODOS.Click += new System.EventHandler(this.BTNVERTODOS_Click);
            // 
            // DGVESTADOSDCTAS
            // 
            this.DGVESTADOSDCTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVESTADOSDCTAS.Location = new System.Drawing.Point(3, 123);
            this.DGVESTADOSDCTAS.Name = "DGVESTADOSDCTAS";
            this.DGVESTADOSDCTAS.Size = new System.Drawing.Size(822, 265);
            this.DGVESTADOSDCTAS.TabIndex = 1;
            // 
            // FESTADODECUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 387);
            this.Controls.Add(this.DGVESTADOSDCTAS);
            this.Controls.Add(this.groupBox1);
            this.Name = "FESTADODECUENTAS";
            this.Text = "ESTADOS DE CUENTAS";
            this.Load += new System.EventHandler(this.FESTADODECUENTAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADOSDCTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNVERTODOS;
        private System.Windows.Forms.TextBox TXTNUMFACT;
        private System.Windows.Forms.TextBox TXTCODIGODELPROV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVESTADOSDCTAS;
    }
}