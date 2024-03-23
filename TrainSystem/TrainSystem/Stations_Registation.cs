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


    public partial class Stations_Registation : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        public Stations_Registation()
        {
            InitializeComponent();
        }

        private void Stations_Registation_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, selectroutecomboBox2, "route_name", "route");
            ComponentClass.add_To_Combo(connection, comboBox1, "station_name", "stations");
        }

        private void selectroutecomboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
                my.Parameters.AddWithValue("@routeName", selectroutecomboBox2.SelectedItem);

                // Execute the query
                MySqlDataReader reader = my.ExecuteReader();

                // Check if there are rows returned
                if (reader.HasRows)
                {
                    // Read the first row (assuming only one row will be returned)
                    reader.Read();

                    // Populate the text boxes with the retrieved data
                    routeidtextBox2.Text = reader.GetInt32(0).ToString();
                    routenumbertextBox1.Text = reader.GetString(2);
                }
                else
                {
                    // Clear the text boxes if no rows are returned
                    routeidtextBox2.Clear();
                    routenumbertextBox1.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }
            if(string.IsNullOrWhiteSpace(selectroutecomboBox2.Text))
            {
                MessageBox.Show("Please select a Route.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }
            if (string.IsNullOrWhiteSpace(routeidtextBox2.Text))
            {
                MessageBox.Show("Invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }

            DBUtil.open_Connection(connection);

            try
            {
                // Prepare the SQL query
                string sql = $"INSERT INTO stations (station_name, route_id) VALUES (@station_name, @route_id)";

                // Create MySqlCommand object
                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameters to the query to prevent SQL injection
                my.Parameters.AddWithValue("@station_name", comboBox1.Text);
                my.Parameters.AddWithValue("@route_id", routeidtextBox2.Text);


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
                IDtextBox1.Clear();
                selectroutecomboBox2.Text = "";
                routeidtextBox2.Clear();
                routenumbertextBox1.Clear();

                ComponentClass.add_To_Combo(connection, comboBox1, "station_name", "stations");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }
    }
}
