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
    public partial class Route_Registation : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        public Route_Registation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(routenumbertextBox3.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }

            DBUtil.open_Connection(connection);

            try
            {
                // Prepare the SQL query
                string sql = $"INSERT INTO route (route_name, route_number) VALUES (@route_name, @route_number)";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameters to the query to prevent SQL injection
                my.Parameters.AddWithValue("@route_name", comboBox1.Text);
                my.Parameters.AddWithValue("@route_number", routenumbertextBox3.Text);


                // Execute the query
                my.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Record Added Successfully!", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                connection.Close();

                // Dispose MySqlCommand object
                my.Dispose();

                // Clear the text fields
                comboBox1.Text = "";
                routenumbertextBox3.Clear();

                ComponentClass.add_To_Combo(connection, comboBox1, "route_name", "route");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }

        private void Route_Registation_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, comboBox1, "route_name", "route");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                DBUtil.open_Connection(connection);

                // SQL Command to select the route based on the selected item in ComboBox
                sql = $"SELECT * FROM route WHERE route_name=@routeName";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameter to the query to prevent SQL injection
                my.Parameters.AddWithValue("@routeName", comboBox1.SelectedItem);

                // Execute the query
                MySqlDataReader reader = my.ExecuteReader();

                // Check if there are rows returned
                if (reader.HasRows)
                {
                    // Read the first row (assuming only one row will be returned)
                    reader.Read();

                    // Populate the text boxes with the retrieved data
                    IDtextBox1.Text = reader.GetInt32(0).ToString();
                    routenumbertextBox3.Text = reader.GetString(2);
                }
                else
                {
                    // Clear the text boxes if no rows are returned
                    IDtextBox1.Clear();
                    routenumbertextBox3.Clear();
                }

                // Close the reader
                reader.Close();

                // Close the connection
                connection.Close();

                // Dispose MySqlCommand object
                my.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);

            sql = $"UPDATE route SET route_name = '{comboBox1.Text}', route_number = '{routenumbertextBox3.Text}' WHERE id = '{IDtextBox1.Text}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
            my.Dispose(); // clear the data stored in the object "my"

            comboBox1.Text = "";
            routenumbertextBox3.Clear();
            IDtextBox1.Clear();


            ComponentClass.add_To_Combo(connection, comboBox1, "route_name", "route"); ;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                DBUtil.open_Connection(connection);

                // SQL Command to delete the record
                sql = "DELETE FROM route WHERE ID = @routeID";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameter to the query to prevent SQL injection
                my.Parameters.AddWithValue("@routeID", IDtextBox1.Text);

                // Execute the query
                int rowsAffected = my.ExecuteNonQuery();

                // Check if the delete was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text fields after deletion
                    IDtextBox1.Clear();
                    comboBox1.SelectedIndex = -1; // Clear selection
                    routenumbertextBox3.Clear();

                    ComponentClass.add_To_Combo(connection, comboBox1, "route_name", "route");
                }
                else
                {
                    MessageBox.Show("No records were deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the connection
                connection.Close();

                // Dispose MySqlCommand object
                my.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Record Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
