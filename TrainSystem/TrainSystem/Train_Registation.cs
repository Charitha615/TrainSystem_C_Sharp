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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainSystem
{
    public partial class Train_Registation : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion
        String sql;

        public Train_Registation()
        {
            InitializeComponent();
        }

        private void Train_Registation_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, startstationnamecomboBox2, "station_name", "stations");
            ComponentClass.add_To_Combo(connection, endstationnamecomboBox3, "station_name", "stations");
            ComponentClass.add_To_Combo(connection, trainnamecomboBox4, "train_name", "train");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBUtil.open_Connection(connection);

                sql = $"SELECT * FROM stations WHERE station_name=@station_name";

                MySqlCommand my = new MySqlCommand(sql, connection);

                my.Parameters.AddWithValue("@station_name", startstationnamecomboBox2.SelectedItem);

                MySqlDataReader reader = my.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    startstationidtextBox1.Text = reader.GetInt32(0).ToString();
                    int routeId = reader.GetInt32(2);

                    reader.Close();

                    sql = $"SELECT * FROM route WHERE id=@route_id";
                    MySqlCommand my2 = new MySqlCommand(sql, connection);

                    my2.Parameters.AddWithValue("@route_id", routeId);

                    MySqlDataReader reader2 = my2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        // Read the first row
                        reader2.Read();

                        /*textBox2.Items.Clear();*/

                        startrouteidtextBox2.Text = reader2.GetInt32(0).ToString();
                        startroutenumbertextBox1.Text = reader2.GetString(2);
                        startroutetextBox2.Text = reader2.GetString(1);
                        /*selectroutecomboBox2.Items.Add(reader2.GetString(1));*/
                    }

                    reader2.Close();

                    /*ComponentClass.add_To_Combo(connection, selectroutecomboBox2, "route_name", "route");*/

                    my2.Dispose();

                }
                else
                {
                    // Clear the text boxes if no rows are returned
                    startstationidtextBox1.Clear();
                    startrouteidtextBox2.Clear();
                    startroutenumbertextBox1.Clear();
                }

                // Close the connection
                connection.Close();


                my.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBUtil.open_Connection(connection);

                sql = $"SELECT * FROM stations WHERE station_name=@station_name";

                MySqlCommand my = new MySqlCommand(sql, connection);

                my.Parameters.AddWithValue("@station_name", endstationnamecomboBox3.SelectedItem);

                MySqlDataReader reader = my.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    endtstationidtextBox1.Text = reader.GetInt32(0).ToString();
                    int routeId = reader.GetInt32(2);

                    reader.Close();

                    sql = $"SELECT * FROM route WHERE id=@route_id";
                    MySqlCommand my2 = new MySqlCommand(sql, connection);

                    my2.Parameters.AddWithValue("@route_id", routeId);

                    MySqlDataReader reader2 = my2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        // Read the first row
                        reader2.Read();

                        /*textBox2.Items.Clear();*/

                        endrouteid2textBox5.Text = reader2.GetInt32(0).ToString();
                        endroutenumber2textBox4.Text = reader2.GetString(2);
                        endroute2textBox3.Text = reader2.GetString(1);
                        /*selectroutecomboBox2.Items.Add(reader2.GetString(1));*/
                    }

                    reader2.Close();

                    /*ComponentClass.add_To_Combo(connection, selectroutecomboBox2, "route_name", "route");*/

                    my2.Dispose();

                }
                else
                {
                    // Clear the text boxes if no rows are returned
                    startstationidtextBox1.Clear();
                    startrouteidtextBox2.Clear();
                    startroutenumbertextBox1.Clear();
                }

                // Close the connection
                connection.Close();


                my.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);

            try
            {
                if (string.IsNullOrWhiteSpace(trainnamecomboBox4.Text) || string.IsNullOrWhiteSpace(startnumericUpDown1.Text) || string.IsNullOrWhiteSpace(endnumericUpDown2.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!checkBox1weekday.Checked && !checkBox2weeekend.Checked)
                {
                    MessageBox.Show("Please select weekend or weekdays.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if start station ID and end station ID are different
                if (startstationidtextBox1.Text == endtstationidtextBox1.Text)
                {
                    MessageBox.Show("Start station  and end station  cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (startnumericUpDown1.Text == endnumericUpDown2.Text)
                {
                    MessageBox.Show("Seat Numbers cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = $"INSERT INTO train (train_name, avalible_date, start_seat_no, end_seat_no, start_station_id, end_station_id) VALUES (@train_name, @avalible_date, @start_seat_no, @end_seat_no, @start_station_id, @end_station_id)";

                MySqlCommand my = new MySqlCommand(sql, connection);

                // Add parameters to the query to prevent SQL injection
                my.Parameters.AddWithValue("@train_name", trainnamecomboBox4.Text);

                int avalibleDateValue = 0;
                if (checkBox1weekday.Checked && !checkBox2weeekend.Checked)
                    avalibleDateValue = 1;
                else if (!checkBox1weekday.Checked && checkBox2weeekend.Checked)
                    avalibleDateValue = 2;

                my.Parameters.AddWithValue("@avalible_date", avalibleDateValue);
                my.Parameters.AddWithValue("@start_seat_no", startnumericUpDown1.Text);
                my.Parameters.AddWithValue("@end_seat_no", endnumericUpDown2.Text);
                my.Parameters.AddWithValue("@start_station_id", startstationidtextBox1.Text);
                my.Parameters.AddWithValue("@end_station_id", endtstationidtextBox1.Text);

                // Execute the query
                my.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Record Added Successfully!", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text boxes
                trainnamecomboBox4.Text = "";
                startnumericUpDown1.Text = "0";
                endnumericUpDown2.Text = "0";
                startstationidtextBox1.Text = "";
                checkBox1weekday.Checked = false;
                checkBox2weeekend.Checked = false;
                startstationnamecomboBox2.Text = "";
                startrouteidtextBox2.Text = "";
                startroutenumbertextBox1.Text = "";
                startroutetextBox2.Text = "";
                endstationnamecomboBox3.Text = "";
                endtstationidtextBox1.Text = "";
                endrouteid2textBox5.Text = "";
                endroutenumber2textBox4.Text = "";
                endroute2textBox3.Text = "";

                connection.Close();

                my.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }

        /*private void trainnamecomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (trainnamecomboBox4.SelectedItem != null)
                {
                    DBUtil.open_Connection(connection);

                    sql = $"SELECT * FROM train WHERE train_name=@train_name";

                    MySqlCommand my = new MySqlCommand(sql, connection);

                    my.Parameters.AddWithValue("@train_name", trainnamecomboBox4.SelectedItem.ToString());

                    MySqlDataReader reader = my.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        trainIDtextBox7.Text = reader.GetInt32(0).ToString();
                        int available_date = reader.GetInt32(2);

                        checkBox1weekday.Checked = available_date == 1 || available_date == 0;
                        checkBox2weeekend.Checked = available_date == 2 || available_date == 0;

                        startnumericUpDown1.Value = reader.GetInt32(3);
                        endnumericUpDown2.Value = reader.GetInt32(4);

                        int start_station_id = reader.GetInt32(5);
                        int end_station_id = reader.GetInt32(6);

                        reader.Close();

                        sql = $"SELECT * FROM stations WHERE id=@start_station_id";
                        MySqlCommand my2 = new MySqlCommand(sql, connection);

                        my2.Parameters.AddWithValue("@start_station_id", start_station_id);

                        MySqlDataReader reader2 = my2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            reader2.Read();

                            startstationnamecomboBox2.Items.Clear();

                            startstationidtextBox1.Text = reader2.GetInt32(0).ToString();
                            startstationnamecomboBox2.Text = reader2.GetString(1);

                            int start_route_id = reader2.GetInt32(2);

                            reader2.Close();

                            sql = $"SELECT * FROM route WHERE id=@start_route_id";
                            MySqlCommand my3 = new MySqlCommand(sql, connection);

                            my3.Parameters.AddWithValue("@start_route_id", start_route_id);

                            MySqlDataReader reader3 = my3.ExecuteReader();
                            if (reader3.HasRows)
                            {
                                reader3.Read();

                                startroutetextBox2.Text = reader3.GetString(1);
                                startrouteidtextBox2.Text = reader3.GetInt32(0).ToString();
                                startroutenumbertextBox1.Text = reader3.GetString(2);


                           *//*     int start_station_id = reader3.GetInt32(5);
                                MessageBox.Show("start_station_id IS  " + start_station_id);*//*

                                reader3.Close();
                            }
                            }

                        reader2.Close();
                        my2.Dispose();
                    }
                    else
                    {
                        // Clear the text boxes if no rows are returned
                        // IDtextBox1.Clear();
                        // routeidtextBox2.Clear();
                        // routenumbertextBox1.Clear();
                    }

                    connection.Close();
                    my.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.Message);
            }
        }*/

        private void trainnamecomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (trainnamecomboBox4.SelectedItem != null)
                {
                    DBUtil.open_Connection(connection);

                    sql = $"SELECT * FROM train WHERE train_name=@train_name";

                    MySqlCommand my = new MySqlCommand(sql, connection);

                    my.Parameters.AddWithValue("@train_name", trainnamecomboBox4.SelectedItem.ToString());

                    MySqlDataReader reader = my.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        trainIDtextBox7.Text = reader.GetInt32(0).ToString();
                        int available_date = reader.GetInt32(2);

                        checkBox1weekday.Checked = available_date == 1 || available_date == 0;
                        checkBox2weeekend.Checked = available_date == 2 || available_date == 0;

                        startnumericUpDown1.Value = reader.GetInt32(3);
                        endnumericUpDown2.Value = reader.GetInt32(4);

                        int start_station_id = reader.GetInt32(5);
                        int end_station_id = reader.GetInt32(6);

                        reader.Close();

                        // Retrieve start station details
                        sql = $"SELECT * FROM stations WHERE id=@start_station_id";
                        MySqlCommand my2 = new MySqlCommand(sql, connection);
                        my2.Parameters.AddWithValue("@start_station_id", start_station_id);
                        MySqlDataReader reader2 = my2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            reader2.Read();
                            startstationnamecomboBox2.Items.Clear();
                            startstationidtextBox1.Text = reader2.GetInt32(0).ToString();
                            startstationnamecomboBox2.Text = reader2.GetString(1);
                            int start_route_id = reader2.GetInt32(2);
                            reader2.Close();

                            // Retrieve start route details
                            sql = $"SELECT * FROM route WHERE id=@start_route_id";
                            MySqlCommand my3 = new MySqlCommand(sql, connection);
                            my3.Parameters.AddWithValue("@start_route_id", start_route_id);
                            MySqlDataReader reader3 = my3.ExecuteReader();

                            if (reader3.HasRows)
                            {
                                reader3.Read();
                                startroutetextBox2.Text = reader3.GetString(1);
                                startrouteidtextBox2.Text = reader3.GetInt32(0).ToString();
                                startroutenumbertextBox1.Text = reader3.GetString(2);
                                reader3.Close();
                            }
                        }

                        // Retrieve end station details
                        sql = $"SELECT * FROM stations WHERE id=@end_station_id";
                        MySqlCommand my4 = new MySqlCommand(sql, connection);
                        my4.Parameters.AddWithValue("@end_station_id", end_station_id);
                        MySqlDataReader reader4 = my4.ExecuteReader();

                        if (reader4.HasRows)
                        {
                            reader4.Read();
                            endstationnamecomboBox3.Items.Clear();
                            endtstationidtextBox1.Text = reader4.GetInt32(0).ToString();
                            endstationnamecomboBox3.Text = reader4.GetString(1);
                            int end_route_id = reader4.GetInt32(2);

            

                            reader4.Close();

                            // Retrieve start route details
                            sql = $"SELECT * FROM route WHERE id=@end_route_id";
                            MySqlCommand my5 = new MySqlCommand(sql, connection);
                            my5.Parameters.AddWithValue("@end_route_id", end_route_id);
                            MySqlDataReader reader5 = my5.ExecuteReader();

                            if (reader5.HasRows)
                            {
                                reader5.Read();
                                endroute2textBox3.Text = reader5.GetString(1);
                                endrouteid2textBox5.Text = reader5.GetInt32(0).ToString();
                                endroutenumber2textBox4.Text = reader5.GetString(2);
                                reader5.Close();
                            }
                        }

                        reader4.Close();
                        my4.Dispose();
                        reader2.Close();
                        my2.Dispose();

                        ComponentClass.add_To_Combo(connection, startstationnamecomboBox2, "station_name", "stations");
                        ComponentClass.add_To_Combo(connection, endstationnamecomboBox3, "station_name", "stations");
                    }
                    else
                    {
                        // Clear the text boxes if no rows are returned
                        // IDtextBox1.Clear();
                        // routeidtextBox2.Clear();
                        // routenumbertextBox1.Clear();
                    }

                    connection.Close();
                    my.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve ComboBox Values Error: " + ex.Message);
            }
        }


    }
}
