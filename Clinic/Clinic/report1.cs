﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
        }

        private void report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClinicDataSet3.Doctor' table. You can move, or remove it, as needed.
            this.DoctorTableAdapter.Fill(this.ClinicDataSet3.Doctor);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
