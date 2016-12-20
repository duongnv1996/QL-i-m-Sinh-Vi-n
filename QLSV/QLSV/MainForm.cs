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
    public partial class MainForm : MetroForm, Response<Int32>
    {
        void Response<Int32>.onResponse(Int32 response) {
            switch (response) {
                case Constants.CODE_LOP: {
                        updateListLop();
                        break;
                    }
                case Constants.CODE_KHOA: {
                        updateListKhoa();
                        break;
                    }
                case Constants.CODE_SV: {
                        UpdateListSinhVien();
                        break;
                    }
                case Constants.CODE_DIEM: {
                    UpdateListDiem();
                        break;
                    }
                case Constants.CODE_MONHOC: {
                    UpdateListMon();
                        break;
                    }
                case Constants.CODE_TONGKET: {

                        break;
                    }
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
        TongKetService tongKetSV;
        User user;
        List<khoa> listKhoa = new List<khoa>();
        List<lop> listLop = new List<lop>();
        List<monhoc> listMon = new List<monhoc>();
        List<sinhvien> listSinhvien = new List<sinhvien>();
        List<bangdiem> listBangdiem = new List<bangdiem>();
        List<tongket> listTongKet = new List<tongket>();
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
        private void UpdateListTongKet() {
            if (tongKetSV == null) tongKetSV = new TongKetService();
            listTongKet.Clear();
            listTongKet.AddRange(tongKetSV.getDsTongKet());
            List<String> listDataAutoComplete = new List<string>();
            foreach (tongket itemDiem in listTongKet) {
                if (itemDiem != null) {
                    listDataAutoComplete.Add(itemDiem.masv);
                }
            }
            bindAutoCompleteToTextbox(listDataAutoComplete.ToArray());
            bindDataSource<tongket>(listTongKet, gridTongKet);
        }
        private void searchListTongKet(String e) {
            if (tongKetSV == null) tongKetSV = new TongKetService();
            listTongKet.Clear();
            listTongKet.AddRange(tongKetSV.searchTongKet(e));

            bindDataSource<tongket>(listTongKet, gridTongKet);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) {

        }
        public void bindDataSource<T>(List<T> l, MetroGrid gridview) {
            BindingList<T> bindList = new BindingList<T>(l);
            gridview.DataSource = new BindingSource(bindList, null);


        }




        private void btnDangNhap_Click(object sender, EventArgs e) {
            MyService service = new MyService();
           user = service.dangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (user != null) {
                panelDangNhap.Visible = false;
                panelMain.Visible = true;
                lblKhoa.Text = user.TenKhoa;
                lblLop.Text = user.Lop;
                lblTen.Text = user.HoTen;
                lblMasv.Text = user.TenDangNhap;
                updateListKhoa();
                if (user.Quyen == Constants.CODE_QUYEN_SV) {
                    btnAdd.Visible = false;
                    int totalWidth = tabControl.Width;
                    int widthTab = totalWidth / 3;
                    Size sizeTab = tabControl.ItemSize;
                    sizeTab.Width = widthTab - 100;
                    tabControl.ItemSize = sizeTab;
                    tabControl.HideTab(tabKhoa);
                    tabControl.HideTab(tabLop);
                    tabControl.HideTab(tabSinhVien);
                } else {
                    MetroFramework.MetroColorStyle style = MetroFramework.MetroColorStyle.Orange;
                    tabControl.Style = style;
                    gridDiem.Style = style;
                    gridLop.Style = style;
                    gridKhoa.Style = style;
                    gridSv.Style = style;
                    gidMonHoc.Style = style;
                    gridTongKet.Style = style;
                    this.Style = style;
                    lbTitle.ForeColor = System.Drawing.Color.Orange;
                    this.UpdateStyles();
                }
              
            } else {
                MessageBox.Show("Sai mat khau hoac tai khoan");
                return;
            }

        }


        private void tabControl_Selected(object sender, TabControlEventArgs e) {

            bindDataToTab();
        }

        private void bindDataToTab() {
            if (user.Quyen == Constants.CODE_QUYEN_SV) {
                switch (tabControl.SelectedIndex) {
                    case 0: {
                            UpdateListMon();
                            break;
                        }
                    case 1: {
                        searchDiem(user.TenDangNhap);
                            break;
                        }
                    case 2: {
                        searchListTongKet(user.TenDangNhap);
                            break;
                        }


                }

            } else {
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
                            UpdateListTongKet();
                            break;
                        }

                }
            }
        }
        private void bindAutoCompleteToTextbox(String[] listSource) {
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

        }

        private void lollipopButton2_Click(object sender, EventArgs e) {
            switch (tabControl.SelectedIndex) {
                case 0: {
                        new DialogKhoa(this, DialogController.CODE_ADD, null).Show();
                        break;
                    }
                case 1: {
                        new DialogController(this, DialogController.CODE_ADD, new lop()).Show();
                        break;
                    }
                case 2: {
                        new DialogSinhVien(this, DialogController.CODE_ADD, null).Show();
                        break;
                    }
                case 3: {
                    new DialogMonHoc(this, DialogController.CODE_ADD, null).Show();
                        break;
                    }
                case 4: {
                    new DialogBangDiem(this, DialogController.CODE_ADD, null).Show();
                        break;
                    }
                case 5: {
                    //    UpdateListDiem();
                        break;
                    }
            }

        }

        private void MainForm_Load_1(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) {
                switch (tabControl.SelectedIndex) {
                    case 0: {
                        searchMonHoc(txtSearch.Text);
                            break;
                        }
                    case 1: {
                        searchDiem(txtSearch.Text);
                            break;
                        }
                    case 2: {
                        searchListTongKet(txtSearch.Text);
                            break;
                        }


                }

            } else {
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
                            searchListTongKet(txtSearch.Text);
                            break;
                        }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtSearch.Text = "";
            //reset tab
            bindDataToTab();
        }

        private void gridLop_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void gridLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) return;
            lop item = (lop)gridLop.CurrentRow.DataBoundItem;
            new DialogController(this, DialogController.CODE_UPDATE, item).Show();
        }

        private void gridKhoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) return;
            khoa item = (khoa)gridKhoa.CurrentRow.DataBoundItem;
            new DialogKhoa(this, DialogController.CODE_UPDATE, item).Show();
        }

        private void gridSv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void gridSv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) return;
            sinhvien item = (sinhvien)gridSv.CurrentRow.DataBoundItem;
            new DialogSinhVien(this, DialogController.CODE_UPDATE, item).Show();
        }

        private void gidMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void gidMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) return;
            monhoc item = (monhoc)gidMonHoc.CurrentRow.DataBoundItem;
            new DialogMonHoc(this, DialogController.CODE_UPDATE, item).Show();
        }

        private void gridDiem_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void gridDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) return;
            bangdiem item = (bangdiem)gridDiem.CurrentRow.DataBoundItem;
            new DialogBangDiem(this, DialogController.CODE_UPDATE, item).Show();
        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e) {

        }

        private void gridTongKet_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e) {
            
        }

        private void btnExport_Click(object sender, EventArgs e) {
            if (user.Quyen == Constants.CODE_QUYEN_SV) {
                switch (tabControl.SelectedIndex) {
                    case 0: {
                        new ReportMonHocForm().Show();

                            break;
                        }
                    case 1: {
                        new ReportBangDiemForm().Show();
                            break;
                        }
                    case 2: {
                        new ReportTongKetForm().Show();
                            break;
                        }


                }

            } else {
                switch (tabControl.SelectedIndex) {
                    case 0: {
                        new ReportKhoaForm().Show();
                            break;
                        }
                    case 1: {
                        new ReportLopForm().Show();
                            break;
                        }
                    case 2: {
                        new ReportSinhVienForm().Show();
                            break;
                        }
                    case 3: {
                        new ReportMonHocForm().Show();

                            break;
                        }
                    case 4: {
                        new ReportBangDiemForm().Show();
                            break;
                        }
                    case 5: {
                        new ReportTongKetForm().Show();
                            break;
                        }
                }
            }
        }



    }
}
