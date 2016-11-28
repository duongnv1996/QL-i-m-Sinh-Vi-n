namespace QLSV
{
    partial class bang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bang));
            this.gridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lollipopTextBox1 = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.DoubleBuffered = true;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.gridview.HeaderForeColor = System.Drawing.Color.White;
            this.gridview.Location = new System.Drawing.Point(41, 162);
            this.gridview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview.RowTemplate.Height = 24;
            this.gridview.Size = new System.Drawing.Size(750, 333);
            this.gridview.TabIndex = 0;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lollipopTextBox1);
            this.panel1.Controls.Add(this.gridview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 523);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(41, 100);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(53, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lollipopTextBox1.BackColor = System.Drawing.Color.White;
            this.lollipopTextBox1.FocusedColor = "23, 209, 188";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(41, 55);
            this.lollipopTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(750, 24);
            this.lollipopTextBox1.TabIndex = 2;
            this.lollipopTextBox1.Text = "Tìm kiếm";
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            this.lollipopTextBox1.Visible = false;
            this.lollipopTextBox1.TextChanged += new System.EventHandler(this.lollipopTextBox1_TextChanged);
            // 
            // bang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "bang";
            this.Size = new System.Drawing.Size(840, 523);
            this.Load += new System.EventHandler(this.bang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridview;
        private System.Windows.Forms.Panel panel1;
        private LollipopTextBox lollipopTextBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;



    }
}
