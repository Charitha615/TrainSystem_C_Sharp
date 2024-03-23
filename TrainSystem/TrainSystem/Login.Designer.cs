namespace TrainSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            password_textBox2 = new TextBox();
            username_textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(password_textBox2);
            groupBox1.Controls.Add(username_textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Form";
            // 
            // button2
            // 
            button2.Location = new Point(17, 148);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 5;
            button2.Text = "User Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 50);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.Location = new Point(398, 148);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password_textBox2
            // 
            password_textBox2.Location = new Point(150, 111);
            password_textBox2.Name = "password_textBox2";
            password_textBox2.Size = new Size(265, 23);
            password_textBox2.TabIndex = 3;
            // 
            // username_textBox1
            // 
            username_textBox1.Location = new Point(150, 52);
            username_textBox1.Name = "username_textBox1";
            username_textBox1.Size = new Size(265, 23);
            username_textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(520, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox password_textBox2;
        private TextBox username_textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}