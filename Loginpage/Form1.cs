using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loginpage
{
    public partial class Home : Form
    {
        private const string ConnString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True";

        public Home()
        {
            InitializeComponent();

            // Populate role combo box with Admin and User
            rolebx.Items.Clear();
            rolebx.Items.AddRange(new object[] { "Admin", "User" });
            rolebx.DropDownStyle = ComboBoxStyle.DropDownList;
            rolebx.SelectedIndex = 1; // default to "User"
        }

        // Overload used by Signup to prefill credentials (if needed)
        public Home(string preUsername, string prePassword) : this()
        {
            textBox1.Text = preUsername ?? string.Empty;
            textBox2.Text = prePassword ?? string.Empty;
            textBox2.Focus();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConnString);
            con.Open();

            string query = "SELECT COUNT(*) FROM login WHERE Username=@Username AND Password=@Password";
            using var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                var selectedRole = rolebx.SelectedItem?.ToString() ?? "User";
                var username = textBox1.Text.Trim();

                // Determine if this account is an admin by checking the admin table.
                using var adminCmd = new SqlCommand("SELECT COUNT(*) FROM admin WHERE LOWER(Username)=LOWER(@Username)", con);
                adminCmd.Parameters.AddWithValue("@Username", username);
                int adminCount = Convert.ToInt32(adminCmd.ExecuteScalar());
                bool isAdmin = adminCount > 0;

                // If account exists in admin table, force Admin role selection
                if (isAdmin && !string.Equals(selectedRole, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Admin accounts must select the 'Admin' role to sign in. Please choose 'Admin' in the Role dropdown.", "Select Admin Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.Equals(selectedRole, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    if (!isAdmin)
                    {
                        MessageBox.Show("You are not authorized to sign in as Admin.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Set current admin username so Admin UI can prefill / lock username
                    Admin.CurrentAdminUsername = username;

                    var admin = new Admin();
                    admin.StartPosition = FormStartPosition.CenterScreen;
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    // User role allowed only for non-admin accounts
                    var userForm = new UserForm();
                    userForm.StartPosition = FormStartPosition.CenterScreen;
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login error! Check username/password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void passwordCk_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = passwordCk.Checked ? '\0' : '*';
        }

        private void fpasslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new forgetpass();
            frm.Show();
            this.Hide();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            var s = new Signup();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}