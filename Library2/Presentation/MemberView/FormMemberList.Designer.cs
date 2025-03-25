namespace Presentation.MemberView
{
    partial class FormMemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemberList));
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Add_Member = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_FirstName = new TextBox();
            label2 = new Label();
            txt_LastName = new TextBox();
            label3 = new Label();
            txt_NationalCode = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            datePicker_FromMember = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label5 = new Label();
            datePicker_ToMember = new DateTimePicker();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Grid_MemberList = new MyGridView();
            Column4 = new DataGridViewTextBoxColumn();
            CelMId = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_MemberList).BeginInit();
            SuspendLayout();
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProofName";
            Column3.HeaderText = "Degree";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MemberDate";
            Column1.HeaderText = "Membership Date";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
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
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FieldName";
            Column2.HeaderText = "Field";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Add_Member);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 427);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(873, 57);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // Add_Member
            // 
            Add_Member.BackColor = SystemColors.ControlLightLight;
            Add_Member.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Add_Member.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            Add_Member.FlatStyle = FlatStyle.Flat;
            Add_Member.Image = (Image)resources.GetObject("Add_Member.Image");
            Add_Member.ImageAlign = ContentAlignment.MiddleRight;
            Add_Member.Location = new Point(5, 10);
            Add_Member.Margin = new Padding(5, 10, 3, 3);
            Add_Member.Name = "Add_Member";
            Add_Member.Size = new Size(115, 38);
            Add_Member.TabIndex = 7;
            Add_Member.Text = "Submit";
            Add_Member.TextAlign = ContentAlignment.MiddleLeft;
            Add_Member.UseVisualStyleBackColor = false;
            Add_Member.Click += Add_Member_Click;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_FirstName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txt_LastName);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txt_NationalCode);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(873, 117);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(87, 31);
            label1.TabIndex = 14;
            label1.Text = "First Name :";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(96, 10);
            txt_FirstName.Margin = new Padding(3, 10, 3, 3);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(145, 27);
            txt_FirstName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 0);
            label2.Size = new Size(82, 31);
            label2.TabIndex = 16;
            label2.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(335, 10);
            txt_LastName.Margin = new Padding(3, 10, 3, 3);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(145, 27);
            txt_LastName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 11, 0, 0);
            label3.Size = new Size(108, 31);
            label3.TabIndex = 18;
            label3.Text = "National Code:";
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Location = new Point(600, 10);
            txt_NationalCode.Margin = new Padding(3, 10, 3, 3);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.Size = new Size(145, 27);
            txt_NationalCode.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(datePicker_FromMember);
            flowLayoutPanel3.Location = new Point(3, 43);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(271, 61);
            flowLayoutPanel3.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "From :";
            // 
            // datePicker_FromMember
            // 
            datePicker_FromMember.Location = new Point(3, 23);
            datePicker_FromMember.Name = "datePicker_FromMember";
            datePicker_FromMember.Size = new Size(250, 27);
            datePicker_FromMember.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(datePicker_ToMember);
            flowLayoutPanel4.Location = new Point(280, 43);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(268, 61);
            flowLayoutPanel4.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 0;
            label5.Text = "To :";
            // 
            // datePicker_ToMember
            // 
            datePicker_ToMember.Location = new Point(3, 23);
            datePicker_ToMember.Name = "datePicker_ToMember";
            datePicker_ToMember.Size = new Size(250, 27);
            datePicker_ToMember.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(button1);
            flowLayoutPanel6.Controls.Add(button2);
            flowLayoutPanel6.Location = new Point(554, 43);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(251, 61);
            flowLayoutPanel6.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(20, 10);
            button1.Margin = new Padding(20, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 12;
            button1.Text = "Search";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Search_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(141, 10);
            button2.Margin = new Padding(20, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 13;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(Grid_MemberList, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 301F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(879, 487);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Grid_MemberList
            // 
            Grid_MemberList.AllowUserToAddRows = false;
            Grid_MemberList.AllowUserToDeleteRows = false;
            Grid_MemberList.BackgroundColor = Color.White;
            Grid_MemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_MemberList.Columns.AddRange(new DataGridViewColumn[] { Column4, CelMId, Column6, Column7, Column8 });
            Grid_MemberList.Dock = DockStyle.Fill;
            Grid_MemberList.Location = new Point(3, 126);
            Grid_MemberList.Name = "Grid_MemberList";
            Grid_MemberList.RowHeadersWidth = 51;
            Grid_MemberList.RowTemplate.Height = 29;
            Grid_MemberList.Size = new Size(873, 295);
            Grid_MemberList.TabIndex = 3;
            Grid_MemberList.CellMouseClick += Grid_MemberList_CellMouseClick;
            Grid_MemberList.CellMouseDoubleClick += Grid_MemberList_CellMouseDoubleClick;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.DataPropertyName = "FullName";
            Column4.HeaderText = "FullName";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 305;
            // 
            // CelMId
            // 
            CelMId.DataPropertyName = "Id";
            CelMId.HeaderText = "Id";
            CelMId.MinimumWidth = 6;
            CelMId.Name = "CelMId";
            CelMId.Visible = false;
            CelMId.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "MajorName";
            Column6.HeaderText = "Major";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ProofName";
            Column7.HeaderText = "Proof";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MemberDate";
            Column8.HeaderText = "Member Date Shipment";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 205;
            // 
            // FormMemberList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 487);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMemberList";
            Text = "FormMemberList";
            Load += FormMemberList_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_MemberList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Column2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button Add_Member;
        private Button button4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_FirstName;
        private Label label2;
        private TextBox txt_LastName;
        private Label label3;
        private TextBox txt_NationalCode;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private DateTimePicker datePicker_FromMember;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label5;
        private DateTimePicker datePicker_ToMember;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private MyGridView Grid_MemberList;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn CelMId;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}