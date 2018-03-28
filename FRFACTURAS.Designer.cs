namespace CUENTAS_POR_PAGAR
{
    partial class FRFACTURAS
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
            this.FACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FACTURASTableAdapter = new CUENTAS_POR_PAGAR.SCXPRAUDODataSetTableAdapters.FACTURASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FACTURASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUENTAS_POR_PAGAR.FACTURACION.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(556, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCXPRAUDODataSet
            // 
            this.SCXPRAUDODataSet.DataSetName = "SCXPRAUDODataSet";
            this.SCXPRAUDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FACTURASBindingSource
            // 
            this.FACTURASBindingSource.DataMember = "FACTURAS";
            this.FACTURASBindingSource.DataSource = this.SCXPRAUDODataSet;
            // 
            // FACTURASTableAdapter
            // 
            this.FACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // FRFACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRFACTURAS";
            this.Text = "FRFACTURAS";
            this.Load += new System.EventHandler(this.FRFACTURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FACTURASBindingSource;
        private SCXPRAUDODataSet SCXPRAUDODataSet;
        private SCXPRAUDODataSetTableAdapters.FACTURASTableAdapter FACTURASTableAdapter;
    }
}