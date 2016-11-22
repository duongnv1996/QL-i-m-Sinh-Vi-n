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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lltxtmk = new LollipopTextBox();
            this.btn_dangnhap = new LollipopFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ll1 = new LollipopTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelNav = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbChucVu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbKhoa = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.avt = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.animatorLogin = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animatorNav = new BunifuAnimatorNS.BunifuTransition(this.components);
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
            this.panelMenu.Location = new System.Drawing.Point(64, 84);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 487);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            this.btn_dangnhap.Location = new System.Drawing.Point(311, 399);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(188, 60);
            this.btn_dangnhap.TabIndex = 13;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
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
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation6;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelMenu);
            this.animator.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.animatorNav.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(387, 53);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(953, 684);
            this.panelMain.TabIndex = 0;
            // 
            // PanelNav
            // 
            this.PanelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.PanelNav.Controls.Add(this.bunifuFlatButton5);
            this.PanelNav.Controls.Add(this.bunifuFlatButton4);
            this.PanelNav.Controls.Add(this.bunifuFlatButton3);
            this.PanelNav.Controls.Add(this.bunifuFlatButton2);
            this.PanelNav.Controls.Add(this.bunifuFlatButton1);
            this.PanelNav.Controls.Add(this.lbChucVu);
            this.PanelNav.Controls.Add(this.lbKhoa);
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
            this.PanelNav.Size = new System.Drawing.Size(387, 684);
            this.PanelNav.TabIndex = 0;
            this.PanelNav.Visible = false;
            this.PanelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNav_Paint);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Sinh viên";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Empty;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 50D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 512);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(407, 59);
            this.bunifuFlatButton5.TabIndex = 9;
            this.bunifuFlatButton5.Text = "Sinh viên";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Điểm";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Empty;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 446);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(407, 59);
            this.bunifuFlatButton4.TabIndex = 8;
            this.bunifuFlatButton4.Text = "Điểm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Môn";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Empty;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 379);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(407, 59);
            this.bunifuFlatButton3.TabIndex = 7;
            this.bunifuFlatButton3.Text = "Môn";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Lớp";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Empty;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 309);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Padding = new System.Windows.Forms.Padding(133, 0, 0, 0);
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(407, 59);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "Lớp";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Khoa";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorNav.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Empty;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 10D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 242);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(411, 64);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Khoa";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.animatorNav.SetDecoration(this.lbChucVu, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lbChucVu, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.lbChucVu, BunifuAnimatorNS.DecorationType.None);
            this.lbChucVu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Location = new System.Drawing.Point(131, 128);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(93, 21);
            this.lbChucVu.TabIndex = 4;
            this.lbChucVu.Text = "Giáo Viên";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.animatorNav.SetDecoration(this.lbKhoa, BunifuAnimatorNS.DecorationType.None);
            this.animatorLogin.SetDecoration(this.lbKhoa, BunifuAnimatorNS.DecorationType.None);
            this.animator.SetDecoration(this.lbKhoa, BunifuAnimatorNS.DecorationType.None);
            this.lbKhoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.ForeColor = System.Drawing.Color.White;
            this.lbKhoa.Location = new System.Drawing.Point(131, 158);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(53, 21);
            this.lbKhoa.TabIndex = 3;
            this.lbKhoa.Text = "CNTT";
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(333, 7);
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 1;
            animation5.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 2F;
            animation5.TransparencyCoeff = 0F;
            this.animatorLogin.DefaultAnimation = animation5;
            // 
            // animatorNav
            // 
            this.animatorNav.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.animatorNav.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animatorNav.DefaultAnimation = animation4;
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
        private Bunifu.Framework.UI.BunifuCustomLabel lbChucVu;
        private Bunifu.Framework.UI.BunifuCustomLabel lbKhoa;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTen;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}