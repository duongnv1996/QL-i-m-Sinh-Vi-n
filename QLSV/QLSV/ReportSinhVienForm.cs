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
    public partial class ReportSinhVienForm : MetroForm
    {
        public ReportSinhVienForm() {
            InitializeComponent();
        }

        private void ReportSinhVienForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'SinhVienDataSet2.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.SinhVienDataSet2.sinhvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
