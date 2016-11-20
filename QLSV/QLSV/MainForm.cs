using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class MainForm : Form
    {
        const int SIZE_AVT_MINI = 40;
        const int SIZE_AVT_MEDIUM = 80;
        const int SIZE_WITDH_COLLAPSE = 54;
        const int SIZE_WITDH_EXPANDE = 300;
        public MainForm() {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e) {


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
        }
        private void collapseNav() {
            avt.Width = SIZE_AVT_MINI;
            avt.Height = SIZE_AVT_MINI;

            PanelNav.Visible = false;
            PanelNav.Width = SIZE_WITDH_COLLAPSE;
            animator.Show(PanelNav);

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
            //collapseToolbar();
            animationVisiableNav();
           
            hideLogin();
         
            panelMain.Visible = true;
        }

        private void PanelNav_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e) {
            if (PanelNav.Width == SIZE_WITDH_COLLAPSE) {
                animationVisiableNav();
            } else {
                collapseNav();

            }
        }

    }
}
