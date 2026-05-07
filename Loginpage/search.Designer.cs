namespace Loginpage
{
    partial class search
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
        // Add this method to your partial class 'search' (in search.cs or here if needed)
        private void search_Load(object sender, EventArgs e)
        {
            // You can leave this empty or add initialization code here if needed.
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtemail = new TextBox();
            txtgender = new TextBox();
            txtdob = new TextBox();
            txtphn = new TextBox();
            txtcountry = new TextBox();
            pbxUser = new PictureBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(697, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 127);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 1;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 187);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 246);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 3;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 304);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 378);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 5;
            label5.Text = "Country";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(159, 127);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(205, 27);
            txtemail.TabIndex = 6;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtgender
            // 
            txtgender.Location = new Point(159, 187);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(205, 27);
            txtgender.TabIndex = 7;
            txtgender.TextChanged += txtgender_TextChanged;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(159, 246);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(205, 27);
            txtdob.TabIndex = 8;
            txtdob.TextChanged += txtdob_TextChanged;
            // 
            // txtphn
            // 
            txtphn.Location = new Point(159, 304);
            txtphn.Name = "txtphn";
            txtphn.Size = new Size(205, 27);
            txtphn.TabIndex = 9;
            txtphn.TextChanged += txtphn_TextChanged;
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(159, 378);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(205, 27);
            txtcountry.TabIndex = 10;
            txtcountry.TextChanged += txtcountry_TextChanged;
            // 
            // pbxUser
            // 
            pbxUser.Image = (Image)resources.GetObject("pbxUser.Image");
            pbxUser.Location = new Point(464, 148);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(186, 179);
            pbxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUser.TabIndex = 11;
            pbxUser.TabStop = false;
            pbxUser.Click += pbxUser_Click;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbxUser);
            Controls.Add(txtcountry);
            Controls.Add(txtphn);
            Controls.Add(txtdob);
            Controls.Add(txtgender);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "search";
            Size = new Size(697, 488);
            Load += search_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtemail;
        private TextBox txtgender;
        private TextBox txtdob;
        private TextBox txtphn;
        private TextBox txtcountry;
        private PictureBox pbxUser;
        private BindingSource bindingSource1;
    }
}
