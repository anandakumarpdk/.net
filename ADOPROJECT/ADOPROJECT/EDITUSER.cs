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
    public partial class EDITUSER : Form
    {
        DBCON d = new DBCON();

        public EDITUSER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = d.updateuser(comboBox2.Text,textBox2.Text,comboBox1.Text);
            MessageBox.Show(x + " update user successfully....");
            load();
        }

        public void load()
        {
            DataTable dt = new DataTable();
            dt = d.displayuser();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "uid";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
        }

        private void EDITUSER_Load(object sender, EventArgs e)
        {
            load();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox2.Text = selecteditem["pwd"].ToString();
                comboBox1.Text = selecteditem["usrtype"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error");
            }
        }
    }
}
