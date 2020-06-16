using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text.NET
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void Go_Url_SVG(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://codefisher.org/pastel-svg/");
        }
    }
}
