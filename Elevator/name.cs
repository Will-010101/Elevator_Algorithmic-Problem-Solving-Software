using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace Elevator
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)       //پیدا کردن نام کاربری و رمز از فایل و اعتبار سنجی و ورود
        {
            string line;
            StreamReader sr = File.OpenText("name1");
            int a = 1;
            while((line = sr.ReadLine()) != null)
            {
                if (a % 2 != 0)
                {
                    if (line == tex_username.Text)
                    {
                        if ((line = sr.ReadLine()) == tex_password.Text)
                        {
                            string user = tex_username.Text + "\n" + tex_password.Text;
                            sr.Close();
                            File.WriteAllText("name2", user);
                            Form1 m = new Form1();
                            m.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            sr.Close(); MessageBox.Show("رمز عبور صحیح نیست");
                        }
                        return;
                    }
                }
                a++;
            }
            MessageBox.Show("نام کاربری صحیح نیست");
            sr.Close();
            return;
        }
        private void button1_Click(object sender, EventArgs e)   //اد کردن نام کاربر جدید
        {
            string line, u="";
            StreamReader sr = File.OpenText("name1");
            while ((line = sr.ReadLine()) != null)
            {
                u += line + "\n";
            }
            sr.Close();
            u += tex_username.Text + "\n" + tex_password.Text;
            File.WriteAllText("name1", u);
            string user = tex_username.Text + "\n" + tex_password.Text;
            File.WriteAllText("name2", user);
            Form1 m = new Form1();
            m.ShowDialog();
            this.Close();
        }

        private void name_Load(object sender, EventArgs e)      //لود شدن صفحه کاربری
        {
            StreamReader sr = File.OpenText("add");
            string line;
            line = sr.ReadLine();
            if (line == "ch")
            { button1.Visible = false; button_login.Visible = true; }
            else
            { button1.Visible = true; button_login.Visible = false; }
        }
    }
}
