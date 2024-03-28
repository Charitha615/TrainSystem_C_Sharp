using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainSystem
{
    public partial class User_dashboard : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        private int UID;

        public User_dashboard(int UID)
        {
            InitializeComponent();
            lstSearchResults.SelectedIndexChanged += lstSearchResults_SelectedIndexChanged; // Subscribe to event handler
            this.UID = UID;
        }

        private void User_dashboard_Load(object sender, EventArgs e)
        {
            useridlabel1.Text = this.UID.ToString(); // Convert integer to string

            DBUtil.open_Connection(connection);

            sql = $"SELECT * FROM customer_details WHERE id=@id";

            MySqlCommand my = new MySqlCommand(sql, connection);

            my.Parameters.AddWithValue("@id", this.UID.ToString());

            MySqlDataReader reader = my.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                UserName_label.Text = reader.GetString(1);
                reader.Close();
            }
            my.Dispose();


            ComponentClass.add_To_Combo(connection, startcomboBox1, "station_name", "stations");
            ComponentClass.add_To_Combo(connection, endcomboBox2, "station_name", "stations");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected date from dateTimePicker1
            DateTime selectedDate = dateTimePicker1.Value;

            // Determine if the selected date is a weekend or weekday
            string dayType = selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday ? "Weekend" : "Weekday";
            int avalibleDateValue = dayType == "Weekend" ? 2 : 1;

            // Open connection
            DBUtil.open_Connection(connection);


            string sql = "SELECT train_name FROM train WHERE avalible_date = @AvalibleDateValue";

            // Check if start_station_id is provided
            if (!string.IsNullOrEmpty(sid.Text))
            {
                sql += " AND start_station_id = @StartStationId";
            }

            // Check if end_station_id is provided
            if (!string.IsNullOrEmpty(did.Text))
            {
                sql += " AND end_station_id = @EndStationId";
            }


            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@AvalibleDateValue", avalibleDateValue);

                // Add start_station_id parameter if provided
                if (!string.IsNullOrEmpty(sid.Text))
                {
                    command.Parameters.AddWithValue("@StartStationId", sid.Text);
                }

                // Add end_station_id parameter if provided
                if (!string.IsNullOrEmpty(did.Text))
                {
                    command.Parameters.AddWithValue("@EndStationId", did.Text);
                }

                MySqlDataReader reader = command.ExecuteReader();

                lstSearchResults.Items.Clear(); // Clear existing items

                while (reader.Read())
                {
                    string trainName = reader["train_name"].ToString();
                    lstSearchResults.Items.Add(trainName); // Add train name to ListBox
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Close connection
            }
        }


        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedIndex != -1 && lstSearchResults.SelectedItem != null)
            {
                try
                {
                    DBUtil.open_Connection(connection); // Open the connection if not already opened
                    string selectedTrainName = lstSearchResults.SelectedItem.ToString();

                    // Fetch detailed train information based on the selected train name
                    string detailedSql = $"SELECT * FROM train WHERE train_name = '{selectedTrainName}'";

                    using (MySqlCommand command = new MySqlCommand(detailedSql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string trainName = reader["train_name"].ToString();
                                /* MessageBox.Show($"ID: {id}\nTrain Name: {trainName}\n");*/

                                reader.Close();
                                HandleSelectedIndexChanged(id);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close(); // Close the connection if open
                    }
                }
            }
        }
        /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// ///

        private void HandleSelectedIndexChanged(int tid)
        {
            DBUtil.open_Connection(connection);

            // SQL query to retrieve train data
            string sql = $"SELECT * FROM train WHERE id=@tid";

            // Create MySqlCommand object
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.Parameters.AddWithValue("@tid", tid);

            // Execute the query and retrieve data
            using (MySqlDataReader reader = my.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    trainidlabel20.Text = reader.GetInt32(0).ToString();
                    train_name_textBox1.Text = reader.GetString(1);
                    int available_date = reader.GetInt32(2);

                    if (available_date == 0)
                    {
                        avdatelabel7.Text = "Weekdays and Weekend Available";
                    }
                    else if (available_date == 1)
                    {
                        avdatelabel7.Text = "Weekdays Available";
                    }
                    else if (available_date == 2)
                    {
                        avdatelabel7.Text = "Weekend Available";
                    };

                    label9.Text = reader.GetInt32(3).ToString();
                    label11.Text = reader.GetInt32(4).ToString();

                    int start_station_id = reader.GetInt32(5);
                    int end_station_id = reader.GetInt32(6);

                    reader.Close();

                    // Retrieve details for start station
                    string startStationSql = $"SELECT * FROM stations WHERE id=@startStationId";
                    MySqlCommand startStationCmd = new MySqlCommand(startStationSql, connection);
                    startStationCmd.Parameters.AddWithValue("@startStationId", start_station_id);

                    using (MySqlDataReader startStationReader = startStationCmd.ExecuteReader())
                    {
                        if (startStationReader.HasRows)
                        {
                            startStationReader.Read();
                            s_station_idlabel20.Text = startStationReader.GetInt32(0).ToString();
                            startstationtextBox1.Text = startStationReader.GetString(1);
                            int startRouteId = startStationReader.GetInt32(2);
                            startStationReader.Close();

                            // Retrieve route details for start station
                            string startRouteSql = $"SELECT * FROM route WHERE id=@startRouteId";
                            MySqlCommand startRouteCmd = new MySqlCommand(startRouteSql, connection);
                            startRouteCmd.Parameters.AddWithValue("@startRouteId", startRouteId);

                            using (MySqlDataReader startRouteReader = startRouteCmd.ExecuteReader())
                            {
                                if (startRouteReader.HasRows)
                                {
                                    startRouteReader.Read();
                                    start_routetnumberextBox3.Text = startRouteReader.GetString(2);
                                    start_route_name_textBox2.Text = startRouteReader.GetString(1);
                                }
                            }
                        }
                    }

                    // Retrieve details for end station
                    string endStationSql = $"SELECT * FROM stations WHERE id=@endStationId";
                    MySqlCommand endStationCmd = new MySqlCommand(endStationSql, connection);
                    endStationCmd.Parameters.AddWithValue("@endStationId", end_station_id);

                    using (MySqlDataReader endStationReader = endStationCmd.ExecuteReader())
                    {
                        if (endStationReader.HasRows)
                        {
                            endStationReader.Read();
                            e_station_id_label20.Text = endStationReader.GetInt32(0).ToString();
                            endstationtextBox1.Text = endStationReader.GetString(1);
                            int endRouteId = endStationReader.GetInt32(2);
                            endStationReader.Close();

                            // Retrieve route details for start station
                            string endRouteSql = $"SELECT * FROM route WHERE id=@endRouteId";
                            MySqlCommand endRouteCmd = new MySqlCommand(endRouteSql, connection);
                            endRouteCmd.Parameters.AddWithValue("@endRouteId", endRouteId);

                            using (MySqlDataReader endRouteReader = endRouteCmd.ExecuteReader())
                            {
                                if (endRouteReader.HasRows)
                                {
                                    endRouteReader.Read();
                                    endroutenumbertextBox4.Text = endRouteReader.GetString(2);
                                    end_route_nametextBox5.Text = endRouteReader.GetString(1);
                                }
                            }
                        }
                    }
                    /* string endStationSql = $"SELECT * FROM stations WHERE id=@endStationId";
                     MySqlCommand endStationCmd = new MySqlCommand(endStationSql, connection);
                     endStationCmd.Parameters.AddWithValue("@endStationId", end_station_id);

                     using (MySqlDataReader endStationReader = endStationCmd.ExecuteReader())
                     {
                         if (endStationReader.HasRows)
                         {
                             endStationReader.Read();
                             // Assuming these are the relevant UI elements for end station
                             textBox6.Text = endStationReader.GetString(1);
                             // Add logic to retrieve route details for end station if needed
                         }
                     }*/
                }
                else
                {
                    // Clear the text boxes if no rows are returned
                    // IDtextBox1.Clear();
                    // routeidtextBox2.Clear();
                    // routenumbertextBox1.Clear();
                }
            }
        }


        /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// ///

        private void startcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBUtil.open_Connection(connection);

                sql = $"SELECT * FROM stations WHERE station_name=@startcomboBox1";

                MySqlCommand my = new MySqlCommand(sql, connection);

                my.Parameters.AddWithValue("@startcomboBox1", startcomboBox1.SelectedItem);

                MySqlDataReader reader = my.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    sid.Text = reader.GetInt32(0).ToString();
                }
                else
                {
                }

                reader.Close();

                connection.Close();

                my.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.ToString());
            }
        }

        private void endcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBUtil.open_Connection(connection);

                sql = $"SELECT * FROM stations WHERE station_name=@endcomboBox2";

                MySqlCommand my = new MySqlCommand(sql, connection);

                my.Parameters.AddWithValue("@endcomboBox2", endcomboBox2.SelectedItem);

                MySqlDataReader reader = my.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    did.Text = reader.GetInt32(0).ToString();
                }
                else
                {
                }

                reader.Close();

                connection.Close();

                my.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.ToString());
            }
        }

        private void Searchgrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void clearlabel5_Click(object sender, EventArgs e)
        {
            sid.Text = "";
            did.Text = "";
            startcomboBox1.Text = "";
            endcomboBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectNumbers_Click(object sender, EventArgs e)
        {
            int start = int.Parse(label9.Text);
            int end = int.Parse(label11.Text);

            PopulateNumbers(start, end);
        }
        private void PopulateNumbers(int start, int end)
        {
            listBoxNumbers.Items.Clear();
            for (int i = start; i <= end; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }



        private List<int> GetSelectedNumbers()
        {
            List<int> selectedNumbers = new List<int>();

            if (listBoxNumbers.SelectedItems.Count > 5)
            {
                MessageBox.Show("You can only book 5 seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (int num in listBoxNumbers.SelectedItems)
                {
                    selectedNumbers.Add(num);
                }
            }

            return selectedNumbers;
        }

        private void btnGetSelected_Click(object sender, EventArgs e)
        {
            List<int> selectedNumbers = GetSelectedNumbers();

            listBoxSelectedNumbers.Items.Clear();
            foreach (int num in selectedNumbers)
            {
                listBoxSelectedNumbers.Items.Add(num);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cus_nametextbox.Text) ||
               string.IsNullOrWhiteSpace(cus_nictextBox2.Text) ||
               string.IsNullOrWhiteSpace(cus_addresstextBox3.Text) ||
               string.IsNullOrWhiteSpace(cus_contacttextBox4.Text) ||
               listBoxSelectedNumbers.Items.Count == 0)
            {
                MessageBox.Show("Please fill in all fields and select at least one seat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBUtil.open_Connection(connection);

            try
            {
                // Check if the NIC has already booked 5 seats
                string checkSql = "SELECT COUNT(*) FROM train_booking tb JOIN booking_seats bs ON tb.id = bs.train_booking_id WHERE tb.cus_id = @cus_id";
                MySqlCommand checkCmd = new MySqlCommand(checkSql, connection);
                checkCmd.Parameters.AddWithValue("@cus_id", cus_nictextBox2.Text);

                int bookedSeatsCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (bookedSeatsCount >= 5)
                {
                    MessageBox.Show("This NIC has already booked 5 seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert into train_booking table
                string insertBookingSql = $"INSERT INTO train_booking (train_id, start_station_id, end_station_id, cus_name, cus_id, cus_address, contact_number, date, u_id) VALUES (@train_id, @start_station_id, @end_station_id, @cus_name, @cus_id, @cus_address, @contact_number, @date, @u_id)";
                MySqlCommand insertBookingCmd = new MySqlCommand(insertBookingSql, connection);

                // Add parameters to the query to prevent SQL injection
                insertBookingCmd.Parameters.AddWithValue("@train_id", trainidlabel20.Text);
                insertBookingCmd.Parameters.AddWithValue("@start_station_id", s_station_idlabel20.Text);
                insertBookingCmd.Parameters.AddWithValue("@end_station_id", e_station_id_label20.Text);
                insertBookingCmd.Parameters.AddWithValue("@cus_name", cus_nametextbox.Text);
                insertBookingCmd.Parameters.AddWithValue("@cus_id", cus_nictextBox2.Text);
                insertBookingCmd.Parameters.AddWithValue("@cus_address", cus_addresstextBox3.Text);
                insertBookingCmd.Parameters.AddWithValue("@contact_number", cus_contacttextBox4.Text);
                insertBookingCmd.Parameters.AddWithValue("@date", cus_datedateTimePicker2.Text);
                insertBookingCmd.Parameters.AddWithValue("@u_id", useridlabel1.Text);

                // Execute the query
                insertBookingCmd.ExecuteNonQuery();

                // Get the ID of the last inserted row
                long bookingId = insertBookingCmd.LastInsertedId;

                // Insert into booking_seats table
                string insertSeatsSql = "INSERT INTO booking_seats (train_booking_id, seat_number) VALUES (@train_booking_id, @seat_number)";
                MySqlCommand insertSeatsCmd = new MySqlCommand(insertSeatsSql, connection);

                // Add parameters to the query
                insertSeatsCmd.Parameters.Add("@train_booking_id", MySqlDbType.Int64);
                insertSeatsCmd.Parameters.Add("@seat_number", MySqlDbType.Int32);

                // Add selected numbers to booking_seats table
                foreach (int seatNumber in listBoxSelectedNumbers.Items)
                {
                    // Add parameters to the query
                    insertSeatsCmd.Parameters["@train_booking_id"].Value = bookingId;
                    insertSeatsCmd.Parameters["@seat_number"].Value = seatNumber;

                    // Execute the query
                    insertSeatsCmd.ExecuteNonQuery();
                }

                // Show success message
                MessageBox.Show("Record Added Successfully!", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text boxes
                cus_nametextbox.Text = "";
                cus_nictextBox2.Text = "";
                cus_addresstextBox3.Text = "";
                cus_contacttextBox4.Text = "";

                connection.Close();
                insertBookingCmd.Dispose();
                insertSeatsCmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Get the selected date from dateTimePicker1
            DateTime selectedDate = dateTimePicker1.Value;

            // Determine if the selected date is a weekend or weekday
            string dayType = selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday ? "Weekend" : "Weekday";
            int avalibleDateValue = dayType == "Weekend" ? 2 : 1;

            // Open connection
            DBUtil.open_Connection(connection);


            string sql = "SELECT train_name FROM train WHERE avalible_date = @AvalibleDateValue";

            // Check if start_station_id is provided
            if (!string.IsNullOrEmpty(sid.Text))
            {
                sql += " AND start_station_id = @StartStationId";
            }

            // Check if end_station_id is provided
            if (!string.IsNullOrEmpty(did.Text))
            {
                sql += " AND end_station_id = @EndStationId";
            }


            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@AvalibleDateValue", avalibleDateValue);

                // Add start_station_id parameter if provided
                if (!string.IsNullOrEmpty(sid.Text))
                {
                    command.Parameters.AddWithValue("@StartStationId", sid.Text);
                }

                // Add end_station_id parameter if provided
                if (!string.IsNullOrEmpty(did.Text))
                {
                    command.Parameters.AddWithValue("@EndStationId", did.Text);
                }

                MySqlDataReader reader = command.ExecuteReader();

                lstSearchResults.Items.Clear(); // Clear existing items

                while (reader.Read())
                {
                    string trainName = reader["train_name"].ToString();
                    lstSearchResults.Items.Add(trainName); // Add train name to ListBox
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Close connection
            }
        }
    }


}
