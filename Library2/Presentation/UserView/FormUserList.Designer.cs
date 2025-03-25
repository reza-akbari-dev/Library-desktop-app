namespace Presentation.UserView
{
    partial class FormUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserList));
            FullName = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_UserName = new TextBox();
            Search = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Grid_User = new MyGridView();
            Fullnam = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ColId = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_User).BeginInit();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 125;
            // 
            // CelId
            // 
            CelId.DataPropertyName = "Id";
            CelId.HeaderText = "Id";
            CelId.MinimumWidth = 6;
            CelId.Name = "CelId";
            CelId.ReadOnly = true;
            CelId.Visible = false;
            CelId.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UserName";
            Column1.HeaderText = "User Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(Grid_User, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(775, 514);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_UserName);
            flowLayoutPanel1.Controls.Add(Search);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(769, 78);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(89, 31);
            label1.TabIndex = 14;
            label1.Text = "User Name :";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(98, 10);
            txt_UserName.Margin = new Padding(3, 10, 3, 3);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(203, 27);
            txt_UserName.TabIndex = 15;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.ControlLightLight;
            Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            Search.FlatStyle = FlatStyle.Flat;
            Search.Image = (Image)resources.GetObject("Search.Image");
            Search.ImageAlign = ContentAlignment.MiddleRight;
            Search.Location = new Point(324, 10);
            Search.Margin = new Padding(20, 10, 3, 3);
            Search.Name = "Search";
            Search.Size = new Size(129, 38);
            Search.TabIndex = 7;
            Search.Text = "Search";
            Search.TextAlign = ContentAlignment.MiddleLeft;
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 454);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(769, 57);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(5, 10);
            button3.Margin = new Padding(5, 10, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(115, 38);
            button3.TabIndex = 7;
            button3.Text = "Add User";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Add_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(128, 10);
            button4.Margin = new Padding(5, 10, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(115, 38);
            button4.TabIndex = 8;
            button4.Text = "Edit";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Edit_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(251, 10);
            button5.Margin = new Padding(5, 10, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(115, 38);
            button5.TabIndex = 9;
            button5.Text = "Remove";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.DialogResult = DialogResult.Cancel;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(374, 10);
            button6.Margin = new Padding(5, 10, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(115, 38);
            button6.TabIndex = 10;
            button6.Text = "Back";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // Grid_User
            // 
            Grid_User.AllowUserToAddRows = false;
            Grid_User.AllowUserToDeleteRows = false;
            Grid_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_User.BackgroundColor = Color.White;
            Grid_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_User.Columns.AddRange(new DataGridViewColumn[] { Fullnam, UserName, ColId });
            Grid_User.Dock = DockStyle.Fill;
            Grid_User.Location = new Point(3, 87);
            Grid_User.Name = "Grid_User";
            Grid_User.RowHeadersWidth = 51;
            Grid_User.RowTemplate.Height = 29;
            Grid_User.Size = new Size(769, 361);
            Grid_User.TabIndex = 3;
            Grid_User.CellMouseClick += Grid_User_CellMouseClick;
            // 
            // Fullnam
            // 
            Fullnam.DataPropertyName = "FullName";
            Fullnam.HeaderText = "Full Name";
            Fullnam.MinimumWidth = 6;
            Fullnam.Name = "Fullnam";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 514);
            Controls.Add(tableLayoutPanel1);
            Name = "FormUserList";
            Text = "User List";
            Load += FormUserList_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn Column1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_UserName;
        private Button Search;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private MyGridView Grid_User;
        private DataGridViewTextBoxColumn Fullnam;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn ColId;
    }
}