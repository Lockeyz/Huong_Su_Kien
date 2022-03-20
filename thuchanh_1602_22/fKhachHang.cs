using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh_1602_22
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaySinh;
            btnEnter.Enabled = (txbName.Text.Trim().Length > 0)
                && DateTime.TryParse(mtbBirthDay.Text.Trim(), out ngaySinh);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-AIEHE0Q\LUCKY;Initial Catalog=db_Shop4Training;Integrated Security=True";
            
            string procedureName = string.IsNullOrEmpty(btnEnter.Tag.ToString())
                ? "spKhachHang_Insert" : "spKhachHang_Update";

            long khachHangID = Convert.ToInt64("0" + btnEnter.Tag);

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PK_iKhachHangID", SqlDbType.BigInt);
                    if (khachHangID == 0) // Them moi
                    {
                        cmd.Parameters["@PK_iKhachHangID"].Direction = ParameterDirection.Output;
                    }
                    else // Cap nhat
                    {
                        cmd.Parameters["@PK_iKhachHangID"].Value = khachHangID;
                    }
                    cmd.Parameters.AddWithValue("@sHoTen", txbName.Text);
                    cmd.Parameters.AddWithValue("@tNgaySinh", Convert.ToDateTime(mtbBirthDay.Text));
                    cmd.Parameters.AddWithValue("@bGioiTinh", rbtnFemale.Checked);
                    cmd.Parameters.AddWithValue("@sDienThoai", txbPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txbAddress.Text);
                    cmd.Parameters.AddWithValue("@sTenCoQuan", txbOffice.Text);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    btnSkip_Click(sender, e);             
                }

            }
        }

        private DataTable getKhachHang()
        {
            string connectionString = @"Data Source=DESKTOP-AIEHE0Q\LUCKY;Initial Catalog=db_Shop4Training;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spKhachHang_Get", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblKhachHang");
                        da.Fill(tbl);
                        return tbl;
                    }
                }

            }
        }

        // Điều kiện lọc
        private void hienKhachHang(string dieuKienLoc="")
        {
            using (DataTable tblKhachHang = getKhachHang())
            {
                DataView dvKhachHang = new DataView(tblKhachHang);
                if (!string.IsNullOrEmpty(dieuKienLoc))
                {
                    dvKhachHang.RowFilter = dieuKienLoc;
                }

                dtgvKhachHang.AutoGenerateColumns = false;
                dtgvKhachHang.DataSource = dvKhachHang;
                btnEdit.Enabled = btnDelete.Enabled = dtgvKhachHang.Rows.Count > 0;
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            txbName.Text
                = txbPhoneNumber.Text
                = txbAddress.Text
                = txbOffice.Text
                = string.Empty;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            mtbBirthDay.ResetText();
            txbName.Focus();
            btnEnter.Text = "Thêm mới";
            btnEnter.Tag = string.Empty;
            hienKhachHang();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            btnEnter.Tag = "";
            hienKhachHang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn xóa không?"
                , "Thông báo"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (re == DialogResult.No)
            {
                return;
            }
            try
            {
                DataView dvKhachHang = (DataView)dtgvKhachHang.DataSource;
                DataRowView drvKhachHang = dvKhachHang[dtgvKhachHang.CurrentRow.Index];

                string connectionString = @"Data Source=DESKTOP-AIEHE0Q\LUCKY;Initial Catalog=db_Shop4Training;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spKhachhang_Delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PK_iKhachHangID", drvKhachHang["PK_iKhachHangID"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienKhachHang();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy liên hệ với đội ngũ kỹ thuật"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khách hàng đang có dữ liệu liên quan, không xóa được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataView dtvKhachHang = (DataView)dtgvKhachHang.DataSource;
            DataRowView dtrvKhachHang = dtvKhachHang[dtgvKhachHang.CurrentRow.Index];
            chuyenTrangThaiSua(dtrvKhachHang);
        }

        private void chuyenTrangThaiSua(DataRowView dtrvKhachHang)
        {
            txbName.Text = dtrvKhachHang["sHoten"].ToString();
            mtbBirthDay.Text = Convert.ToString(dtrvKhachHang["tNgaysinh"]);
            rbtnFemale.Checked = Convert.ToBoolean(dtrvKhachHang["bGioitinh"]);
            rbtnMale.Checked = !rbtnFemale.Checked;
            txbAddress.Text = dtrvKhachHang["sDiaChi"].ToString();
            txbPhoneNumber.Text = Convert.ToString(dtrvKhachHang["sDienthoai"]);
            txbOffice.Text = Convert.ToString(dtrvKhachHang["sTencoquan"]);

            btnEnter.Text = "Cập nhật";
            btnEnter.Tag = dtrvKhachHang["PK_iKhachhangID"].ToString();

            btnEdit.Enabled = btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = "PK_iKhachhangID>0 ";
            if (!string.IsNullOrEmpty(txbName.Text.Trim()))
            {
                filter += string.Format(" AND sHoten LIKE '%{0}%'", txbName.Text);
            }
            if (!string.IsNullOrEmpty(txbPhoneNumber.Text.Trim()))
            {
                filter += string.Format(" AND sDienthoai LIKE '%{0}%'", txbPhoneNumber.Text);
            }

            hienKhachHang(filter);
        }
    }
}
