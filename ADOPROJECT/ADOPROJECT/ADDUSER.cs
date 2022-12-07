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
    public partial class ADDUSER : Form
    {
        DBCON d = new DBCON();
        public ADDUSER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = d.insertuser(textBox1.Text,textBox2.Text,comboBox1.Text);
            MessageBox.Show(x + "inserted user successfully....");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";

        }
        
        private void ADDUSER_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("USER");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
