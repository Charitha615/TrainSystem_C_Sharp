namespace TrainSystem
{
    partial class User_Registation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Registation));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            passwordtextBox4 = new TextBox();
            label6 = new Label();
            contacttextBox3 = new TextBox();
            label5 = new Label();
            addressrichTextBox1 = new RichTextBox();
            label4 = new Label();
            email_textBox2 = new TextBox();
            label3 = new Label();
            username_textBox1 = new TextBox();
            label2 = new Label();
            Login = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 241);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 1;
            label1.Text = "User Registration";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(passwordtextBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(contacttextBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(addressrichTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(email_textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(username_textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(283, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passwordtextBox4
            // 
            passwordtextBox4.Location = new Point(107, 146);
            passwordtextBox4.Name = "passwordtextBox4";
            passwordtextBox4.Size = new Size(251, 23);
            passwordtextBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 150);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // contacttextBox3
            // 
            contacttextBox3.Location = new Point(107, 101);
            contacttextBox3.Name = "contacttextBox3";
            contacttextBox3.Size = new Size(251, 23);
            contacttextBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 104);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Contact";
            // 
            // addressrichTextBox1
            // 
            addressrichTextBox1.Location = new Point(107, 197);
            addressrichTextBox1.Name = "addressrichTextBox1";
            addressrichTextBox1.Size = new Size(251, 57);
            addressrichTextBox1.TabIndex = 6;
            addressrichTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 197);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // email_textBox2
            // 
            email_textBox2.Location = new Point(107, 59);
            email_textBox2.Name = "email_textBox2";
            email_textBox2.Size = new Size(251, 23);
            email_textBox2.TabIndex = 3;
            email_textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 62);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // username_textBox1
            // 
            username_textBox1.Location = new Point(107, 16);
            username_textBox1.Name = "username_textBox1";
            username_textBox1.Size = new Size(251, 23);
            username_textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 19);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.ForeColor = Color.Blue;
            Login.Location = new Point(399, 12);
            Login.Name = "Login";
            Login.Size = new Size(37, 15);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // User_Registation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(445, 589);
            Controls.Add(Login);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "User_Registation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Registation";
            Load += User_Registation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox email_textBox2;
        private Label label3;
        private TextBox username_textBox1;
        private Label label2;
        private TextBox passwordtextBox4;
        private Label label6;
        private TextBox contacttextBox3;
        private Label label5;
        private RichTextBox addressrichTextBox1;
        private Label label4;
        private Button button1;
        private Label Login;
    }
}