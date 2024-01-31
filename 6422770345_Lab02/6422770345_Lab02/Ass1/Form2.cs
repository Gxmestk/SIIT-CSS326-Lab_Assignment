using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass1
{
    public partial class Form2 : Form
    {
        public Form2(object v)
        {
            InitializeComponent();
            V = v;
        }
        public object V { get; set; }
        BindingSource studentBindingSource = new BindingSource();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = V;
            dataGridView1.DataSource = studentBindingSource;
        }
    }
}
