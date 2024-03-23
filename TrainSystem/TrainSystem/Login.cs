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
    public partial class Login : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Define a global variable to store the user ID
        private int loggedInUserID = -1; // Initialize with an invalid value (-1)

        private void button1_Click(object sender, EventArgs e)
        {
 
            string loginIdentifier = username_textBox1.Text; 
            string password = password_textBox2.Text;

            // Check if the login credentials are correct
            if (IsValidLogin(loginIdentifier, password))
            {


                // Set the user ID to the global variable
                loggedInUserID = GetUserID(loginIdentifier);

                MessageBox.Show("Login successful!"+ loggedInUserID);
                
                if(loggedInUserID == 3)
                {
                    // Close the current form
                    this.Hide();

                    // Create an instance of the new form
                    Admin_Dashboard Admin_Dashboard = new Admin_Dashboard();

                    // Show the new form
                    Admin_Dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username/email or password. Please try again.");
            }
        }

        private int GetUserID(string loginIdentifier)
        {

            // Check if the login credentials match the hardcoded admin credentials
            if (loginIdentifier == "admin")
            {
                return 0;
            }


            // Open the connection
            DBUtil.open_Connection(connection);

            try
            {
                // Prepare the SQL query
                string sql = "SELECT id FROM customer_details WHERE username = @loginIdentifier OR email = @loginIdentifier";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameter to the query to prevent SQL injection
                my.Parameters.AddWithValue("@loginIdentifier", loginIdentifier);

                // Execute the query and get the user ID
                int userID = Convert.ToInt32(my.ExecuteScalar());

                // Close the connection
                connection.Close();

                // Return the user ID
                return userID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
                return -1; // Return an invalid value if an error occurs
            }
        }

        private bool IsValidLogin(string loginIdentifier, string password)
        {
            // Check if the login credentials match the hardcoded admin credentials
            if (loginIdentifier == "admin" && password == "admin")
            {
                return true;
            }

            // Query the database to check if the username or email exists and if the password matches
            // This assumes you have a table named 'users' with columns 'username', 'email', and 'password'

            // Open the connection
            DBUtil.open_Connection(connection);

            try
            {
                // Prepare the SQL query
                string sql = "SELECT COUNT(*) FROM customer_details WHERE (username = @loginIdentifier OR email = @loginIdentifier) AND password = @password";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameters to the query to prevent SQL injection
                my.Parameters.AddWithValue("@loginIdentifier", loginIdentifier);
                my.Parameters.AddWithValue("@password", password);

                // Execute the query and get the count of matching rows
                int count = Convert.ToInt32(my.ExecuteScalar());

                // Close the connection
                connection.Close();

                // Return true if there is a matching user with the provided password, false otherwise
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
                return false;
            }
        }




            private void button2_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();

            // Create an instance of the new form
            User_Registation userRegistrationForm = new User_Registation();

            // Show the new form
            userRegistrationForm.Show();
        }
    }
}
