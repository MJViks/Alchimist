using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchimist
{
    public partial class Options : Form
    {
        public Options()
        {

            InitializeComponent();
            fr1 main = this.Owner as fr1;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options opt = new Options();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr1 form1 = Application.OpenForms.OfType<fr1>().Single();
        form1.opt_save();



        }
    }
}
