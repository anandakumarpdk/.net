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
    public partial class DAILYSALESREPORT : Form
    {
        DBCON d = new DBCON();


        public DAILYSALESREPORT()
        {
            InitializeComponent();
        }

        private void DAILYSALESREPORT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displadailyreport();
            dataGridView1.DataSource = dt;
        }
    }
}
