namespace Presentation
{
    partial class FormMajor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMajor));
            Grid_Major = new DataGridView();
            MajorName = new DataGridViewTextBoxColumn();
            ColID = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_MajerName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)Grid_Major).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Grid_Major
            // 
            Grid_Major.AllowUserToAddRows = false;
            Grid_Major.AllowUserToDeleteRows = false;
            Grid_Major.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Major.BackgroundColor = SystemColors.ButtonHighlight;
            Grid_Major.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Major.Columns.AddRange(new DataGridViewColumn[] { MajorName, ColID });
            Grid_Major.Dock = DockStyle.Fill;
            Grid_Major.Location = new Point(236, 3);
            Grid_Major.Name = "Grid_Major";
            Grid_Major.ReadOnly = true;
            Grid_Major.RowHeadersWidth = 51;
            Grid_Major.RowTemplate.Height = 29;
            Grid_Major.Size = new Size(391, 461);
            Grid_Major.TabIndex = 1;
            Grid_Major.CellMouseClick += Grid_Major_CellMouseClick;
            // 
            // MajorName
            // 
            MajorName.DataPropertyName = "MajorName";
            MajorName.HeaderText = "Major name";
            MajorName.MinimumWidth = 6;
            MajorName.Name = "MajorName";
            MajorName.ReadOnly = true;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "Id";
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.99422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.00578F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(Grid_Major, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(630, 467);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_MajerName);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(227, 461);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(48, 30);
            label1.TabIndex = 0;
            label1.Text = "Major";
            // 
            // txt_MajerName
            // 
            txt_MajerName.Location = new Point(3, 33);
            txt_MajerName.Name = "txt_MajerName";
            txt_MajerName.Size = new Size(183, 27);
            txt_MajerName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(3, 66);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(button1, "Click to submit");
            button1.UseVisualStyleBackColor = false;
            button1.Click += regester_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(3, 101);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 3;
            button2.Text = "Remove";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(button2, "Click to remove");
            button2.UseVisualStyleBackColor = false;
            button2.Click += Remove_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(3, 136);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 4;
            button3.Text = "New";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(button3, "Click to new");
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(3, 171);
            button4.Name = "button4";
            button4.Size = new Size(117, 29);
            button4.TabIndex = 5;
            button4.Text = "Back";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(button4, "Click to back");
            button4.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "222.jpg");
            imageList1.Images.SetKeyName(1, "back.jpg");
            imageList1.Images.SetKeyName(2, "close.jpg");
            imageList1.Images.SetKeyName(3, "download.jpg");
            imageList1.Images.SetKeyName(4, "edit.jpg");
            imageList1.Images.SetKeyName(5, "Go-back-icon.jpg");
            imageList1.Images.SetKeyName(6, "icon-of-delete-in-flat-style-trash-bin-vector.jpg");
            imageList1.Images.SetKeyName(7, "images.jpg");
            imageList1.Images.SetKeyName(8, "kisspng-computer-icons-button-5ae031e2bf0904.7825510515246422747825aaa.jpg");
            imageList1.Images.SetKeyName(9, "open.jpg");
            imageList1.Images.SetKeyName(10, "Screenshot (431)0.jpg");
            imageList1.Images.SetKeyName(11, "Screenshot (431)1.jpg");
            imageList1.Images.SetKeyName(12, "Screenshot (431)2.jpg");
            imageList1.Images.SetKeyName(13, "Screenshot (431)3.jpg");
            imageList1.Images.SetKeyName(14, "Screenshot (431)4.jpg");
            imageList1.Images.SetKeyName(15, "Screenshot (431)5.jpg");
            imageList1.Images.SetKeyName(16, "Screenshot (431)8.jpg");
            // 
            // FormMajor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 467);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMajor";
            Text = "FormMajor";
            Load += FormMajor_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Major).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid_Major;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_MajerName;
        private Button button1;
        private ToolTip toolTip1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn MajorName;
        private DataGridViewTextBoxColumn ColID;
    }
}