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
    public partial class DELETEPRODUCT : Form
    {
        DBCON dd = new DBCON();
        public DELETEPRODUCT()
        {
            InitializeComponent();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            int x = dd.deleteproduct(int.Parse(comboBox1.Text));
            MessageBox.Show(x + " delete product successfully...");
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = dd.displayproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";

        }
        private void DELETEPRODUCT_Load(object sender, EventArgs e)
        {

            loaddata();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["pname"].ToString();
                textBox2.Text = selecteditem["pdesc"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error");
            }

        }
    }
}
