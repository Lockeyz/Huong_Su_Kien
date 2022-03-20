using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh_1602_22
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new fReportViewer());*/
            Application.Run(new fKhachHang());
        }
        
        // Tìm form đang mở theo tên
        public static Form FindOpenedForm(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return f;
                }
            }
            return null;
        }
    }
}
