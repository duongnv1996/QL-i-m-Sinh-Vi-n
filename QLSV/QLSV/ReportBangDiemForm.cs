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

namespace QLSV
{
    public partial class ReportBangDiemForm : MetroForm
    {
        public ReportBangDiemForm() {
            InitializeComponent();
        }

        private void ReportBangDiemForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'SinhVienDataSet2.bangdiem' table. You can move, or remove it, as needed.
            this.bangdiemTableAdapter.Fill(this.SinhVienDataSet2.bangdiem);

            this.reportViewer1.RefreshReport();
        }
    }
}
