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
    public partial class ReportKhoaForm : MetroForm
    {
        public ReportKhoaForm() {
            InitializeComponent();
        }

        private void ReportKhoaForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'SinhVienDataSet2.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.SinhVienDataSet2.khoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
