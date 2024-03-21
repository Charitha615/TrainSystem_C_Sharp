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
            //Add_To_Combo method is implemented to read the table and view Qty Types in the combo box
            combobox_Name.Items.Clear();

            try
            {
                MySqlDataReader read;

                // opening the connection
                DBUtil.open_Connection(connection);

                //sql statment to get room types from the database
                String sql = $" select {column_Name} from {Tabel_Name}";

                //creating mysqlcommand object to pass sql statment and the connection string for execution
                MySqlCommand command = new MySqlCommand(sql, connection);

                //creating a reader object to pass the result of executed sql statment  
                read = command.ExecuteReader();

                //use while to loop through the reader and read for all the values.
                while (read.Read())
                {

                    //pass the value from reader to the combo box 
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


        //method to get listbox name and a value and pass them to the given listbox
        public static void add_To_List_Box(ListBox listbox, String item)
        {
            //Add passed item to list box
            listbox.Items.Add(item);
        }



        //method to get listbox name and remove selected item
        public static void Remove_List_Box_Item(ListBox listbox, String item)
        {
            //remove item
            foreach (int i in listbox.SelectedIndices)
            {
                listbox.Items.Remove(listbox.Items[i]);
            }
        }
    }
}
