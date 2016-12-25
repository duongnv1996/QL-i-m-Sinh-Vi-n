namespace QLSV
{
    partial class DialogController
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new LollipopButton();
            this.btnAdd = new LollipopButton();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new LollipopTextBox();
            this.txtMaLop = new LollipopTextBox();
            this.btnExcel = new LollipopButton();
            this.btnDelete = new LollipopButton();
            this.sinhvienSerivicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaSeriviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienSerivicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaSeriviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lollipopLabel3);
            this.panel2.Controls.Add(this.lollipopLabel2);
            this.panel2.Controls.Add(this.lollipopLabel1);
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.txtTenLop);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 339);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BGColor = "#508ef5";
            this.btnUpdate.FontColor = "#ffffff";
            this.btnUpdate.Location = new System.Drawing.Point(178, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.lollipopButton2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BGColor = "#90DFAA";
            this.btnAdd.FontColor = "#ffffff";
            this.btnAdd.Location = new System.Drawing.Point(178, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(16, 109);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(64, 20);
            this.lollipopLabel3.TabIndex = 7;
            this.lollipopLabel3.Text = "Tên lớp";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(16, 44);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(59, 20);
            this.lollipopLabel2.TabIndex = 6;
            this.lollipopLabel2.Text = "Mã lớp";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(16, 183);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(72, 20);
            this.lollipopLabel1.TabIndex = 2;
            this.lollipopLabel1.Text = "Mã khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(113, 183);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(252, 24);
            this.cbbKhoa.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.FocusedColor = "#508ef5";
            this.txtTenLop.FontColor = "#999999";
            this.txtTenLop.IsEnabled = true;
            this.txtTenLop.Location = new System.Drawing.Point(113, 109);
            this.txtTenLop.MaxLength = 32767;
            this.txtTenLop.Multiline = false;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.ReadOnly = false;
            this.txtTenLop.Size = new System.Drawing.Size(252, 24);
            this.txtTenLop.TabIndex = 1;
            this.txtTenLop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenLop.UseSystemPasswordChar = false;
            this.txtTenLop.Enter += new System.EventHandler(this.txtTenLop_Enter);
            // 
            // txtMaLop
            // 
            this.txtMaLop.FocusedColor = "#508ef5";
            this.txtMaLop.FontColor = "#999999";
            this.txtMaLop.IsEnabled = true;
            this.txtMaLop.Location = new System.Drawing.Point(113, 40);
            this.txtMaLop.MaxLength = 32767;
            this.txtMaLop.Multiline = false;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = false;
            this.txtMaLop.Size = new System.Drawing.Size(252, 24);
            this.txtMaLop.TabIndex = 0;
            this.txtMaLop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaLop.UseSystemPasswordChar = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BGColor = "#508ef5";
            this.btnExcel.FontColor = "#ffffff";
            this.btnExcel.Location = new System.Drawing.Point(3, 295);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(177, 41);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Nhập từ Excel";
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BGColor = "#F44336";
            this.btnDelete.FontColor = "#ffffff";
            this.btnDelete.Location = new System.Drawing.Point(3, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.lollipopButton3_Click);
            // 
            // sinhvienSerivicesBindingSource
            // 
            this.sinhvienSerivicesBindingSource.DataSource = typeof(QLSV.Bussiness.SinhvienSerivices);
            // 
            // khoaSeriviceBindingSource
            // 
            this.khoaSeriviceBindingSource.DataSource = typeof(QLSV.Bussiness.KhoaSerivice);
            // 
            // fileDialog
            // 
            this.fileDialog.DefaultExt = "xls,xlsl";
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // DialogController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 419);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "DialogController";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.DialogController_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienSerivicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaSeriviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private LollipopTextBox txtTenLop;
        private LollipopTextBox txtMaLop;
        private System.Windows.Forms.BindingSource khoaSeriviceBindingSource;
        private System.Windows.Forms.BindingSource sinhvienSerivicesBindingSource;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopButton btnDelete;
        private LollipopButton btnUpdate;
        private LollipopButton btnAdd;
        private LollipopButton btnExcel;
        private System.Windows.Forms.OpenFileDialog fileDialog;

    }
}