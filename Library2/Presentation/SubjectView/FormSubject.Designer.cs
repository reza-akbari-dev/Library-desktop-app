namespace Presentation
{
    partial class FormSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubject));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_SubjectName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Grid_Subject = new DataGridView();
            SubjectName = new DataGridViewTextBoxColumn();
            BookCount = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Subject).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.99422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.00578F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(Grid_Subject, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(537, 414);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_SubjectName);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 408);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(58, 30);
            label1.TabIndex = 0;
            label1.Text = "Subject";
            // 
            // txt_SubjectName
            // 
            txt_SubjectName.Location = new Point(3, 33);
            txt_SubjectName.Name = "txt_SubjectName";
            txt_SubjectName.Size = new Size(165, 27);
            txt_SubjectName.TabIndex = 1;
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
            button1.Click += register_Click;
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
            button3.Click += New_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.DialogResult = DialogResult.Cancel;
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
            // Grid_Subject
            // 
            Grid_Subject.AllowUserToAddRows = false;
            Grid_Subject.AllowUserToDeleteRows = false;
            Grid_Subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Subject.BackgroundColor = SystemColors.ButtonFace;
            Grid_Subject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Subject.Columns.AddRange(new DataGridViewColumn[] { SubjectName, BookCount, CelId });
            Grid_Subject.Dock = DockStyle.Fill;
            Grid_Subject.Location = new Point(201, 3);
            Grid_Subject.Name = "Grid_Subject";
            Grid_Subject.ReadOnly = true;
            Grid_Subject.RowHeadersWidth = 51;
            Grid_Subject.RowTemplate.Height = 29;
            Grid_Subject.Size = new Size(333, 408);
            Grid_Subject.TabIndex = 1;
            Grid_Subject.CellMouseClick += Grid_Subject_CellMouseClick;
            Grid_Subject.CellMouseDoubleClick += Grid_Subject_CellMouseDoubleClick;
            // 
            // SubjectName
            // 
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Subject Name";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            // 
            // BookCount
            // 
            BookCount.DataPropertyName = "BookCount";
            BookCount.HeaderText = "Book Count";
            BookCount.MinimumWidth = 6;
            BookCount.Name = "BookCount";
            BookCount.ReadOnly = true;
            // 
            // CelId
            // 
            CelId.DataPropertyName = "Id";
            CelId.HeaderText = "Id";
            CelId.MinimumWidth = 6;
            CelId.Name = "CelId";
            CelId.ReadOnly = true;
            CelId.Visible = false;
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
            // FormSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 414);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSubject";
            Text = "FormSubject";
            Load += FormSubject_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Subject).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_SubjectName;
        private Button button1;
        private ToolTip toolTip1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private DataGridView Grid_Subject;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn BookCount;
        private DataGridViewTextBoxColumn CelId;
    }
}