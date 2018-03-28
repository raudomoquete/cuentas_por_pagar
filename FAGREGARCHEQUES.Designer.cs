namespace CUENTAS_POR_PAGAR
{
    partial class FAGREGARCHEQUES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNUMCHEC = new System.Windows.Forms.TextBox();
            this.TXTNUMFACT = new System.Windows.Forms.TextBox();
            this.TXTVALCHEC = new System.Windows.Forms.TextBox();
            this.TXTFCHECQ = new System.Windows.Forms.TextBox();
            this.BTNAGREGA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DE CHEQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR CHEQUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA CHEQUE";
            // 
            // TXTNUMCHEC
            // 
            this.TXTNUMCHEC.Location = new System.Drawing.Point(159, 26);
            this.TXTNUMCHEC.Name = "TXTNUMCHEC";
            this.TXTNUMCHEC.Size = new System.Drawing.Size(100, 20);
            this.TXTNUMCHEC.TabIndex = 4;
            // 
            // TXTNUMFACT
            // 
            this.TXTNUMFACT.Location = new System.Drawing.Point(159, 65);
            this.TXTNUMFACT.Name = "TXTNUMFACT";
            this.TXTNUMFACT.Size = new System.Drawing.Size(100, 20);
            this.TXTNUMFACT.TabIndex = 5;
            // 
            // TXTVALCHEC
            // 
            this.TXTVALCHEC.Location = new System.Drawing.Point(159, 105);
            this.TXTVALCHEC.Name = "TXTVALCHEC";
            this.TXTVALCHEC.Size = new System.Drawing.Size(100, 20);
            this.TXTVALCHEC.TabIndex = 6;
            // 
            // TXTFCHECQ
            // 
            this.TXTFCHECQ.Location = new System.Drawing.Point(159, 141);
            this.TXTFCHECQ.Name = "TXTFCHECQ";
            this.TXTFCHECQ.Size = new System.Drawing.Size(100, 20);
            this.TXTFCHECQ.TabIndex = 7;
            // 
            // BTNAGREGA
            // 
            this.BTNAGREGA.Location = new System.Drawing.Point(114, 193);
            this.BTNAGREGA.Name = "BTNAGREGA";
            this.BTNAGREGA.Size = new System.Drawing.Size(75, 23);
            this.BTNAGREGA.TabIndex = 8;
            this.BTNAGREGA.Text = "AGREGAR";
            this.BTNAGREGA.UseVisualStyleBackColor = true;
            this.BTNAGREGA.Click += new System.EventHandler(this.BTNAGREGA_Click);
            // 
            // FAGREGARCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 280);
            this.Controls.Add(this.BTNAGREGA);
            this.Controls.Add(this.TXTFCHECQ);
            this.Controls.Add(this.TXTVALCHEC);
            this.Controls.Add(this.TXTNUMFACT);
            this.Controls.Add(this.TXTNUMCHEC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARCHEQUES";
            this.Text = "REGISTRAR DATOS DE CHEQUES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTNUMCHEC;
        private System.Windows.Forms.TextBox TXTNUMFACT;
        private System.Windows.Forms.TextBox TXTVALCHEC;
        private System.Windows.Forms.TextBox TXTFCHECQ;
        private System.Windows.Forms.Button BTNAGREGA;
    }
}