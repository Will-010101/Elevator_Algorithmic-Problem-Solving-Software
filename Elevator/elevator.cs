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
    public partial class elevator : Form
    {
        public elevator()
        {
            InitializeComponent();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_finish_array_TextChanged(object sender, EventArgs e) //اعتبار سنحی مقادیر
        {
            if (txt_start_array.Text == "")
                MessageBox.Show("اول نقطه شروع را وارد کنید");
        }

        private void txt__startpos_TextChanged(object sender, EventArgs e)   //اعتبار سنحی مقادیر
        {
            if (txt_start_array.Text == "" || txt_finish_array.Text == "")
                MessageBox.Show("خانه های قبلی را پر کنید");
        }

        private void txt_start_TextChanged(object sender, EventArgs e)   //اعتبار سنحی مقادیر
        {
            if (txt_start_array.Text == "" || txt_finish_array.Text == "" || txt__startpos.Text == "")
                MessageBox.Show("خانه های قبلی را پر کنید");
        }

        private void txt_finish_TextChanged(object sender, EventArgs e) //اعتبار سنحی مقادیر
        {
            if (txt_start_array.Text == "" || txt_finish_array.Text == "" || txt__startpos.Text == "" || txt_start.Text == "")
                MessageBox.Show("خانه های قبلی را پر کنید");
        }

        int[ , ] array_way = new int [2 , 1000];
        int[] way = new int[1000];
        int startpos, startway, finishway, count = 0;
        private void button1_Click(object sender, EventArgs e) //ثبت خانه های مسیر
        { 
            if (txt_start_array.Text == "" || txt_finish_array.Text == "")    //اعتبار سنحی مقادیر
            { MessageBox.Show("مقدار ها را وارد کنید"); return; }
            array_way[0, count] = Convert.ToInt32(txt_start_array.Text);
            array_way[1, count] = Convert.ToInt32(txt_finish_array.Text);
            count++;
            MessageBox.Show("ثبت شد ");
        }

        private void button2_Click(object sender, EventArgs e)  //ثبت محل استقرار اولیه اسانسور
        {
            if (txt__startpos.Text=="")
            { MessageBox.Show("مقدار ها را وارد کنید"); return; }
            startpos = Convert.ToInt32(txt__startpos.Text);
            MessageBox.Show("ثبت شد ");
        }

        private void button3_Click(object sender, EventArgs e) //ثبت محل شروع حرکت
        {
            if(txt_start.Text=="")
            { MessageBox.Show("مقدار ها را وارد کنید"); return; }
            startway = Convert.ToInt32(txt_start.Text);
            MessageBox.Show("ثبت شد ");
        }

        private void elevator_Load(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)  //ثبت مکان پایان حرکت و سپس نمایش پاسخ با ارجاع دادن به توابع مرتبط
        {
            if (txt_finish.Text == "")
            { MessageBox.Show("مقدار ها را وارد کنید"); return; }
            if (txt_start_array.Text == "0" || txt_finish_array.Text == "0" || txt__startpos.Text == "0" || txt_start.Text == "0" || txt_finish.Text == "0")
            { MessageBox.Show("نمیتوانید عدد صفر را وارد کنید"); return; }
            finishway = Convert.ToInt32(txt_finish.Text);
            if(search(array_way,startpos,startway,finishway)==false)
            { richTextBoxEx1.Text = "NO"; return; }
            way[0] = finishway;
            button4.Enabled = false;
            if(x(finishway,startway)==0)
            { richTextBoxEx1.Text = "NO" ; return; }
            else
            {   if (startpos != startway)
                {
                    int a = 0; while (way[a] != 0) { way[a] = 0; a++; }
                    way[0] = startway;
                    if (x(startway, startpos) == 0)
                    { richTextBoxEx1.Text = "NO"; return; }
                    richTextBoxEx1.Text = "YES\n";
                    richTextBoxEx1.Text += (startpos.ToString() + "\n");
                    int u = 1; while (way[u] != 0) { richTextBoxEx1.Text += way[u].ToString() + "\n"; u++; }
                    u = 0; while (way[u] != 0) { way[u] = 0; u++; }
                    way[0] = finishway;
                    int y = x(finishway, startway);
                    richTextBoxEx1.Text += (startway.ToString() + "\n");
                    u = 1; while (way[u] != 0) { richTextBoxEx1.Text += way[u].ToString() + "\n"; u++; }
                    richTextBoxEx1.Text += finishway.ToString() + "\n";
                }
                else
                {

                    richTextBoxEx1.Text = "YES\n";
                    richTextBoxEx1.Text += (startway.ToString() + "\n");
                    int u = 1; while (way[u] != 0) { richTextBoxEx1.Text += way[u].ToString()+"\n"; u++; }
                    richTextBoxEx1.Text += finishway.ToString();
                }
            }
        }
        public int x(int num,int num1)      //تابع بازگشتی یافتن مسیر مناسب
        {

            int flag_fine = 0, flag = 0, flag2 = 0;
            for(int i=0;i<count;i++)
            {
                if (num == array_way[1, i])
                {
                    flag_fine = 1;
                    if (array_way[0, i] == num1)
                        return 1;

                    int a = 0;
                    flag = 0;
                    while(way[a]!=0)
                    {
                        if (way[a] == array_way[0, i])
                        {
                            
                            flag = 1;
                            break;
                        }
                        a++;
                    }
                    if (flag == 0)
                    {
                        flag2 = 1;
                        
                        if(x(array_way[0, i], num1)!=0)
                        {
                            int o = 0;
                            while (way[o] != 0)
                                o++;
                            way[o] = array_way[0, i];
                            return 1;
                        }

                    }
                }
               
            }
            if (flag2 == 0)
            {
              return 0; }
            if (flag_fine == 0)
            { return 0; }
             return 0;
        }
        private bool search (int[ , ] wa ,int s, int start , int finish)    //تابع سرچ در ارایه برای اعتبار سنجی اعداد وارد شده
        {
            int flag_start = 0, flag_finish = 0, flag_s = 0;
            for(int i=0;i<count;i++)
            {
                if (wa[0, i] == start)
                    flag_start = 1;
                if (wa[0, i] == s)
                    flag_s = 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (wa[1, i] == finish)
                    flag_finish = 1;
            }
            if (flag_finish == 0 || flag_start == 0 || flag_s == 0)
                return false;
            return true;
        }
            
    }
}
