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
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void table_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string number;
        private void txt_num1_s_TextChanged(object sender, EventArgs e) //اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num1_s.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void txt_num2_s_TextChanged(object sender, EventArgs e)//اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num2_s.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void txt_num1_as_TextChanged(object sender, EventArgs e)//اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num1_as.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void txt_num1_am_TextChanged(object sender, EventArgs e)//اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num1_am.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void txt_num2_as_TextChanged(object sender, EventArgs e)//اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num2_as.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void txt_num2_am_TextChanged(object sender, EventArgs e)//اعتبار سنجی مقادیر وارد شده در تکست باکس
        {
            number = txt_num2_am.Text;
            if (number.Contains(".")) MessageBox.Show("عدد نمیتواند نقطه داشته باشد");
            if (number.Contains("/")) MessageBox.Show("عدد نمیتواند ممیز داشته باشد");
        }

        private void button1_MouseEnter(object sender, EventArgs e)    //رابط کابری
        {
            button1.Width = button1.Width - 4;
            button1.Height = button1.Height - 4;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Width = button1.Width + 4;
            button1.Height = button1.Height + 4;
                                                }
        
        private int number_s (int num1,int num2, int num3)     //تابع پیدا کردن تعداد عدد صحیح در کسر اگر باشد
        {
            int b = num2 % num3;
            num2 -= b;
            return num2/num3;

        }

        private int x(int num1,int num2,int num3, int num4, int num5, int num6)      //تابع یافتن ک.م.م برای اندازه پیکسل ها و اعتبار سنجی اعداد
        {
            int max;
            if (num3 > num6)
                max = num3;
            else
                max = num6;
            while(max<310)
            {
                if(max==309)
                {
                    MessageBox.Show("در نمایش این عدد محدودیت پیکسل وجود دارد");
                    return 0;
                }
                if(max%num3==0 && max%num6==0)
                {
                    break;
                }
                max++;
            }
            if(num2==0|| num5==0)
            {
                if ((num1 * max) < 310 && (num4 * max) < 310)
                {
                    if (max < 15)
                        max *= 3;
                    return max;
                }
            }    
            if ((num1 * max) + (max / num2) < 310 && (num4 * max) + (max / num5) < 310)
            {
                if (max < 15)
                    max *= 3;
                return max;
            }
            MessageBox.Show("در نمایش این عدد محدودیت پیکسل وجود دارد");
            return 0;
        }
        Button b = new Button();
        private void drow_s(int num1, int num2, int m)    //تابع کشیدن قسمت های صحیح جدول
        {
            for(int i=0;i<num1;i++)
            {
                for(int j=0;j<num2;j++)
                {
                    Button b = new Button();
                    b.Top = (j * m)+276;
                    b.Left = (i * m) + 12;
                    b.Width = m;
                    b.Height = m;
                    b.BackColor = Color.HotPink;
                    b.FlatStyle = FlatStyle.Flat;
                    b.Text = "";
                    this.Controls.Add(b);
                }
            }
            return ;
        }
        private void drow_a(int num1,int num2,int num3,int num4,int num5,int num6,int m)   //تابع کشیدن قسمت های اعشاری جدول
        {
            for(int i=0;i<num2;i++)
            {
                Button b = new Button();
                b.Top = (i * m) + 276;
                b.Left = (num1 * m) + 12;
                b.Width = num3*m/num5;
                b.Height = m;
                b.BackColor = Color.MediumVioletRed;
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "";
                this.Controls.Add(b);
            }
            for (int i = 0; i < num1; i++)
            {
                Button b = new Button();
                b.Top = (num2 * m) + 276;
                b.Left = (i * m) + 12;
                b.Width = m;
                b.Height = num4 * m / num6;
                b.BackColor = Color.DarkMagenta;
                b.FlatStyle = FlatStyle.Flat;
                b.Text = "";
                this.Controls.Add(b);
            }
            Button d = new Button();
            d.Top = (num2 * m) + 276;
            d.Left = (num1* m) + 12;
            d.Width = num3 * m / num5; ;
            d.Height = num4 * m / num6;
            d.BackColor = Color.White;
            d.FlatStyle = FlatStyle.Flat;
            d.Text = "";
            this.Controls.Add(d);
            return;
        }
        int meghdar_x;
        private void droww(int num1,int num2,int r,int x,int y)   //تابع کشیدن اعداد بی عدد صحیح
        {
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Button c = new Button();
                    c.Top = (j * 20) + x;
                    c.Left = (i * 20) + y;
                    c.Width = 20;
                    c.Height = 20;
                    if (r == 1) c.BackColor = Color.White;
                    if (r == 2) c.BackColor = Color.HotPink;
                    if (r == 3) c.BackColor = Color.Pink;
                    if (r == 4) c.BackColor = Color.DarkMagenta;
                    c.FlatStyle = FlatStyle.Flat;
                    c.Text = "";
                    this.Controls.Add(c);
                }
            }
            return ;
        }                                                      //باتن نمایش جدول ضرب
        private void button1_Click(object sender, EventArgs e) //اعتبار سنجی اعداد و ارجاع انها به توابع
        {
            
            if (txt_num1_s.Text == "" && txt_num1_as.Text == "" && txt_num1_am.Text == "") MessageBox.Show("برای عدد اول مقدار وارد کنید");
            else if (txt_num2_s.Text == "" && txt_num2_as.Text == "" && txt_num2_am.Text == "") MessageBox.Show("برای عدد دوم مقدار وارد کنید");
            else if (txt_num1_am.Text == "0") MessageBox.Show("مخرج عدد اول قابل قبول نیست ");
            else if (txt_num2_am.Text == "0") MessageBox.Show("مخرج عدد دوم قابل قبول نیست ");
            else if (txt_num1_as.Text == "" && txt_num1_am.Text != "") MessageBox.Show("صورت عدد اول را وارد کنید");
            else if (txt_num1_as.Text != "" && txt_num1_am.Text == "") MessageBox.Show("مخرج عدد اول را وارد کنید");
            else if (txt_num2_as.Text == "" && txt_num2_am.Text != "") MessageBox.Show("صورت عدد دوم را وارد کنید");
            else if (txt_num2_as.Text != "" && txt_num2_am.Text == "") MessageBox.Show("مخرج عدد دوم را وارد کنید");
            
            else 
            {
                if (txt_num1_am.Text == "" && txt_num1_as.Text == "")
                { txt_num1_as.Text = "0"; txt_num1_am.Text = "1"; }
                if (txt_num2_am.Text == "" && txt_num2_as.Text == "")
                { txt_num2_as.Text = "0"; txt_num2_am.Text = "1"; }
                int num1_s = Convert.ToInt16(txt_num1_s.Text);
                int num1_as = Convert.ToInt16(txt_num1_as.Text);
                int num1_am = Convert.ToInt16(txt_num1_am.Text);
                int num2_s = Convert.ToInt16(txt_num2_s.Text);
                int num2_as = Convert.ToInt16(txt_num2_as.Text);
                int num2_am = Convert.ToInt16(txt_num2_am.Text);
                if (num1_as >= num1_am) { num1_s += number_s(num1_s, num1_as, num1_am); num1_as = num1_as % num1_am;  }
                if (num2_as >= num2_am) { num2_s += number_s(num2_s, num2_as, num2_am); num2_as = num2_as % num2_am;  }
                if (txt_num1_s.Text == "0" && txt_num2_s.Text == "0")
                {
                    droww(num1_as, num2_as, 1, 276, 12);
                    droww(num1_am - num1_as, num2_as, 2, 276, (num1_as * 20)+12);
                    droww(num1_as, num2_am - num2_as, 3, (num2_as * 20)+276, 12);
                    droww(num1_am - num1_as, num2_am - num2_as, 4, (num2_as * 20)+276, (num1_as * 20+12));
                    button1.Enabled = false;
                    
                }
                else if (x(num1_s, num1_as, num1_am,num2_s,num2_as,num2_am) !=0)
                {
                    meghdar_x = x(num1_s, num1_as, num1_am, num2_s, num2_as, num2_am);
                    drow_s(num1_s, num2_s, meghdar_x);
                    drow_a(num1_s, num2_s, num1_as, num2_as, num1_am, num2_am, meghdar_x);
                    button1.Visible = false;
                }
                else MessageBox.Show("در نمایش این عدد محدودیت پیکسل وجود دارد");
            }
            
        }
    }
}
