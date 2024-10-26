namespace LearnWinform
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            textBox_UserName = new TextBox();
            label1 = new Label();
            textBox_Password = new TextBox();
            label2 = new Label();
            textBox_ConfirmPassword = new TextBox();
            label3 = new Label();
            textBox_Email = new TextBox();
            label4 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(308, 233);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(229, 27);
            textBox_UserName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 236);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "User Name:";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(308, 266);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(229, 27);
            textBox_Password.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 269);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // textBox_ConfirmPassword
            // 
            textBox_ConfirmPassword.Location = new Point(308, 299);
            textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            textBox_ConfirmPassword.Size = new Size(229, 27);
            textBox_ConfirmPassword.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 302);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password:";
            label3.Click += label3_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(308, 332);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(229, 27);
            textBox_Email.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 332);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(358, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(308, 365);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(310, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "I have agreed to the terms and conditions.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox_Email);
            Controls.Add(label4);
            Controls.Add(textBox_ConfirmPassword);
            Controls.Add(label3);
            Controls.Add(textBox_Password);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_UserName);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_UserName;
        private Label label1;
        private TextBox textBox_Password;
        private Label label2;
        private TextBox textBox_ConfirmPassword;
        private Label label3;
        private TextBox textBox_Email;
        private Label label4;
        private Button button1;
        private CheckBox checkBox1;
    }
}