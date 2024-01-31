using Google.Protobuf.WellKnownTypes;
using static System.Collections.Specialized.BitVector32;
using System.Numerics;
using MySqlX.XDevAPI.Common;
using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;
using System.Xml;

namespace Assignment6_6422770345
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Current_rID = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public static int Current_rID { set; get; }
        private void add_info(List<logininfo> returnall_login)
        {
            infoDAO infor = new infoDAO(); 
            List<info> returnall = new List<info>();
            returnall = infor.getAll();

            string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
            info a1 = new info()
            {
                ID = returnall.Last().ID + 1,
                fName = fname.Text,
                LName = lname.Text,
                Sex = sxCombo.Text,
                Bdate = dateValue,
                Email = email.Text,
                Occup = occupation.Text,
            };

            int result = infoDAO.addOneRecord(a1);
            /*(c) If a new user sign-up, then there should be a message box mentioning
                that “row added to information collector.”, once he presses submit.*/
            
            if (Current_rID != -1)
            {
                MessageBox.Show("Log Out from User " + Current_rID);
            }
            Current_rID = returnall.Last().ID + 1;
            MessageBox.Show("Row added to information collector. User " + Current_rID);
            MessageBox.Show("Log In Successfully . . . User " + Current_rID);
            logininfo a1_login = new logininfo()
            {
                uID = returnall_login.Last().uID + 1,
                rID = Current_rID,
                uName = signup_username.Text,
                Pass = signup_password.Text

            };
            infoDAO.addOneRecord_login(a1_login);

        }
        private void submit_Click(object sender, EventArgs e)
        {
            /*(d) A user must always fill in either login or signup section (priority of
                checking is for login section), otherwise a popup message should say
                “Please fill all the fieds in either login or signup section”, once he
                presses submit.*/

            infoDAO logininfor = new infoDAO();
            List<logininfo> returnall_login = new List<logininfo>();
            returnall_login = logininfor.getAll_login();

            // If login was completly filled
            if (!(String.IsNullOrEmpty(login_username.Text) || String.IsNullOrEmpty(login_password.Text)))
            {
                // If signup was complety filled
                if (!(String.IsNullOrEmpty(signup_username.Text) || String.IsNullOrEmpty(signup_password.Text) ||
                    String.IsNullOrEmpty(signup_cpassword.Text)))
                {
                    MessageBox.Show("Please fill all the fieds in either login or signup section.");
                }
                else // If login was complety filled only and signup has no filled or partial filled
                {
                    bool new_login = false;
                    foreach (logininfo i in returnall_login)
                    {


                        if ((String.Equals(i.uName, login_username.Text) &&
                            String.Equals(i.Pass, login_password.Text)))
                        {
                           
                            if (Current_rID != -1)
                            {
                                MessageBox.Show("Log Out from User " + Current_rID);
                            }
                            Current_rID = i.rID;
                            MessageBox.Show("Log In Successfully . . . User " + Current_rID);
                            new_login = true;
                            break;
                        }
                    }
                    if (!new_login)
                    {
                        MessageBox.Show("Log In Fail Incorrect Password . .  You are User " + Current_rID);
                    }
                    else
                    {
                        logininfo a1 = new logininfo()
                        {
                            uID = returnall_login.Last().uID + 1,
                            rID = Current_rID,
                            uName = login_username.Text,
                            Pass = login_password.Text

                        };
                        int result = infoDAO.addOneRecord_login(a1);


                    }
                    


                }
            }
            else // If login was not completly filled
            {
                /*(a) When a new user signup, he must provide all the details in the
                    personal information & signup sections (link to the database as well),
                    otherwise pop out a message box saying, “Please fill all the fields in
                    signup” and/or “Please fill all the fields in personal information”, once
                    he presses submit.*/
                if ((String.IsNullOrEmpty(fname.Text) || String.IsNullOrEmpty(lname.Text)
                    || String.IsNullOrEmpty(sxCombo.Text) || String.IsNullOrEmpty(birthDatePick.Text)
                    || String.IsNullOrEmpty(occupation.Text) || String.IsNullOrEmpty(email.Text)) &&
                    (String.IsNullOrEmpty(signup_username.Text) || String.IsNullOrEmpty(signup_cpassword.Text)
                    || String.IsNullOrEmpty(signup_password.Text))
                    && (String.IsNullOrEmpty(login_username.Text) || String.IsNullOrEmpty(login_password.Text)))
                {
                    MessageBox.Show("Please fill all the fieds in either login or signup section.");
                }
                else
                {
                    bool signup_availably = true;
                    // if any of personal information was null or empty
                    if (String.IsNullOrEmpty(fname.Text) || String.IsNullOrEmpty(lname.Text)
                        || String.IsNullOrEmpty(sxCombo.Text) || String.IsNullOrEmpty(birthDatePick.Text)
                        || String.IsNullOrEmpty(occupation.Text) || String.IsNullOrEmpty(email.Text))
                    {
                        MessageBox.Show("Please fill all the fields in personal information.");
                        signup_availably = false;
                    }
                    // if any of signup was null or empty
                    if (String.IsNullOrEmpty(signup_username.Text) || String.IsNullOrEmpty(signup_cpassword.Text)
                        || String.IsNullOrEmpty(signup_password.Text))
                    {
                        MessageBox.Show("Please fill all the fields in signup.");
                        signup_availably = false;
                    }
                    if (signup_availably)
                    {

                        /*(b) Then, the Password and confirm password should be checked for
                            similarity, otherwise pop out a message saying, “Your passwords do
                            not match”, once he presses submit.*/
                        if (String.Equals(signup_password.Text, signup_cpassword.Text))
                        {
                            /*(f) Only unique values should be allowed to enter for username and password.*/

                            // Username == Password
                            if (String.Equals(signup_username.Text, signup_password.Text))
                            {
                                MessageBox.Show("Your username and password are the same !");
                            }
                            else
                            {
                                bool uniqueness = true;
                                foreach (logininfo i in returnall_login)
                                {
                                    if (String.Equals(i.uName, signup_username.Text) ||
                                        String.Equals(i.Pass, signup_password.Text))
                                    {
                                        uniqueness = false;
                                    }
                                }
                                if (uniqueness)
                                {
                                    MessageBox.Show("Signed up Successfully . . .");
                                    this.add_info(returnall_login);
                                }
                                else
                                {
                                    MessageBox.Show("Only unique values should be allowed to enter for username and password.");
                                }
                            }
                            List<String> x = new List<String>();

                        }
                        else
                        {
                            MessageBox.Show("Your passwords do not match");
                        }
                    }

                }
                    


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*(e) Once a user successfully login or signup, he/she must only see their
            records only.*/
            infoDAO infor = new infoDAO();
            if (Current_rID != -1)
            {
                userpage newuserpage = new userpage(infor.getAll()[Current_rID - 1]);
                newuserpage.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must log in or sign up first.");
            }

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

