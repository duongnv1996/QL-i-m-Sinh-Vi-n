namespace QLSV
{
    partial class ReportKhoaForm
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
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SinhVienDataSet2 = new QLSV.SinhVienDataSet2();
            this.khoaTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.khoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetKhoa";
            reportDataSource1.Value = this.khoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            this.khoaBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // SinhVienDataSet2
            // 
            this.SinhVienDataSet2.DataSetName = "SinhVienDataSet2";
            this.SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 733);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportKhoaForm";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.Text = "Xuất Danh Sách Khoa";
            this.Load += new System.EventHandler(this.ReportKhoaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private SinhVienDataSet2 SinhVienDataSet2;
        private SinhVienDataSet2TableAdapters.khoaTableAdapter khoaTableAdapter;
    }
}