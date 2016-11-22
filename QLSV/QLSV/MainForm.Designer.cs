namespace QLSV
{
    partial class MainForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelNav = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSinhVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbLop = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNgaySinh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.avt = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.animatorLogin = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animatorNav = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lltxtmk = new LollipopTextBox();
            this.btn_dangnhap = new LollipopFlatButton();
            this.ll1 = new LollipopTextBox();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.PanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.panelToolbar.Controls.Add(this.bunifuImageButton1);
            this.animator.SetDecoration(this.panelToolbar, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.panelToolbar, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.panelToolbar, BunifuAnimatorNS.DecorationType.None);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(1340, 53);
            this.panelToolbar.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1295, 12);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.lltxtmk);
            this.panelMenu.Controls.Add(this.btn_dangnhap);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.ll1);
            this.animator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Location = new System.Drawing.Point(82, 84);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 487);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.animatorNav.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelToolbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelMenu);
            this.animator.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(351, 53);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(989, 684);
            this.panelMain.TabIndex = 0;
            // 
            // PanelNav
            // 
            this.PanelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.PanelNav.Controls.Add(this.bunifuCustomLabel3);
            this.PanelNav.Controls.Add(this.btnSinhVien);
            this.PanelNav.Controls.Add(this.btnDiem);
            this.PanelNav.Controls.Add(this.btnMon);
            this.PanelNav.Controls.Add(this.btnLop);
            this.PanelNav.Controls.Add(this.btnKhoa);
            this.PanelNav.Controls.Add(this.lbLop);
            this.PanelNav.Controls.Add(this.lbNgaySinh);
            this.PanelNav.Controls.Add(this.lbTen);
            this.PanelNav.Controls.Add(this.avt);
            this.PanelNav.Controls.Add(this.bunifuImageButton2);
            this.animator.SetDecoration(this.PanelNav, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.PanelNav, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.PanelNav, BunifuAnimatorNS.DecorationType.None);
            this.PanelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNav.Location = new System.Drawing.Point(0, 53);
            this.PanelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelNav.Name = "PanelNav";
            this.PanelNav.Size = new System.Drawing.Size(351, 684);
            this.PanelNav.TabIndex = 0;
            this.PanelNav.Visible = false;
            this.PanelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNav_Paint);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.animatorNav.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(145, 196);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 21);
            this.bunifuCustomLabel3.TabIndex = 12;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinhVien.BorderRadius = 0;
            this.btnSinhVien.ButtonText = "Sinh viên";
            this.btnSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.btnSinhVien, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btnSinhVien, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btnSinhVien, BunifuAnimatorNS.DecorationType.None);
            this.btnSinhVien.DisabledColor = System.Drawing.Color.Empty;
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSinhVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSinhVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSinhVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Iconimage")));
            this.btnSinhVien.Iconimage_right = null;
            this.btnSinhVien.Iconimage_right_Selected = null;
            this.btnSinhVien.Iconimage_Selected = null;
            this.btnSinhVien.IconMarginLeft = 0;
            this.btnSinhVien.IconMarginRight = 0;
            this.btnSinhVien.IconRightVisible = true;
            this.btnSinhVien.IconRightZoom = 0D;
            this.btnSinhVien.IconVisible = true;
            this.btnSinhVien.IconZoom = 50D;
            this.btnSinhVien.IsTab = true;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 512);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(5);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Normalcolor = System.Drawing.Color.Empty;
            this.btnSinhVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnSinhVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSinhVien.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.btnSinhVien.selected = false;
            this.btnSinhVien.Size = new System.Drawing.Size(407, 59);
            this.btnSinhVien.TabIndex = 9;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSinhVien.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnSinhVien.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDiem
            // 
            this.btnDiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiem.BorderRadius = 0;
            this.btnDiem.ButtonText = "Điểm";
            this.btnDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.btnDiem, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btnDiem, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btnDiem, BunifuAnimatorNS.DecorationType.None);
            this.btnDiem.DisabledColor = System.Drawing.Color.Empty;
            this.btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiem.Iconimage")));
            this.btnDiem.Iconimage_right = null;
            this.btnDiem.Iconimage_right_Selected = null;
            this.btnDiem.Iconimage_Selected = null;
            this.btnDiem.IconMarginLeft = 0;
            this.btnDiem.IconMarginRight = 0;
            this.btnDiem.IconRightVisible = true;
            this.btnDiem.IconRightZoom = 0D;
            this.btnDiem.IconVisible = true;
            this.btnDiem.IconZoom = 50D;
            this.btnDiem.IsTab = true;
            this.btnDiem.Location = new System.Drawing.Point(0, 446);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Normalcolor = System.Drawing.Color.Empty;
            this.btnDiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnDiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiem.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.btnDiem.selected = false;
            this.btnDiem.Size = new System.Drawing.Size(407, 59);
            this.btnDiem.TabIndex = 8;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiem.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDiem.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMon
            // 
            this.btnMon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMon.BorderRadius = 0;
            this.btnMon.ButtonText = "Môn";
            this.btnMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.btnMon, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btnMon, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btnMon, BunifuAnimatorNS.DecorationType.None);
            this.btnMon.DisabledColor = System.Drawing.Color.Empty;
            this.btnMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMon.Iconimage")));
            this.btnMon.Iconimage_right = null;
            this.btnMon.Iconimage_right_Selected = null;
            this.btnMon.Iconimage_Selected = null;
            this.btnMon.IconMarginLeft = 0;
            this.btnMon.IconMarginRight = 0;
            this.btnMon.IconRightVisible = true;
            this.btnMon.IconRightZoom = 0D;
            this.btnMon.IconVisible = true;
            this.btnMon.IconZoom = 50D;
            this.btnMon.IsTab = true;
            this.btnMon.Location = new System.Drawing.Point(0, 379);
            this.btnMon.Margin = new System.Windows.Forms.Padding(5);
            this.btnMon.Name = "btnMon";
            this.btnMon.Normalcolor = System.Drawing.Color.Empty;
            this.btnMon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnMon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMon.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.btnMon.selected = false;
            this.btnMon.Size = new System.Drawing.Size(407, 59);
            this.btnMon.TabIndex = 7;
            this.btnMon.Text = "Môn";
            this.btnMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMon.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnMon.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLop
            // 
            this.btnLop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLop.BorderRadius = 0;
            this.btnLop.ButtonText = "Lớp";
            this.btnLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.btnLop, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btnLop, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btnLop, BunifuAnimatorNS.DecorationType.None);
            this.btnLop.DisabledColor = System.Drawing.Color.Empty;
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLop.Iconimage")));
            this.btnLop.Iconimage_right = null;
            this.btnLop.Iconimage_right_Selected = null;
            this.btnLop.Iconimage_Selected = null;
            this.btnLop.IconMarginLeft = 0;
            this.btnLop.IconMarginRight = 0;
            this.btnLop.IconRightVisible = true;
            this.btnLop.IconRightZoom = 0D;
            this.btnLop.IconVisible = true;
            this.btnLop.IconZoom = 50D;
            this.btnLop.IsTab = true;
            this.btnLop.Location = new System.Drawing.Point(0, 309);
            this.btnLop.Margin = new System.Windows.Forms.Padding(5);
            this.btnLop.Name = "btnLop";
            this.btnLop.Normalcolor = System.Drawing.Color.Empty;
            this.btnLop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnLop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLop.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.btnLop.selected = false;
            this.btnLop.Size = new System.Drawing.Size(407, 59);
            this.btnLop.TabIndex = 6;
            this.btnLop.Text = "Lớp";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLop.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnLop.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.btnKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhoa.BorderRadius = 0;
            this.btnKhoa.ButtonText = "Khoa";
            this.btnKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.btnKhoa, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btnKhoa, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btnKhoa, BunifuAnimatorNS.DecorationType.None);
            this.btnKhoa.DisabledColor = System.Drawing.Color.Empty;
            this.btnKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKhoa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Iconimage")));
            this.btnKhoa.Iconimage_right = null;
            this.btnKhoa.Iconimage_right_Selected = null;
            this.btnKhoa.Iconimage_Selected = null;
            this.btnKhoa.IconMarginLeft = 0;
            this.btnKhoa.IconMarginRight = 0;
            this.btnKhoa.IconRightVisible = false;
            this.btnKhoa.IconRightZoom = 10D;
            this.btnKhoa.IconVisible = true;
            this.btnKhoa.IconZoom = 50D;
            this.btnKhoa.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.btnKhoa.IsTab = true;
            this.btnKhoa.Location = new System.Drawing.Point(0, 242);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.btnKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.btnKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKhoa.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnKhoa.selected = false;
            this.btnKhoa.Size = new System.Drawing.Size(411, 64);
            this.btnKhoa.TabIndex = 5;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKhoa.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnKhoa.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.animatorNav.SetDecoration(this.lbLop, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lbLop, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.lbLop, BunifuAnimatorNS.DecorationType.None);
            this.lbLop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.ForeColor = System.Drawing.Color.White;
            this.lbLop.Location = new System.Drawing.Point(131, 128);
            this.lbLop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(93, 21);
            this.lbLop.TabIndex = 4;
            this.lbLop.Text = "Giáo Viên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.animatorNav.SetDecoration(this.lbNgaySinh, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lbNgaySinh, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.lbNgaySinh, BunifuAnimatorNS.DecorationType.None);
            this.lbNgaySinh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.White;
            this.lbNgaySinh.Location = new System.Drawing.Point(131, 154);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(53, 21);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "CNTT";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.animatorNav.SetDecoration(this.lbTen, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lbTen, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.lbTen, BunifuAnimatorNS.DecorationType.None);
            this.lbTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(131, 98);
            this.lbTen.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(173, 21);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Nguyen Van Duong";
            // 
            // avt
            // 
            this.animatorNav.SetDecoration(this.avt, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.avt, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.avt, BunifuAnimatorNS.DecorationType.None);
            this.avt.Image = ((System.Drawing.Image)(resources.GetObject("avt.Image")));
            this.avt.Location = new System.Drawing.Point(9, 85);
            this.avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avt.Name = "avt";
            this.avt.Size = new System.Drawing.Size(107, 98);
            this.avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avt.TabIndex = 1;
            this.avt.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(297, 7);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // animatorLogin
            // 
            this.animatorLogin.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animatorLogin.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.animatorLogin.DefaultAnimation = animation2;
            // 
            // animatorNav
            // 
            this.animatorNav.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.animatorNav.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animatorNav.DefaultAnimation = animation3;
            // 
            // lltxtmk
            // 
            this.lltxtmk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.animator.SetDecoration(this.lltxtmk, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.lltxtmk, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lltxtmk, BunifuAnimatorNS.DecorationType.None);
            this.lltxtmk.FocusedColor = "23, 209, 188";
            this.lltxtmk.FontColor = "61, 85, 109";
            this.lltxtmk.IsEnabled = true;
            this.lltxtmk.Location = new System.Drawing.Point(272, 308);
            this.lltxtmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lltxtmk.MaxLength = 32767;
            this.lltxtmk.Multiline = false;
            this.lltxtmk.Name = "lltxtmk";
            this.lltxtmk.ReadOnly = false;
            this.lltxtmk.Size = new System.Drawing.Size(272, 24);
            this.lltxtmk.TabIndex = 15;
            this.lltxtmk.Text = "Mật khẩu";
            this.lltxtmk.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lltxtmk.UseSystemPasswordChar = false;
            this.lltxtmk.Enter += new System.EventHandler(this.lltxtmk_Enter);
            this.lltxtmk.Leave += new System.EventHandler(this.lltxtmk_Leave_1);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_dangnhap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.animatorNav.SetDecoration(this.btn_dangnhap, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.btn_dangnhap, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.btn_dangnhap, BunifuAnimatorNS.DecorationType.None);
            this.btn_dangnhap.FontColor = "23, 209, 188";
            this.btn_dangnhap.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.btn_dangnhap.Location = new System.Drawing.Point(356, 391);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(188, 60);
            this.btn_dangnhap.TabIndex = 13;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // ll1
            // 
            this.ll1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.animator.SetDecoration(this.ll1, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.ll1, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.ll1, BunifuAnimatorNS.DecorationType.None);
            this.ll1.FocusedColor = "23, 209, 188";
            this.ll1.FontColor = "61, 85, 109";
            this.ll1.IsEnabled = true;
            this.ll1.Location = new System.Drawing.Point(272, 244);
            this.ll1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ll1.MaxLength = 32767;
            this.ll1.Multiline = false;
            this.ll1.Name = "ll1";
            this.ll1.ReadOnly = false;
            this.ll1.Size = new System.Drawing.Size(272, 24);
            this.ll1.TabIndex = 14;
            this.ll1.Text = "Tên đăng nhập";
            this.ll1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ll1.UseSystemPasswordChar = false;
            this.ll1.Enter += new System.EventHandler(this.ll1_Enter);
            this.ll1.Leave += new System.EventHandler(this.ll1_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 737);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.PanelNav);
            this.Controls.Add(this.panelToolbar);
            this.animatorLogin.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.PanelNav.ResumeLayout(false);
            this.PanelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panelMenu;
        private LollipopTextBox lltxtmk;
        private LollipopFlatButton btn_dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopTextBox ll1;
        private BunifuAnimatorNS.BunifuTransition animator;
        private BunifuAnimatorNS.BunifuTransition animatorLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel PanelNav;
        private BunifuAnimatorNS.BunifuTransition animatorNav;
        private System.Windows.Forms.PictureBox avt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbLop;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNgaySinh;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTen;
        private Bunifu.Framework.UI.BunifuFlatButton btnKhoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSinhVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnMon;
        private Bunifu.Framework.UI.BunifuFlatButton btnLop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}