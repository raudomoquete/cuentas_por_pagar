namespace CUENTAS_POR_PAGAR
{
    partial class FAGREGARFACT
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
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.TXTCOD = new System.Windows.Forms.TextBox();
            this.TXTVALFACT = new System.Windows.Forms.TextBox();
            this.TXTFECHAFACT = new System.Windows.Forms.TextBox();
            this.TXTFECHVENC = new System.Windows.Forms.TextBox();
            this.BTNAGREGAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR FACTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA FACTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA VENCIMIENTO";
            // 
            // TXTNUM
            // 
            this.TXTNUM.Location = new System.Drawing.Point(162, 31);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(137, 20);
            this.TXTNUM.TabIndex = 5;
            this.TXTNUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUM_KeyPress);
            // 
            // TXTCOD
            // 
            this.TXTCOD.Location = new System.Drawing.Point(162, 65);
            this.TXTCOD.Name = "TXTCOD";
            this.TXTCOD.Size = new System.Drawing.Size(160, 20);
            this.TXTCOD.TabIndex = 6;
            this.TXTCOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCOD_KeyPress);
            // 
            // TXTVALFACT
            // 
            this.TXTVALFACT.Location = new System.Drawing.Point(162, 101);
            this.TXTVALFACT.Name = "TXTVALFACT";
            this.TXTVALFACT.Size = new System.Drawing.Size(160, 20);
            this.TXTVALFACT.TabIndex = 7;
            this.TXTVALFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTVALFACT_KeyPress);
            // 
            // TXTFECHAFACT
            // 
            this.TXTFECHAFACT.Location = new System.Drawing.Point(162, 141);
            this.TXTFECHAFACT.Name = "TXTFECHAFACT";
            this.TXTFECHAFACT.Size = new System.Drawing.Size(160, 20);
            this.TXTFECHAFACT.TabIndex = 8;
            this.TXTFECHAFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFECHAFACT_KeyPress);
            // 
            // TXTFECHVENC
            // 
            this.TXTFECHVENC.Location = new System.Drawing.Point(162, 181);
            this.TXTFECHVENC.Name = "TXTFECHVENC";
            this.TXTFECHVENC.Size = new System.Drawing.Size(160, 20);
            this.TXTFECHVENC.TabIndex = 9;
            this.TXTFECHVENC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFECHVENC_KeyPress);
            // 
            // BTNAGREGAR
            // 
            this.BTNAGREGAR.Location = new System.Drawing.Point(133, 223);
            this.BTNAGREGAR.Name = "BTNAGREGAR";
            this.BTNAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BTNAGREGAR.TabIndex = 10;
            this.BTNAGREGAR.Text = "AGREGAR";
            this.BTNAGREGAR.UseVisualStyleBackColor = true;
            this.BTNAGREGAR.Click += new System.EventHandler(this.BTNAGREGAR_Click);
            // 
            // FAGREGARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 337);
            this.Controls.Add(this.BTNAGREGAR);
            this.Controls.Add(this.TXTFECHVENC);
            this.Controls.Add(this.TXTFECHAFACT);
            this.Controls.Add(this.TXTVALFACT);
            this.Controls.Add(this.TXTCOD);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARFACT";
            this.Text = "REGISTRAR DATOS DE FACTURAS POR PAGAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.TextBox TXTCOD;
        private System.Windows.Forms.TextBox TXTVALFACT;
        private System.Windows.Forms.TextBox TXTFECHAFACT;
        private System.Windows.Forms.TextBox TXTFECHVENC;
        private System.Windows.Forms.Button BTNAGREGAR;
    }
}