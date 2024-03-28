using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    class ComponentClass
    {
        public static void add_To_Combo(MySqlConnection connection, ComboBox combobox_Name, String column_Name, String Tabel_Name)
        {
            combobox_Name.Items.Clear();

            try
            {
                MySqlDataReader read;

                DBUtil.open_Connection(connection);

                String sql = $" select {column_Name} from {Tabel_Name}";

                MySqlCommand command = new MySqlCommand(sql, connection);

                read = command.ExecuteReader();

                while (read.Read())
                {
                    combobox_Name.Items.Add(read.GetString(0).ToString());
                }

                connection.Close();
                command.Dispose();
                read.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

    }
}
