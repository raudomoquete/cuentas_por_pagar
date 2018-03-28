namespace CUENTAS_POR_PAGAR
{
    partial class FCHEQUES
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
            this.DGVFCHEQUES = new System.Windows.Forms.DataGridView();
            this.BTNAGREGA = new System.Windows.Forms.Button();
            this.BTNMODIFICA = new System.Windows.Forms.Button();
            this.BTNELIMINA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTNFACT = new System.Windows.Forms.TextBox();
            this.TXTNCHEQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFCHEQUES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFCHEQUES
            // 
            this.DGVFCHEQUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFCHEQUES.Location = new System.Drawing.Point(0, 0);
            this.DGVFCHEQUES.Name = "DGVFCHEQUES";
            this.DGVFCHEQUES.Size = new System.Drawing.Size(499, 386);
            this.DGVFCHEQUES.TabIndex = 0;
            // 
            // BTNAGREGA
            // 
            this.BTNAGREGA.Location = new System.Drawing.Point(571, 49);
            this.BTNAGREGA.Name = "BTNAGREGA";
            this.BTNAGREGA.Size = new System.Drawing.Size(75, 23);
            this.BTNAGREGA.TabIndex = 1;
            this.BTNAGREGA.Text = "AGREGAR";
            this.BTNAGREGA.UseVisualStyleBackColor = true;
            this.BTNAGREGA.Click += new System.EventHandler(this.BTNAGREGA_Click);
            // 
            // BTNMODIFICA
            // 
            this.BTNMODIFICA.Location = new System.Drawing.Point(571, 99);
            this.BTNMODIFICA.Name = "BTNMODIFICA";
            this.BTNMODIFICA.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICA.TabIndex = 2;
            this.BTNMODIFICA.Text = "MODIFICAR";
            this.BTNMODIFICA.UseVisualStyleBackColor = true;
            this.BTNMODIFICA.Click += new System.EventHandler(this.BTNMODIFICA_Click);
            // 
            // BTNELIMINA
            // 
            this.BTNELIMINA.Location = new System.Drawing.Point(571, 159);
            this.BTNELIMINA.Name = "BTNELIMINA";
            this.BTNELIMINA.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINA.TabIndex = 3;
            this.BTNELIMINA.Text = "ELIMINAR";
            this.BTNELIMINA.UseVisualStyleBackColor = true;
            this.BTNELIMINA.Click += new System.EventHandler(this.BTNELIMINA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR CHEQUES POR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXTNFACT);
            this.panel1.Controls.Add(this.TXTNCHEQ);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(505, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 103);
            this.panel1.TabIndex = 5;
            // 
            // TXTNFACT
            // 
            this.TXTNFACT.Location = new System.Drawing.Point(130, 52);
            this.TXTNFACT.Name = "TXTNFACT";
            this.TXTNFACT.Size = new System.Drawing.Size(100, 20);
            this.TXTNFACT.TabIndex = 3;
            // 
            // TXTNCHEQ
            // 
            this.TXTNCHEQ.Location = new System.Drawing.Point(130, 13);
            this.TXTNCHEQ.Name = "TXTNCHEQ";
            this.TXTNCHEQ.Size = new System.Drawing.Size(100, 20);
            this.TXTNCHEQ.TabIndex = 2;
            this.TXTNCHEQ.TextChanged += new System.EventHandler(this.TXTNCHEQ_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NUMERO DE FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUMERO DE CHEQUE";
            // 
            // FCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINA);
            this.Controls.Add(this.BTNMODIFICA);
            this.Controls.Add(this.BTNAGREGA);
            this.Controls.Add(this.DGVFCHEQUES);
            this.Name = "FCHEQUES";
            this.Text = "MANTENIMIENTO DE CHEQUES";
            this.Load += new System.EventHandler(this.FCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFCHEQUES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFCHEQUES;
        private System.Windows.Forms.Button BTNAGREGA;
        private System.Windows.Forms.Button BTNMODIFICA;
        private System.Windows.Forms.Button BTNELIMINA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTNFACT;
        private System.Windows.Forms.TextBox TXTNCHEQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}