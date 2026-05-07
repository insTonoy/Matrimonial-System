namespace Loginpage
{
    partial class searchUser
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


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnback = new Button();
            btndel = new Button();
            btnsearch = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            search1 = new search();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnback);
            panel1.Controls.Add(btndel);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 484);
            panel1.TabIndex = 0;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.HotTrack;
            btnback.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.ForeColor = SystemColors.ButtonHighlight;
            btnback.Location = new Point(61, 396);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 38);
            btnback.TabIndex = 4;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            // 
            // btndel
            // 
            btndel.BackColor = SystemColors.HotTrack;
            btndel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndel.ForeColor = SystemColors.ButtonHighlight;
            btndel.Location = new Point(61, 215);
            btndel.Name = "btndel";
            btndel.Size = new Size(94, 37);
            btndel.TabIndex = 3;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = false;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.HotTrack;
            btnsearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = SystemColors.Control;
            btnsearch.Location = new Point(61, 139);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 40);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // search1
            // 
            search1.Location = new Point(247, 2);
            search1.Name = "search1";
            search1.Size = new Size(743, 478);
            search1.TabIndex = 1;
            // 
            // searchUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(search1);
            Controls.Add(panel1);
            Name = "searchUser";
            Size = new Size(993, 486);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button btnsearch;
        private Button btnback;
        private Button btndel;
        private FolderBrowserDialog folderBrowserDialog1;
        private search search1;
    }
}
