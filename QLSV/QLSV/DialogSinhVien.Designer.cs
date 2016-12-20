namespace QLSV
{
    partial class DialogSinhVien
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
            this.comboMaLop = new MetroFramework.Controls.MetroComboBox();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.txtDiaChi = new LollipopTextBox();
            this.lollipopLabel6 = new LollipopLabel();
            this.btnDelete = new LollipopButton();
            this.radNam = new LollipopRadioButton();
            this.radNu = new LollipopRadioButton();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel4 = new LollipopLabel();
            this.txtTenSinhVien = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.txtMaSv = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.btnAdd = new LollipopButton();
            this.btnUpdate = new LollipopButton();
            this.SuspendLayout();
            // 
            // comboMaLop
            // 
            this.comboMaLop.FormattingEnabled = true;
            this.comboMaLop.ItemHeight = 24;
            this.comboMaLop.Location = new System.Drawing.Point(152, 330);
            this.comboMaLop.Name = "comboMaLop";
            this.comboMaLop.Size = new System.Drawing.Size(353, 30);
            this.comboMaLop.TabIndex = 13;
            this.comboMaLop.UseSelectable = true;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(152, 283);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(353, 30);
            this.dateTime.TabIndex = 19;
            this.dateTime.Value = new System.DateTime(2016, 12, 21, 23, 59, 59, 0);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.FocusedColor = "#508ef5";
            this.txtDiaChi.FontColor = "#000";
            this.txtDiaChi.IsEnabled = true;
            this.txtDiaChi.Location = new System.Drawing.Point(152, 198);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = false;
            this.txtDiaChi.Size = new System.Drawing.Size(353, 24);
            this.txtDiaChi.TabIndex = 18;
            this.txtDiaChi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(23, 198);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(64, 20);
            this.lollipopLabel6.TabIndex = 17;
            this.lollipopLabel6.Text = "Địa Chỉ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BGColor = "#F44336";
            this.btnDelete.FontColor = "#ffffff";
            this.btnDelete.Location = new System.Drawing.Point(11, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 53);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.CheckColor = "#508ef5";
            this.radNam.ForeColor = System.Drawing.Color.Coral;
            this.radNam.Location = new System.Drawing.Point(152, 240);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(61, 19);
            this.radNam.TabIndex = 11;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.CheckColor = "#508ef5";
            this.radNu.ForeColor = System.Drawing.Color.Coral;
            this.radNu.Location = new System.Drawing.Point(242, 240);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(46, 19);
            this.radNu.TabIndex = 12;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(23, 330);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(65, 20);
            this.lollipopLabel3.TabIndex = 10;
            this.lollipopLabel3.Text = "Mã Lớp";
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(23, 283);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(85, 20);
            this.lollipopLabel5.TabIndex = 8;
            this.lollipopLabel5.Text = "Ngày Sinh";
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(23, 238);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(76, 20);
            this.lollipopLabel4.TabIndex = 6;
            this.lollipopLabel4.Text = "Giới Tính";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.FocusedColor = "#508ef5";
            this.txtTenSinhVien.FontColor = "#000";
            this.txtTenSinhVien.IsEnabled = true;
            this.txtTenSinhVien.Location = new System.Drawing.Point(152, 158);
            this.txtTenSinhVien.MaxLength = 32767;
            this.txtTenSinhVien.Multiline = false;
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.ReadOnly = false;
            this.txtTenSinhVien.Size = new System.Drawing.Size(353, 24);
            this.txtTenSinhVien.TabIndex = 3;
            this.txtTenSinhVien.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenSinhVien.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(23, 158);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(113, 20);
            this.lollipopLabel2.TabIndex = 2;
            this.lollipopLabel2.Text = "Tên Sinh Viên";
            // 
            // txtMaSv
            // 
            this.txtMaSv.FocusedColor = "#508ef5";
            this.txtMaSv.FontColor = "#000";
            this.txtMaSv.IsEnabled = true;
            this.txtMaSv.Location = new System.Drawing.Point(152, 115);
            this.txtMaSv.MaxLength = 32767;
            this.txtMaSv.Multiline = false;
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.ReadOnly = false;
            this.txtMaSv.Size = new System.Drawing.Size(353, 24);
            this.txtMaSv.TabIndex = 1;
            this.txtMaSv.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaSv.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(23, 115);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(108, 20);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Mã Sinh Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BGColor = "#90DFAA";
            this.btnAdd.FontColor = "#ffffff";
            this.btnAdd.Location = new System.Drawing.Point(250, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 53);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BGColor = "#508ef5";
            this.btnUpdate.FontColor = "#ffffff";
            this.btnUpdate.Location = new System.Drawing.Point(250, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 53);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DialogSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 473);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboMaLop);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txtMaSv);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "DialogSinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.DialogSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txtMaSv;
        private LollipopTextBox txtTenSinhVien;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel3;
        private LollipopRadioButton radNam;
        private LollipopRadioButton radNu;
        private MetroFramework.Controls.MetroComboBox comboMaLop;
        private LollipopButton btnDelete;
        private LollipopButton btnUpdate;
        private LollipopButton btnAdd;
        private LollipopTextBox txtDiaChi;
        private LollipopLabel lollipopLabel6;
        private MetroFramework.Controls.MetroDateTime dateTime;
    }
}