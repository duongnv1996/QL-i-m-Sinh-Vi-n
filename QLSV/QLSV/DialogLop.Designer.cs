namespace QLSV
{
    partial class DialogLop
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
            Bunifu.Framework.UI.BunifuDragControl drag;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogLop));
            this.panelTool = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new LollipopFlatButton();
            this.btnUpdate = new LollipopFlatButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new LollipopTextBox();
            this.txtMaLop = new LollipopTextBox();
            this.sinhvienSerivicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaSeriviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienSerivicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaSeriviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // drag
            // 
            drag.Fixed = true;
            drag.Horizontal = true;
            drag.TargetControl = this.panelTool;
            drag.Vertical = true;
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.panelTool.Controls.Add(this.bunifuImageButton1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(408, 58);
            this.panelTool.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(353, 11);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lollipopLabel3);
            this.panel2.Controls.Add(this.lollipopLabel2);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lollipopLabel1);
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.txtTenLop);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 361);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(34, 121);
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
            this.lollipopLabel2.Location = new System.Drawing.Point(34, 56);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(59, 20);
            this.lollipopLabel2.TabIndex = 6;
            this.lollipopLabel2.Text = "Mã lớp";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Sienna;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "+";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(74, 260);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 56);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = false;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FontColor = "238, 70, 83";
            this.btnDelete.Location = new System.Drawing.Point(104, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FontColor = "#508ef5";
            this.btnUpdate.Location = new System.Drawing.Point(253, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(34, 195);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(72, 20);
            this.lollipopLabel1.TabIndex = 2;
            this.lollipopLabel1.Text = "Mã khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(131, 195);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(239, 24);
            this.cbbKhoa.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.FocusedColor = "#508ef5";
            this.txtTenLop.FontColor = "#999999";
            this.txtTenLop.IsEnabled = true;
            this.txtTenLop.Location = new System.Drawing.Point(131, 121);
            this.txtTenLop.MaxLength = 32767;
            this.txtTenLop.Multiline = false;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.ReadOnly = false;
            this.txtTenLop.Size = new System.Drawing.Size(239, 24);
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
            this.txtMaLop.Location = new System.Drawing.Point(131, 52);
            this.txtMaLop.MaxLength = 32767;
            this.txtMaLop.Multiline = false;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = false;
            this.txtMaLop.Size = new System.Drawing.Size(239, 24);
            this.txtMaLop.TabIndex = 0;
            this.txtMaLop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaLop.UseSystemPasswordChar = false;
            // 
            // sinhvienSerivicesBindingSource
            // 
            this.sinhvienSerivicesBindingSource.DataSource = typeof(QLSV.Bussiness.SinhvienSerivices);
            // 
            // khoaSeriviceBindingSource
            // 
            this.khoaSeriviceBindingSource.DataSource = typeof(QLSV.Bussiness.KhoaSerivice);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DialogLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogLop";
            this.Text = "DialogLop";
            this.Load += new System.EventHandler(this.DialogLop_Load);
            this.panelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienSerivicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaSeriviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTool;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private LollipopTextBox txtTenLop;
        private LollipopTextBox txtMaLop;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private LollipopFlatButton btnDelete;
        private LollipopFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.BindingSource khoaSeriviceBindingSource;
        private System.Windows.Forms.BindingSource sinhvienSerivicesBindingSource;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;

    }
}