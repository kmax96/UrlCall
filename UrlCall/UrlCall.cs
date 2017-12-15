using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlCall
{
    public partial class UrlCall : Form
    {
        public UrlCall()
        {
            InitializeComponent();
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            WebTest.getWebContent(txtUrl.Text, txtQty.Text.toInt());
        }
    }
}
