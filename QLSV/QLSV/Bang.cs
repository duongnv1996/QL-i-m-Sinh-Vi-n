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
      
        // Tao Datamodel -> Datacontroller -> dataService -> main tao day list vao bang. 

        public List<khoa> LstKhoa {
            get { return lstKhoa; }
            set { lstKhoa = value; }
        }

        public bang() {
            InitializeComponent();
            
        }
        public void hienList(List<khoa> list) {
            LstKhoa = list;
            bindDataSource<khoa>(LstKhoa);
        }
        public void hienList(List<lop> list) {
            lstLop = list;
        }
        public void hienList(List<monhoc> list) {
            lstMonhoc = list;
          
        }
       
        public void bindDataSource<T>(List<T> l){
             BindingList<T> bindList = new BindingList<T>(l);
            gridview.DataSource = new BindingSource(bindList, null);
            gridview.ReadOnly = true;
        }
        private void bang_Load(object sender, EventArgs e) {
            //BindingList<khoa> bindList = new BindingList<khoa>(LstKhoa);
            //gridview.DataSource = new BindingSource(bindList, null);
            //gridview.ReadOnly = true;
            //gridview.Visible = false;
        }
       
        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void gridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void lollipopCard1_Click(object sender, EventArgs e) {

        }

        private void lollipopCard1_Click_1(object sender, EventArgs e) {

        }

        private void gridview_CellContentClick_2(object sender, DataGridViewCellEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void lollipopTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
