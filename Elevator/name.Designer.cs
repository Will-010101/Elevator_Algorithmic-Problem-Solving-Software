
namespace Elevator
{
    partial class name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(name));
            this.button_login = new System.Windows.Forms.Button();
            this.tex_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tex_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Gray;
            this.button_login.Font = new System.Drawing.Font("Brush Script MT", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(31, 260);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(249, 71);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // tex_username
            // 
            // 
            // 
            // 
            this.tex_username.Border.Class = "TextBoxBorder";
            this.tex_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tex_username.Location = new System.Drawing.Point(31, 156);
            this.tex_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_username.Name = "tex_username";
            this.tex_username.PreventEnterBeep = true;
            this.tex_username.Size = new System.Drawing.Size(249, 22);
            this.tex_username.TabIndex = 3;
            this.tex_username.WatermarkText = "Please enter a username";
            // 
            // tex_password
            // 
            // 
            // 
            // 
            this.tex_password.Border.Class = "TextBoxBorder";
            this.tex_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tex_password.Location = new System.Drawing.Point(31, 202);
            this.tex_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tex_password.Name = "tex_password";
            this.tex_password.PreventEnterBeep = true;
            this.tex_password.Size = new System.Drawing.Size(249, 22);
            this.tex_password.TabIndex = 4;
            this.tex_password.WatermarkText = "Please enter the password";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 126);
            this.label1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Brush Script MT", 30F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(31, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(312, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_password);
            this.Controls.Add(this.tex_username);
            this.Controls.Add(this.button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "name";
            this.Load += new System.EventHandler(this.name_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_login;
        private DevComponents.DotNetBar.Controls.TextBoxX tex_username;
        private DevComponents.DotNetBar.Controls.TextBoxX tex_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}