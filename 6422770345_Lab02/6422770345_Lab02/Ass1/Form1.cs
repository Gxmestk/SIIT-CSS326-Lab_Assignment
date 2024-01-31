namespace Ass1
{
    public partial class Login : Form
    {
        static List<Student> st = new List<Student>();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student a1 = new Student
            {
                Name = this.txtName.Text,
                Student_ID = Convert.ToInt64(this.textID.Text),
            };
            st.Add(a1);

            Form2 form2 = new Form2(st);
            form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void stud_name_Click(object sender, EventArgs e)
        {

        }
    }
}