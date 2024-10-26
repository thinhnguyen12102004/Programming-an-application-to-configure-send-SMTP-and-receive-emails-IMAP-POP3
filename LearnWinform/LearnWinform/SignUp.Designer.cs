namespace LearnWinform
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_UserName = new TextBox();
            textBox_Password = new TextBox();
            pictureBox1 = new PictureBox();
            linkLabel_Register = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            linkLabel_ForgotPassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(299, 377);
            button1.Name = "button1";
            button1.Size = new Size(106, 36);
            button1.TabIndex = 0;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 196);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 256);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(259, 219);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(229, 27);
            textBox_UserName.TabIndex = 3;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(259, 279);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(229, 27);
            textBox_Password.TabIndex = 4;
            textBox_Password.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel_Register
            // 
            linkLabel_Register.AutoSize = true;
            linkLabel_Register.Location = new Point(425, 327);
            linkLabel_Register.Name = "linkLabel_Register";
            linkLabel_Register.Size = new Size(63, 20);
            linkLabel_Register.TabIndex = 8;
            linkLabel_Register.TabStop = true;
            linkLabel_Register.Text = "Register";
            linkLabel_Register.LinkClicked += linkLabel_Register_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(200, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // linkLabel_ForgotPassword
            // 
            linkLabel_ForgotPassword.AutoSize = true;
            linkLabel_ForgotPassword.Location = new Point(220, 327);
            linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            linkLabel_ForgotPassword.Size = new Size(125, 20);
            linkLabel_ForgotPassword.TabIndex = 11;
            linkLabel_ForgotPassword.TabStop = true;
            linkLabel_ForgotPassword.Text = "Forgot Password?";
            linkLabel_ForgotPassword.LinkClicked += linkLabel_ForgotPassword_LinkClicked;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 458);
            Controls.Add(linkLabel_ForgotPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel_Register);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox_UserName;
        private TextBox textBox_Password;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel_Register;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel_ForgotPassword;
    }
}
