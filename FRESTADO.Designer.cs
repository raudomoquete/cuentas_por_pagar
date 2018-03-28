namespace CUENTAS_POR_PAGAR
{
    partial class FRESTADO
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SCXPRAUDODataSet = new CUENTAS_POR_PAGAR.SCXPRAUDODataSet();
            this.estado_de_cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estado_de_cuentasTableAdapter = new CUENTAS_POR_PAGAR.SCXPRAUDODataSetTableAdapters.estado_de_cuentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado_de_cuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estado_de_cuentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUENTAS_POR_PAGAR.ESTADO_DE_CUENTAS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(767, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCXPRAUDODataSet
            // 
            this.SCXPRAUDODataSet.DataSetName = "SCXPRAUDODataSet";
            this.SCXPRAUDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estado_de_cuentasBindingSource
            // 
            this.estado_de_cuentasBindingSource.DataMember = "estado_de_cuentas";
            this.estado_de_cuentasBindingSource.DataSource = this.SCXPRAUDODataSet;
            // 
            // estado_de_cuentasTableAdapter
            // 
            this.estado_de_cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // FRESTADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRESTADO";
            this.Text = "FRESTADO";
            this.Load += new System.EventHandler(this.FRESTADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado_de_cuentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estado_de_cuentasBindingSource;
        private SCXPRAUDODataSet SCXPRAUDODataSet;
        private SCXPRAUDODataSetTableAdapters.estado_de_cuentasTableAdapter estado_de_cuentasTableAdapter;
    }
}