namespace QLSV
{
    partial class ReportLopForm
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
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.khoaTableAdapter();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QLSV.SinhVienDataSet2TableAdapters.lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLop";
            reportDataSource1.Value = this.lopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhVienDataSet2
            // 
            this.SinhVienDataSet2.DataSetName = "SinhVienDataSet2";
            this.SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "khoa";
            this.khoaBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.SinhVienDataSet2;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // ReportLopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 689);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportLopForm";
            this.Padding = new System.Windows.Forms.Padding(20, 90, 20, 20);
            this.Text = "Xuất Danh Sách Lớp";
            this.Load += new System.EventHandler(this.ReportLopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private SinhVienDataSet2 SinhVienDataSet2;
        private SinhVienDataSet2TableAdapters.khoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private SinhVienDataSet2TableAdapters.lopTableAdapter lopTableAdapter;
    }
}