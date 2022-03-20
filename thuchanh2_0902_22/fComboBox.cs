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
    public partial class fComboBox : Form
    {
        public fComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("index:{0}; selected item:\"{1}\";",
                comboBox1.SelectedIndex, comboBox1.SelectedItem);
        }
    }
}
