using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDLogfileReader
{
    public partial class About : Form
    {

        public About()
        {
            InitializeComponent();
            label1.Text = label1.Text + " " +  Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void closeClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void onLinkClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Azyron/EDLogfileReader");
        }

    }
}
