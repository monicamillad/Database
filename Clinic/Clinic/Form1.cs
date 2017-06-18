using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into Patient values('" + textBox1.Text + "'," + textBox2.Text + "," + 1 + ",'" + textBox3.Text + "')";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.Connection = sqlConnection;
            SqlCommand sqlCommand3 = new SqlCommand();
            sqlCommand3.Connection = sqlConnection;
            sqlCommand1.CommandText = "select ID from Speciality where name = '" + textBox4.Text + "'";
            sqlCommand2.CommandText = "insert into Needs values(" + textBox2.Text + ", '" + (string)sqlCommand1.ExecuteScalar() + "' )";
            sqlCommand.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            sqlCommand3.CommandText = "select Emp_SSN from Doctor where ID = '" + (string)sqlCommand1.ExecuteScalar() + "'";
            sqlCommand2.CommandText = "insert into Examine values(" + textBox2.Text + "," + (int)sqlCommand3.ExecuteScalar() + ")";
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion is successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select ID from Speciality where name = '" + textBox4.Text + "'";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.Connection = sqlConnection;
            SqlCommand sqlCommand3 = new SqlCommand();
            sqlCommand3.Connection = sqlConnection;
            sqlCommand1.CommandText = "update Needs set ID = '" + (string)sqlCommand.ExecuteScalar() + "'  where Num = " + textBox2.Text + "";
            sqlCommand1.ExecuteNonQuery();
            sqlCommand3.CommandText = "select Emp_SSN from Doctor where ID = '" + (string)sqlCommand.ExecuteScalar() + "'";
            sqlCommand2.CommandText = "Update Examine set Emp_SSN = " + (int)sqlCommand3.ExecuteScalar() + " where Num = " + textBox2.Text + "";
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update is successfully completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select Num from Patient where name = '" + textBox1.Text + "'";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.Connection = sqlConnection;
            SqlCommand sqlCommand3 = new SqlCommand();
            sqlCommand3.Connection = sqlConnection;
            sqlCommand1.CommandText = "delete from Needs where Num = " + (int)sqlCommand.ExecuteScalar() + "";
            sqlCommand2.CommandText = "delete from Examine where Num = " + (int)sqlCommand.ExecuteScalar() + "";
            sqlCommand3.CommandText = "delete from Patient where Num = " + (int)sqlCommand.ExecuteScalar() + "";
            sqlCommand1.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion is successfully completed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
