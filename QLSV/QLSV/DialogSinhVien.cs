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
namespace QLSV
{
    public partial class DialogSinhVien : MetroForm
    {
       List<lop>  listLop ;
        Response<Int32> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private sinhvien mItem;
        private int mCode;
        List<sinhvien> listKhoa;
        public Response<Int32> Response {
            get { return response; }
            set { response = value; }
        }

        /*
         * res : callback goi lai truyen tu main
         * code : phan loai chuc nang ( them/sua+xoa) . Xem phan constant 
         * */


        public DialogSinhVien(Response<Int32> res, int code, sinhvien l) {
         
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
                 txtMaSv.Enabled = false;
               
             } else {
                 btnUpdate.Visible = false;
                 btnDelete.Visible = false;
                 btnAdd.Visible = true;
             }
         }



         private sinhvien getDataFromView() {
             String ten = txtTenSinhVien.Text;
             String ma = txtMaSv.Text;
             String diaChi = txtDiaChi.Text;
             String ngaySinh = dateTime.Value.ToString("yyyy-MM-dd");
             String gioiTinh;
             if (radNam.Checked) {
                 gioiTinh = "Nam";
             } else {
                 gioiTinh = "Nữ";
             }

             sinhvien item = new sinhvien();
             item.masv = ma;
             item.hoten = ten;
             item.diachi = diaChi;
             item.ngaysinh = ngaySinh;
             item.gioitinh = gioiTinh;
             item.malop = listLop[comboMaLop.SelectedIndex].malop;


             return item;
         }

       

        public DialogSinhVien() {
            InitializeComponent();
        }
        private void DialogSinhVien_Load(object sender, EventArgs e) {
            listLop = new LopSerivice().getDsLop();
            comboMaLop.DataSource = listLop;
            comboMaLop.DisplayMember = "malop";
            comboMaLop.ValueMember = "malop";
            if (mCode == CODE_UPDATE && mItem != null) {
                txtMaSv.Text = mItem.masv;
                txtTenSinhVien.Text = mItem.hoten;
                txtDiaChi.Text = mItem.diachi;
                String gioiTinh = mItem.gioitinh;
                if (gioiTinh.Equals("Nam")) {
                    radNam.Checked = true;
                    radNu.Checked = false;

                } else {
                    radNam.Checked = false ;
                    radNu.Checked = true;
                }
                String ngaySinh = mItem.ngaysinh;
                try {
                    dateTime.Value = DateTime.Parse(ngaySinh);
                } catch (Exception er) {

                    dateTime.Value = new DateTime();
                }
                
                int i = 0;

                foreach (lop k in listLop) {
                    if (k.malop == mItem.malop) {
                        comboMaLop.SelectedIndex = i;
                        break;
                    }
                    i++;

                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            bool result = new SinhvienSerivices().delete(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_SV);
            } else {
                MessageBox.Show("Khong the xoa sinh vien");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            bool result = new SinhvienSerivices().update(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_SV);
            } else {
                MessageBox.Show("Khong the sua sinh vien");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            sinhvien khoa = getDataFromView();
            bool result = new SinhvienSerivices().add(khoa);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_SV);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
        }
    }
}
