
namespace Elevator
{
    partial class table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1_s = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_num1_as = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_num1_am = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_num2_s = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_num2_as = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_num2_am = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "number 1:";
            // 
            // txt_num1_s
            // 
            // 
            // 
            // 
            this.txt_num1_s.Border.Class = "TextBoxBorder";
            this.txt_num1_s.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num1_s.Location = new System.Drawing.Point(18, 53);
            this.txt_num1_s.Name = "txt_num1_s";
            this.txt_num1_s.PreventEnterBeep = true;
            this.txt_num1_s.Size = new System.Drawing.Size(100, 20);
            this.txt_num1_s.TabIndex = 2;
            this.txt_num1_s.WatermarkText = "عدد صحیح وارد کنید";
            this.txt_num1_s.TextChanged += new System.EventHandler(this.txt_num1_s_TextChanged);
            // 
            // txt_num1_as
            // 
            // 
            // 
            // 
            this.txt_num1_as.Border.Class = "TextBoxBorder";
            this.txt_num1_as.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num1_as.Location = new System.Drawing.Point(18, 80);
            this.txt_num1_as.Name = "txt_num1_as";
            this.txt_num1_as.PreventEnterBeep = true;
            this.txt_num1_as.Size = new System.Drawing.Size(128, 20);
            this.txt_num1_as.TabIndex = 3;
            this.txt_num1_as.WatermarkText = "صورت کسر را وارد کنید";
            this.txt_num1_as.TextChanged += new System.EventHandler(this.txt_num1_as_TextChanged);
            // 
            // txt_num1_am
            // 
            // 
            // 
            // 
            this.txt_num1_am.Border.Class = "TextBoxBorder";
            this.txt_num1_am.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num1_am.Location = new System.Drawing.Point(164, 80);
            this.txt_num1_am.Name = "txt_num1_am";
            this.txt_num1_am.PreventEnterBeep = true;
            this.txt_num1_am.Size = new System.Drawing.Size(128, 20);
            this.txt_num1_am.TabIndex = 4;
            this.txt_num1_am.WatermarkText = "مخرج کسر را وارد کنید";
            this.txt_num1_am.TextChanged += new System.EventHandler(this.txt_num1_am_TextChanged);
            // 
            // txt_num2_s
            // 
            // 
            // 
            // 
            this.txt_num2_s.Border.Class = "TextBoxBorder";
            this.txt_num2_s.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num2_s.Location = new System.Drawing.Point(18, 165);
            this.txt_num2_s.Name = "txt_num2_s";
            this.txt_num2_s.PreventEnterBeep = true;
            this.txt_num2_s.Size = new System.Drawing.Size(100, 20);
            this.txt_num2_s.TabIndex = 5;
            this.txt_num2_s.WatermarkText = "عدد صحیح را وارد کنید";
            this.txt_num2_s.TextChanged += new System.EventHandler(this.txt_num2_s_TextChanged);
            // 
            // txt_num2_as
            // 
            // 
            // 
            // 
            this.txt_num2_as.Border.Class = "TextBoxBorder";
            this.txt_num2_as.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num2_as.Location = new System.Drawing.Point(18, 192);
            this.txt_num2_as.Name = "txt_num2_as";
            this.txt_num2_as.PreventEnterBeep = true;
            this.txt_num2_as.Size = new System.Drawing.Size(128, 20);
            this.txt_num2_as.TabIndex = 6;
            this.txt_num2_as.WatermarkText = "صورت کسر را وارد کنید";
            this.txt_num2_as.TextChanged += new System.EventHandler(this.txt_num2_as_TextChanged);
            // 
            // txt_num2_am
            // 
            // 
            // 
            // 
            this.txt_num2_am.Border.Class = "TextBoxBorder";
            this.txt_num2_am.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_num2_am.Location = new System.Drawing.Point(164, 192);
            this.txt_num2_am.Name = "txt_num2_am";
            this.txt_num2_am.PreventEnterBeep = true;
            this.txt_num2_am.Size = new System.Drawing.Size(128, 20);
            this.txt_num2_am.TabIndex = 7;
            this.txt_num2_am.WatermarkText = "مخرج کسر را وارد کنید";
            this.txt_num2_am.TextChanged += new System.EventHandler(this.txt_num2_am_TextChanged);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "number 2:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(271, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = ".................Show..................";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2_am);
            this.Controls.Add(this.txt_num2_as);
            this.Controls.Add(this.txt_num2_s);
            this.Controls.Add(this.txt_num1_am);
            this.Controls.Add(this.txt_num1_as);
            this.Controls.Add(this.txt_num1_s);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "table";
            this.Load += new System.EventHandler(this.table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num1_s;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num1_as;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num1_am;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num2_s;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num2_as;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_num2_am;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}