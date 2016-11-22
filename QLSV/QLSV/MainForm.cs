﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Bussiness;
using QLSV.Data;

namespace QLSV
{
    public partial class MainForm : Form
    {
        const int SIZE_AVT_MINI = 40;
        const int SIZE_AVT_MEDIUM = 80;
        const int SIZE_WITDH_COLLAPSE = 54;
        const int SIZE_WITDH_EXPANDE = 300;
        KhoaSerivice khoaSV ;
        bang bangKhoa;
        public MainForm() {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e) {
          
            bangKhoa = new bang();
        }




        private void bunifuImageButton1_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void hideLogin() {

           
            
            animatorLogin.Show(panelMenu);
            panelMenu.Visible = false;
        }

        private void animationVisiableNav() {
            avt.Width = SIZE_AVT_MEDIUM;
            avt.Height = SIZE_AVT_MEDIUM;
            PanelNav.Width = SIZE_WITDH_EXPANDE;
            PanelNav.Visible = false;
            animatorNav.Show(PanelNav);
            bangKhoa.Width = panelMain.Width;
            bangKhoa.Height = panelMain.Height;                 
        }
        private void collapseNav() {
            avt.Width = SIZE_AVT_MINI;
            avt.Height = SIZE_AVT_MINI;

            PanelNav.Visible = false;
            PanelNav.Width = SIZE_WITDH_COLLAPSE;
            animator.Show(PanelNav);
            bangKhoa.Width = panelMain.Width;
            bangKhoa.Height = panelMain.Height;
        }

        private void ll1_Enter(object sender, EventArgs e) {
            ll1.Text = "";


        }

        private void lltxtmk_Enter(object sender, EventArgs e) {
            lltxtmk.Text = "";
            lltxtmk.UseSystemPasswordChar = true;
        }

        private void lltxtmk_Leave_1(object sender, EventArgs e) {
            if (lltxtmk.Text.Equals("")) {
                lltxtmk.Text = "Mật khẩu";
                lltxtmk.UseSystemPasswordChar = false;

            }
        }

        private void ll1_Leave(object sender, EventArgs e) {
            if (ll1.Text.Equals("")) {
                ll1.Text = "Tên đăng nhập";
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e) {
            khoaSV = new KhoaSerivice(); ;
            MyService service = new MyService();
            User user = service.dangNhap(ll1.Text, lltxtmk.Text);
            if (user != null) {
                lbLop.Text =user.Lop+" - "+ user.TenKhoa;
                lbNgaySinh.Text = user.NgaySinh;
                lbTen.Text = user.HoTen;
            }

            //collapseToolbar();
            animationVisiableNav();
           
            hideLogin();
         
            panelMain.Visible = true;
        }

        private void PanelNav_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
           khoaSV = new KhoaSerivice();

           bangKhoa.hienList(khoaSV.getDsKhoa());
            bangKhoa.Width = panelMain.Width;
            bangKhoa.Height = panelMain.Height;
            bangKhoa.Anchor =  AnchorStyles.Left ;
        
            this.panelMain.Controls.Add(bangKhoa);

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e) {
            //if (PanelNav.Width == SIZE_WITDH_COLLAPSE) {
            //    animationVisiableNav();
            //} else {
            //    collapseNav();

            //}
        }

        private void btnLop_Click(object sender, EventArgs e) {
          
        }

    }
}
