namespace CUENTAS_POR_PAGAR
{
    partial class FINICIO
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
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.TXTCLAVE = new System.Windows.Forms.TextBox();
            this.BTNENTRAR = new System.Windows.Forms.Button();
            this.DGVUSUARIOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(224, 24);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(138, 20);
            this.TXTUSUARIO.TabIndex = 2;
            this.TXTUSUARIO.TextChanged += new System.EventHandler(this.TXTUSUARIO_TextChanged);
            // 
            // TXTCLAVE
            // 
            this.TXTCLAVE.Location = new System.Drawing.Point(224, 55);
            this.TXTCLAVE.Name = "TXTCLAVE";
            this.TXTCLAVE.Size = new System.Drawing.Size(138, 20);
            this.TXTCLAVE.TabIndex = 3;
            this.TXTCLAVE.TextChanged += new System.EventHandler(this.TXTCLAVE_TextChanged);
            // 
            // BTNENTRAR
            // 
            this.BTNENTRAR.Location = new System.Drawing.Point(147, 81);
            this.BTNENTRAR.Name = "BTNENTRAR";
            this.BTNENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTNENTRAR.TabIndex = 4;
            this.BTNENTRAR.Text = "ENTRAR";
            this.BTNENTRAR.UseVisualStyleBackColor = true;
            this.BTNENTRAR.Click += new System.EventHandler(this.BTNENTRAR_Click);
            // 
            // DGVUSUARIOS
            // 
            this.DGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUSUARIOS.Location = new System.Drawing.Point(0, 110);
            this.DGVUSUARIOS.Name = "DGVUSUARIOS";
            this.DGVUSUARIOS.Size = new System.Drawing.Size(377, 135);
            this.DGVUSUARIOS.TabIndex = 5;
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 242);
            this.Controls.Add(this.DGVUSUARIOS);
            this.Controls.Add(this.BTNENTRAR);
            this.Controls.Add(this.TXTCLAVE);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FINICIO";
            this.Text = "INICIO DE SESION";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.TextBox TXTCLAVE;
        private System.Windows.Forms.Button BTNENTRAR;
        private System.Windows.Forms.DataGridView DGVUSUARIOS;
    }
}

