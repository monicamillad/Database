using System;
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
    public partial class Formshow : Form
    {
        public Formshow()
        {
            InitializeComponent();
        }

        private void Formshow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet3.show2' table. You can move, or remove it, as needed.
            this.show2TableAdapter.Fill(this.clinicDataSet3.show2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
