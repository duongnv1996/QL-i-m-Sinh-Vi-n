using System;
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
    public partial class MainForm : Form,Response<bool>
    {
           void Response<bool>.onResponse(bool response){
               if (response) {
                   updateListLop();
               }

        }
        const int SIZE_AVT_MINI = 40;
        const int SIZE_AVT_MEDIUM = 80;
        const int SIZE_WITDH_COLLAPSE = 54;
        const int SIZE_WITDH_EXPANDE = 300;

        KhoaSerivice khoaSV;
        LopSerivice lopSV;
        MonSerivices monSV;
        SinhvienSerivices sinhvienSV;
        BangdiemSerivices bangdiemSV;

        bang bangKhoa;

        List<khoa> listKhoa = new List<khoa>();
        List<lop> listLop = new List<lop>();
        List<monhoc> listMon = new List<monhoc>();
        List<sinhvien> listSinhvien = new List<sinhvien>();
        List<bangdiem> listBangdiem = new List<bangdiem>();

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bangKhoa = new bang();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideLogin()
        {
            animatorLogin.Show(panelMenu);
            panelMenu.Visible = false;
        }

        private void animationVisiableNav()
        {
            avt.Width = SIZE_AVT_MEDIUM;
            avt.Height = SIZE_AVT_MEDIUM;
            PanelNav.Width = SIZE_WITDH_EXPANDE;
            PanelNav.Visible = false;
            animatorNav.Show(PanelNav);
            bangKhoa.Width = panelMain.Width;
            bangKhoa.Height = panelMain.Height;
        }

        private void collapseNav()
        {
            avt.Width = SIZE_AVT_MINI;
            avt.Height = SIZE_AVT_MINI;
            PanelNav.Visible = false;
            PanelNav.Width = SIZE_WITDH_COLLAPSE;
            animator.Show(PanelNav);
            bangKhoa.Width = panelMain.Width;
            bangKhoa.Height = panelMain.Height;
        }

        private void ll1_Enter(object sender, EventArgs e)
        {
            ll1.Text = "";
        }

        private void lltxtmk_Enter(object sender, EventArgs e)
        {
            lltxtmk.Text = "";
            lltxtmk.UseSystemPasswordChar = true;
        }

        private void lltxtmk_Leave_1(object sender, EventArgs e)
        {
            if (lltxtmk.Text.Equals(""))
            {
                lltxtmk.Text = "Mật khẩu";
                lltxtmk.UseSystemPasswordChar = false;
            }
        }

        private void ll1_Leave(object sender, EventArgs e)
        {
            if (ll1.Text.Equals(""))
            {
                ll1.Text = "Tên đăng nhập";
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            khoaSV = new KhoaSerivice(); ;
            MyService service = new MyService();
            User user = service.dangNhap(ll1.Text, lltxtmk.Text);
            if (user != null)
            {
                lbLop.Text = user.Lop + " - " + user.TenKhoa;
                lbNgaySinh.Text = user.NgaySinh;
                lbTen.Text = user.HoTen;
            }
            else
            {
                MessageBox.Show("Sai mat khau hoac tai khoan");
                return;
            }
            //collapseToolbar();
            animationVisiableNav();
            hideLogin();
            panelMain.Visible = true;
           // this.panelMain.Controls.Add(bangKhoa);
            panelBang.Visible = true;
        
        }

        private void PanelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            updateListKhoa();
        }

        private void updateListKhoa() {
            if (khoaSV == null) khoaSV = new KhoaSerivice();

            listKhoa.Clear();
            listKhoa.AddRange(khoaSV.getDsKhoa());
            bindDataSource<khoa>(listKhoa);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (PanelNav.Width == SIZE_WITDH_COLLAPSE) {
                animationVisiableNav();
            } else {
                collapseNav();

            }
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            updateListLop();
           
        }

     

        private void btnMon_Click(object sender, EventArgs e)
        {
            UpdateListMon();
        }

        private void updateListLop() {
            if (lopSV == null) lopSV = new LopSerivice();
            listLop.Clear();
            listLop.AddRange(lopSV.getDsLop());
            //bangKhoa.hienList(listLop);
            //bangKhoa.Width = panelMain.Width;
            //bangKhoa.Height = panelMain.Height;
            //bangKhoa.Anchor = AnchorStyles.Left;

            bindDataSource<lop>(listLop);

        }
        private void searchListLop(String search) {
            if (lopSV == null) lopSV = new LopSerivice();
            listLop.Clear();
            listLop.AddRange(lopSV.getDsLop(search));
            //bangKhoa.hienList(listLop);
            //bangKhoa.Width = panelMain.Width;
            //bangKhoa.Height = panelMain.Height;
            //bangKhoa.Anchor = AnchorStyles.Left;

            bindDataSource<lop>(listLop);

        }
        private void UpdateListMon() {
            if (monSV == null) monSV = new MonSerivices();
            listMon.Clear();
            listMon.AddRange(monSV.getDsMon());
            bindDataSource<monhoc>(listMon);
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            UpdateListSinhVien();
        }

        private void UpdateListSinhVien() {
            if (sinhvienSV == null) sinhvienSV = new SinhvienSerivices();
            listSinhvien.Clear();
            listSinhvien.AddRange(sinhvienSV.getDsSinhvien());
            bindDataSource<sinhvien>(listSinhvien);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            UpdateListDiem();
        }

        private void UpdateListDiem() {
            if (bangdiemSV == null) bangdiemSV = new BangdiemSerivices();
            listBangdiem.Clear();
            listBangdiem.AddRange(bangdiemSV.getDsBangdiem());
            bindDataSource<bangdiem>(listBangdiem);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) {

        }
        public void bindDataSource<T>(List<T> l) {
            BindingList<T> bindList = new BindingList<T>(l);
            gridview.DataSource = new BindingSource(bindList, null);
            gridview.ReadOnly = true;

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) {
            new DialogLop(this, DialogLop.CODE_ADD,null).Show();
        }

        private void gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            //String maLop = gridview[e.ColumnIndex, e.RowIndex].Value.ToString();
            //lop ls = new lop();
            //ls.malop = maLop;
            lop currentObject = (lop)gridview.CurrentRow.DataBoundItem;
            new DialogLop(this, DialogLop.CODE_UPDATE, currentObject).Show();
        }

        private void lollipopTextBox1_TextChanged(object sender, EventArgs e) {
            searchListLop(txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            txtSearch.Text = "";
        }

     


     

    }
}
