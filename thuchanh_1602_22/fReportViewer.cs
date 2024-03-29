﻿using CrystalDecisions.CrystalReports.Engine;
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

namespace thuchanh_1602_22
{
    public partial class fReportViewer : Form
    {
        public fReportViewer()
        {
            InitializeComponent();
        }

        private void fReportViewer_Load(object sender, EventArgs e)
        {
        }

        /*public void ShowReport(string reportFileName, string reportFilter="", string reportTitle="")*/
        public void ShowReport(string reportFileName, string reportFilter="", string reportTitle="")
        {
            // 1. Nạp Report
            ReportDocument rpt = new ReportDocument();
            string path = string.Format("{0}\\Report\\{1}", Application.StartupPath, reportFileName);
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
            // Gán cứng:
            /*rpt.RecordSelectionFormula = "YEAR({tblKhachhang.tNgaysinh})>=1990";
            rpt.SummaryInfo.ReportTitle = "DEMO_2302";*/

            if (!string.IsNullOrEmpty(reportFilter))
            {
                rpt.RecordSelectionFormula = reportFilter;
            }
            if (!string.IsNullOrEmpty(reportTitle))
            {
                rpt.SummaryInfo.ReportTitle = reportTitle;
            }

            // 4. Hiển thị
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
