namespace CUENTAS_POR_PAGAR
{
    partial class FRCHEQUES
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
            this.CHEQUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHEQUESTableAdapter = new CUENTAS_POR_PAGAR.SCXPRAUDODataSetTableAdapters.CHEQUESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHEQUESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUENTAS_POR_PAGAR.RCHEQUES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(556, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // SCXPRAUDODataSet
            // 
            this.SCXPRAUDODataSet.DataSetName = "SCXPRAUDODataSet";
            this.SCXPRAUDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHEQUESBindingSource
            // 
            this.CHEQUESBindingSource.DataMember = "CHEQUES";
            this.CHEQUESBindingSource.DataSource = this.SCXPRAUDODataSet;
            // 
            // CHEQUESTableAdapter
            // 
            this.CHEQUESTableAdapter.ClearBeforeFill = true;
            // 
            // FRCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 338);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRCHEQUES";
            this.Text = "FRCHEQUES";
            this.Load += new System.EventHandler(this.FRCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCXPRAUDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHEQUESBindingSource;
        private SCXPRAUDODataSet SCXPRAUDODataSet;
        private SCXPRAUDODataSetTableAdapters.CHEQUESTableAdapter CHEQUESTableAdapter;
    }
}