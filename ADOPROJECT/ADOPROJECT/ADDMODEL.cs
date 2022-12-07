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
    public partial class ADDMODEL : Form
    {
        DBCON d = new DBCON();
        public ADDMODEL()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = d.insertmodel(int.Parse(comboBox1.Text), textBox1.Text,int.Parse(textBox2.Text),textBox3.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text));
            MessageBox.Show(x + " Inserted model successfully....");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADDMODEL_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displayproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["pname"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error");
            }
        }
    }
}
