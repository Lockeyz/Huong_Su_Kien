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
    public partial class fListBox : Form
    {
        public fListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomListItem cli = new CustomListItem();
            cli.Value = txbValue.Text;
            cli.Text = txbText.Text;
            listBox1.Items.Add(cli);

            txbText.Text = txbValue.Text = string.Empty;
            txbText.Focus();
        }
    }
}
