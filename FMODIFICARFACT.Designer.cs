﻿namespace CUENTAS_POR_PAGAR
{
    partial class FMODIFICARFACT
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
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNUMEROF = new System.Windows.Forms.TextBox();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.TXTVALFACT = new System.Windows.Forms.TextBox();
            this.TXTFECHAFACT = new System.Windows.Forms.TextBox();
            this.TXTFECHAVENC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR FACTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA FACTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA VENCIMIENTO";
            // 
            // TXTNUMEROF
            // 
            this.TXTNUMEROF.Location = new System.Drawing.Point(155, 15);
            this.TXTNUMEROF.Name = "TXTNUMEROF";
            this.TXTNUMEROF.Size = new System.Drawing.Size(109, 20);
            this.TXTNUMEROF.TabIndex = 5;
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(155, 49);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.Size = new System.Drawing.Size(142, 20);
            this.TXTCODIGO.TabIndex = 6;
            // 
            // TXTVALFACT
            // 
            this.TXTVALFACT.Location = new System.Drawing.Point(155, 83);
            this.TXTVALFACT.Name = "TXTVALFACT";
            this.TXTVALFACT.Size = new System.Drawing.Size(142, 20);
            this.TXTVALFACT.TabIndex = 7;
            // 
            // TXTFECHAFACT
            // 
            this.TXTFECHAFACT.Location = new System.Drawing.Point(155, 115);
            this.TXTFECHAFACT.Name = "TXTFECHAFACT";
            this.TXTFECHAFACT.Size = new System.Drawing.Size(142, 20);
            this.TXTFECHAFACT.TabIndex = 8;
            // 
            // TXTFECHAVENC
            // 
            this.TXTFECHAVENC.Location = new System.Drawing.Point(155, 146);
            this.TXTFECHAVENC.Name = "TXTFECHAVENC";
            this.TXTFECHAVENC.Size = new System.Drawing.Size(142, 20);
            this.TXTFECHAVENC.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMODIFICARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTFECHAVENC);
            this.Controls.Add(this.TXTFECHAFACT);
            this.Controls.Add(this.TXTVALFACT);
            this.Controls.Add(this.TXTCODIGO);
            this.Controls.Add(this.TXTNUMEROF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMODIFICARFACT";
            this.Text = "MODIFICAR DATOS DE FACTURAS POR PAGAR";
            this.Load += new System.EventHandler(this.FMODIFICARFACT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTNUMEROF;
        private System.Windows.Forms.TextBox TXTCODIGO;
        private System.Windows.Forms.TextBox TXTVALFACT;
        private System.Windows.Forms.TextBox TXTFECHAFACT;
        private System.Windows.Forms.TextBox TXTFECHAVENC;
        private System.Windows.Forms.Button button1;
    }
}