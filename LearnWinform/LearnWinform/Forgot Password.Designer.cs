namespace LearnWinform
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            pictureBox1 = new PictureBox();
            textBox_EmailRegister = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(290, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox_EmailRegister
            // 
            textBox_EmailRegister.Location = new Point(274, 243);
            textBox_EmailRegister.Name = "textBox_EmailRegister";
            textBox_EmailRegister.Size = new Size(229, 27);
            textBox_EmailRegister.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 250);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 7;
            label1.Text = "Email Register:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 302);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Result:";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(312, 370);
            button1.Name = "button1";
            button1.Size = new Size(139, 30);
            button1.TabIndex = 11;
            button1.Text = "Recover password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_EmailRegister);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Forgot_Password";
            Text = "Forgot_Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_EmailRegister;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}