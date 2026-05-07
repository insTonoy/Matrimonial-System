using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loginpage
{
    public partial class Admin : Form
    {
        // Static holder for the currently-logged-in admin username.
        // Set this from the login form before showing Admin.
        public static string? CurrentAdminUsername { get; set; }

        public Admin()
        {
            InitializeComponent();

            try
            {
                // enable the buttons so they can be used
                btnAsearch.Enabled = true;
                btnviewA.Enabled = true;
            }
            catch
            {

            }

            btnAdminout.Click += BtnAdminout_Click;
            btnAdminadd.Click += BtnAdminadd_Click;
            btnAdminedit.Click += BtnAdminedit_Click;
        }

        private void BtnAdminadd_Click(object? sender, EventArgs e)
        {
            try
            {
                var uc = new addAdmin();
                var dialog = new Form
                {
                    Text = "Add Admin",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MinimizeBox = false,
                    MaximizeBox = false,
                    ShowIcon = false,
                    ClientSize = new Size(Math.Max(uc.Width, 500), Math.Max(uc.Height, 400))
                };
                uc.Dock = DockStyle.Fill;
                dialog.Controls.Add(uc);
                dialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Add Admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdminedit_Click(object? sender, EventArgs e)
        {
            try
            {
                var uc = new adminEdit();
                var dialog = new Form
                {
                    Text = "Edit Admin Profile",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MinimizeBox = false,
                    MaximizeBox = false,
                    ShowIcon = false,
                    ClientSize = new Size(Math.Max(uc.Width, 500), Math.Max(uc.Height, 400))
                };
                uc.Dock = DockStyle.Fill;
                dialog.Controls.Add(uc);
                dialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Edit Profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdminout_Click(object? sender, EventArgs e)
        {
            var login = new Home();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            this.Close();
        }

        private void btnAdminedit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdminadd_Click_1(object sender, EventArgs e)
        {

        }

        // Open Search User dialog (wired by the designer)
        private void btnAsearch_Click(object sender, EventArgs e)
        {
            try
            {
                var uc = new searchUser();
                var dialog = new Form
                {
                    Text = "Search User",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MinimizeBox = false,
                    MaximizeBox = false,
                    ShowIcon = false,
                    ClientSize = new Size(Math.Max(uc.Width, 800), Math.Max(uc.Height, 480))
                };
                uc.Dock = DockStyle.Fill;
                dialog.Controls.Add(uc);
                dialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Search User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open View Users dialog (wired by the designer)
        private void btnviewA_Click(object sender, EventArgs e)
        {
            try
            {
                var uc = new viewUser();
                var dialog = new Form
                {
                    Text = "View Users",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MinimizeBox = false,
                    MaximizeBox = false,
                    ShowIcon = false,
                    ClientSize = new Size(Math.Max(uc.Width, 800), Math.Max(uc.Height, 480))
                };
                uc.Dock = DockStyle.Fill;
                dialog.Controls.Add(uc);
                dialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open View Users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnAdminout_Click_1(object sender, EventArgs e)
        {

        }
    }

}