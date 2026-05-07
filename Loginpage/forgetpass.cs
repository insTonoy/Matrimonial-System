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
    public partial class forgetpass : Form
    {
        public forgetpass()
        {
            InitializeComponent();
        }

        private void forgetpass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
private void btnConfirm_Click(object sender, EventArgs e)
        {
            string user = textBox1?.Text?.Trim() ?? string.Empty;
            string currentPass = textBox4?.Text ?? string.Empty;
            string newPass = textBox2?.Text?.Trim() ?? string.Empty;
            string confirmPass = textBox3?.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(currentPass) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (!string.Equals(newPass, confirmPass, StringComparison.Ordinal))
            {
                MessageBox.Show("New passwords do not match!");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();

                string checkUser = @"SELECT COUNT(*) 
                                     FROM login 
                                     WHERE Username=@user AND Password=@currentPass";

                using (SqlCommand checkCmd = new SqlCommand(checkUser, con))
                {
                    checkCmd.Parameters.Add("@user", System.Data.SqlDbType.NVarChar, 256).Value = user;
                    checkCmd.Parameters.Add("@currentPass", System.Data.SqlDbType.NVarChar, 256).Value = currentPass;

                    int valid = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (valid == 0)
                    {
                        MessageBox.Show("Username or current password is incorrect!");
                        return;
                    }
                }

                string updatePass = @"UPDATE login 
                                      SET Password=@newPass 
                                      WHERE Username=@user";

                using (SqlCommand updateCmd = new SqlCommand(updatePass, con))
                {
                    updateCmd.Parameters.Add("@newPass", System.Data.SqlDbType.NVarChar, 256).Value = newPass;
                    updateCmd.Parameters.Add("@user", System.Data.SqlDbType.NVarChar, 256).Value = user;

                    updateCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Password changed successfully!");

            Home login = new Home();
            login.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home login = new Home();
            login.Show();
            this.Hide();
        }
    }
}