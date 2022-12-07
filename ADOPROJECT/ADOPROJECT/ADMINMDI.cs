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
    public partial class ADMINMDI : Form
    {
        public ADMINMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
            LOGIN_PAGE l = new LOGIN_PAGE();
            l.Show();
            
        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDPRODUCT a = new ADDPRODUCT();
            a.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWPRODUCT v = new VIEWPRODUCT();
            v.Show();

        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITPRODUCT ep = new EDITPRODUCT();
            ep.Show();
        }

        private void dELETEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEPRODUCT dp = new DELETEPRODUCT();
            dp.Show();
        }
        
        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDMODEL am = new ADDMODEL();
            am.Show();

        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWMODEL vm = new VIEWMODEL();
            vm.Show();

        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITMODEL em = new EDITMODEL();
            em.Show();
        }

        private void dELETEMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEMODEL dm = new DELETEMODEL();
            dm.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUSER au = new ADDUSER();
            au.Show();
        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWUSER vu = new VIEWUSER();
            vu.Show();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITUSER eu = new EDITUSER();
            eu.Show();
        }

        private void dELETEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEUSER du = new DELETEUSER();
            du.Show();
        }

        private void dAILYREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAILYSALESREPORT ds = new DAILYSALESREPORT();
            ds.Show();
        }

        private void dATEBETWEENTWODAYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAYBW2DAYS t = new DAYBW2DAYS();
            t.Show();
        }

        private void pRODUCTWISEREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODWISEREPORT pr = new PRODWISEREPORT();
            pr.Show();
        }

        private void mODELWISEREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODELREPORT mr = new MODELREPORT();
            mr.Show();
        }

        //private void dAILYREPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}

        //private void rEP1ToolStripMenuItem_Click(object sender, EventArgs e)
        //{


        //}
    }
}
