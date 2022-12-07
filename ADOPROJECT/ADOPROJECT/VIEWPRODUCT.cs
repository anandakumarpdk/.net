﻿using System;
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
    public partial class VIEWPRODUCT : Form
    {
        DBCON d = new DBCON();
        public VIEWPRODUCT()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displayproductid(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = d.displayproduct();
            dataGridView1.DataSource = dt;

        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = d.displayproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
       
        private void VIEWPRODUCT_Load(object sender, EventArgs e)
        {
            load();
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
