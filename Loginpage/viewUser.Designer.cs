namespace Loginpage
{
    partial class viewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewUser));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnasc = new RadioButton();
            btndesc = new RadioButton();
            btnback = new Button();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(985, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Modern No. 20", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(102, 54);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Modern No. 20", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(724, 58);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 2;
            label2.Text = "Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 165);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Sort by";
            label3.Click += label3_Click;
            // 
            // btnasc
            // 
            btnasc.AutoSize = true;
            btnasc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnasc.Location = new Point(154, 165);
            btnasc.Name = "btnasc";
            btnasc.Size = new Size(101, 24);
            btnasc.TabIndex = 4;
            btnasc.TabStop = true;
            btnasc.Text = "Ascending";
            btnasc.UseVisualStyleBackColor = true;
            btnasc.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btndesc
            // 
            btndesc.AutoSize = true;
            btndesc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btndesc.Location = new Point(333, 165);
            btndesc.Name = "btndesc";
            btndesc.Size = new Size(110, 24);
            btndesc.TabIndex = 5;
            btndesc.TabStop = true;
            btndesc.Text = "Descending";
            btndesc.UseVisualStyleBackColor = true;
            btndesc.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnback
            // 
            btnback.BackColor = Color.LightBlue;
            btnback.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnback.Location = new Point(832, 158);
            btnback.Name = "btnback";
            btnback.Size = new Size(138, 37);
            btnback.TabIndex = 6;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Location = new Point(3, 245);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 10);
            panel1.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.AliceBlue;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = SystemColors.InactiveCaption;
            dataGridView.Location = new Point(3, 261);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(981, 507);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // viewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(btnback);
            Controls.Add(btndesc);
            Controls.Add(btnasc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "viewUser";
            Size = new Size(987, 771);
            Load += viewUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton btnasc;
        private RadioButton btndesc;
        private Button btnback;
        private Panel panel1;
        private DataGridView dataGridView;
    }
}
