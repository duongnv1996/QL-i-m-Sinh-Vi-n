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
using QLSV.Bussiness;
using QLSV.Data;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
namespace QLSV
{
    public partial class DialogMonHoc : MetroForm
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        Microsoft.Office.Interop.Excel.Range range;
        Response<Int32> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private monhoc mItem;
        private int mCode;

        public Response<Int32> Response {
            get { return response; }
            set { response = value; }
        }

        /*
         * res : callback goi lai truyen tu main
         * code : phan loai chuc nang ( them/sua+xoa) . Xem phan constant 
         * */


        public DialogMonHoc(Response<Int32> res, int code, monhoc l) {

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
                txtMa.Enabled = false;

            } else {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = true;
            }
        }



        private monhoc getDataFromView() {
            String ten = txtTen.Text;
            String ma = txtMa.Text;
            String soTinChi = txtSoTinChi.Text;
            String soTiet = txtSoTiet.Text;
            String hocKy = txtHocKy.Text;

            monhoc item = new monhoc();
            item.tenmonhoc = ten;
            item.mamonhoc = ma;
            item.sotinchi = soTinChi;
            item.tongsotiet = soTiet;
            item.hocky = hocKy;
            return item;
        }

        private void DialogMonHoc_Load(object sender, EventArgs e) {
            if (mCode == CODE_UPDATE && mItem != null) {
                txtMa.Text = mItem.mamonhoc;
                txtTen.Text = mItem.tenmonhoc;
                txtHocKy.Text = mItem.hocky;
                txtSoTiet.Text = mItem.tongsotiet;
                txtSoTinChi.Text = mItem.sotinchi;
            }
        }

        private void lollipopTextBox2_KeyPress(object sender, KeyPressEventArgs e) {

            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back)) {


            } else {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                bool result = new MonSerivices().delete(getDataFromView());
                if (result) {
                    this.Hide();
                    //refresh list
                    response.onResponse(Constants.CODE_MONHOC);
                } else {
                    MessageBox.Show("Khong the xoa sinh vien");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            bool result = new MonSerivices().update(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_MONHOC);
            } else {
                MessageBox.Show("Khong the sua sinh vien");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            monhoc item = getDataFromView();
            bool result = new MonSerivices().add(item);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_MONHOC);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
        }

        private void txtSoTinChi_TextChanged(object sender, EventArgs e) {

        }

        private void txtSoTinChi_KeyDown(object sender, KeyEventArgs e) {

        }

        private void txtSoTiet_TextChanged(object sender, EventArgs e) {

        }

        private void txtSoTiet_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtSoTinChi_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtSoTinChi.Text, @"^\d+$");
            if (!match.Success) { MessageBox.Show("Vui lòng nhập số!");
            txtSoTinChi.Text = "0";
            }

        }

        private void txtSoTiet_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtSoTiet.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtSoTiet.Text = "0";
            }
        }

        private void txtHocKy_Leave(object sender, EventArgs e) {
            Match match = Regex.Match(txtHocKy.Text, @"^\d+$");
            if (!match.Success) {
                MessageBox.Show("Vui lòng nhập số!");
                txtHocKy.Text = "1";
            }
        }

        private void txtHocKy_TextChanged(object sender, EventArgs e) {

        }

        private List<khoa> getListKhoaFromExcel(String path) {
            List<khoa> listKhoa = new List<khoa>();
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(path, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            if (xlWorkSheet != null) {
                range = xlWorkSheet.UsedRange;
                int row = range.Rows.Count;
                int col = range.Columns.Count;
                for (int r = 2; r <= row; r++) {
                    khoa itemKhoa = new khoa();
                    bool badRow = false;
                    for (int c = 1; c <= col; c++) {
                        String content = "" + (range[r, c] as Range).Value2;
                        if (content.Equals("")) {
                            badRow = true;
                            break;
                        }
                        if (c == 1) {
                            itemKhoa.makhoa = content;
                        } else {
                            itemKhoa.tenkhoa = content;
                        }

                    }
                    if (!badRow)
                        listKhoa.Add(itemKhoa);

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
