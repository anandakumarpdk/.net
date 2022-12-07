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
    public partial class DELETEMODEL : Form
    {
        DBCON d = new DBCON();
        public DELETEMODEL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = d.deletemodel(int.Parse(comboBox1.Text));
            MessageBox.Show(x + " Deleted model successfully..... ");
            load();
        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = d.displaymodel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void DELETEMODEL_Load(object sender, EventArgs e)
        {
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text =selecteditem["mname"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error");
            }
        }
    }
}
