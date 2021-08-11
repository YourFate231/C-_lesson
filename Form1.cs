using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TestConnection4
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source = DESKTOP-RJRURB5\SQLEXPRESS;Initial Catalog=lesson2;Integrated Security= True;");
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection open");
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openConnection();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection open");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            closeConnection();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("connection closed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand command1 = new SqlCommand("insert into [user](email)values('" + txtemail.Text.ToString() + "')", connection);
            SqlCommand command2 = new SqlCommand("insert into [user](email)values(N'awdawd@awwggggggg')", connection);
            SqlCommand command3 = new SqlCommand("select * from [user] where email like (wdad)/ or 1=1", connection);

            MessageBox.Show( command1.ExecuteNonQuery().ToString());
           
            MessageBox.Show("New user added");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
