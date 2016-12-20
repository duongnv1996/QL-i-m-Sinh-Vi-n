namespace QLSV
{
    partial class DialogMonHoc
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
            this.btnDelete = new LollipopButton();
            this.btnAdd = new LollipopButton();
            this.btnUpdate = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.txtMa = new LollipopTextBox();
            this.txtSoTinChi = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.txtTen = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.txtSoTiet = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.txtHocKy = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BGColor = "#F44336";
            this.btnDelete.FontColor = "#ffffff";
            this.btnDelete.Location = new System.Drawing.Point(17, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 53);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BGColor = "#90DFAA";
            this.btnAdd.FontColor = "#ffffff";
            this.btnAdd.Location = new System.Drawing.Point(256, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 53);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BGColor = "#508ef5";
            this.btnUpdate.FontColor = "#ffffff";
            this.btnUpdate.Location = new System.Drawing.Point(256, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 53);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(33, 102);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(101, 20);
            this.lollipopLabel1.TabIndex = 20;
            this.lollipopLabel1.Text = "Mã môn học";
            // 
            // txtMa
            // 
            this.txtMa.FocusedColor = "#508ef5";
            this.txtMa.FontColor = "#000";
            this.txtMa.IsEnabled = true;
            this.txtMa.Location = new System.Drawing.Point(170, 101);
            this.txtMa.MaxLength = 32767;
            this.txtMa.Multiline = false;
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = false;
            this.txtMa.Size = new System.Drawing.Size(341, 24);
            this.txtMa.TabIndex = 21;
            this.txtMa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMa.UseSystemPasswordChar = false;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.FocusedColor = "#508ef5";
            this.txtSoTinChi.FontColor = "#000";
            this.txtSoTinChi.IsEnabled = true;
            this.txtSoTinChi.Location = new System.Drawing.Point(170, 168);
            this.txtSoTinChi.MaxLength = 32767;
            this.txtSoTinChi.Multiline = false;
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = false;
            this.txtSoTinChi.Size = new System.Drawing.Size(341, 24);
            this.txtSoTinChi.TabIndex = 23;
            this.txtSoTinChi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTinChi.UseSystemPasswordChar = false;
            this.txtSoTinChi.TextChanged += new System.EventHandler(this.txtSoTinChi_TextChanged);
            this.txtSoTinChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTinChi_KeyDown);
            this.txtSoTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lollipopTextBox2_KeyPress);
            this.txtSoTinChi.Leave += new System.EventHandler(this.txtSoTinChi_Leave);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(33, 138);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(106, 20);
            this.lollipopLabel2.TabIndex = 22;
            this.lollipopLabel2.Text = "Tên môn học";
            // 
            // txtTen
            // 
            this.txtTen.FocusedColor = "#508ef5";
            this.txtTen.FontColor = "#000";
            this.txtTen.IsEnabled = true;
            this.txtTen.Location = new System.Drawing.Point(170, 138);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = false;
            this.txtTen.Size = new System.Drawing.Size(341, 24);
            this.txtTen.TabIndex = 25;
            this.txtTen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(33, 172);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(79, 20);
            this.lollipopLabel3.TabIndex = 24;
            this.lollipopLabel3.Text = "Số tín chỉ";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.FocusedColor = "#508ef5";
            this.txtSoTiet.FontColor = "#000";
            this.txtSoTiet.IsEnabled = true;
            this.txtSoTiet.Location = new System.Drawing.Point(170, 202);
            this.txtSoTiet.MaxLength = 32767;
            this.txtSoTiet.Multiline = false;
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.ReadOnly = false;
            this.txtSoTiet.Size = new System.Drawing.Size(341, 24);
            this.txtSoTiet.TabIndex = 27;
            this.txtSoTiet.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoTiet.UseSystemPasswordChar = false;
            this.txtSoTiet.TextChanged += new System.EventHandler(this.txtSoTiet_TextChanged);
            this.txtSoTiet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTiet_KeyPress);
            this.txtSoTiet.Leave += new System.EventHandler(this.txtSoTiet_Leave);
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(33, 206);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(97, 20);
            this.lollipopLabel4.TabIndex = 26;
            this.lollipopLabel4.Text = "Tổng số tiết";
            // 
            // txtHocKy
            // 
            this.txtHocKy.FocusedColor = "#508ef5";
            this.txtHocKy.FontColor = "#000";
            this.txtHocKy.IsEnabled = true;
            this.txtHocKy.Location = new System.Drawing.Point(170, 242);
            this.txtHocKy.MaxLength = 32767;
            this.txtHocKy.Multiline = false;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = false;
            this.txtHocKy.Size = new System.Drawing.Size(341, 24);
            this.txtHocKy.TabIndex = 29;
            this.txtHocKy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHocKy.UseSystemPasswordChar = false;
            this.txtHocKy.Leave += new System.EventHandler(this.txtHocKy_Leave);
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(33, 242);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(61, 20);
            this.lollipopLabel5.TabIndex = 28;
            this.lollipopLabel5.Text = "Học kỳ";
            // 
            // DialogMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 425);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Name = "DialogMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.DialogMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopButton btnDelete;
        private LollipopButton btnAdd;
        private LollipopButton btnUpdate;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txtMa;
        private LollipopTextBox txtSoTinChi;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox txtTen;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox txtSoTiet;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txtHocKy;
        private LollipopLabel lollipopLabel5;
    }
}