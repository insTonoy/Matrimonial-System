namespace Loginpage
{
    partial class adminEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminEdit));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            useradmin = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnaUp = new Button();
            btnaBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 96);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 48);
            label1.TabIndex = 0;
            label1.Text = "Edit Profile";
            // 
            // useradmin
            // 
            useradmin.AutoSize = true;
            useradmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            useradmin.Location = new Point(46, 178);
            useradmin.Name = "useradmin";
            useradmin.Size = new Size(88, 23);
            useradmin.TabIndex = 1;
            useradmin.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 234);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 296);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 3;
            label4.Text = "email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 6;
            // 
            // btnaUp
            // 
            btnaUp.BackColor = SystemColors.ControlLight;
            btnaUp.Location = new Point(184, 412);
            btnaUp.Name = "btnaUp";
            btnaUp.Size = new Size(94, 37);
            btnaUp.TabIndex = 7;
            btnaUp.Text = "Update";
            btnaUp.UseVisualStyleBackColor = false;
            btnaUp.Click += btnaUp_Click;
            // 
            // btnaBack
            // 
            btnaBack.BackColor = SystemColors.ControlLight;
            btnaBack.Location = new Point(365, 412);
            btnaBack.Name = "btnaBack";
            btnaBack.Size = new Size(94, 37);
            btnaBack.TabIndex = 8;
            btnaBack.Text = "Back";
            btnaBack.UseVisualStyleBackColor = false;
            btnaBack.Click += btnaBack_Click;
            // 
            // adminEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnaBack);
            Controls.Add(btnaUp);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(useradmin);
            Controls.Add(panel1);
            Name = "adminEdit";
            Size = new Size(547, 547);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label useradmin;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnaUp;
        private Button btnaBack;
    }
}
