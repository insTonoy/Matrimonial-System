namespace Loginpage
{
    partial class addAdmin
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
            panel1 = new Panel();
            label1 = new Label();
            userA = new Label();
            passA = new Label();
            emailA = new Label();
            txtuserA = new TextBox();
            txtpassA = new TextBox();
            txtemailA = new TextBox();
            btnconfirmA = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 23);
            label1.Name = "label1";
            label1.Size = new Size(193, 48);
            label1.TabIndex = 0;
            label1.Text = "New Admin";
            // 
            // userA
            // 
            userA.AutoSize = true;
            userA.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userA.Location = new Point(94, 163);
            userA.Name = "userA";
            userA.Size = new Size(102, 19);
            userA.TabIndex = 1;
            userA.Text = "Username";
            // 
            // passA
            // 
            passA.AutoSize = true;
            passA.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passA.Location = new Point(94, 228);
            passA.Name = "passA";
            passA.Size = new Size(96, 19);
            passA.TabIndex = 2;
            passA.Text = "Password";
            // 
            // emailA
            // 
            emailA.AutoSize = true;
            emailA.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            emailA.Location = new Point(94, 287);
            emailA.Name = "emailA";
            emailA.Size = new Size(61, 19);
            emailA.TabIndex = 3;
            emailA.Text = "email";
            // 
            // txtuserA
            // 
            txtuserA.Location = new Point(246, 160);
            txtuserA.Name = "txtuserA";
            txtuserA.Size = new Size(192, 27);
            txtuserA.TabIndex = 4;
            // 
            // txtpassA
            // 
            txtpassA.Location = new Point(246, 228);
            txtpassA.Name = "txtpassA";
            txtpassA.Size = new Size(192, 27);
            txtpassA.TabIndex = 5;
            // 
            // txtemailA
            // 
            txtemailA.Location = new Point(246, 287);
            txtemailA.Name = "txtemailA";
            txtemailA.Size = new Size(192, 27);
            txtemailA.TabIndex = 6;
            // 
            // btnconfirmA
            // 
            btnconfirmA.BackColor = SystemColors.GradientActiveCaption;
            btnconfirmA.Location = new Point(198, 396);
            btnconfirmA.Name = "btnconfirmA";
            btnconfirmA.Size = new Size(94, 38);
            btnconfirmA.TabIndex = 7;
            btnconfirmA.Text = "Confirm";
            btnconfirmA.UseVisualStyleBackColor = false;
            btnconfirmA.Click += btnconfirmA_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(404, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // addAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnconfirmA);
            Controls.Add(txtemailA);
            Controls.Add(txtpassA);
            Controls.Add(txtuserA);
            Controls.Add(emailA);
            Controls.Add(passA);
            Controls.Add(userA);
            Controls.Add(panel1);
            Name = "addAdmin";
            Size = new Size(618, 489);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label userA;
        private Label passA;
        private Label emailA;
        private TextBox txtuserA;
        private TextBox txtpassA;
        private TextBox txtemailA;
        private Button btnconfirmA;
        private Button button1;
    }
}
