namespace QLSV
{
    partial class ReportBangDiemForm
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
            this.bangdiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangdiemTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.bangdiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangdiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDiem";
            reportDataSource1.Value = this.bangdiemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(866, 645);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhVienDataSet2
            // 
            this.SinhVienDataSet2.DataSetName = "SinhVienDataSet2";
            this.SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangdiemBindingSource
            // 
            this.bangdiemBindingSource.DataMember = "bangdiem";
            this.bangdiemBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // bangdiemTableAdapter
            // 
            this.bangdiemTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBangDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 755);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBangDiemForm";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.Text = "Xuất Bảng Điểm";
            this.Load += new System.EventHandler(this.ReportBangDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangdiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bangdiemBindingSource;
        private SinhVienDataSet2 SinhVienDataSet2;
        private SinhVienDataSet2TableAdapters.bangdiemTableAdapter bangdiemTableAdapter;
    }
}