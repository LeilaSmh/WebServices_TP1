using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCalcul
{
    public partial class FormCal : Form
    {
        ServiceReferenceCalcul.Service1Client cal = new ServiceReferenceCalcul.Service1Client();
        public FormCal()
        {
            InitializeComponent();
        }

        private void Btplus_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebAdd(int.Parse(Txtx.Text),int.Parse(Txty.Text)));
        }

        private void Btsous_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebSoustraction(int.Parse(Txtx.Text),int.Parse(Txty.Text)));
        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebMultiply(int.Parse(Txtx.Text),int.Parse(Txty.Text)));

        }

        private void Btdiv_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebDivision(int.Parse(Txtx.Text),int.Parse(Txty.Text)));
        }
    }
}
