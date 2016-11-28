using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Data;
using QLSV.Bussiness;
namespace QLSV
{
    public partial class bang : UserControl
    {
        List<khoa> lstKhoa;
        List<lop> lstLop;
        List<monhoc> lstMonhoc;
        List<sinhvien> lstSinhvien;
        List<bangdiem> lstBangdiem;

        // Tao Datamodel -> Datacontroller -> dataService -> main tao day list vao bang. 

        public List<khoa> LstKhoa
        {
            get { return lstKhoa; }
            set { lstKhoa = value; }
        }
        public List<lop> LstLop
        {
            get { return lstLop; }
            set { lstLop = value; }
        }
        public List<monhoc> LstMonhoc
        {
            get { return lstMonhoc; }
            set { lstMonhoc = value; }
        }
        public List<sinhvien> LstSinhvien
        {
            get { return lstSinhvien; }
            set { lstSinhvien = value; }
        }
        public List<bangdiem> LstBangdiem
        {
            get { return lstBangdiem; }
            set { lstBangdiem = value; }
        }

        public bang()
        {
            InitializeComponent();

        }
        public void hienList(List<khoa> list)
        {
            LstKhoa = list;
            bindDataSource<khoa>(LstKhoa);
            gridview.AutoSizeColumnsMode =
       DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void hienList(List<lop> list)
        {
            lstLop = list;
            bindDataSource<lop>(LstLop);
            //     gridview.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void hienList(List<monhoc> list)
        {
            lstMonhoc = list;
            bindDataSource<monhoc>(LstMonhoc);
            //     gridview.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void hienList(List<sinhvien> list)
        {
            LstSinhvien = list;
            bindDataSource<sinhvien>(LstSinhvien);
            //     gridview.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void hienList(List<bangdiem> list)
        {
            LstBangdiem = list;
            bindDataSource<bangdiem>(LstBangdiem);
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void bindDataSource<T>(List<T> l)
        {
            BindingList<T> bindList = new BindingList<T>(l);
            gridview.DataSource = new BindingSource(bindList, null);
            gridview.ReadOnly = true;

        }
        private void bang_Load(object sender, EventArgs e)
        {
            //BindingList<khoa> bindList = new BindingList<khoa>(LstKhoa);
            //gridview.DataSource = new BindingSource(bindList, null);
            //gridview.ReadOnly = true;
            //gridview.Visible = false;
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lollipopCard1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopCard1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridview_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
