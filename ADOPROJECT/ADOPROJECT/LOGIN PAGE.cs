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
    public partial class LOGIN_PAGE : Form
    {
        DBCON d = new DBCON();
        public LOGIN_PAGE()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = d.CHKLogin(textBox1.Text, textBox2.Text, comboBox1.Text);
            if (x >= 1)
            {
                if (comboBox1.Text == "ADMIN")
                {
                    ADMINMDI m = new ADMINMDI();
                    m.Show();
                }
                else
                {
                    MDIUSER u = new MDIUSER();
                    u.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid UserID/Password.....");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_Show_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_Show_hide.Checked== true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            { 
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void LOGIN_PAGE_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
