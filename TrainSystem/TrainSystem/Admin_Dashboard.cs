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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Create an instance of the new form
            Route_Registation Route_Registation = new Route_Registation();

            // Show the new form
            Route_Registation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Stations_Registation Stations_Registation = new Stations_Registation();

            // Show the new form
            Stations_Registation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Train_Registation Train_Registation = new Train_Registation();

            // Show the new form
            Train_Registation.Show();
        }
    }
}
