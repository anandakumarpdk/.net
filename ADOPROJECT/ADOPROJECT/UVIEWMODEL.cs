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
    public partial class UVIEWMODEL : Form
    {
        
        public UVIEWMODEL()
        {
           // InitializeComponent();
        }
        DBCON d = new DBCON();
        //public void load()
        //{
        //    DataTable dt = new DataTable();
        //    dt = d.displaymodel();
        //    comboBox1.DataSource = dt;
        //    comboBox1.DisplayMember = "mid";
        //}

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    var cb = (sender as ComboBox);
            //    var selecteditem = (cb.SelectedItem as DataRowView);
            //    textBox1.Text = selecteditem["pid"].ToString();
            //    textBox2.Text = selecteditem["pname"].ToString();
            //    textBox3.Text = selecteditem["mname"].ToString();
            //    textBox4.Text = selecteditem["spec"].ToString();
            //    textBox5.Text = selecteditem["uprice"].ToString();
            //   // textBox6.Text = selecteditem["soh"].ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString() + "error");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x = d.insertsales(int.Parse(textBox1.Text),textBox2.Text,int.Parse(comboBox1.Text),textBox3.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text),int.Parse(textBox7.Text));
            //MessageBox.Show(x + " PURCHASE PRODUCT SUCCESSFULLY....... ");
        }

        private void UVIEWMODEL_Load(object sender, EventArgs e)
        {
            //load();
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
        //    textBox7.Text =(int.Parse(textBox5.Text) * (int.Parse(textBox6.Text))).ToString();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //comboBox1.Text = "";
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //comboBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void UVIEWMODEL_Load_1(object sender, EventArgs e)
        {

        }
    }
}
