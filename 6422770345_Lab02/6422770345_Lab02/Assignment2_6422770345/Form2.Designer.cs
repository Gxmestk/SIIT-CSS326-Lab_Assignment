namespace Assignment2_6422770345
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(140, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 724);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "From Naigation";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(22, 192);
            button3.Name = "button3";
            button3.Size = new Size(288, 46);
            button3.TabIndex = 5;
            button3.Text = "User Group";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(22, 126);
            button2.Name = "button2";
            button2.Size = new Size(288, 46);
            button2.TabIndex = 4;
            button2.Text = "User Add-In";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Location = new Point(22, 259);
            button4.Name = "button4";
            button4.Size = new Size(288, 107);
            button4.TabIndex = 6;
            button4.Text = "User Group Add-In";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(22, 60);
            button1.Name = "button1";
            button1.Size = new Size(288, 46);
            button1.TabIndex = 3;
            button1.Text = "User Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(140, 182);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1046, 185);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 66);
            label9.Name = "label9";
            label9.Size = new Size(714, 62);
            label9.TabIndex = 3;
            label9.Text = "CSS326 Laboratory System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(708, 724);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(971, 923);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 402);
            label1.Name = "label1";
            label1.Size = new Size(114, 42);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(486, 468);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(685, 143);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 46);
            label2.Name = "label2";
            label2.Size = new Size(114, 42);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 1278);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button1;
        private GroupBox groupBox4;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label2;
    }
}