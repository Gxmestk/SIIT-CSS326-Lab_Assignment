namespace Assignment2_6422770345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = this.comboBox1.Text;
            string fname = this.textBox1.Text;
            string lname = this.textBox2.Text;
            string email = this.textBox3.Text;
            string password = this.textBox5.Text;
            string username = this.textBox4.Text;
            string user_group = string.Empty;

            

            if (string.IsNullOrEmpty(this.textBox1.Text) ||
                string.IsNullOrEmpty(this.textBox2.Text) ||
                string.IsNullOrEmpty(this.textBox3.Text) ||
                string.IsNullOrEmpty(this.textBox4.Text) ||
                string.IsNullOrEmpty(this.textBox5.Text) ||
                string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Fill all blank !", "Error !",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.radioButton1.Checked)
            {
                user_group = this.radioButton1.Text;
            }
            else if (this.radioButton2.Checked)
            {
                user_group = this.radioButton2.Text;
            }
            else if (this.radioButton3.Checked)
            {
                user_group = this.radioButton3.Text;
            }
            else
            {
                MessageBox.Show("Choose your role !", "Error !",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != this.textBox6.Text)
            {
                //System.Diagnostics.Debug.WriteLine(password);
                //System.Diagnostics.Debug.WriteLine(this.textBox6.Text);
                MessageBox.Show("Password != Confirm Password", "Error !",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User a1 = new User(title, fname, lname, email, password, username, user_group);

            Form2 form2 = new Form2(a1);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}