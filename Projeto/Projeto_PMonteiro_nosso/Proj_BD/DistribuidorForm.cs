﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_BD
{
    public partial class DistribuidorForm : Form
    {
        public DistribuidorForm()
        {
            InitializeComponent();
        }

        private void DistribuidorForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getDistribuidores");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }
    }
}