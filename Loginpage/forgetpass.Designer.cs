namespace Loginpage
{
    partial class forgetpass
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnback = new Button();
            btnConfirm = new Button();
            txtConfirm = new Label();
            txtnpass = new Label();
            txtUser = new Label();
            txtCurr = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(333, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 22;
            // 
            // btnback
            // 
            btnback.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnback.Location = new Point(528, 351);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 36);
            btnback.TabIndex = 21;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(314, 351);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 36);
            btnConfirm.TabIndex = 20;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.AutoSize = true;
            txtConfirm.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtConfirm.Location = new Point(139, 277);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(166, 19);
            txtConfirm.TabIndex = 19;
            txtConfirm.Text = "Confirm Password";
            // 
            // txtnpass
            // 
            txtnpass.AutoSize = true;
            txtnpass.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtnpass.Location = new Point(139, 220);
            txtnpass.Name = "txtnpass";
            txtnpass.Size = new Size(130, 19);
            txtnpass.TabIndex = 18;
            txtnpass.Text = "New Password";
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.BackColor = SystemColors.ActiveCaption;
            txtUser.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(156, 109);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(95, 19);
            txtUser.TabIndex = 17;
            txtUser.Text = "Username";
            txtUser.Click += label1_Click;
            // 
            // txtCurr
            // 
            txtCurr.AutoSize = true;
            txtCurr.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCurr.Location = new Point(139, 164);
            txtCurr.Name = "txtCurr";
            txtCurr.Size = new Size(161, 19);
            txtCurr.TabIndex = 25;
            txtCurr.Text = "Current Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(333, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 27);
            textBox4.TabIndex = 26;
            // 
            // forgetpass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(txtCurr);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnback);
            Controls.Add(btnConfirm);
            Controls.Add(txtConfirm);
            Controls.Add(txtnpass);
            Controls.Add(txtUser);
            Name = "forgetpass";
            Text = "forgetpass";
            Load += forgetpass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnback;
        private Button btnConfirm;
        private Label txtConfirm;
        private Label txtnpass;
        private Label txtUser;
        private Label txtCurr;
        private TextBox textBox4;
    }
}