namespace CUENTAS_POR_PAGAR
{
    partial class FFACTURAS
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
            this.DGVFACTURAS = new System.Windows.Forms.DataGridView();
            this.BTNAGR = new System.Windows.Forms.Button();
            this.BTNMODIF = new System.Windows.Forms.Button();
            this.BTNELIMN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.TXTNFACTURA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFACTURAS
            // 
            this.DGVFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFACTURAS.Location = new System.Drawing.Point(1, 0);
            this.DGVFACTURAS.Name = "DGVFACTURAS";
            this.DGVFACTURAS.Size = new System.Drawing.Size(572, 472);
            this.DGVFACTURAS.TabIndex = 1;
            // 
            // BTNAGR
            // 
            this.BTNAGR.Location = new System.Drawing.Point(669, 94);
            this.BTNAGR.Name = "BTNAGR";
            this.BTNAGR.Size = new System.Drawing.Size(75, 23);
            this.BTNAGR.TabIndex = 2;
            this.BTNAGR.Text = "AGREGAR";
            this.BTNAGR.UseVisualStyleBackColor = true;
            this.BTNAGR.Click += new System.EventHandler(this.BTNAGR_Click);
            // 
            // BTNMODIF
            // 
            this.BTNMODIF.Location = new System.Drawing.Point(669, 149);
            this.BTNMODIF.Name = "BTNMODIF";
            this.BTNMODIF.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIF.TabIndex = 3;
            this.BTNMODIF.Text = "MODIFICAR";
            this.BTNMODIF.UseVisualStyleBackColor = true;
            this.BTNMODIF.Click += new System.EventHandler(this.BTNMODIF_Click);
            // 
            // BTNELIMN
            // 
            this.BTNELIMN.Location = new System.Drawing.Point(669, 202);
            this.BTNELIMN.Name = "BTNELIMN";
            this.BTNELIMN.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMN.TabIndex = 4;
            this.BTNELIMN.Text = "ELIMINAR";
            this.BTNELIMN.UseVisualStyleBackColor = true;
            this.BTNELIMN.Click += new System.EventHandler(this.BTNELIMN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BUSCAR FACTURAS POR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXTCODIGO);
            this.panel1.Controls.Add(this.TXTNFACTURA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(584, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 100);
            this.panel1.TabIndex = 6;
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(117, 53);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TXTCODIGO.TabIndex = 3;
            this.TXTCODIGO.TextChanged += new System.EventHandler(this.TXTCODIGO_TextChanged);
            // 
            // TXTNFACTURA
            // 
            this.TXTNFACTURA.Location = new System.Drawing.Point(117, 20);
            this.TXTNFACTURA.Name = "TXTNFACTURA";
            this.TXTNFACTURA.Size = new System.Drawing.Size(100, 20);
            this.TXTNFACTURA.TabIndex = 2;
            this.TXTNFACTURA.TextChanged += new System.EventHandler(this.TXTNFACTURA_TextChanged);
            this.TXTNFACTURA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNFACTURA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CODIGO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // FFACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMN);
            this.Controls.Add(this.BTNMODIF);
            this.Controls.Add(this.BTNAGR);
            this.Controls.Add(this.DGVFACTURAS);
            this.Name = "FFACTURAS";
            this.Text = "MANTENIMIENTO DE FACTURAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFACTURAS_FormClosed);
            this.Load += new System.EventHandler(this.FFACTURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFACTURAS;
        private System.Windows.Forms.Button BTNAGR;
        private System.Windows.Forms.Button BTNMODIF;
        private System.Windows.Forms.Button BTNELIMN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTCODIGO;
        private System.Windows.Forms.TextBox TXTNFACTURA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}