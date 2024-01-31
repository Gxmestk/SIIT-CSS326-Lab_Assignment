namespace Assignment6_6422770345
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            occupation = new TextBox();
            email = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            birthDatePick = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            sxCombo = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label11 = new Label();
            label8 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            signup_cpassword = new TextBox();
            label12 = new Label();
            signup_password = new TextBox();
            signup_username = new TextBox();
            label9 = new Label();
            label10 = new Label();
            submit = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(191, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(515, 65);
            label1.TabIndex = 1;
            label1.Text = "Information Collector";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(occupation);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(fname);
            groupBox1.Controls.Add(birthDatePick);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(sxCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(191, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 327);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // occupation
            // 
            occupation.Location = new Point(167, 274);
            occupation.Name = "occupation";
            occupation.Size = new Size(328, 39);
            occupation.TabIndex = 12;
            // 
            // email
            // 
            email.Location = new Point(167, 229);
            email.Name = "email";
            email.Size = new Size(328, 39);
            email.TabIndex = 11;
            // 
            // lname
            // 
            lname.Location = new Point(167, 95);
            lname.Name = "lname";
            lname.Size = new Size(328, 39);
            lname.TabIndex = 10;
            // 
            // fname
            // 
            fname.Location = new Point(167, 49);
            fname.Name = "fname";
            fname.Size = new Size(328, 39);
            fname.TabIndex = 2;
            fname.TextChanged += fname_TextChanged;
            // 
            // birthDatePick
            // 
            birthDatePick.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePick.Location = new Point(167, 185);
            birthDatePick.Name = "birthDatePick";
            birthDatePick.Size = new Size(328, 39);
            birthDatePick.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 274);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 7;
            label7.Text = "Occupation:";
            // 
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(167, 139);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(328, 40);
            sxCombo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 232);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 185);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 5;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 4;
            label4.Text = "Sex:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 90);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 3;
            label11.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 48);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 2;
            label8.Text = "Username:";
            label8.Click += label8_Click;
            // 
            // login_username
            // 
            login_username.Location = new Point(233, 41);
            login_username.Name = "login_username";
            login_username.Size = new Size(328, 39);
            login_username.TabIndex = 2;
            // 
            // login_password
            // 
            login_password.Location = new Point(233, 87);
            login_password.Name = "login_password";
            login_password.Size = new Size(328, 39);
            login_password.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(login_password);
            groupBox2.Controls.Add(login_username);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(707, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(589, 134);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(signup_cpassword);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(signup_password);
            groupBox3.Controls.Add(signup_username);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(707, 235);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 188);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Signup";
            // 
            // signup_cpassword
            // 
            signup_cpassword.Location = new Point(232, 128);
            signup_cpassword.Name = "signup_cpassword";
            signup_cpassword.Size = new Size(328, 39);
            signup_cpassword.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 131);
            label12.Name = "label12";
            label12.Size = new Size(192, 25);
            label12.TabIndex = 11;
            label12.Text = "Confirm Password:";
            // 
            // signup_password
            // 
            signup_password.Location = new Point(232, 82);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(328, 39);
            signup_password.TabIndex = 10;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(232, 36);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(328, 39);
            signup_username.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 43);
            label9.Name = "label9";
            label9.Size = new Size(116, 25);
            label9.TabIndex = 2;
            label9.Text = "Username:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 85);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 3;
            label10.Text = "Password:";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.Highlight;
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(232, 449);
            submit.Name = "submit";
            submit.Size = new Size(477, 46);
            submit.TabIndex = 15;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(760, 449);
            button1.Name = "button1";
            button1.Size = new Size(467, 46);
            button1.TabIndex = 16;
            button1.Text = "Userpage";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 507);
            Controls.Add(button1);
            Controls.Add(submit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sign-up/Login form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox occupation;
        private TextBox email;
        private TextBox lname;
        private TextBox fname;
        private DateTimePicker birthDatePick;
        private ComboBox sxCombo;
        private Label label11;
        private Label label8;
        private TextBox login_username;
        private TextBox login_password;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox signup_cpassword;
        private Label label12;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label label9;
        private Label label10;
        private Button submit;
        private Button button1;
    }
}