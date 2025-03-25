namespace Presentation.BookView
{
    partial class FormBooklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooklist));
            ColId = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_BookName = new TextBox();
            label2 = new Label();
            txt_ISBN = new TextBox();
            label3 = new Label();
            combo_Subject = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Column3 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Grid_BookList = new MyGridView();
            Column4 = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Writers = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_BookList).BeginInit();
            SuspendLayout();
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_BookName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txt_ISBN);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(combo_Subject);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(997, 75);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(56, 31);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txt_BookName
            // 
            txt_BookName.Location = new Point(65, 10);
            txt_BookName.Margin = new Padding(3, 10, 3, 3);
            txt_BookName.Name = "txt_BookName";
            txt_BookName.Size = new Size(145, 27);
            txt_BookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 0);
            label2.Size = new Size(48, 31);
            label2.TabIndex = 2;
            label2.Text = "ISBN :";
            // 
            // txt_ISBN
            // 
            txt_ISBN.Location = new Point(270, 10);
            txt_ISBN.Margin = new Padding(3, 10, 3, 3);
            txt_ISBN.Name = "txt_ISBN";
            txt_ISBN.Size = new Size(145, 27);
            txt_ISBN.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 11, 0, 0);
            label3.Size = new Size(65, 31);
            label3.TabIndex = 4;
            label3.Text = "Subject :";
            // 
            // combo_Subject
            // 
            combo_Subject.FormattingEnabled = true;
            combo_Subject.Location = new Point(492, 10);
            combo_Subject.Margin = new Padding(3, 10, 3, 3);
            combo_Subject.Name = "combo_Subject";
            combo_Subject.Size = new Size(151, 28);
            combo_Subject.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(651, 10);
            button1.Margin = new Padding(5, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 6;
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
            button2.Location = new Point(774, 10);
            button2.Margin = new Padding(5, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 7;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ISBN";
            Column2.HeaderText = "ISBM";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Subject";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BookName";
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
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
            button3.Text = "Submit";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Add_List;
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
            button5.Click += Remove_Click;
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
            // Column3
            // 
            Column3.DataPropertyName = "Abstract";
            Column3.HeaderText = "Abstract";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 451);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(997, 57);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(Grid_BookList, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1003, 511);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Grid_BookList
            // 
            Grid_BookList.AllowUserToAddRows = false;
            Grid_BookList.AllowUserToDeleteRows = false;
            Grid_BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_BookList.BackgroundColor = Color.White;
            Grid_BookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_BookList.Columns.AddRange(new DataGridViewColumn[] { Column4, CelId, Column6, Column7, Writers });
            Grid_BookList.Dock = DockStyle.Fill;
            Grid_BookList.Location = new Point(3, 84);
            Grid_BookList.Name = "Grid_BookList";
            Grid_BookList.ReadOnly = true;
            Grid_BookList.RowHeadersWidth = 51;
            Grid_BookList.RowTemplate.Height = 29;
            Grid_BookList.Size = new Size(997, 361);
            Grid_BookList.TabIndex = 3;
            Grid_BookList.CellMouseClick += Grid_BookList_CellMouseClick;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "BookName";
            Column4.FillWeight = 62.0320854F;
            Column4.HeaderText = "Book Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // CelId
            // 
            CelId.DataPropertyName = "Id";
            CelId.HeaderText = "Column6";
            CelId.MinimumWidth = 6;
            CelId.Name = "CelId";
            CelId.ReadOnly = true;
            CelId.Visible = false;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ISBN";
            Column6.FillWeight = 62.0320854F;
            Column6.HeaderText = "ISBN";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "SubjectName";
            Column7.FillWeight = 62.0320854F;
            Column7.HeaderText = "Subject";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Writers
            // 
            Writers.DataPropertyName = "Writers";
            Writers.FillWeight = 213.903748F;
            Writers.HeaderText = "Writer";
            Writers.MinimumWidth = 6;
            Writers.Name = "Writers";
            Writers.ReadOnly = true;
            // 
            // FormBooklist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 511);
            Controls.Add(tableLayoutPanel1);
            Name = "FormBooklist";
            Text = "FormBooklist";
            Load += FormBooklist_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_BookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ColId;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_BookName;
        private Label label2;
        private TextBox txt_ISBN;
        private Label label3;
        private ComboBox combo_Subject;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridViewTextBoxColumn Column3;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private MyGridView Grid_BookList;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Writers;
    }
}