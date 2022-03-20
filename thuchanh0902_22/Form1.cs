using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh0902_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayIt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + tbEdit.Text, "Say it");
        }

        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            lbCount.Text = tbEdit.Text.Replace(" ","").Length.ToString();
            btnSayIt.Enabled = (tbEdit.Text.Trim().Length > 0);
        }
    }
}
