namespace TrainSystem
{
    partial class Train_Registation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train_Registation));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            endnumericUpDown2 = new NumericUpDown();
            label18 = new Label();
            startnumericUpDown1 = new NumericUpDown();
            label2 = new Label();
            groupBox3 = new GroupBox();
            startroutetextBox2 = new TextBox();
            startroutenumbertextBox1 = new TextBox();
            label7 = new Label();
            startrouteidtextBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            startstationnamecomboBox2 = new ComboBox();
            label5 = new Label();
            startstationidtextBox1 = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            endroute2textBox3 = new TextBox();
            endroutenumber2textBox4 = new TextBox();
            label10 = new Label();
            endrouteid2textBox5 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            endstationnamecomboBox3 = new ComboBox();
            label13 = new Label();
            endtstationidtextBox1 = new TextBox();
            label14 = new Label();
            groupBox4 = new GroupBox();
            checkBox2weeekend = new CheckBox();
            checkBox1weekday = new CheckBox();
            trainnamecomboBox4 = new ComboBox();
            label15 = new Label();
            trainIDtextBox7 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endnumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startnumericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 7;
            label1.Text = "Train Registation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endnumericUpDown2);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(startnumericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 116);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Train Seat";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // endnumericUpDown2
            // 
            endnumericUpDown2.Location = new Point(126, 71);
            endnumericUpDown2.Name = "endnumericUpDown2";
            endnumericUpDown2.Size = new Size(58, 23);
            endnumericUpDown2.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 73);
            label18.Name = "label18";
            label18.Size = new Size(98, 15);
            label18.TabIndex = 28;
            label18.Text = "Seat No. Final No";
            // 
            // startnumericUpDown1
            // 
            startnumericUpDown1.Location = new Point(126, 30);
            startnumericUpDown1.Name = "startnumericUpDown1";
            startnumericUpDown1.Size = new Size(58, 23);
            startnumericUpDown1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 10;
            label2.Text = "Seat No. Starting No";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(startroutetextBox2);
            groupBox3.Controls.Add(startroutenumbertextBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(startrouteidtextBox2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(startstationnamecomboBox2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(startstationidtextBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(18, 434);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 239);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Start Station ";
            // 
            // startroutetextBox2
            // 
            startroutetextBox2.Location = new Point(114, 122);
            startroutetextBox2.Name = "startroutetextBox2";
            startroutetextBox2.ReadOnly = true;
            startroutetextBox2.Size = new Size(246, 23);
            startroutetextBox2.TabIndex = 25;
            // 
            // startroutenumbertextBox1
            // 
            startroutenumbertextBox1.Location = new Point(114, 210);
            startroutenumbertextBox1.Name = "startroutenumbertextBox1";
            startroutenumbertextBox1.ReadOnly = true;
            startroutenumbertextBox1.Size = new Size(246, 23);
            startroutenumbertextBox1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 213);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 23;
            label7.Text = "Route Number";
            // 
            // startrouteidtextBox2
            // 
            startrouteidtextBox2.Location = new Point(114, 167);
            startrouteidtextBox2.Name = "startrouteidtextBox2";
            startrouteidtextBox2.ReadOnly = true;
            startrouteidtextBox2.Size = new Size(89, 23);
            startrouteidtextBox2.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 167);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 21;
            label8.Text = "Route ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 122);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 19;
            label9.Text = "Route";
            // 
            // startstationnamecomboBox2
            // 
            startstationnamecomboBox2.FormattingEnabled = true;
            startstationnamecomboBox2.Location = new Point(114, 25);
            startstationnamecomboBox2.Name = "startstationnamecomboBox2";
            startstationnamecomboBox2.Size = new Size(246, 23);
            startstationnamecomboBox2.TabIndex = 12;
            startstationnamecomboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 25);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Station Name";
            // 
            // startstationidtextBox1
            // 
            startstationidtextBox1.Location = new Point(114, 75);
            startstationidtextBox1.Name = "startstationidtextBox1";
            startstationidtextBox1.ReadOnly = true;
            startstationidtextBox1.Size = new Size(89, 23);
            startstationidtextBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 75);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 7;
            label6.Text = "Station ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(endroute2textBox3);
            groupBox2.Controls.Add(endroutenumber2textBox4);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(endrouteid2textBox5);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(endstationnamecomboBox3);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(endtstationidtextBox1);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(414, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 239);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "End Station ";
            // 
            // endroute2textBox3
            // 
            endroute2textBox3.Location = new Point(114, 122);
            endroute2textBox3.Name = "endroute2textBox3";
            endroute2textBox3.ReadOnly = true;
            endroute2textBox3.Size = new Size(246, 23);
            endroute2textBox3.TabIndex = 25;
            // 
            // endroutenumber2textBox4
            // 
            endroutenumber2textBox4.Location = new Point(114, 210);
            endroutenumber2textBox4.Name = "endroutenumber2textBox4";
            endroutenumber2textBox4.ReadOnly = true;
            endroutenumber2textBox4.Size = new Size(246, 23);
            endroutenumber2textBox4.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 213);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 23;
            label10.Text = "Route Number";
            // 
            // endrouteid2textBox5
            // 
            endrouteid2textBox5.Location = new Point(114, 167);
            endrouteid2textBox5.Name = "endrouteid2textBox5";
            endrouteid2textBox5.ReadOnly = true;
            endrouteid2textBox5.Size = new Size(89, 23);
            endrouteid2textBox5.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 167);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 21;
            label11.Text = "Route ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 122);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 19;
            label12.Text = "Route";
            // 
            // endstationnamecomboBox3
            // 
            endstationnamecomboBox3.FormattingEnabled = true;
            endstationnamecomboBox3.Location = new Point(114, 25);
            endstationnamecomboBox3.Name = "endstationnamecomboBox3";
            endstationnamecomboBox3.Size = new Size(246, 23);
            endstationnamecomboBox3.TabIndex = 12;
            endstationnamecomboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 25);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 10;
            label13.Text = "Station Name";
            // 
            // endtstationidtextBox1
            // 
            endtstationidtextBox1.Location = new Point(114, 75);
            endtstationidtextBox1.Name = "endtstationidtextBox1";
            endtstationidtextBox1.ReadOnly = true;
            endtstationidtextBox1.Size = new Size(89, 23);
            endtstationidtextBox1.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 75);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 7;
            label14.Text = "Station ID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox2weeekend);
            groupBox4.Controls.Add(checkBox1weekday);
            groupBox4.Controls.Add(trainnamecomboBox4);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(trainIDtextBox7);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Location = new Point(18, 63);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(347, 161);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Train Details";
            // 
            // checkBox2weeekend
            // 
            checkBox2weeekend.AutoSize = true;
            checkBox2weeekend.Location = new Point(192, 119);
            checkBox2weeekend.Name = "checkBox2weeekend";
            checkBox2weeekend.Size = new Size(80, 19);
            checkBox2weeekend.TabIndex = 31;
            checkBox2weeekend.Text = "Weekends";
            checkBox2weeekend.UseVisualStyleBackColor = true;
            // 
            // checkBox1weekday
            // 
            checkBox1weekday.AutoSize = true;
            checkBox1weekday.Location = new Point(95, 119);
            checkBox1weekday.Name = "checkBox1weekday";
            checkBox1weekday.Size = new Size(79, 19);
            checkBox1weekday.TabIndex = 30;
            checkBox1weekday.Text = "Weekdays";
            checkBox1weekday.UseVisualStyleBackColor = true;
            // 
            // trainnamecomboBox4
            // 
            trainnamecomboBox4.FormattingEnabled = true;
            trainnamecomboBox4.Location = new Point(95, 28);
            trainnamecomboBox4.Name = "trainnamecomboBox4";
            trainnamecomboBox4.Size = new Size(246, 23);
            trainnamecomboBox4.TabIndex = 16;
            trainnamecomboBox4.SelectedIndexChanged += trainnamecomboBox4_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 123);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 13;
            label15.Text = "Available";
            // 
            // trainIDtextBox7
            // 
            trainIDtextBox7.Location = new Point(95, 74);
            trainIDtextBox7.Name = "trainIDtextBox7";
            trainIDtextBox7.ReadOnly = true;
            trainIDtextBox7.Size = new Size(89, 23);
            trainIDtextBox7.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 77);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 11;
            label16.Text = "Train ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 31);
            label17.Name = "label17";
            label17.Size = new Size(65, 15);
            label17.TabIndex = 10;
            label17.Text = "Train name";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(492, 690);
            button3.Name = "button3";
            button3.Size = new Size(92, 33);
            button3.TabIndex = 29;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(592, 690);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 28;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(695, 690);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 27;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Train_Registation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(794, 723);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Train_Registation";
            Text = "Train_Registation";
            Load += Train_Registation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endnumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)startnumericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox3;
        private ComboBox startstationnamecomboBox2;
        private Label label5;
        private TextBox startstationidtextBox1;
        private Label label6;
        private TextBox startroutetextBox2;
        private TextBox startroutenumbertextBox1;
        private Label label7;
        private TextBox startrouteidtextBox2;
        private Label label8;
        private Label label9;
        private NumericUpDown startnumericUpDown1;
        private GroupBox groupBox2;
        private TextBox endroute2textBox3;
        private TextBox endroutenumber2textBox4;
        private Label label10;
        private TextBox endrouteid2textBox5;
        private Label label11;
        private Label label12;
        private ComboBox endstationnamecomboBox3;
        private Label label13;
        private TextBox endtstationidtextBox1;
        private Label label14;
        private GroupBox groupBox4;
        private ComboBox trainnamecomboBox4;
        private Label label15;
        private TextBox trainIDtextBox7;
        private Label label16;
        private Label label17;
        private Label label18;
        private NumericUpDown endnumericUpDown2;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox2weeekend;
        private CheckBox checkBox1weekday;
    }
}