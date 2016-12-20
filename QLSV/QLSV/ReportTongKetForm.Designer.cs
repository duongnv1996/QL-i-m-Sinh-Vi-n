namespace QLSV
{
    partial class ReportTongKetForm
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
            this.tongketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tongketTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.tongketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTongKet";
            reportDataSource1.Value = this.tongketBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 597);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhVienDataSet2
            // 
            this.SinhVienDataSet2.DataSetName = "SinhVienDataSet2";
            this.SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tongketBindingSource
            // 
            this.tongketBindingSource.DataMember = "tongket";
            this.tongketBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // tongketTableAdapter
            // 
            this.tongketTableAdapter.ClearBeforeFill = true;
            // 
            // ReportTongKetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 707);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportTongKetForm";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.Text = "Xuất Bảng Điểm Tổng Kết";
            this.Load += new System.EventHandler(this.ReportTongKetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tongketBindingSource;
        private SinhVienDataSet2 SinhVienDataSet2;
        private SinhVienDataSet2TableAdapters.tongketTableAdapter tongketTableAdapter;
    }
}