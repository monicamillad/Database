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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.Doctor' table. You can move, or remove it, as needed.
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.doctorTableAdapter.Fill(this.clinicDataSet.Doctor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.Connection = sqlConnection;
            sqlCommand1.CommandText = "select ID from Speciality where name = '" + textBox2.Text + "'";
            sqlCommand2.CommandText = "insert into Employee values('" + textBox3.Text + "'," + textBox1.Text + "," + textBox4.Text + ",'" + textBox5.Text + "')";
            sqlCommand2.ExecuteNonQuery();
            sqlCommand.CommandText = "insert into Doctor values(" + textBox1.Text + ","+4+",'" + (string)sqlCommand1.ExecuteScalar() + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion is successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select Emp_SSN from Doctor where name = '" + textBox3.Text + "'";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            sqlCommand1.CommandText = "update Doctor set Days = '" + textBox6.Text + "'  where Emp_SSN = " + (int)sqlCommand.ExecuteScalar() + "";
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update is successfully completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=USER\\FCI;Initial Catalog=Clinic;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select Emp_SSN from Doctor where name = '" + textBox3.Text + "'";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.Connection = sqlConnection;
            SqlCommand sqlCommand3 = new SqlCommand();
            sqlCommand3.Connection = sqlConnection;
            SqlCommand sqlCommand4 = new SqlCommand();
            sqlCommand4.Connection = sqlConnection;
            sqlCommand1.CommandText = "delete from Examine where Emp_SSN = " + (int)sqlCommand.ExecuteScalar() + " ";
            sqlCommand2.CommandText = "delete from Assist where Emp_SSN = " + (int)sqlCommand.ExecuteScalar() + " ";
            sqlCommand4.CommandText = "delete from Employee where SSN = " + (int)sqlCommand.ExecuteScalar() + " ";
            sqlCommand3.CommandText = "delete from Doctor where Emp_SSN = " + (int)sqlCommand.ExecuteScalar() + " ";
            sqlCommand1.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            sqlCommand3.ExecuteNonQuery();
            sqlCommand4.ExecuteNonQuery();
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
