namespace Loginpage
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            btnAdminout = new Button();
            btnAdminadd = new Button();
            pictureBox2 = new PictureBox();
            btnAdminedit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAview = new Panel();
            btnAsearch = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnviewA = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btnAview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(btnAdminout);
            panel1.Controls.Add(btnAdminadd);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAdminedit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 706);
            panel1.TabIndex = 0;
            // 
            // btnAdminout
            // 
            btnAdminout.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdminout.Location = new Point(53, 615);
            btnAdminout.Name = "btnAdminout";
            btnAdminout.Size = new Size(150, 29);
            btnAdminout.TabIndex = 5;
            btnAdminout.Text = "Sign Out";
            btnAdminout.UseVisualStyleBackColor = true;
            btnAdminout.Click += btnAdminout_Click_1;
            // 
            // btnAdminadd
            // 
            btnAdminadd.Location = new Point(80, 461);
            btnAdminadd.Name = "btnAdminadd";
            btnAdminadd.Size = new Size(94, 29);
            btnAdminadd.TabIndex = 4;
            btnAdminadd.Text = "Add Admin";
            btnAdminadd.UseVisualStyleBackColor = true;
            btnAdminadd.Click += btnAdminadd_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(64, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnAdminedit
            // 
            btnAdminedit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminedit.Location = new Point(80, 230);
            btnAdminedit.Name = "btnAdminedit";
            btnAdminedit.Size = new Size(94, 29);
            btnAdminedit.TabIndex = 2;
            btnAdminedit.Text = "Edit Profile";
            btnAdminedit.UseVisualStyleBackColor = true;
            btnAdminedit.Click += btnAdminedit_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Script MT Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(294, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Panel";
            // 
            // btnAview
            // 
            btnAview.BackColor = Color.Teal;
            btnAview.Controls.Add(btnAsearch);
            btnAview.Controls.Add(pictureBox3);
            btnAview.Location = new Point(311, 68);
            btnAview.Name = "btnAview";
            btnAview.Size = new Size(664, 248);
            btnAview.TabIndex = 1;
            // 
            // btnAsearch
            // 
            btnAsearch.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsearch.Location = new Point(268, 175);
            btnAsearch.Name = "btnAsearch";
            btnAsearch.Size = new Size(110, 29);
            btnAsearch.TabIndex = 1;
            btnAsearch.Text = "Search User";
            btnAsearch.UseVisualStyleBackColor = true;
            btnAsearch.Click += btnAsearch_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(235, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(168, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(235, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnviewA
            // 
            btnviewA.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnviewA.Location = new Point(268, 149);
            btnviewA.Name = "btnviewA";
            btnviewA.Size = new Size(94, 29);
            btnviewA.TabIndex = 3;
            btnviewA.Text = "View";
            btnviewA.UseVisualStyleBackColor = true;
            btnviewA.Click += btnviewA_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Controls.Add(btnviewA);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(311, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 216);
            panel2.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 712);
            Controls.Add(panel2);
            Controls.Add(btnAview);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btnAview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAdminedit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAdminadd;
        private Button btnAdminout;
        private Panel btnAview;
        private PictureBox pictureBox3;
        private Button btnAsearch;
        private PictureBox pictureBox4;
        private Button btnviewA;
        private Panel panel2;
    }
}