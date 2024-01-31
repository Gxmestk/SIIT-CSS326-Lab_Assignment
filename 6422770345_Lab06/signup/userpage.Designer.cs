namespace signup
{
    partial class userpage
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
            userdataGridView = new DataGridView();
            update = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)userdataGridView).BeginInit();
            SuspendLayout();
            // 
            // userdataGridView
            // 
            userdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdataGridView.Location = new Point(119, 3);
            userdataGridView.Name = "userdataGridView";
            userdataGridView.RowTemplate.Height = 25;
            userdataGridView.Size = new Size(555, 269);
            userdataGridView.TabIndex = 0;
            userdataGridView.CellClick += userdataGridView_CellClick;
            userdataGridView.CellContentClick += userdataGridView_CellContentClick;
            // 
            // update
            // 
            update.Location = new Point(230, 278);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 1;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(486, 278);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // userpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(userdataGridView);
            Name = "userpage";
            Text = "userpage";
            Load += userpage_Load;
            ((System.ComponentModel.ISupportInitialize)userdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userdataGridView;
        private Button update;
        private Button delete;
    }
}