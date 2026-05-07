
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Loginpage
{
    public partial class Signup : Form
    {
        private const string ConnString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True";

        public Signup()
        {
            InitializeComponent();

            txtgen.Items.Clear();
            txtgen.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtgen.DropDownStyle = ComboBoxStyle.DropDownList;
            if (txtgen.Items.Count > 0)
                txtgen.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtconfirm_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text?.Trim() ?? string.Empty;
            string password = textBox2.Text ?? string.Empty;
            string email = textBox5.Text?.Trim() ?? string.Empty;
            string phone = textBox4.Text?.Trim() ?? string.Empty;
            string gender = txtgen.SelectedItem?.ToString() ?? string.Empty;
            string country = textBox3.Text?.Trim() ?? string.Empty;
            string dob = txtdate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(email) &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                using var tran = con.BeginTransaction();

                try
                {
                    // check existing username (either table)
                    using (var checkCmd = new SqlCommand("SELECT COUNT(*) FROM login WHERE Username = @Username", con, tran))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Username already exists. Choose another.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tran.Rollback();
                            return;
                        }
                    }

                    // Insert full profile into signup table
                    // Make sure your DB has a table named 'signup' with these columns.
                    using (var insertSignup = new SqlCommand(
                        @"INSERT INTO signup (Username, Password, DOB, Gender, Country, Phone, Email)
                          VALUES (@Username, @Password, @DOB, @Gender, @Country, @Phone, @Email)", con, tran))
                    {
                        insertSignup.Parameters.AddWithValue("@Username", username);
                        insertSignup.Parameters.AddWithValue("@Password", password);
                        insertSignup.Parameters.AddWithValue("@DOB", dob);
                        insertSignup.Parameters.AddWithValue("@Gender", gender);
                        insertSignup.Parameters.AddWithValue("@Country", country);
                        insertSignup.Parameters.AddWithValue("@Phone", phone);
                        insertSignup.Parameters.AddWithValue("@Email", email);
                        insertSignup.ExecuteNonQuery();
                    }

                    // Insert into login table for authentication (keep existing behavior)
                    using (var insertLogin = new SqlCommand(
                        "INSERT INTO login (Username, Password) VALUES (@Username, @Password)", con, tran))
                    {
                        insertLogin.Parameters.AddWithValue("@Username", username);
                        insertLogin.Parameters.AddWithValue("@Password", password);
                        insertLogin.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Account created successfully. You will be returned to the login screen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Return to the login form and pre-fill the username/password so the user can log in.
                    var login = new Home(username, password); // overload added to Home (Form1.cs)
                    login.Show();
                    this.Hide();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtback_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }
    }
}