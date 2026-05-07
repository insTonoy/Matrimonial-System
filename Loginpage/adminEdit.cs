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
    public partial class adminEdit : UserControl
    {
        private const string ConnString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True";

        public adminEdit()
        {
            InitializeComponent();

            // Prefill username and lock editing
            textBox1.Text = Admin.CurrentAdminUsername ?? string.Empty;
            textBox1.ReadOnly = true;

            btnaUp.Click += BtnaUp_Click;
            btnaBack.Click += BtnaBack_Click;

            // Optionally load current admin details (email) from admin table
            LoadAdminDetails();
        }

        private void LoadAdminDetails()
        {
            var username = Admin.CurrentAdminUsername;
            if (string.IsNullOrEmpty(username)) return;

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                using var cmd = new SqlCommand("SELECT Password, Email FROM admin WHERE Username=@u", con);
                cmd.Parameters.AddWithValue("@u", username);
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    textBox2.Text = rdr["Password"]?.ToString() ?? string.Empty;
                    textBox3.Text = rdr["Email"]?.ToString() ?? string.Empty;
                }
            }
            catch
            {
                // ignore load errors silently or show message if preferred
            }
        }

        private void BtnaBack_Click(object? sender, EventArgs e)
        {
            var f = this.FindForm();
            f?.Close();
        }

        private void BtnaUp_Click(object? sender, EventArgs e)
        {
            var username = Admin.CurrentAdminUsername;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("No admin selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPass = textBox2.Text;
            string newEmail = textBox3.Text.Trim();

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                // Update admin table
                using (var cmd = new SqlCommand("UPDATE admin SET Password=@p, Email=@e WHERE Username=@u", con))
                {
                    cmd.Parameters.AddWithValue("@p", newPass);
                    cmd.Parameters.AddWithValue("@e", newEmail);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.ExecuteNonQuery();
                }

                // Keep login table password in sync
                using (var cmd2 = new SqlCommand("UPDATE login SET Password=@p WHERE Username=@u", con))
                {
                    cmd2.Parameters.AddWithValue("@p", newPass);
                    cmd2.Parameters.AddWithValue("@u", username);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = this.FindForm();
                f?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaUp_Click(object sender, EventArgs e)
        {

        }

        private void btnaBack_Click(object sender, EventArgs e)
        {

        }
    }
}