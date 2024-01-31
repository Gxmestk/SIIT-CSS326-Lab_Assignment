namespace Ass1
{
    partial class Login
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
            label1 = new Label();
            stud_id = new Label();
            stud_name = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            msc = new RadioButton();
            bsc = new RadioButton();
            Location = new Label();
            listBox1 = new ListBox();
            School = new Label();
            comboBox1 = new ComboBox();
            textID = new TextBox();
            txtName = new TextBox();
            btnSubmit = new Button();
            DB = new CheckBox();
            conf_info = new GroupBox();
            stsdate = new DateTimePicker();
            AI = new CheckBox();
            Indus4 = new CheckBox();
            groupBox1.SuspendLayout();
            conf_info.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 388);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // stud_id
            // 
            stud_id.AutoSize = true;
            stud_id.Location = new Point(18, 101);
            stud_id.Name = "stud_id";
            stud_id.Size = new Size(127, 32);
            stud_id.TabIndex = 2;
            stud_id.Text = "Student ID";
            // 
            // stud_name
            // 
            stud_name.AutoSize = true;
            stud_name.Location = new Point(18, 44);
            stud_name.Name = "stud_name";
            stud_name.Size = new Size(168, 32);
            stud_name.TabIndex = 3;
            stud_name.Text = "Student Name";
            stud_name.Click += stud_name_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(msc);
            groupBox1.Controls.Add(bsc);
            groupBox1.Controls.Add(Location);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(School);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(stud_name);
            groupBox1.Controls.Add(stud_id);
            groupBox1.ImeMode = ImeMode.Off;
            groupBox1.Location = new Point(228, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 432);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 370);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 11;
            label2.Text = "Level";
            label2.Click += label2_Click_2;
            // 
            // msc
            // 
            msc.AutoSize = true;
            msc.Location = new Point(401, 370);
            msc.Name = "msc";
            msc.Size = new Size(91, 36);
            msc.TabIndex = 10;
            msc.TabStop = true;
            msc.Text = "MSc";
            msc.UseVisualStyleBackColor = true;
            // 
            // bsc
            // 
            bsc.AutoSize = true;
            bsc.Location = new Point(205, 370);
            bsc.Name = "bsc";
            bsc.Size = new Size(83, 36);
            bsc.TabIndex = 9;
            bsc.TabStop = true;
            bsc.Text = "BSc";
            bsc.UseVisualStyleBackColor = true;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(18, 259);
            Location.Name = "Location";
            Location.Size = new Size(104, 32);
            Location.TabIndex = 8;
            Location.Text = "Location";
            Location.Click += label2_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "Rangsit", "BKD", "Other" });
            listBox1.Location = new Point(192, 230);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 100);
            listBox1.TabIndex = 7;
            // 
            // School
            // 
            School.AutoSize = true;
            School.Location = new Point(18, 157);
            School.Name = "School";
            School.Size = new Size(86, 32);
            School.TabIndex = 6;
            School.Text = "School";
            School.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AAA", "BBB", "CCC" });
            comboBox1.Location = new Point(192, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(372, 40);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textID
            // 
            textID.Location = new Point(192, 101);
            textID.Name = "textID";
            textID.Size = new Size(372, 39);
            textID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 39);
            txtName.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(656, 1007);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // DB
            // 
            DB.AutoSize = true;
            DB.Location = new Point(33, 49);
            DB.Name = "DB";
            DB.Size = new Size(227, 36);
            DB.TabIndex = 5;
            DB.Text = "DB Management";
            DB.UseVisualStyleBackColor = true;
            // 
            // conf_info
            // 
            conf_info.Controls.Add(stsdate);
            conf_info.Controls.Add(AI);
            conf_info.Controls.Add(Indus4);
            conf_info.Controls.Add(DB);
            conf_info.Location = new Point(228, 670);
            conf_info.Name = "conf_info";
            conf_info.Size = new Size(587, 308);
            conf_info.TabIndex = 9;
            conf_info.TabStop = false;
            conf_info.Text = "Conf Info";
            // 
            // stsdate
            // 
            stsdate.Location = new Point(68, 229);
            stsdate.Name = "stsdate";
            stsdate.Size = new Size(400, 39);
            stsdate.TabIndex = 10;
            // 
            // AI
            // 
            AI.AutoSize = true;
            AI.Location = new Point(33, 133);
            AI.Name = "AI";
            AI.Size = new Size(67, 36);
            AI.TabIndex = 7;
            AI.Text = "AI";
            AI.UseVisualStyleBackColor = true;
            // 
            // Indus4
            // 
            Indus4.AutoSize = true;
            Indus4.Location = new Point(33, 91);
            Indus4.Name = "Indus4";
            Indus4.Size = new Size(142, 36);
            Indus4.TabIndex = 6;
            Indus4.Text = "Indus 4.0";
            Indus4.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2801, 1292);
            Controls.Add(conf_info);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            conf_info.ResumeLayout(false);
            conf_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label stud_id;
        private Label stud_name;
        private GroupBox groupBox1;
        private TextBox textID;
        private TextBox txtName;
        private ComboBox comboBox1;
        private Button btnSubmit;
        private Label School;
        private Label Location;
        private ListBox listBox1;
        private CheckBox DB;
        private Label label2;
        private RadioButton msc;
        private RadioButton bsc;
        private GroupBox conf_info;
        private CheckBox AI;
        private CheckBox Indus4;
        private DateTimePicker stsdate;
    }
}