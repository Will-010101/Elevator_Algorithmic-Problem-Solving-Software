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
using System.Media;
using System.Resources;

namespace Elevator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string line;
        private void Form1_Load(object sender, EventArgs e)          //بررسی ورود و داشتن اکانت
        {
            
            //File.WriteAllText("name1", "");
            StreamReader sr = File.OpenText("name2");
            if ((line = sr.ReadLine()) == null)
            {
                sr.Close();
                name f = new name();
                f.ShowDialog();
                this.Close();
            }
            sr.Close();
            StreamReader sr1 = File.OpenText("name2");
            label_name.Text = sr1.ReadLine();
            sr1.Close();
            timer1.Start();
            pic_user2.Visible = false;
            pic_help2.Visible = false;
            pic_setting2.Visible = false;
            pic_home2.Visible = true;
            label_name.Text = "Home";
            groupBox_user.Visible = false;
            groupBox_setting.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            groupBox_home.Visible = true;
            groupBox_help.Visible = false;
        }
        int count = 0;
        int count_help = 1;
        int home_flag = 0, setting_flag = 0, user_flag = 0, help_flag = 0;
        
        private void pic_user_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pic_user_MouseLeave(object sender, EventArgs e)
        {
            if(user_flag==0)
            pic_user2.Visible = false;
        }

        private void pic_user_MouseEnter(object sender, EventArgs e)
        {
            pic_user2.Visible = true;
        }

        private void pic_help_MouseEnter(object sender, EventArgs e)
        {
            pic_help2.Visible = true;
        }

        private void pic_help_MouseLeave(object sender, EventArgs e)
        {
            if(help_flag==0)
            pic_help2.Visible = false;
        }

        private void pic_setting_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pic_setting_MouseEnter(object sender, EventArgs e)
        {
            pic_setting2.Visible = true;
        }

        private void pic_setting_MouseLeave(object sender, EventArgs e)
        {
            if(setting_flag==0)
            pic_setting2.Visible = false;
        }

        private void pic_home_MouseEnter(object sender, EventArgs e)
        {
            pic_home2.Visible = true;
        }

        private void pic_home_MouseLeave(object sender, EventArgs e)
        {
            if(home_flag==0)
            pic_home2.Visible = false;
        }

        private void pic_shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_help2_Click(object sender, EventArgs e)
        {

        }

        private void pic_help_MouseDown(object sender, MouseEventArgs e)      //وارد قسمت کمک و راهنمایی شدن
        {
            pic_user2.Visible = false;
            pic_help2.Visible = true;
            pic_setting2.Visible = false;
            pic_home2.Visible = false;
            label_name.Text = "Help";
            toolTip1.SetToolTip(label_name, "Help");
            home_flag = 0; setting_flag = 0; user_flag = 0; help_flag = 1;
            groupBox_user.Visible = false;
            groupBox_setting.Visible = false;
            groupBox_home.Visible = false;
            groupBox_help.Visible = true;
            pictureBox62.Visible = false;
            help1.Visible = true;
            help2.Visible = false;
            count_help = 2;
        }

        private void button1_MouseEnter(object sender, EventArgs e)     //رابط کاربری 
        {
            button1.Width = button1.Width - 3;
            button1.Height = button1.Height - 3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Width = button1.Width + 3;
            button1.Height = button1.Height + 3;
        }

        private void button1_Click(object sender, EventArgs e)     //تغییر اکانت وارد شده
        {
            File.WriteAllText("add", "ch");
            name f = new name();
            f.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label7.Visible = false; label8.Visible = true;
            label9.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            button5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label7.Visible = true; label8.Visible = false;
            label9.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            button5.Visible = false;
        }
        int y = 0;
        private void timer1_Tick(object sender, EventArgs e)     //نمایش صفحه لودینگ
        {
            count++;
            loding m = new loding();
            if (count == 1)
                m.ShowDialog();
            else if (count > 1 && count < 100)
                y++;
            else
            {
                m.Close();
                Stream stream = Properties.Resources.aha;
                SoundPlayer player = new SoundPlayer(stream);
                player.Play();
                timer1.Stop();
            }
        }

        private void groupBox_setting_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)       //تغییر رنگ متون از طریق groupbox ها 
        {
            name n = new name();
            table s = new table();
            colorDialog1.ShowDialog();
            foreach (Control b in s.Controls)
                b.ForeColor = colorDialog1.Color;
            foreach (Control b in n.Controls)
                b.ForeColor = colorDialog1.Color;
            foreach (Control b in groupBox_user.Controls)
                b.ForeColor = colorDialog1.Color;
            foreach (Control b in groupBox_help.Controls)
                b.ForeColor = colorDialog1.Color;
            foreach (Control b in groupBox_home.Controls)
                b.ForeColor = colorDialog1.Color;
            foreach (Control b in groupBox_setting.Controls)
                b.ForeColor = colorDialog1.Color;
        }
        private void x2_MouseEnter(object sender, EventArgs e)       //تغییرات اندازه برای ui
        {
                x1.Width = x1.Width - 7;
                x1.Height = x1.Height - 7;
                x2.Width = x2.Width - 7;
                x2.Height = x2.Height - 7;
        }

        private void x2_MouseLeave(object sender, EventArgs e)
        {
            x1.Width = x1.Width + 7;
            x1.Height = x1.Height + 7;
            x2.Width = x2.Width + 7;
            x2.Height = x2.Height + 7;
        }

        private void y2_MouseEnter(object sender, EventArgs e)
        {
            y1.Width = y1.Width - 7;
            y1.Height = y1.Height - 7;
            y2.Width = y2.Width - 7;
            y2.Height = y2.Height - 7;
        }

        private void y2_MouseLeave(object sender, EventArgs e)
        {
            y1.Width = y1.Width + 7;
            y1.Height = y1.Height + 7;
            y2.Width = y2.Width + 7;
            y2.Height = y2.Height + 7;
        }

        private void button3_Click(object sender, EventArgs e)          //باتن شروع اهنگ
        {
            Stream stream = Properties.Resources.aha;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)        //باتن پایان اهنگ
        {
            Stream stream = Properties.Resources.aha;
            SoundPlayer player = new SoundPlayer(stream);
            player.Stop();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox62.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox62.Visible = false;
        }

        private void pictureBox_next_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_next_MouseDown(object sender, MouseEventArgs e)    //برای قسمت راهنمایی
        {
            if (count_help == 1)
            {
                help1.Visible = true;
                help2.Visible = false;
                count_help++;
            }
            else if (count_help == 2)
            {
                help1.Visible = false;
                help2.Visible = true;
                count_help=1;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)         //برای رابط کاربری زیبا
        {
            button2.Width = button2.Width - 6;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Width = button2.Width + 6;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Width = button3.Width - 6;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Width = button3.Width + 6;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Width = button4.Width - 6;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Width = button4.Width + 6;
        }

        private void x2_Click(object sender, EventArgs e)          //باز کردن فرم جدول ضرب
        {
            table n = new table();
            n.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)      //تعیین فونت ها از طریق groupbox
        {
            name n = new name();
            table s = new table();
            fontDialog1.ShowDialog();
            foreach (Control b in n.Controls)
                b.Font = fontDialog1.Font;
            foreach (Control b in s.Controls)
                b.Font = fontDialog1.Font;
            foreach(Control b in groupBox_user.Controls)
                b.Font = fontDialog1.Font;
            foreach (Control b in groupBox_help.Controls)
                b.Font = fontDialog1.Font;
            foreach (Control b in groupBox_setting.Controls)
                b.Font = fontDialog1.Font;
            foreach (Control b in groupBox_home.Controls)
                b.Font = fontDialog1.Font;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Width = button5.Width - 6;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Width = button5.Width + 6;
        }

        private void y2_Click(object sender, EventArgs e)         //باز کردن فرم اسانسور
        {
            elevator em = new elevator();
            em.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)       //دکمه اضافه کردن اکانت
        {
            File.WriteAllText("add", "add");
            name f = new name();
            f.ShowDialog();

        }

        private void pic_user_MouseDown(object sender, MouseEventArgs e)      //وارد قسمت اطلاعات کاربری شدن
        {
            pic_user2.Visible = true;
            pic_help2.Visible = false;
            pic_setting2.Visible = false;
            pic_home2.Visible = false;
            label_name.Text = "User information";
            toolTip1.SetToolTip(label_name, "User information");
            home_flag = 0; setting_flag = 0; user_flag = 1; help_flag = 0;
            groupBox_user.Visible = true;
            groupBox_setting.Visible = false;
            groupBox_home.Visible = false;
            groupBox_help.Visible = false;
            StreamReader sr2 = File.OpenText("name2");
            label3.Text = sr2.ReadLine();
            label4.Text= sr2.ReadLine();
            sr2.Close();
        }

        private void pic_setting_MouseDown(object sender, MouseEventArgs e)     //وارد قسمت تنظیمات شدن
        {
            pic_user2.Visible = false;
            pic_help2.Visible = false;
            pic_setting2.Visible = true;
            pic_home2.Visible = false;
            label_name.Text = "Setting";
            toolTip1.SetToolTip(label_name, "Setting");
            home_flag = 0; setting_flag = 1; user_flag = 0; help_flag = 0;
            groupBox_user.Visible = false;
            groupBox_setting.Visible = true;
            groupBox_help.Visible = false;
            label7.Visible = false;label8.Visible = true;
            label9.Visible = false;
            groupBox_home.Visible = false;
            label7.Visible = false; label8.Visible = true;
            label9.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            button5.Visible = true;
        }

        private void pic_home_MouseDown(object sender, MouseEventArgs e)  //وارد قسمت خانه شدن
        {
            pic_user2.Visible = false;
            pic_help2.Visible = false;
            pic_setting2.Visible = false;
            pic_home2.Visible = true;
            label_name.Text = "Home";
            toolTip1.SetToolTip(label_name, "Home");
            home_flag = 1; setting_flag = 0; user_flag = 0; help_flag = 0;
            groupBox_user.Visible = false;
            groupBox_setting.Visible = false;
            groupBox_home.Visible = true;
            groupBox_help.Visible = false;
        }
    }
}
