
namespace Elevator
{
    partial class elevator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevator));
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.txt_start_array = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt__startpos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_start = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_finish = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txt_finish_array = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.BackgroundImage")));
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Location = new System.Drawing.Point(270, 12);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(52, 42);
            this.pictureBox_home.TabIndex = 0;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // txt_start_array
            // 
            // 
            // 
            // 
            this.txt_start_array.Border.Class = "TextBoxBorder";
            this.txt_start_array.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_start_array.Location = new System.Drawing.Point(12, 93);
            this.txt_start_array.Name = "txt_start_array";
            this.txt_start_array.PreventEnterBeep = true;
            this.txt_start_array.Size = new System.Drawing.Size(90, 20);
            this.txt_start_array.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_start_array, "نقطه شروع مسیری که اسانسور می تواند طی کند را وارد کنید");
            this.txt_start_array.WatermarkText = "از کدام طبقه؟";
            // 
            // txt__startpos
            // 
            // 
            // 
            // 
            this.txt__startpos.Border.Class = "TextBoxBorder";
            this.txt__startpos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt__startpos.Location = new System.Drawing.Point(12, 143);
            this.txt__startpos.Name = "txt__startpos";
            this.txt__startpos.PreventEnterBeep = true;
            this.txt__startpos.Size = new System.Drawing.Size(100, 20);
            this.txt__startpos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt__startpos, "مکان اولیه استقرار اسانسور را وارد کنید");
            this.txt__startpos.WatermarkText = "مکان اولیه؟؟";
            this.txt__startpos.TextChanged += new System.EventHandler(this.txt__startpos_TextChanged);
            // 
            // txt_start
            // 
            // 
            // 
            // 
            this.txt_start.Border.Class = "TextBoxBorder";
            this.txt_start.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_start.Location = new System.Drawing.Point(12, 196);
            this.txt_start.Name = "txt_start";
            this.txt_start.PreventEnterBeep = true;
            this.txt_start.Size = new System.Drawing.Size(229, 20);
            this.txt_start.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_start, "از کدام طبقه می خواهید حرکت کنید؟");
            this.txt_start.WatermarkText = "از کجا شروع کنیم؟";
            this.txt_start.TextChanged += new System.EventHandler(this.txt_start_TextChanged);
            // 
            // txt_finish
            // 
            // 
            // 
            // 
            this.txt_finish.Border.Class = "TextBoxBorder";
            this.txt_finish.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_finish.Location = new System.Drawing.Point(12, 246);
            this.txt_finish.Name = "txt_finish";
            this.txt_finish.PreventEnterBeep = true;
            this.txt_finish.Size = new System.Drawing.Size(167, 20);
            this.txt_finish.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txt_finish, "به کدام طبقه می خواهید بروید؟");
            this.txt_finish.WatermarkText = "به کجا بریم؟";
            this.txt_finish.TextChanged += new System.EventHandler(this.txt_finish_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(209, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "...next...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(118, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "..........yes..........";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(247, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "..yes..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(185, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = ".....yes.....";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-42, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 307);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBoxEx1
            // 
            this.richTextBoxEx1.BackColorRichTextBox = System.Drawing.Color.BlueViolet;
            this.richTextBoxEx1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("richTextBoxEx1.BackgroundImage")));
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx1.ForeColor = System.Drawing.Color.White;
            this.richTextBoxEx1.Location = new System.Drawing.Point(225, 292);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Rtf = resources.GetString("richTextBoxEx1.Rtf");
            this.richTextBoxEx1.Size = new System.Drawing.Size(80, 275);
            this.richTextBoxEx1.TabIndex = 10;
            // 
            // txt_finish_array
            // 
            // 
            // 
            // 
            this.txt_finish_array.Border.Class = "TextBoxBorder";
            this.txt_finish_array.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_finish_array.Location = new System.Drawing.Point(108, 93);
            this.txt_finish_array.Name = "txt_finish_array";
            this.txt_finish_array.PreventEnterBeep = true;
            this.txt_finish_array.Size = new System.Drawing.Size(95, 20);
            this.txt_finish_array.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txt_finish_array, "نقطه پایان مسیری که اسانسور می تواند طی کند را وارد کنید");
            this.txt_finish_array.WatermarkText = "به کدام طبقه؟";
            this.txt_finish_array.TextChanged += new System.EventHandler(this.txt_finish_array_TextChanged);
            // 
            // elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 595);
            this.Controls.Add(this.txt_finish_array);
            this.Controls.Add(this.richTextBoxEx1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_finish);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.txt__startpos);
            this.Controls.Add(this.txt_start_array);
            this.Controls.Add(this.pictureBox_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "elevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "elevator";
            this.Load += new System.EventHandler(this.elevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_home;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_start_array;
        private DevComponents.DotNetBar.Controls.TextBoxX txt__startpos;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_start;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_finish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_finish_array;
    }
}