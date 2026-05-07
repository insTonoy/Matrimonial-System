using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Loginpage
{
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        // Public helper used by the parent searchUser control to fill fields and photo
        public void SetUserData(string email, string gender, string dob, string phone, string country, Image? photo)
        {
            txtemail.Text = email ?? string.Empty;
            txtgender.Text = gender ?? string.Empty;
            txtdob.Text = dob ?? string.Empty;
            txtphn.Text = phone ?? string.Empty;
            txtcountry.Text = country ?? string.Empty;

            // Dispose previous image to avoid file locks / memory leaks
            var prev = pbxUser.Image;
            if (prev != null)
            {
                pbxUser.Image = null;
                try { prev.Dispose(); } catch { }
            }

            if (photo != null)
            {
                // Use a clone to avoid sharing stream/locking issues
                pbxUser.Image = (Image)photo.Clone();
            }
            else
            {
                var defaultPath = Path.Combine(Application.StartupPath, "Screenshot 2026-01-01 140011.png");
                if (File.Exists(defaultPath))
                {
                    try
                    {
                        using var fs = File.OpenRead(defaultPath);
                        pbxUser.Image = Image.FromStream(fs);
                    }
                    catch
                    {
                        pbxUser.Image = null;
                    }
                }
                else
                {
                    pbxUser.Image = null;
                }
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxUser_Click(object sender, EventArgs e)
        {

        }
    }
}