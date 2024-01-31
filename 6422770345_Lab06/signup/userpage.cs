using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signup
{
    public partial class userpage : Form
    {
        public userpage(object v)
        {
            InitializeComponent();
            V = v;
        }
        public object V { get; set; }

        BindingSource infobindingSource = new BindingSource();
        private int rowClicked;
        private int id_row;
        private void userpage_Load(object sender, EventArgs e)
        {
            infobindingSource.DataSource = V;
            userdataGridView.DataSource = infobindingSource;
        }

        private void userdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void userdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            rowClicked = dataGridView.CurrentRow.Index;
            id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());
        }

        private void update_Click(object sender, EventArgs e)
        {
            infoDAO infor = new infoDAO();
            this.Hide();
            Form1 newupdatepage = new Form1(id_row);
            newupdatepage.ShowDialog();


        }
    }
}
