namespace signup
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
            fname = new TextBox();
            lname = new TextBox();
            email = new TextBox();
            occupation = new TextBox();
            sxCombo = new ComboBox();
            birthDatePick = new DateTimePicker();
            submit = new Button();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Location = new Point(373, 59);
            fname.Name = "fname";
            fname.Size = new Size(100, 23);
            fname.TabIndex = 0;
            fname.TextChanged += fname_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(373, 105);
            lname.Name = "lname";
            lname.Size = new Size(100, 23);
            lname.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(373, 213);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 2;
            // 
            // occupation
            // 
            occupation.Location = new Point(373, 252);
            occupation.Name = "occupation";
            occupation.Size = new Size(100, 23);
            occupation.TabIndex = 3;
            // 
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(373, 143);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(121, 23);
            sxCombo.TabIndex = 4;
            // 
            // birthDatePick
            // 
            birthDatePick.Location = new Point(373, 172);
            birthDatePick.Name = "birthDatePick";
            birthDatePick.Size = new Size(200, 23);
            birthDatePick.TabIndex = 5;
            birthDatePick.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // submit
            // 
            submit.Location = new Point(542, 292);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 6;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(birthDatePick);
            Controls.Add(sxCombo);
            Controls.Add(occupation);
            Controls.Add(email);
            Controls.Add(lname);
            Controls.Add(fname);
            Name = "Form1";
            Text = "Sign-up form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fname;
        private TextBox lname;
        private TextBox email;
        private TextBox occupation;
        private ComboBox sxCombo;
        private DateTimePicker birthDatePick;
        private Button submit;
    }
}