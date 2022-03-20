using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huong_Su_Kien
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
            Application.Run(new Form1());

            string tenhang = "Hàng hóa 1";
            float gianiemyet = 10000.0f;
            string dacdiem = "Đặc điểm 1";
            string xuatxu = "Xuất xứ 1";
            string connectionString = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection (connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spHanghoa_Insert", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@sTenhang", tenhang);
                    Cmd.Parameters.AddWithValue("@fGianiemyet", gianiemyet);
                    Cmd.Parameters.AddWithValue("@sDacdiem", dacdiem);
                    Cmd.Parameters.AddWithValue("@sXuatxu", xuatxu);

                    Cnn.Open();
                    int n = Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    if (n>0)
                    {
                        Console.WriteLine("Đã thêm bản ghi");
                    }

                } //Cmd   
            }   //Cnn 
        }
    }
}
