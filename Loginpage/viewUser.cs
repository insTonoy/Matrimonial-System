using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Loginpage
{
    public partial class viewUser : UserControl
    {
        // Connection string for your SQL Server Express instance RAFA\SQLEXPRESS
        private readonly string _connectionString = "Data Source=RAFA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public viewUser()
        {
            InitializeComponent();
        }

        private void viewUser_Load(object sender, EventArgs e)
        {
            // Load users initially (unsorted or default)
            LoadUsers();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Ascending selected
            if (btnasc.Checked)
                LoadUsers("ASC");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Descending selected
            if (btndesc.Checked)
                LoadUsers("DESC");
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = this.FindForm();
            f?.Close();// Back button logic (existing)
        }

        /// <summary>
        /// Loads the signUp table into the DataGridView.
        /// If sortOrder is "ASC" or "DESC" it will append ORDER BY [dob] only if the column exists.
        /// </summary>
        private void LoadUsers(string? sortOrder = null)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();

                // Ensure table exists
                using (SqlCommand chk = new SqlCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='signUp'", conn))
                {
                    int exists = Convert.ToInt32(chk.ExecuteScalar() ?? 0);
                    if (exists == 0)
                    {
                        MessageBox.Show("Table dbo.signUp was not found in the 'login' database.", "Table Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Check whether column 'dob' exists (lowercase as in your DB)
                bool hasDob = false;
                using (SqlCommand chkCol = new SqlCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='signUp' AND COLUMN_NAME='dob'", conn))
                {
                    hasDob = Convert.ToInt32(chkCol.ExecuteScalar() ?? 0) > 0;
                }

                // Base query -- explicitly reference dbo
                string query = "SELECT * FROM dbo.signUp";

                // Append ORDER BY only when column exists
                if (!string.IsNullOrWhiteSpace(sortOrder))
                {
                    if (hasDob)
                    {
                        query += $" ORDER BY [dob] {(sortOrder.Equals("ASC", StringComparison.OrdinalIgnoreCase) ? "ASC" : "DESC")}";
                    }
                    else
                    {
                        MessageBox.Show("Column 'dob' not found in dbo.signUp; skipping sort.", "Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                using SqlCommand cmd = new SqlCommand(query, conn);
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dataGridView == null)
                {
                    MessageBox.Show("DataGridView control 'dataGridView' not found in Designer.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No rows returned from dbo.signUp.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQL error ({sqlex.Number}): {sqlex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}