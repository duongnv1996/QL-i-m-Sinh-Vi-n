using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Data;
using QLSV.Bussiness;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
namespace QLSV
{
    public partial class DialogBangDiem : MetroForm
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        Microsoft.Office.Interop.Excel.Range range;
        Response<Int32> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private bangdiem mItem;
        private int mCode;
        private List<sinhvien> mListSinhVien;
        private List<monhoc> mListMonHoc;
        public Response<Int32> Response {
            get { return response; }
            set { response = value; }
        }

        /*
         * res : callback goi lai truyen tu main
         * code : phan loai chuc nang ( them/sua+xoa) . Xem phan constant 
         * */


        public DialogBangDiem(Response<Int32> res, int code, bangdiem l) {

            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mCode = code;
            mItem = l;
        }
        private void setViewControl(int code) {
            if (code == CODE_UPDATE) {
                btnUpdate.Visible = true;
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
                cboMaMonHoc.Enabled = false;
                cboMaSv.Enabled = false;
            } else {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = true;
            }
        }



        private bangdiem getDataFromView() {
            String masv = mListSinhVien[cboMaSv.SelectedIndex].masv;
            String mamonhoc = mListMonHoc[cboMaMonHoc.SelectedIndex].mamonhoc;
            String soTietNghi = txtSoTietNghi.Text;
            String diemtp = txtDiemTp.Text;
            String diemlan1 = txtDiemLan1.Text;
            String diemlan2 = txtDiemLan2.Text;
            bangdiem item = new bangdiem();
            item.masv = masv;
            item.mamonhoc = mamonhoc;
            item.sotietnghi = soTietNghi;
            item.diemthilan1 = diemlan1;
            item.diemthilan2 = diemlan2;
            item.diemtp = diemtp;
            return item;
        }

        private void DialogBangDiem_Load(object sender, EventArgs e) {
            mListMonHoc = new MonSerivices().getDsMon();
            mListSinhVien = new SinhvienSerivices().getDsSinhvien();
            cboMaSv.DataSource = mListSinhVien;
            cboMaMonHoc.DataSource = mListMonHoc;
            //config display
            cboMaSv.DisplayMember = "masv";
            cboMaSv.ValueMember = "masv";
            cboMaMonHoc.DisplayMember = "mamonhoc";
            cboMaMonHoc.ValueMember = "mamonhoc";


            if (mCode == CODE_UPDATE && mItem != null) {
                //config default combo sinhvien
                int i = 0;
                foreach (sinhvien k in mListSinhVien) {
                    if (k.masv == mItem.masv) {
                        cboMaSv.SelectedIndex = i;
                        break;
                    }
                    i++;

                }
                //config default combo monhoc

                i = 0;
                foreach (monhoc k in mListMonHoc) {
                    if (k.mamonhoc == mItem.mamonhoc) {
                        cboMaMonHoc.SelectedIndex = i;
                        break;
                    }
                    i++;

                }

                txtDiemLan1.Text = mItem.diemthilan1;
                txtDiemLan2.Text = mItem.diemthilan2;
                txtDiemTp.Text = mItem.diemtp;
                txtSoTietNghi.Text = mItem.sotietnghi;

            }
        }


        private void btnDelete_Click(object sender, EventArgs e) {
             DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
             if (dr == DialogResult.Yes) {
                 bool result = new BangdiemSerivices().delete(getDataFromView());
                 if (result) {
                     this.Hide();
                     //refresh list
                     response.onResponse(Constants.CODE_DIEM);
                 } else {
                     MessageBox.Show("Khong the xoa diem");
                 }
             }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            bangdiem item = getDataFromView();
            bool result = new BangdiemSerivices().add(item);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_DIEM);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            bool result = new BangdiemSerivices().update(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_DIEM);
            } else {
                MessageBox.Show("Khong the sua diem");
            }
        }

        private void txtDiemTp_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtDiemTp.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtDiemTp.Text = "0";
            }
        }

        private void txtDiemLan1_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtDiemLan1.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtDiemLan1.Text = "0";
            }
        }

        private void txtDiemLan2_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtDiemLan2.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtDiemLan2.Text = "0";
            }
        }

        private void txtSoTietNghi_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtSoTietNghi.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtSoTietNghi.Text = "0";
            }
        }

        private List<bangdiem> getListDiemFromExcel(String path) {
            List<bangdiem> listKhoa = new List<bangdiem>();
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(path, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            if (xlWorkSheet != null) {
                range = xlWorkSheet.UsedRange;
                int row = range.Rows.Count;
                int col = range.Columns.Count;
                for (int r = 2; r <= row; r++) {
                    bangdiem item = new bangdiem();
                    bool badRow = false;
                    for (int c = 1; c <= col; c++) {
                        String content = "" + (range[r, c] as Range).Value2;
                        if (content.Equals("")) {
                            badRow = true;
                            break;
                        }
                        if (c == 1) {
                            item.masv = content;
                        } else {
                           // item. = content;
                        }

                    }
                    if (!badRow)
                        listKhoa.Add(item);

                }


            }

            return listKhoa;

        }
        private void fileDialog_FileOk(object sender, CancelEventArgs e) {

        }

        private void btnExcel_Click(object sender, EventArgs e) {
            fileDialog.Filter = "Excel Worksheets|*.xls;*.xlsx";
            fileDialog.ShowDialog();
        }
    }
}
