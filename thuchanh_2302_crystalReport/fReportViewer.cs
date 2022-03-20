using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh_2302_crystalReport
{
    public partial class fReportViewer : Form
    {
        public fReportViewer()
        {
            InitializeComponent();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            showReport();
        }

        private void showReport()
        {
            // 1. Nạp Report
            ReportDocument rpt = new ReportDocument();
            string path = string.Format("{0}\\Reports\\KhachHang.rpt", Application.StartupPath);
            rpt.Load(path);

            // 2. Cập nhật nguồn dữ liệu
            // Thông số không nên viết cứng, nên đặt trong tệp App.config
            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = @"DESKTOP-AIEHE0Q\LUCKY"; // hoặc: ".\\DESKTOP-AIEHE0Q\\LUCKY"
            logOnInfo.ConnectionInfo.DatabaseName = "db_Shop4Training";
            logOnInfo.ConnectionInfo.IntegratedSecurity = true;

            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(logOnInfo);
            }
            // 3.
            rpt.RecordSelectionFormula = "YEAR({tblKhachhang.tNgaysinh})>=1990";
            rpt.SummaryInfo.ReportTitle = "DEMO_2302";
            // 4. Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
