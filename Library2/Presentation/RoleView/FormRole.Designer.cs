namespace Presentation.RoleView
{
    partial class FormRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRole));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_RoleName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Grid_Role = new MyGridView();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            CelID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewLinkColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Role).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.99422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.00578F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(Grid_Role, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(555, 438);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_RoleName);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(199, 432);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(45, 30);
            label1.TabIndex = 0;
            label1.Text = "Title :";
            // 
            // txt_RoleName
            // 
            txt_RoleName.Location = new Point(3, 33);
            txt_RoleName.Name = "txt_RoleName";
            txt_RoleName.Size = new Size(165, 27);
            txt_RoleName.TabIndex = 1;
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
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(button1, "Click to submit");
            button1.UseVisualStyleBackColor = false;
            button1.Click += Add_Click;
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
            // Grid_Role
            // 
            Grid_Role.AllowUserToAddRows = false;
            Grid_Role.AllowUserToDeleteRows = false;
            Grid_Role.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Role.BackgroundColor = Color.White;
            Grid_Role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Role.Columns.AddRange(new DataGridViewColumn[] { CelID, Column1, Column2 });
            Grid_Role.Dock = DockStyle.Fill;
            Grid_Role.Location = new Point(208, 3);
            Grid_Role.Name = "Grid_Role";
            Grid_Role.RowHeadersWidth = 51;
            Grid_Role.RowTemplate.Height = 29;
            Grid_Role.Size = new Size(344, 432);
            Grid_Role.TabIndex = 1;
            Grid_Role.CellContentClick += Grid_Role_CellContentClick;
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
            // CelID
            // 
            CelID.DataPropertyName = "Id";
            CelID.HeaderText = "Id";
            CelID.MinimumWidth = 6;
            CelID.Name = "CelID";
            CelID.Visible = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "RoleName";
            Column1.HeaderText = "Role";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.ActiveLinkColor = Color.RoyalBlue;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Activity";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Text = "Allocate";
            Column2.UseColumnTextForLinkValue = true;
            Column2.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            // 
            // FormRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 438);
            Controls.Add(tableLayoutPanel1);
            Name = "FormRole";
            Text = "Form Role";
            Load += FormRole_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Role).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_RoleName;
        private Button button1;
        private ToolTip toolTip1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private MyGridView Grid_Role;
        private DataGridViewTextBoxColumn CelID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewLinkColumn Column2;
    }
}