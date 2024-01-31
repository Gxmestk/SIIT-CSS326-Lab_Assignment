using MySql.Data.MySqlClient;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace signup
{
    public partial class Form1 : Form
    {
        public Form1(int v)
        {
            InitializeComponent();
            V = v;
        }
        public int V { get; set; }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /* A */
        /* private void submit_Click(object sender, EventArgs e)
        {

            /* 1 */
            /* infoDAO infoDAO = new infoDAO();
            info a1 = new info()
            {
                ID = 1,
                fName = fname.Text,
                LName = lname.Text,
                Sex = sxCombo.Text,
                Bdate = birthDatePick.Text,
                Email = email.Text,
                Occup = occupation.Text,
            };
            infoDAO.info_try.Add(a1);
            userpage newuserpage = new userpage(infoDAO.info_try);
            newuserpage.ShowDialog();*/

            /* 3 */
            /*string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
            info a1 = new info()
            {
                ID = 1,
                fName = fname.Text,
                LName = lname.Text,
                Sex = sxCombo.Text,
                Bdate = dateValue,
                Email = email.Text,
                Occup = occupation.Text,
            };
            infoDAO infor = new infoDAO();
            int result = infoDAO.addOneRecord(a1);
            MessageBox.Show(result + " new row(s) added.");

            /* 2 */
            /*infoDAO infor = new infoDAO();
            userpage newuserpage = new userpage(infor.getAll());
            newuserpage.ShowDialog();*/
        /*}*/

        /* B */
        private void submit_Click(object sender, EventArgs e)
    {
        string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
        info a1 = new info()
        {
            ID = V,
            fName = fname.Text,
            LName = lname.Text,
            Sex = sxCombo.Text,
            Bdate = dateValue,
            Email = email.Text,
            Occup = occupation.Text,
        };
        infoDAO infor = new infoDAO();
        int result = infor.updateOneRecord(a1);
        this.Hide();
        userpage newuserpage = new userpage(infor.getAll());
        newuserpage.ShowDialog();
    }

    private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}