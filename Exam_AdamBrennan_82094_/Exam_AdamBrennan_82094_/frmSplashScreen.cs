using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_AdamBrennan_82094_
{
    public partial class frmSplashForm : Form
    {
        public frmSplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Start();
            frmMailOrder form = new frmMailOrder();
            form.Show();
            timer1.Stop();
            this.Hide();
            
        }
    }
}
