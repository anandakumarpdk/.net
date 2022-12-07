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
    public partial class DAYBW2DAYS : Form
    {
        DBCON d = new DBCON();
        public DAYBW2DAYS()
        {
            InitializeComponent();
        }

        private void DAYBW2DAYS_Load(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            dt = d.disdatebetreport((DateTime.Parse(dateTimePicker1.Text)), (DateTime.Parse(dateTimePicker2.Text)));
            dataGridView1.DataSource = dt;
        }
    }
}
