using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2_0902_22
{
    public partial class fPhepChia : Form
    {
        public fPhepChia()
        {
            InitializeComponent();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float b = Convert.ToSingle(txbB.Text);
                if (b == 0)
                {
                    errorProvider1.SetError(txbB, "So chia phai khac 0");
                }
                float thuong = Convert.ToSingle(txbA.Text)/b;
                lbAnswer.Text = thuong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Co loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            fComboBox f = new fComboBox();
            f.ShowDialog();
        }

        private void btnToListBox_Click(object sender, EventArgs e)
        {
            fListBox f = new fListBox();
            f.Show();
        }
    }
}
