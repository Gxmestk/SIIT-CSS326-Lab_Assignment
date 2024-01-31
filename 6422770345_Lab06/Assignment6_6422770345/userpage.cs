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
    public partial class userpage : Form
    {
        public userpage(info v)
        {
            InitializeComponent();


            V = v;
        }
        public info V { get; set; }
        public int rowClicked { get; private set; }
        public int id_row { get; private set; }

        BindingSource infobindingSource = new BindingSource();
        private void userpage_Load(object sender, EventArgs e)
        {
            infobindingSource.DataSource = V;
            userdataGridView.DataSource = infobindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userdataGridView_CellClick(object sender,
        DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            rowClicked = dataGridView.CurrentRow.Index;
            id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());
        }

        private void update_Click(object sender, EventArgs e)
        {
            infoDAO infor = new infoDAO();
            this.Hide();
            updatepage newupdatepage = new updatepage(V.ID);
            newupdatepage.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            infoDAO infor = new infoDAO();
            int result = infor.deleteOneRecord(V.ID);
            this.Hide();
            Form1.Current_rID = -1;
        }
    }
}
