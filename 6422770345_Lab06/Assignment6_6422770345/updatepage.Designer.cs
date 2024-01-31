namespace Assignment6_6422770345
{
    partial class updatepage
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
            occupation = new TextBox();
            email = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            birthDatePick = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            sxCombo = new ComboBox();
            label4 = new Label();
            submit = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(167, 139);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(328, 40);
            sxCombo.TabIndex = 8;
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
            // submit
            // 
            submit.BackColor = SystemColors.Highlight;
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(299, 479);
            submit.Name = "submit";
            submit.Size = new Size(477, 46);
            submit.TabIndex = 21;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
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
            groupBox1.Location = new Point(248, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 327);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(248, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 79);
            panel1.TabIndex = 17;
            // 
            // updatepage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 568);
            Controls.Add(submit);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "updatepage";
            Text = "Update page";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox occupation;
        private TextBox email;
        private TextBox lname;
        private TextBox fname;
        private DateTimePicker birthDatePick;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private ComboBox sxCombo;
        private Label label4;
        private Button submit;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
    }
}