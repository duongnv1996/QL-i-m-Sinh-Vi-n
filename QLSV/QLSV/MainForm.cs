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
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace QLSV
{
    public partial class MainForm : MetroForm, Response<bool>
    {
        void Response<bool>.onResponse(bool response) {
            if (response) {
                updateListLop();
            }

        }
        const int SIZE_AVT_MINI = 40;
        const int SIZE_AVT_MEDIUM = 80;
        const int SIZE_WITDH_COLLAPSE = 54;
        const int SIZE_WITDH_EXPANDE = 300;
        const int CODE_MON = 0;
        const int CODE_LOP = 1;
        const int CODE_DIEM = 2;
        const int CODE_SV = 3;
        int currentTab = -1;
        KhoaSerivice khoaSV;
        LopSerivice lopSV;
        MonSerivices monSV;
        SinhvienSerivices sinhvienSV;
        BangdiemSerivices bangdiemSV;


        List<khoa> listKhoa = new List<khoa>();
        List<lop> listLop = new List<lop>();
        List<monhoc> listMon = new List<monhoc>();
        List<sinhvien> listSinhvien = new List<sinhvien>();
        List<bangdiem> listBangdiem = new List<bangdiem>();

        public MainForm() {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e) {
            updateListKhoa();
        }





        private void updateListKhoa() {
            if (khoaSV == null) khoaSV = new KhoaSerivice();

            listKhoa.Clear();
            listKhoa.AddRange(khoaSV.getDsKhoa());
            List<String> listDataAutoComplete = new List<string>();
            foreach (khoa itemKhoa in listKhoa) {
                if (itemKhoa != null) {
                    listDataAutoComplete.Add(itemKhoa.makhoa);
                    listDataAutoComplete.Add(itemKhoa.tenkhoa);
                }
            }
            bindAutoCompleteToTextbox(listDataAutoComplete.ToArray());
            bindDataSource<khoa>(listKhoa, gridKhoa);
        }
        private void searchKhoa(String text) {
            if (khoaSV == null) khoaSV = new KhoaSerivice();

            listKhoa.Clear();
            listKhoa.AddRange(khoaSV.searchKhoa(text));         
            bindDataSource<khoa>(listKhoa, gridKhoa);
        }

        private void updateListLop() {
            if (lopSV == null) lopSV = new LopSerivice();
            listLop.Clear();
            listLop.AddRange(lopSV.getDsLop());
            List<String> s = new List<string>();

            foreach (lop l in listLop) {
                s.Add(l.malop);
                s.Add(l.makhoa);
                s.Add(l.tenlop);

            }
           
            bindAutoCompleteToTextbox(s.ToArray());
            bindDataSource<lop>(listLop, gridLop);

        }
        private void searchListLop(String search) {
            if (lopSV == null) lopSV = new LopSerivice();
            listLop.Clear();
            listLop.AddRange(lopSV.getDsLop(search));
            bindDataSource<lop>(listLop, gridLop);

        }
        private void UpdateListMon() {
            if (monSV == null) monSV = new MonSerivices();
            listMon.Clear();
            listMon.AddRange(monSV.getDsMon());
            List<String> listDataAutoComplete = new List<string>();
            foreach (monhoc itemMon in listMon) {
                if (itemMon != null) {
                    listDataAutoComplete.Add(itemMon.mamonhoc);
                    listDataAutoComplete.Add(itemMon.tenmonhoc);
                    //listDataAutoComplete.Add(itemMon.hocky+"");
                    //listDataAutoComplete.Add(itemMon.sotinchi+"");
                    //listDataAutoComplete.Add(itemMon.tongsotiet+"");

                }
            }
            bindAutoCompleteToTextbox(listDataAutoComplete.ToArray());
            bindDataSource<monhoc>(listMon, gidMonHoc);
        }
        private void searchMonHoc(String sr) {
            if (monSV == null) monSV = new MonSerivices();
            listMon.Clear();
            listMon.AddRange(monSV.searchMonHoc(sr));
          
            bindDataSource<monhoc>(listMon, gidMonHoc);
        }

        private void btnSinhVien_Click(object sender, EventArgs e) {
            currentTab = CODE_SV;
            UpdateListSinhVien();
        }

        private void UpdateListSinhVien() {
            if (sinhvienSV == null) sinhvienSV = new SinhvienSerivices();
            listSinhvien.Clear();
            listSinhvien.AddRange(sinhvienSV.getDsSinhvien());
            List<String> listDataAutoComplete = new List<string>();
            foreach (sinhvien itemSinhVien in listSinhvien) {
                if (itemSinhVien != null) {
                    listDataAutoComplete.Add(itemSinhVien.hoten);
                    listDataAutoComplete.Add(itemSinhVien.malop);
                    listDataAutoComplete.Add(itemSinhVien.masv);
                    listDataAutoComplete.Add(itemSinhVien.tenkhoa);
                    listDataAutoComplete.Add(itemSinhVien.diachi);
                    listDataAutoComplete.Add(itemSinhVien.ngaysinh);
                    listDataAutoComplete.Add(itemSinhVien.gioitinh);
                }
            }
            bindAutoCompleteToTextbox(listDataAutoComplete.ToArray());
            bindDataSource<sinhvien>(listSinhvien, gridSv);
        }
        private void searchSinhVien(String search) {
            if (sinhvienSV == null) sinhvienSV = new SinhvienSerivices();
            listSinhvien.Clear();
            listSinhvien.AddRange(sinhvienSV.searchSinhvien(search));
            bindDataSource<sinhvien>(listSinhvien, gridSv);
        }


        private void UpdateListDiem() {
            if (bangdiemSV == null) bangdiemSV = new BangdiemSerivices();
            listBangdiem.Clear();
            listBangdiem.AddRange(bangdiemSV.getDsBangdiem());
            List<String> listDataAutoComplete = new List<string>();
            foreach (bangdiem itemDiem in listBangdiem) {
                if (itemDiem != null) {
                    listDataAutoComplete.Add(itemDiem.masv);
          
                    listDataAutoComplete.Add(itemDiem.trangthai);
                    listDataAutoComplete.Add(itemDiem.mamonhoc);
                   
                }
            }
            bindAutoCompleteToTextbox(listDataAutoComplete.ToArray());
            bindDataSource<bangdiem>(listBangdiem, gridDiem);
        }
        private void searchDiem(String e) {
            if (bangdiemSV == null) bangdiemSV = new BangdiemSerivices();
            listBangdiem.Clear();
            listBangdiem.AddRange(bangdiemSV.searchBangdiem(e));
            
            bindDataSource<bangdiem>(listBangdiem, gridDiem);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) {

        }
        public void bindDataSource<T>(List<T> l, MetroGrid gridview) {
            BindingList<T> bindList = new BindingList<T>(l);
            gridview.DataSource = new BindingSource(bindList, null);


        }


       

        private void btnDangNhap_Click(object sender, EventArgs e) {
            MyService service = new MyService();
            User user = service.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (user != null) {
                panelDangNhap.Visible = false;
                panelMain.Visible = true;
                lblKhoa.Text = user.TenKhoa;
                lblLop.Text = user.Lop;
                lblTen.Text = user.HoTen;
                lblMasv.Text = user.TenDangNhap;
                updateListKhoa();
            } else {
                MessageBox.Show("Sai mat khau hoac tai khoan");
                return;
            }

        }

       
        private void tabControl_Selected(object sender, TabControlEventArgs e) {

            bindDataToTab();
        }

        private void bindDataToTab() {
            switch (tabControl.SelectedIndex) {
                case 0: {
                        updateListKhoa();

                        break;
                    }
                case 1: {
                        updateListLop();
                        break;
                    }
                case 2: {
                        UpdateListSinhVien();
                        break;
                    }
                case 3: {
                        UpdateListMon();

                        break;
                    }
                case 4: {
                        UpdateListDiem();
                        break;
                    }
                case 5: {
                        UpdateListDiem();
                        break;
                    }

            }
        }
        private void  bindAutoCompleteToTextbox(String[] listSource){
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(listSource);
            txtSearch.AutoCompleteCustomSource = source;
        }

        private void htmlLabel1_Click(object sender, EventArgs e) {

        }

        private void metroTextBox1_Click(object sender, EventArgs e) {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e) {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void gridKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            khoa itemKhoa = (khoa)gridKhoa.CurrentRow.DataBoundItem;
            new DialogController(this, DialogController.CODE_UPDATE, itemKhoa).Show();
        }

        private void lollipopButton2_Click(object sender, EventArgs e) {
            new DialogController(this, DialogController.CODE_UPDATE, new khoa()).Show();
        }

        private void MainForm_Load_1(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            switch (tabControl.SelectedIndex) {
                case 0: {
                        searchKhoa(txtSearch.Text);

                        break;
                    }
                case 1: {
                    searchListLop(txtSearch.Text);
                        break;
                    }
                case 2: {
                    searchSinhVien(txtSearch.Text);
                        break;
                    }
                case 3: {
                        searchMonHoc(txtSearch.Text);

                        break;
                    }
                case 4: {
                        searchDiem(txtSearch.Text);
                        break;
                    }
                case 5: {
                        UpdateListDiem();
                        break;
                    }
            }

        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtSearch.Text = "";
            //reset tab
            bindDataToTab();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e) {

        }

        private void tabKhoa_Click(object sender, EventArgs e) {

        }

        private void tabLop_Click(object sender, EventArgs e) {

        }

        private void gridLop_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tabSinhVien_Click(object sender, EventArgs e) {

        }

        private void gridSv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tabMonHoc_Click(object sender, EventArgs e) {

        }

        private void gidMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tabDiem_Click(object sender, EventArgs e) {

        }

        private void gridDiem_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tabTongKet_Click(object sender, EventArgs e) {

        }

        private void gridTongKet_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void panelDangNhap_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void lblLop_Click(object sender, EventArgs e) {

        }

        private void lblTen_Click(object sender, EventArgs e) {

        }

        private void lblKhoa_Click(object sender, EventArgs e) {

        }

        private void lblMasv_Click(object sender, EventArgs e) {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e) {

        }

        private void lollipopLabel2_Click(object sender, EventArgs e) {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e) {

        }

        private void lollipopLabel1_Click(object sender, EventArgs e) {

        }

      


    }
}
