namespace QLSV
{
    partial class DialogBangDiem
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
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.txtDiemTp = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.txtDiemLan1 = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.txtDiemLan2 = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.txtSoTietNghi = new LollipopTextBox();
            this.lollipopLabel6 = new LollipopLabel();
            this.btnDelete = new LollipopButton();
            this.btnAdd = new LollipopButton();
            this.btnUpdate = new LollipopButton();
            this.cboMaSv = new MetroFramework.Controls.MetroComboBox();
            this.cboMaMonHoc = new MetroFramework.Controls.MetroComboBox();
            this.btnExcel = new LollipopButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(10, 100);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(103, 20);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Mã sinh viên";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(10, 144);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(101, 20);
            this.lollipopLabel2.TabIndex = 2;
            this.lollipopLabel2.Text = "Mã môn học";
            // 
            // txtDiemTp
            // 
            this.txtDiemTp.FocusedColor = "#508ef5";
            this.txtDiemTp.FontColor = "#999999";
            this.txtDiemTp.IsEnabled = true;
            this.txtDiemTp.Location = new System.Drawing.Point(169, 183);
            this.txtDiemTp.MaxLength = 32767;
            this.txtDiemTp.Multiline = false;
            this.txtDiemTp.Name = "txtDiemTp";
            this.txtDiemTp.ReadOnly = false;
            this.txtDiemTp.Size = new System.Drawing.Size(330, 24);
            this.txtDiemTp.TabIndex = 5;
            this.txtDiemTp.Text = "0";
            this.txtDiemTp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiemTp.UseSystemPasswordChar = false;
            this.txtDiemTp.Leave += new System.EventHandler(this.txtDiemTp_Leave);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(10, 184);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(135, 20);
            this.lollipopLabel3.TabIndex = 4;
            this.lollipopLabel3.Text = "Điểm thành phần";
            // 
            // txtDiemLan1
            // 
            this.txtDiemLan1.FocusedColor = "#508ef5";
            this.txtDiemLan1.FontColor = "#999999";
            this.txtDiemLan1.IsEnabled = true;
            this.txtDiemLan1.Location = new System.Drawing.Point(169, 227);
            this.txtDiemLan1.MaxLength = 32767;
            this.txtDiemLan1.Multiline = false;
            this.txtDiemLan1.Name = "txtDiemLan1";
            this.txtDiemLan1.ReadOnly = false;
            this.txtDiemLan1.Size = new System.Drawing.Size(330, 24);
            this.txtDiemLan1.TabIndex = 7;
            this.txtDiemLan1.Text = "0";
            this.txtDiemLan1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiemLan1.UseSystemPasswordChar = false;
            this.txtDiemLan1.Leave += new System.EventHandler(this.txtDiemLan1_Leave);
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(10, 228);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(112, 20);
            this.lollipopLabel4.TabIndex = 6;
            this.lollipopLabel4.Text = "Điểm thi lần 1";
            // 
            // txtDiemLan2
            // 
            this.txtDiemLan2.FocusedColor = "#508ef5";
            this.txtDiemLan2.FontColor = "#999999";
            this.txtDiemLan2.IsEnabled = true;
            this.txtDiemLan2.Location = new System.Drawing.Point(169, 267);
            this.txtDiemLan2.MaxLength = 32767;
            this.txtDiemLan2.Multiline = false;
            this.txtDiemLan2.Name = "txtDiemLan2";
            this.txtDiemLan2.ReadOnly = false;
            this.txtDiemLan2.Size = new System.Drawing.Size(330, 24);
            this.txtDiemLan2.TabIndex = 9;
            this.txtDiemLan2.Text = "0";
            this.txtDiemLan2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiemLan2.UseSystemPasswordChar = false;
            this.txtDiemLan2.Leave += new System.EventHandler(this.txtDiemLan2_Leave);
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(10, 268);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(112, 20);
            this.lollipopLabel5.TabIndex = 8;
            this.lollipopLabel5.Text = "Điểm thi lần 2";
            // 
            // txtSoTietNghi
            // 
            this.txtSoTietNghi.FocusedColor = "#508ef5";
            this.txtSoTietNghi.FontColor = "#999999";
            this.txtSoTietNghi.IsEnabled = true;
            this.txtSoTietNghi.Location = new System.Drawing.Point(169, 307);
            this.txtSoTietNghi.MaxLength = 32767;
            this.txtSoTietNghi.Multiline = false;
            this.txtSoTietNghi.Name = "txtSoTietNghi";
            this.txtSoTietNghi.ReadOnly = false;
            this.txtSoTietNghi.Size = new System.Drawing.Size(330, 24);
            this.txtSoTietNghi.TabIndex = 11;
            this.txtSoTietNghi.Text = "0";
            this.txtSoTietNghi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTietNghi.UseSystemPasswordChar = false;
            this.txtSoTietNghi.Leave += new System.EventHandler(this.txtSoTietNghi_Leave);
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(10, 308);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(93, 20);
            this.lollipopLabel6.TabIndex = 10;
            this.lollipopLabel6.Text = "Số tiết nghỉ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BGColor = "#F44336";
            this.btnDelete.FontColor = "#ffffff";
            this.btnDelete.Location = new System.Drawing.Point(14, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 53);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BGColor = "#90DFAA";
            this.btnAdd.FontColor = "#ffffff";
            this.btnAdd.Location = new System.Drawing.Point(253, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 53);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BGColor = "#508ef5";
            this.btnUpdate.FontColor = "#ffffff";
            this.btnUpdate.Location = new System.Drawing.Point(253, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 53);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboMaSv
            // 
            this.cboMaSv.FormattingEnabled = true;
            this.cboMaSv.ItemHeight = 24;
            this.cboMaSv.Location = new System.Drawing.Point(169, 93);
            this.cboMaSv.Name = "cboMaSv";
            this.cboMaSv.Size = new System.Drawing.Size(330, 30);
            this.cboMaSv.TabIndex = 23;
            this.cboMaSv.UseSelectable = true;
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.ItemHeight = 24;
            this.cboMaMonHoc.Location = new System.Drawing.Point(169, 134);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(330, 30);
            this.cboMaMonHoc.TabIndex = 24;
            this.cboMaMonHoc.UseSelectable = true;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BGColor = "#508ef5";
            this.btnExcel.FontColor = "#ffffff";
            this.btnExcel.Location = new System.Drawing.Point(14, 379);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(247, 53);
            this.btnExcel.TabIndex = 25;
            this.btnExcel.Text = "Nhập từ Excel";
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.DefaultExt = "xls,xlsl";
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // DialogBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 457);
            this.Controls.Add(this.cboMaMonHoc);
            this.Controls.Add(this.cboMaSv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSoTietNghi);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.txtDiemLan2);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.txtDiemLan1);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txtDiemTp);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExcel);
            this.Name = "DialogBangDiem";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.DialogBangDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txtDiemTp;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox txtDiemLan1;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txtDiemLan2;
        private LollipopLabel lollipopLabel5;
        private LollipopTextBox txtSoTietNghi;
        private LollipopLabel lollipopLabel6;
        private LollipopButton btnDelete;
        private LollipopButton btnAdd;
        private LollipopButton btnUpdate;
        private MetroFramework.Controls.MetroComboBox cboMaSv;
        private MetroFramework.Controls.MetroComboBox cboMaMonHoc;
        private LollipopButton btnExcel;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}