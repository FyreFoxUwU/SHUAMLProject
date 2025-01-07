using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LibraryManagement
{
    public partial class Fees : Form
    {
        string connectionString = "Data Source=db.db;Version=3;";
        public Fees()
        {
            InitializeComponent();
            LoadCurrentFines();
        }
        private void Fees_Load(object sender, EventArgs e)
        {
            // Call the method to load the user's current fines and display it
            
        }

        private void LoadCurrentFines()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to fetch currentFines from the User table
                    string query = "SELECT currentFines FROM User LIMIT 1";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Execute the query and retrieve the current fines
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Convert the result to a decimal (fines could be in float, decimal, or double)
                            decimal currentFines = Convert.ToDecimal(result);

                            // Display the fines in the feesLabel with a £ symbol
                            feesLabel.Text = "£" + currentFines.ToString("F2"); // Format to 2 decimal places

                            // Change the text color based on the value of currentFines
                            if (currentFines > 0)
                            {
                                feesLabel.ForeColor = System.Drawing.Color.Red; // Red if fines are greater than 0
                            }
                            else
                            {
                                feesLabel.ForeColor = System.Drawing.Color.Black; // Black if fines are 0
                            }
                        }
                        else
                        {
                            MessageBox.Show("No user data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the fines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
