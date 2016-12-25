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
using Microsoft.Reporting.WinForms;
namespace QLSV
{
    public partial class ReportBangDiemForm : MetroForm
    {
        public ReportBangDiemForm() {
            InitializeComponent();
        }
     
       DataTable bangDiems;
       public ReportBangDiemForm(DataTable bangDiems) {
            InitializeComponent();
            this.bangDiems = bangDiems;
        }
        private void ReportBangDiemForm_Load(object sender, EventArgs e) {
            this.bangdiemTableAdapter.Fill(this.SinhVienDataSet2.bangdiem);

            this.reportViewer1.RefreshReport();
        }
    }
}
