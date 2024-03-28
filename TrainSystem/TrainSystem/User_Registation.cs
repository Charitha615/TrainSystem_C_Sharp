using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSystem
{
    public partial class User_Registation : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        public User_Registation()
        {
            InitializeComponent();
        }

        private void User_Registation_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(username_textBox1.Text) ||
                string.IsNullOrWhiteSpace(email_textBox2.Text) ||
                string.IsNullOrWhiteSpace(contacttextBox3.Text) ||
                string.IsNullOrWhiteSpace(passwordtextBox4.Text) ||
                string.IsNullOrWhiteSpace(addressrichTextBox1.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }

            // You can add additional validation logic here (e.g., email format validation, contact number format validation, etc.)

            // Open the connection
            DBUtil.open_Connection(connection);

            try
            {
                // Prepare the SQL query
                string sql = $"INSERT INTO customer_details (username, email, contact, password, address) VALUES (@username, @email, @contact, @password, @address)";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameters to the query to prevent SQL injection
                my.Parameters.AddWithValue("@username", username_textBox1.Text);
                my.Parameters.AddWithValue("@email", email_textBox2.Text);
                my.Parameters.AddWithValue("@contact", contacttextBox3.Text);
                my.Parameters.AddWithValue("@password", passwordtextBox4.Text);
                my.Parameters.AddWithValue("@address", addressrichTextBox1.Text);

                // Execute the query
                my.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Record Added Successfully!", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                connection.Close();

                // Dispose MySqlCommand object
                my.Dispose();

                // Clear the text fields
                username_textBox1.Clear();
                email_textBox2.Clear();
                contacttextBox3.Clear();
                passwordtextBox4.Clear();
                addressrichTextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }

     

        private void label7_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();

            // Create an instance of the new form
            Login Login = new Login();

            // Show the new form
            Login.Show();
        }
    }
}
