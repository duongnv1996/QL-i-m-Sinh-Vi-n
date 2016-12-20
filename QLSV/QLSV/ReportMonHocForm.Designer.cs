namespace QLSV
{
    partial class ReportMonHocForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SinhVienDataSet2 = new QLSV.SinhVienDataSet2();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.monhocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMonHoc";
            reportDataSource1.Value = this.monhocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhVienDataSet2
            // 
            this.SinhVienDataSet2.DataSetName = "SinhVienDataSet2";
            this.SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "monhoc";
            this.monhocBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // ReportMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 709);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportMonHocForm";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.Text = "Xuất Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.ReportMonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private SinhVienDataSet2 SinhVienDataSet2;
        private SinhVienDataSet2TableAdapters.monhocTableAdapter monhocTableAdapter;
    }
}