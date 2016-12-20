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
    public partial class ReportTongKetForm : MetroForm
    {
        public ReportTongKetForm() {
            InitializeComponent();
        }

        private void ReportTongKetForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'SinhVienDataSet2.tongket' table. You can move, or remove it, as needed.
            this.tongketTableAdapter.Fill(this.SinhVienDataSet2.tongket);

            this.reportViewer1.RefreshReport();
        }
    }
}
