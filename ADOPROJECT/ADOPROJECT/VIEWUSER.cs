using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPROJECT
{
    public partial class VIEWUSER : Form
    {
        DBCON d = new DBCON();
        public VIEWUSER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displayuser();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displayuserid(comboBox1.Text);
            dataGridView1.DataSource = dt;
        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = d.displayuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }

        private void VIEWUSER_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
