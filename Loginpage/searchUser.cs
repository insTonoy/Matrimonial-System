using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loginpage
{
    public partial class searchUser : UserControl
    {
        private const string ConnString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True";

        public searchUser()
        {
            InitializeComponent();
            btnsearch.Click += Btnsearch_Click;
            btnback.Click += Btnback_Click;
            btndel.Click += Btndel_Click;
        }

        private search? GetSearchChild()
        {
            // designer field might not be accessible in some build setups;
            // find the child control by name at runtime as a safe fallback.
            var ctl = this.Controls.Find("search1", true).FirstOrDefault() as search;
            return ctl;
        }

        private void Btnback_Click(object? sender, EventArgs e)
        {
            var f = this.FindForm();
            f?.Close();
        }

        private void Btnsearch_Click(object? sender, EventArgs e)
        {
            var username = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter a username to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                using var cmd = new SqlCommand(
                    "SELECT Email, Gender, DOB, Phone, Country FROM signup WHERE Username = @u", con);
                cmd.Parameters.AddWithValue("@u", username);

                using var rdr = cmd.ExecuteReader();
                if (!rdr.Read())
                {
                    MessageBox.Show("User not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var emptyChild = GetSearchChild();
                    emptyChild?.SetUserData(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null);
                    return;
                }

                string email = rdr["Email"]?.ToString() ?? string.Empty;
                string gender = rdr["Gender"]?.ToString() ?? string.Empty;
                string dob = rdr["DOB"]?.ToString() ?? string.Empty;
                string phone = rdr["Phone"]?.ToString() ?? string.Empty;
                string country = rdr["Country"]?.ToString() ?? string.Empty;

                rdr.Close();

                Image? photo = null;
                try
                {
                    using var colCheck = new SqlCommand(
                        "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='signup' AND COLUMN_NAME='Photo'", con);
                    var colExists = colCheck.ExecuteScalar();
                    if (colExists != null)
                    {
                        using var photoCmd = new SqlCommand("SELECT Photo FROM signup WHERE Username = @u", con);
                        photoCmd.Parameters.AddWithValue("@u", username);
                        var photoObj = photoCmd.ExecuteScalar();
                        if (photoObj != null && photoObj != DBNull.Value)
                        {
                            if (photoObj is byte[] bytes)
                            {
                                using var ms = new MemoryStream(bytes);
                                photo = Image.FromStream(ms);
                            }
                            else
                            {
                                var path = photoObj.ToString() ?? string.Empty;
                                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                                {
                                    photo = Image.FromFile(path);
                                }
                                else if (!string.IsNullOrEmpty(path))
                                {
                                    // try base64 only if path is not empty
                                    try
                                    {
                                        var b = Convert.FromBase64String(path);
                                        using var ms2 = new MemoryStream(b);
                                        photo = Image.FromStream(ms2);
                                    }
                                    catch
                                    {
                                        photo = null;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    photo = null;
                }

                var child = GetSearchChild();
                child?.SetUserData(email, gender, dob, phone, country, photo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btndel_Click(object? sender, EventArgs e)
        {
            var username = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter a username to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Delete account '{username}'? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var con = new SqlConnection(ConnString);
                con.Open();

                using var tran = con.BeginTransaction();
                try
                {
                    using (var cmdDelSignup = new SqlCommand("DELETE FROM signup WHERE Username = @u", con, tran))
                    {
                        cmdDelSignup.Parameters.AddWithValue("@u", username);
                        cmdDelSignup.ExecuteNonQuery();
                    }

                    using (var cmdDelLogin = new SqlCommand("DELETE FROM login WHERE Username = @u", con, tran))
                    {
                        cmdDelLogin.Parameters.AddWithValue("@u", username);
                        cmdDelLogin.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Account deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var child = GetSearchChild();
                    child?.SetUserData(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null);
                    textBox1.Text = string.Empty;
                }
                catch (Exception exTran)
                {
                    tran.Rollback();
                    MessageBox.Show("Delete failed: " + exTran.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void search1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}