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
    public partial class DialogController : Form
    {
        Response<bool> response;
        public const int CODE_ADD = 0;
        public const int CODE_UPDATE = 1;
        private lop mLop;
        private khoa mKhoa;
        private sinhvien mSinhVien;
        private monhoc mMonHoc;
        private bangdiem mDiem;
        
        List<khoa> listKhoa;
        public Response<bool> Response {
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
        public DialogController(Response<bool> res, int code) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            if (code == CODE_UPDATE) {
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }


        }
        public DialogController(Response<bool> res, int code, lop l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mLop = l;
        }
        public DialogController(Response<bool> res, int code, khoa l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mKhoa = l;
        }
        public DialogController(Response<bool> res, int code, sinhvien l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mSinhVien = l;

        }
        public DialogController(Response<bool> res, int code, monhoc l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mMonHoc = l;

        }
        public DialogController(Response<bool> res, int code, bangdiem l) {
            listKhoa = new KhoaSerivice().getDsKhoa();
            this.response = res;
            InitializeComponent();
            setViewControl(code);
            mDiem = l;

        }
     
        // Hide or Show view controller
        private void setViewControl(int code) {
            if (code == CODE_UPDATE) {
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                txtMaLop.Enabled = false;
                cbbKhoa.Enabled = false;
            }
        }
      

       

        private void bunifuThinButton21_Click(object sender, EventArgs e) {
            //new LopSerivice().themLop
            lop lop = getDataFromView();
            bool result = new LopSerivice().themLop(lop);
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(true);
            } else {
                MessageBox.Show("Khong the them vao danh sach");
            }
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
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.DisplayMember = "makhoa";
            cbbKhoa.ValueMember = "makhoa";
            if (mLop != null) {
                txtMaLop.Text = mLop.malop;
                txtTenLop.Text = mLop.tenlop;
                int i = 0;
               
                foreach ( khoa k in listKhoa){
                    if (k.makhoa == mLop.makhoa) {
                        cbbKhoa.SelectedIndex = i;
                        break;
                    }
                    i++;

                }
              

            }
         
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            bool result = new LopSerivice().suaLop(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(true);
            } else {
                MessageBox.Show("Khong the sua lop");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            bool result = new LopSerivice().xoaLop(getDataFromView());
            if (result) {
                this.Hide();
                //refresh list
                response.onResponse(true);
            } else {
                MessageBox.Show("Khong the xoa lop");
            }
        }

        private void txtMaLop_Enter(object sender, EventArgs e) {
            
        }

        private void txtTenLop_Enter(object sender, EventArgs e) {
          
        }
    }
}
