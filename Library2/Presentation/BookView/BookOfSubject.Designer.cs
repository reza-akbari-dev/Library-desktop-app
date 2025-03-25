namespace Presentation.BookView
{
    partial class BookOfSubject
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
            Column1 = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            Grid_bookList = new MyGridView();
            BookName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Subject_lable = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_bookList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // ISBN
            // 
            ISBN.DataPropertyName = "ISBN";
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Grid_bookList, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7777786F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.22222F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Grid_bookList
            // 
            Grid_bookList.AllowUserToAddRows = false;
            Grid_bookList.AllowUserToDeleteRows = false;
            Grid_bookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_bookList.BackgroundColor = Color.White;
            Grid_bookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_bookList.Columns.AddRange(new DataGridViewColumn[] { BookName, Column2 });
            Grid_bookList.Dock = DockStyle.Fill;
            Grid_bookList.Location = new Point(3, 83);
            Grid_bookList.Name = "Grid_bookList";
            Grid_bookList.RowHeadersWidth = 51;
            Grid_bookList.RowTemplate.Height = 29;
            Grid_bookList.Size = new Size(794, 364);
            Grid_bookList.TabIndex = 0;
            // 
            // BookName
            // 
            BookName.DataPropertyName = "BookName";
            BookName.HeaderText = "Name";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ISBN";
            Column2.HeaderText = "ISBN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.Controls.Add(Subject_lable);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 74);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Subject_lable
            // 
            Subject_lable.AutoSize = true;
            Subject_lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Subject_lable.ImageAlign = ContentAlignment.TopCenter;
            Subject_lable.Location = new Point(3, 0);
            Subject_lable.Name = "Subject_lable";
            Subject_lable.Size = new Size(0, 28);
            Subject_lable.TabIndex = 0;
            // 
            // BookOfSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "BookOfSubject";
            Text = "BookOfSubject";
            Load += BookOfSubject_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_bookList).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ISBN;
        private TableLayoutPanel tableLayoutPanel1;
        private MyGridView Grid_bookList;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Column2;
        private Label Subject_lable;
    }
}