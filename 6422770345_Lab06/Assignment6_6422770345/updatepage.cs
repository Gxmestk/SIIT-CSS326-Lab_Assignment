using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_6422770345
{
    public partial class updatepage : Form
    {
        public updatepage(int id_row)
        {
            InitializeComponent();
            V = id_row;
        }

        public int V { get; private set; }

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
            userpage newuserpage = new userpage(infor.getAll()[V - 1]);
            newuserpage.ShowDialog();
        }


    }
}
