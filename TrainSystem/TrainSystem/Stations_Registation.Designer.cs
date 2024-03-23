namespace TrainSystem
{
    partial class Stations_Registation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stations_Registation));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            IDtextBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            routenumbertextBox1 = new TextBox();
            label6 = new Label();
            routeidtextBox2 = new TextBox();
            label7 = new Label();
            selectroutecomboBox2 = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 5;
            label1.Text = "Stations Registation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(IDtextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 128);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Station Details";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 25);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 10;
            label4.Text = "Station Name";
            // 
            // IDtextBox1
            // 
            IDtextBox1.Location = new Point(114, 75);
            IDtextBox1.Name = "IDtextBox1";
            IDtextBox1.ReadOnly = true;
            IDtextBox1.Size = new Size(89, 23);
            IDtextBox1.TabIndex = 8;
            IDtextBox1.Text = "Can't Edit ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Station ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(routenumbertextBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(routeidtextBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(selectroutecomboBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 150);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Route Details";
            // 
            // routenumbertextBox1
            // 
            routenumbertextBox1.Location = new Point(114, 121);
            routenumbertextBox1.Name = "routenumbertextBox1";
            routenumbertextBox1.ReadOnly = true;
            routenumbertextBox1.Size = new Size(246, 23);
            routenumbertextBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 124);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 17;
            label6.Text = "Route Number";
            // 
            // routeidtextBox2
            // 
            routeidtextBox2.Location = new Point(114, 78);
            routeidtextBox2.Name = "routeidtextBox2";
            routeidtextBox2.ReadOnly = true;
            routeidtextBox2.Size = new Size(89, 23);
            routeidtextBox2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 78);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // selectroutecomboBox2
            // 
            selectroutecomboBox2.FormattingEnabled = true;
            selectroutecomboBox2.Location = new Point(114, 33);
            selectroutecomboBox2.Name = "selectroutecomboBox2";
            selectroutecomboBox2.Size = new Size(246, 23);
            selectroutecomboBox2.TabIndex = 14;
            selectroutecomboBox2.Tag = "";
            selectroutecomboBox2.SelectedIndexChanged += selectroutecomboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 33);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 13;
            label5.Text = "Select Route";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(89, 530);
            button3.Name = "button3";
            button3.Size = new Size(92, 33);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(189, 530);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(292, 530);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Stations_Registation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 575);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Stations_Registation";
            Text = "Stations_Registation";
            Load += Stations_Registation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox IDtextBox1;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox selectroutecomboBox2;
        private Label label5;
        private TextBox routenumbertextBox1;
        private Label label6;
        private TextBox routeidtextBox2;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}