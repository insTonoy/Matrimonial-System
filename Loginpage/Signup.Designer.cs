namespace Loginpage
{
    partial class Signup
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
            label1 = new Label();
            textBox1 = new TextBox();
            txtuser = new Label();
            txtpass = new Label();
            textBox2 = new TextBox();
            txtdate = new DateTimePicker();
            txtdob = new Label();
            txtgender = new Label();
            txtgen = new ComboBox();
            txtcountry = new Label();
            textBox3 = new TextBox();
            txtphone = new Label();
            textBox4 = new TextBox();
            txtemail = new Label();
            textBox5 = new TextBox();
            txtconfirm = new Button();
            txtback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(352, 28);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 28);
            textBox1.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.AutoSize = true;
            txtuser.Location = new Point(26, 119);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(102, 19);
            txtuser.TabIndex = 2;
            txtuser.Text = "Username";
            // 
            // txtpass
            // 
            txtpass.AutoSize = true;
            txtpass.Location = new Point(504, 119);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(96, 19);
            txtpass.TabIndex = 3;
            txtpass.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(625, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 28);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtdate
            // 
            txtdate.CalendarFont = new Font("Lucida Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtdate.Location = new Point(154, 189);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(250, 28);
            txtdate.TabIndex = 5;
            // 
            // txtdob
            // 
            txtdob.AutoSize = true;
            txtdob.Location = new Point(35, 189);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(49, 19);
            txtdob.TabIndex = 6;
            txtdob.Text = "DOB";
            // 
            // txtgender
            // 
            txtgender.AutoSize = true;
            txtgender.Location = new Point(504, 198);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(75, 19);
            txtgender.TabIndex = 7;
            txtgender.Text = "Gender";
            // 
            // txtgen
            // 
            txtgen.FormattingEnabled = true;
            txtgen.Location = new Point(625, 198);
            txtgen.Name = "txtgen";
            txtgen.Size = new Size(201, 27);
            txtgen.TabIndex = 8;
            // 
            // txtcountry
            // 
            txtcountry.AutoSize = true;
            txtcountry.Location = new Point(35, 270);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(79, 19);
            txtcountry.TabIndex = 9;
            txtcountry.Text = "Country";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 28);
            textBox3.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.AutoSize = true;
            txtphone.Location = new Point(504, 276);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(69, 19);
            txtphone.TabIndex = 11;
            txtphone.Text = "Phone ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(625, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 28);
            textBox4.TabIndex = 12;
            // 
            // txtemail
            // 
            txtemail.AutoSize = true;
            txtemail.Location = new Point(35, 348);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(61, 19);
            txtemail.TabIndex = 13;
            txtemail.Text = "email";
            txtemail.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 339);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 28);
            textBox5.TabIndex = 14;
            // 
            // txtconfirm
            // 
            txtconfirm.BackColor = Color.Cyan;
            txtconfirm.Location = new Point(232, 478);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.Size = new Size(182, 41);
            txtconfirm.TabIndex = 15;
            txtconfirm.Text = "Confirm";
            txtconfirm.UseVisualStyleBackColor = false;
            txtconfirm.Click += txtconfirm_Click;
            // 
            // txtback
            // 
            txtback.BackColor = Color.Cyan;
            txtback.Location = new Point(637, 478);
            txtback.Name = "txtback";
            txtback.Size = new Size(124, 41);
            txtback.TabIndex = 16;
            txtback.Text = "Back";
            txtback.UseVisualStyleBackColor = false;
            txtback.Click += txtback_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1300, 580);
            Controls.Add(txtback);
            Controls.Add(txtconfirm);
            Controls.Add(textBox5);
            Controls.Add(txtemail);
            Controls.Add(textBox4);
            Controls.Add(txtphone);
            Controls.Add(textBox3);
            Controls.Add(txtcountry);
            Controls.Add(txtgen);
            Controls.Add(txtgender);
            Controls.Add(txtdob);
            Controls.Add(txtdate);
            Controls.Add(textBox2);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Signup";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label txtuser;
        private Label txtpass;
        private TextBox textBox2;
        private DateTimePicker txtdate;
        private Label txtdob;
        private Label txtgender;
        private ComboBox txtgen;
        private Label txtcountry;
        private TextBox textBox3;
        private Label txtphone;
        private TextBox textBox4;
        private Label txtemail;
        private TextBox textBox5;
        private Button txtconfirm;
        private Button txtback;

        // Add this method to the Signup partial class to resolve CS0103
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }
    }
}