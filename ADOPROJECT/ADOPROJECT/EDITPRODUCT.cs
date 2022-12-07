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
    public partial class EDITPRODUCT : Form
    {
        DBCON d = new DBCON();
        public EDITPRODUCT()
        {
            InitializeComponent();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            int x = d.updateproduct(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(x + "update product successfully.....");
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = d.displayproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
        private void EDITPRODUCT_Load(object sender, EventArgs e)
        {
            load();
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
