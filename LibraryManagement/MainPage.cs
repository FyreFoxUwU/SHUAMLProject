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

namespace LibraryManagement
{
    public partial class MainPage : Form
    {
        // Connection string to the SQLite database (db.db)
        string connectionString = "Data Source=db.db;Version=3;";

        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the search query from textBox1
            string searchQuery = textBox1.Text.Trim();

            // Ensure the search query is not empty
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the method to fetch data from the database
            FetchBookData(searchQuery);
        }

        private void FetchBookData(string searchQuery)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to search for books by title, author, or ISBN
                    string query = "SELECT title, author, ISBN FROM Book WHERE title LIKE @SearchQuery OR author LIKE @SearchQuery OR ISBN LIKE @SearchQuery LIMIT 1";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Use parameterized queries to prevent SQL injection
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Execute the query and read the results
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string bookTitle = reader["title"].ToString();
                                string bookAuthor = reader["author"].ToString();
                                string bookISBN = reader["isbn"].ToString();

                                bookTitleLabel.Text = "Title: " + bookTitle;
                                bookAuthorLabel.Text = "Author: " + bookAuthor;
                                bookISBNLabel.Text = "ISBN: " + bookISBN;
                            }
                            else
                            {
                                MessageBox.Show("No book found matching the search query.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fees feesForm = new Fees();
            feesForm.Show();
            this.Hide();
        }
    }
}
