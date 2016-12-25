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
using  Microsoft.Office.Interop.Excel;
namespace QLSV
{
    public partial class DialogKhoa : MetroForm
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook ;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet ;
        Microsoft.Office.Interop.Excel.Range range ;
          Response<Int32> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private khoa mKhoa;
        private int mCode;
        List<khoa> listKhoa;
        public Response<Int32> Response {
            get { return response; }
            set { response = value; }
        }


        //Contructer
         public DialogKhoa() {
            InitializeComponent();
        }
       
        /*
         * res : callback goi lai truyen tu main
         * code : phan loai chuc nang ( them/sua+xoa) . Xem phan constant 
         * */


         public DialogKhoa(Response<Int32> res, int code, khoa l) {
         
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mKhoa = l;
        }
         private void setViewControl(int code) {
             if (code == CODE_UPDATE) {
                 btnUpdate.Visible = true;
                 btnUpdate.Visible = true;
                 btnAdd.Visible = false;
                 txtMaLop.Enabled = false;
               
             } else {
                 btnUpdate.Visible = false;
                 btnDelete.Visible = false;
                 btnAdd.Visible = true;
             }
         }



         private khoa getDataFromView() {
             String ten = txtTenLop.Text;
             String ma = txtMaLop.Text;
            
             khoa khoa = new khoa();
             khoa.tenkhoa = ten;
             khoa.makhoa = ma;

             return khoa;
         }

       

        private void DialogKhoa_Load(object sender, EventArgs e) {
            if (mKhoa != null) {
                txtMaLop.Text = mKhoa.makhoa;
                txtTenLop.Text = mKhoa.tenkhoa;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa khoa. Vui lòng xóa các lớp của khoa đó trước! Xóa?", "Xóa ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                bool result = new KhoaSerivice().delete(getDataFromView());
                if (result) {
                    this.Hide();
                    //refresh list
                    response.onResponse(Constants.CODE_KHOA);
                } else {
                    MessageBox.Show("Khong the xoa ");
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            bool result = new KhoaSerivice().update(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_KHOA);
            } else {
                MessageBox.Show("Khong the sua lop");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            khoa khoa = getDataFromView();
            bool result = new KhoaSerivice().add(khoa);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_KHOA);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
        }
      
        private void btnExcel_Click(object sender, EventArgs e) {
            fileDialog.Filter = "Excel Worksheets|*.xls;*.xlsx";
            fileDialog.ShowDialog();
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
            List<khoa> listKhoa = getListKhoaFromExcel(fileDialog.FileName);
           KhoaSerivice service =  new KhoaSerivice();
            foreach(khoa itemKhoa in listKhoa ){
                bool result = service.add(itemKhoa);
                if (result) {
                    this.Hide();
                    //refresh list
                   
                } else {
                  //  MessageBox.Show("Khong the them vao danh sach");

                }
            }
            response.onResponse(Constants.CODE_KHOA);
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }
    }
}
