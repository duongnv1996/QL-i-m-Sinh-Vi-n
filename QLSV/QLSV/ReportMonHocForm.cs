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
    public partial class ReportMonHocForm : MetroForm
    {
        public ReportMonHocForm() {
            InitializeComponent();
        }

        private void ReportMonHocForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'SinhVienDataSet2.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.SinhVienDataSet2.monhoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
