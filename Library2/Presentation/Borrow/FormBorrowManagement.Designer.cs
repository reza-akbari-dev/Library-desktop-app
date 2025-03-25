namespace Presentation.Borrow
{
    partial class FormBorrowManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowManagement));
            label1 = new Label();
            lbl_SelectedMember = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Picker_BorrowDate = new DateTimePicker();
            label5 = new Label();
            txt_NumDay = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label6 = new Label();
            button2 = new Button();
            lbl_selected_member = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label8 = new Label();
            Combo_Subject = new Shared.MyComboBox();
            label9 = new Label();
            Combo_SubjectsBook = new Shared.MyComboBox();
            label10 = new Label();
            Picker_Date_Borrow = new DateTimePicker();
            label11 = new Label();
            Text_Number_Day = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            Grid_FormBorrow = new MyGridView();
            Column1 = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_FormBorrow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "Select Member :";
            // 
            // lbl_SelectedMember
            // 
            lbl_SelectedMember.AutoSize = true;
            lbl_SelectedMember.FlatStyle = FlatStyle.Flat;
            lbl_SelectedMember.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SelectedMember.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_SelectedMember.ImageAlign = ContentAlignment.MiddleRight;
            lbl_SelectedMember.Location = new Point(3, 72);
            lbl_SelectedMember.Name = "lbl_SelectedMember";
            lbl_SelectedMember.Padding = new Padding(0, 10, 10, 0);
            lbl_SelectedMember.Size = new Size(128, 52);
            lbl_SelectedMember.TabIndex = 20;
            lbl_SelectedMember.Text = "Member not selected";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(lbl_SelectedMember);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(194, 158);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(3, 34);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 15;
            button1.Text = "Member";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(296, 33);
            label2.TabIndex = 1;
            label2.Text = "Subject :";
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 0);
            label3.Size = new Size(296, 32);
            label3.TabIndex = 3;
            label3.Text = "Book :";
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 65);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 0);
            label4.Size = new Size(296, 33);
            label4.TabIndex = 5;
            label4.Text = "Date Borrow :";
            // 
            // Picker_BorrowDate
            // 
            Picker_BorrowDate.Location = new Point(3, 101);
            Picker_BorrowDate.Name = "Picker_BorrowDate";
            Picker_BorrowDate.Size = new Size(250, 27);
            Picker_BorrowDate.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 131);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 0);
            label5.Size = new Size(296, 36);
            label5.TabIndex = 7;
            label5.Text = "Number of Borrows day:";
            // 
            // txt_NumDay
            // 
            txt_NumDay.Location = new Point(3, 170);
            txt_NumDay.Name = "txt_NumDay";
            txt_NumDay.Size = new Size(250, 27);
            txt_NumDay.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(5, 210);
            button3.Margin = new Padding(5, 10, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(110, 38);
            button3.TabIndex = 10;
            button3.Text = "Submit";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(5, 261);
            button4.Margin = new Padding(5, 10, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(110, 38);
            button4.TabIndex = 11;
            button4.Text = "New";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(5, 312);
            button5.Margin = new Padding(5, 10, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(99, 38);
            button5.TabIndex = 12;
            button5.Text = "Remove";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.612545F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.387455F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(194, 74);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(Picker_BorrowDate);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(txt_NumDay);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(108, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(83, 68);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 491F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(895, 565);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Controls.Add(lbl_selected_member);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(889, 68);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Margin = new Padding(3, 10, 3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 0);
            label6.Size = new Size(131, 31);
            label6.TabIndex = 21;
            label6.Text = "Select Member :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(140, 13);
            button2.Margin = new Padding(3, 13, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(105, 35);
            button2.TabIndex = 22;
            button2.Text = "Member";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Select_Member_Click;
            // 
            // lbl_selected_member
            // 
            lbl_selected_member.AutoSize = true;
            lbl_selected_member.FlatStyle = FlatStyle.Flat;
            lbl_selected_member.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_selected_member.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_selected_member.ImageAlign = ContentAlignment.MiddleRight;
            lbl_selected_member.Location = new Point(251, 10);
            lbl_selected_member.Margin = new Padding(3, 10, 3, 0);
            lbl_selected_member.Name = "lbl_selected_member";
            lbl_selected_member.Padding = new Padding(0, 10, 10, 0);
            lbl_selected_member.Size = new Size(195, 31);
            lbl_selected_member.TabIndex = 23;
            lbl_selected_member.Text = "No member selected";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.25974F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.74026F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel4.Controls.Add(Grid_FormBorrow, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 77);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(881, 462);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Controls.Add(Combo_Subject);
            flowLayoutPanel4.Controls.Add(label9);
            flowLayoutPanel4.Controls.Add(Combo_SubjectsBook);
            flowLayoutPanel4.Controls.Add(label10);
            flowLayoutPanel4.Controls.Add(Picker_Date_Borrow);
            flowLayoutPanel4.Controls.Add(label11);
            flowLayoutPanel4.Controls.Add(Text_Number_Day);
            flowLayoutPanel4.Controls.Add(button6);
            flowLayoutPanel4.Controls.Add(button7);
            flowLayoutPanel4.Controls.Add(button8);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(348, 456);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // label8
            // 
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 10, 0, 0);
            label8.Size = new Size(82, 33);
            label8.TabIndex = 13;
            label8.Text = "Subject :";
            // 
            // Combo_Subject
            // 
            Combo_Subject.DisplayMember = "Name";
            Combo_Subject.FormattingEnabled = true;
            Combo_Subject.Location = new Point(91, 10);
            Combo_Subject.Margin = new Padding(3, 10, 3, 3);
            Combo_Subject.Name = "Combo_Subject";
            Combo_Subject.Size = new Size(208, 28);
            Combo_Subject.TabIndex = 22;
            Combo_Subject.ValueMember = "Id";
            Combo_Subject.SelectionChangeCommitted += myComboBox1_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 41);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 10, 0, 0);
            label9.Size = new Size(82, 32);
            label9.TabIndex = 14;
            label9.Text = "Book :";
            // 
            // Combo_SubjectsBook
            // 
            Combo_SubjectsBook.DisplayMember = "Name";
            Combo_SubjectsBook.FormattingEnabled = true;
            Combo_SubjectsBook.Location = new Point(91, 51);
            Combo_SubjectsBook.Margin = new Padding(3, 10, 3, 3);
            Combo_SubjectsBook.Name = "Combo_SubjectsBook";
            Combo_SubjectsBook.Size = new Size(208, 28);
            Combo_SubjectsBook.TabIndex = 23;
            Combo_SubjectsBook.ValueMember = "Id";
            // 
            // label10
            // 
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 82);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 10, 0, 0);
            label10.Size = new Size(296, 33);
            label10.TabIndex = 15;
            label10.Text = "Date Borrow :";
            // 
            // Picker_Date_Borrow
            // 
            Picker_Date_Borrow.Location = new Point(3, 118);
            Picker_Date_Borrow.Name = "Picker_Date_Borrow";
            Picker_Date_Borrow.Size = new Size(193, 27);
            Picker_Date_Borrow.TabIndex = 16;
            // 
            // label11
            // 
            label11.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 148);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 10, 0, 0);
            label11.Size = new Size(296, 36);
            label11.TabIndex = 17;
            label11.Text = "Number of Borrows day:";
            // 
            // Text_Number_Day
            // 
            Text_Number_Day.Location = new Point(3, 187);
            Text_Number_Day.Name = "Text_Number_Day";
            Text_Number_Day.Size = new Size(219, 27);
            Text_Number_Day.TabIndex = 18;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(5, 227);
            button6.Margin = new Padding(5, 10, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(191, 38);
            button6.TabIndex = 19;
            button6.Text = "Submit";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Add_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(5, 278);
            button7.Margin = new Padding(5, 10, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(191, 38);
            button7.TabIndex = 20;
            button7.Text = "New";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += New_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(5, 329);
            button8.Margin = new Padding(5, 10, 3, 3);
            button8.Name = "button8";
            button8.Size = new Size(191, 38);
            button8.TabIndex = 21;
            button8.Text = "Remove";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // Grid_FormBorrow
            // 
            Grid_FormBorrow.AllowUserToAddRows = false;
            Grid_FormBorrow.AllowUserToDeleteRows = false;
            Grid_FormBorrow.BackgroundColor = Color.White;
            Grid_FormBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_FormBorrow.Columns.AddRange(new DataGridViewColumn[] { Column1, CelId, Column3, Column4 });
            Grid_FormBorrow.Dock = DockStyle.Fill;
            Grid_FormBorrow.Location = new Point(357, 3);
            Grid_FormBorrow.Name = "Grid_FormBorrow";
            Grid_FormBorrow.ReadOnly = true;
            Grid_FormBorrow.RowHeadersWidth = 51;
            Grid_FormBorrow.RowTemplate.Height = 29;
            Grid_FormBorrow.Size = new Size(521, 456);
            Grid_FormBorrow.TabIndex = 1;
            Grid_FormBorrow.CellMouseClick += Grid_FormBorrow_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BookName";
            Column1.HeaderText = "Book";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 180;
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
            // Column3
            // 
            Column3.DataPropertyName = "BorrowDate";
            Column3.HeaderText = "Date of Borrow";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 155;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NumberOfDay";
            Column4.HeaderText = "number of day";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // FormBorrowManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 565);
            Controls.Add(tableLayoutPanel3);
            Name = "FormBorrowManagement";
            Text = "FormBorrowManagement";
            Load += FormBorrowManagement_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_FormBorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_SelectedMember;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker Picker_BorrowDate;
        private Label label5;
        private TextBox txt_NumDay;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label6;
        private Button button2;
        private Label lbl_selected_member;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button6;
        private Button button7;
        private Button button8;
        private MyGridView Grid_FormBorrow;
        private Shared.MyComboBox Combo_Subject;
        private Shared.MyComboBox Combo_SubjectsBook;
        private DateTimePicker Picker_Date_Borrow;
        private TextBox Text_Number_Day;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}