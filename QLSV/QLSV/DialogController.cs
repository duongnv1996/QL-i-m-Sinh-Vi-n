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

namespace QLSV
{
    public partial class DialogController : MetroForm
    {
        Response<Int32> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private lop mLop;
        private int mCode;
        List<khoa> listKhoa;
        public Response<Int32> Response {
            get { return response; }
            set { response = value; }
        }


        //Contructer

        public DialogController() {
            listKhoa = new KhoaSerivice().getDsKhoa();
            InitializeComponent();
        }
        /*
         * res : callback goi lai truyen tu main
         * code : phan loai chuc nang ( them/sua+xoa) . Xem phan constant 
         * */
        public DialogController(Response<Int32> res, int code) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            if (code == CODE_UPDATE) {
                btnUpdate.Visible = true;
                btnUpdate.Visible = true;
            }


        }
        public DialogController(Response<Int32> res, int code, lop l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mCode = code;
            mLop = l;
        }
        //public DialogController(Response<bool> res, int code, khoa l) {
        //    listKhoa = new KhoaSerivice().getDsKhoa();
        //    this.response = res;
        //    InitializeComponent();
        //    setViewControl(code);
        //    mKhoa = l;
        //}
        //public DialogController(Response<bool> res, int code, sinhvien l) {
        //    listKhoa = new KhoaSerivice().getDsKhoa();
        //    this.response = res;
        //    InitializeComponent();
        //    setViewControl(code);
        //    mSinhVien = l;

        //}
        //public DialogController(Response<bool> res, int code, monhoc l) {
        //    listKhoa = new KhoaSerivice().getDsKhoa();
        //    this.response = res;
        //    InitializeComponent();
        //    setViewControl(code);
        //    mMonHoc = l;

        //}
        //public DialogController(Response<bool> res, int code, bangdiem l) {
        //    listKhoa = new KhoaSerivice().getDsKhoa();
        //    this.response = res;
        //    InitializeComponent();
        //    setViewControl(code);
        //    mDiem = l;

        //}
     
        // Hide or Show view controller
        private void setViewControl(int code) {
            if (code == CODE_UPDATE) {
                btnUpdate.Visible = true;
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
                txtMaLop.Enabled = false;
                cbbKhoa.Enabled = false;
            } else {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = true;
            }
        }
      

       

        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            //new LopSerivice().themLop
         
        }

        private lop getDataFromView() {
            String tenLop = txtTenLop.Text;
            String maLop = txtMaLop.Text;
            String maKhoa = listKhoa[cbbKhoa.SelectedIndex].makhoa;
            lop lop = new lop();
            lop.tenlop = tenLop;
            lop.makhoa = maKhoa;
            lop.malop = maLop;
            return lop;
        }


        private void DialogController_Load(object sender, EventArgs e) {

            //BindingSource bs = new BindingSource();
            //bs.DataSource = listKhoa;
         
         
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
          
        }

        private void btnDelete_Click(object sender, EventArgs e) {
         
        }

        private void txtMaLop_Enter(object sender, EventArgs e) {
            
        }

        private void txtTenLop_Enter(object sender, EventArgs e) {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void lollipopButton3_Click(object sender, EventArgs e) {
            bool result = new LopSerivice().xoaLop(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_LOP);
            } else {
                MessageBox.Show("Khong the xoa lop");
            }
        }

        private void lollipopButton2_Click(object sender, EventArgs e) {
            bool result = new LopSerivice().suaLop(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_LOP);
            } else {
                MessageBox.Show("Khong the sua lop");
            }
        }

        private void lollipopButton1_Click(object sender, EventArgs e) {
            lop lop = getDataFromView();
            bool result = new LopSerivice().themLop(lop);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(Constants.CODE_LOP);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
        }

        private void DialogController_Load_1(object sender, EventArgs e) {
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.DisplayMember = "makhoa";
            cbbKhoa.ValueMember = "makhoa";
            if (mCode == CODE_UPDATE && mLop != null) {
                txtMaLop.Text = mLop.malop;
                txtTenLop.Text = mLop.tenlop;
                int i = 0;

                foreach (khoa k in listKhoa) {
                    if (k.makhoa == mLop.makhoa) {
                        cbbKhoa.SelectedIndex = i;
                        break;
                    }
                    i++;

                }


            }
        }
    }
}
