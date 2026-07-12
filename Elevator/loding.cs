using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class loding : Form
    {
        public loding()
        {
            InitializeComponent();
        }

        private void loding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)     //باز شدن صفحه لودینگ و مقدار دهیprogressbar
        {
            count++;
            if (count >= 1 && count <= 99)
                progressBar1.Value = count;
            else
            {
                timer1.Stop();this.Close();
            }
        }
    }
}
