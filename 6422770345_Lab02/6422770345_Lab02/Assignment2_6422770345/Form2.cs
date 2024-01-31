using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_6422770345
{
    public partial class Form2 : Form
    {
        public User U { get; set; }
        public Form2(User u)
        {
            U = u;
            InitializeComponent();
            label1.Text = String.Format("Hi {0} {1} {2}!!!", U.title, U.fname, U.lname);
            label2.Text = String.Format("We are glad to welcome \nyou as one of the {0}", U.user_group);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
