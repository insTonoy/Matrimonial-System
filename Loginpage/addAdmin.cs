using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loginpage
{
    public partial class addAdmin : UserControl
    {
        private const string ConnString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True";

        public addAdmin()
        {
            InitializeComponent();

            btnconfirmA.Click += BtnconfirmA_Click;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            // Close the host dialog/form
            var f = this.FindForm();
            f?.Close();
        }

        private void BtnconfirmA_Click(object? sender, EventArgs e)
        {
            string user = txtuserA.Text.Trim();
            string pass = txtpassA.Text;
            string email = txtemailA.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Username and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                // Check login table for existing username
                using (var check = new SqlCommand("SELECT COUNT(*) FROM login WHERE Username=@u", con))
                {
                    check.Parameters.AddWithValue("@u", user);
                    int exists = Convert.ToInt32(check.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert into admin table
                using (var ins = new SqlCommand("INSERT INTO admin (Username, Password, Email) VALUES (@u,@p,@e)", con))
                {
                    ins.Parameters.AddWithValue("@u", user);
                    ins.Parameters.AddWithValue("@p", pass);
                    ins.Parameters.AddWithValue("@e", email);
                    ins.ExecuteNonQuery();
                }

                // Also insert into login table so the new admin can authenticate
                using (var ins2 = new SqlCommand("INSERT INTO login (Username, Password) VALUES (@u,@p)", con))
                {
                    ins2.Parameters.AddWithValue("@u", user);
                    ins2.Parameters.AddWithValue("@p", pass);
                    ins2.ExecuteNonQuery();
                }

                MessageBox.Show("Admin added successfully. Remember to select 'Admin' role at login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var f = this.FindForm();
                f?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnconfirmA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
