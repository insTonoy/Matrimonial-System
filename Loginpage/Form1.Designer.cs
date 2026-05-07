namespace Loginpage
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            username = new Label();
            password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            fpasslink = new LinkLabel();
            passwordCk = new CheckBox();
            loginbtn = new Button();
            signupbtn = new Button();
            rolebx = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username.Location = new Point(61, 295);
            username.Name = "username";
            username.Size = new Size(102, 19);
            username.TabIndex = 1;
            username.Text = "Username";
            username.Click += username_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password.Location = new Point(61, 355);
            password.Name = "password";
            password.Size = new Size(96, 19);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 355);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // fpasslink
            // 
            fpasslink.AutoSize = true;
            fpasslink.Font = new Font("Lucida Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            fpasslink.Location = new Point(803, 390);
            fpasslink.Name = "fpasslink";
            fpasslink.Size = new Size(135, 17);
            fpasslink.TabIndex = 5;
            fpasslink.TabStop = true;
            fpasslink.Text = "Forget Password";
            fpasslink.LinkClicked += fpasslink_LinkClicked;
            // 
            // passwordCk
            // 
            passwordCk.AutoSize = true;
            passwordCk.Location = new Point(183, 405);
            passwordCk.Name = "passwordCk";
            passwordCk.Size = new Size(134, 24);
            passwordCk.TabIndex = 6;
            passwordCk.Text = "Show password";
            passwordCk.UseVisualStyleBackColor = true;
            passwordCk.CheckedChanged += passwordCk_CheckedChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Cyan;
            loginbtn.Font = new Font("Lucida Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(814, 285);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 29);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.Cyan;
            signupbtn.Font = new Font("Lucida Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signupbtn.Location = new Point(814, 336);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(94, 29);
            signupbtn.TabIndex = 8;
            signupbtn.Text = "Sign up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signinbtn_Click;
            // 
            // rolebx
            // 
            rolebx.FormattingEnabled = true;
            rolebx.Location = new Point(539, 294);
            rolebx.Name = "rolebx";
            rolebx.Size = new Size(96, 28);
            rolebx.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 298);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 10;
            label1.Text = "Role";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 441);
            Controls.Add(label1);
            Controls.Add(rolebx);
            Controls.Add(signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(passwordCk);
            Controls.Add(fpasslink);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Matrimonial Bangladesh";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label username;
        private Label password;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel fpasslink;
        private CheckBox passwordCk;
        private Button loginbtn;
        private Button signupbtn;
        private ComboBox rolebx;
        private Label label1;
    }
}
