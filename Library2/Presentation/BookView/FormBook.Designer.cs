namespace Presentation.BookView
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            txt_Abstract = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            combo_BookSubject = new ComboBox();
            label1 = new Label();
            txt_BookName = new TextBox();
            label2 = new Label();
            txt_ISBN = new TextBox();
            tabPage1 = new TabPage();
            tabContr_Writer = new TabControl();
            tabPage2 = new TabPage();
            Grid_writer = new DataGridView();
            CellRemove = new DataGridViewLinkColumn();
            FullName = new DataGridViewTextBoxColumn();
            Biography = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            Link_Lbl_Writer = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabContr_Writer.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_writer).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(128, 10);
            button1.Margin = new Padding(5, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 388);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(759, 82);
            flowLayoutPanel1.TabIndex = 1;
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
            button3.TabIndex = 8;
            button3.Text = "Confirm";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Regester_Book_Click;
            // 
            // txt_Abstract
            // 
            txt_Abstract.Location = new Point(35, 244);
            txt_Abstract.Margin = new Padding(3, 10, 3, 3);
            txt_Abstract.Multiline = true;
            txt_Abstract.Name = "txt_Abstract";
            txt_Abstract.Size = new Size(693, 82);
            txt_Abstract.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 205);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 11, 0, 0);
            label7.Size = new Size(71, 31);
            label7.TabIndex = 13;
            label7.Text = "Abstract :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(-1, 138);
            label6.Name = "label6";
            label6.Size = new Size(29, 38);
            label6.TabIndex = 12;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(-1, 68);
            label5.Name = "label5";
            label5.Size = new Size(29, 38);
            label5.TabIndex = 11;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(29, 38);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 134);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 11, 0, 0);
            label3.Size = new Size(65, 31);
            label3.TabIndex = 8;
            label3.Text = "Subject :";
            // 
            // combo_BookSubject
            // 
            combo_BookSubject.FormattingEnabled = true;
            combo_BookSubject.Location = new Point(35, 172);
            combo_BookSubject.Margin = new Padding(3, 10, 3, 3);
            combo_BookSubject.Name = "combo_BookSubject";
            combo_BookSubject.Size = new Size(151, 28);
            combo_BookSubject.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(56, 31);
            label1.TabIndex = 4;
            label1.Text = "Name :";
            // 
            // txt_BookName
            // 
            txt_BookName.Location = new Point(35, 41);
            txt_BookName.Margin = new Padding(3, 10, 3, 3);
            txt_BookName.Name = "txt_BookName";
            txt_BookName.Size = new Size(145, 27);
            txt_BookName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 0);
            label2.Size = new Size(48, 31);
            label2.TabIndex = 6;
            label2.Text = "ISBN :";
            // 
            // txt_ISBN
            // 
            txt_ISBN.Location = new Point(35, 101);
            txt_ISBN.Margin = new Padding(3, 10, 3, 3);
            txt_ISBN.Name = "txt_ISBN";
            txt_ISBN.Size = new Size(145, 27);
            txt_ISBN.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_Abstract);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(combo_BookSubject);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_BookName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_ISBN);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(751, 346);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books' Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabContr_Writer
            // 
            tabContr_Writer.Controls.Add(tabPage1);
            tabContr_Writer.Controls.Add(tabPage2);
            tabContr_Writer.Dock = DockStyle.Fill;
            tabContr_Writer.Location = new Point(3, 3);
            tabContr_Writer.Name = "tabContr_Writer";
            tabContr_Writer.SelectedIndex = 0;
            tabContr_Writer.Size = new Size(759, 379);
            tabContr_Writer.TabIndex = 0;
            tabContr_Writer.SelectedIndexChanged += tabContr_Writer_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Grid_writer);
            tabPage2.Controls.Add(Link_Lbl_Writer);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(751, 346);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Writers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grid_writer
            // 
            Grid_writer.AllowUserToAddRows = false;
            Grid_writer.AllowUserToDeleteRows = false;
            Grid_writer.BackgroundColor = SystemColors.ButtonFace;
            Grid_writer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_writer.Columns.AddRange(new DataGridViewColumn[] { CellRemove, FullName, Biography, CelId });
            Grid_writer.Location = new Point(5, 67);
            Grid_writer.Name = "Grid_writer";
            Grid_writer.ReadOnly = true;
            Grid_writer.RowHeadersWidth = 51;
            Grid_writer.RowTemplate.Height = 29;
            Grid_writer.Size = new Size(743, 266);
            Grid_writer.TabIndex = 3;
            Grid_writer.CellContentClick += Grid_writer_CellContentClick;
            // 
            // CellRemove
            // 
            CellRemove.ActiveLinkColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 0, 192);
            CellRemove.DefaultCellStyle = dataGridViewCellStyle1;
            CellRemove.HeaderText = "Remove";
            CellRemove.LinkBehavior = LinkBehavior.HoverUnderline;
            CellRemove.LinkColor = Color.FromArgb(128, 128, 255);
            CellRemove.MinimumWidth = 6;
            CellRemove.Name = "CellRemove";
            CellRemove.ReadOnly = true;
            CellRemove.Text = "Remove";
            CellRemove.UseColumnTextForLinkValue = true;
            CellRemove.VisitedLinkColor = Color.Blue;
            CellRemove.Width = 75;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 175;
            // 
            // Biography
            // 
            Biography.DataPropertyName = "Biography";
            Biography.HeaderText = "Biography";
            Biography.MinimumWidth = 6;
            Biography.Name = "Biography";
            Biography.ReadOnly = true;
            Biography.Width = 515;
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
            // Link_Lbl_Writer
            // 
            Link_Lbl_Writer.AutoSize = true;
            Link_Lbl_Writer.Location = new Point(6, 13);
            Link_Lbl_Writer.Name = "Link_Lbl_Writer";
            Link_Lbl_Writer.Size = new Size(128, 20);
            Link_Lbl_Writer.TabIndex = 2;
            Link_Lbl_Writer.TabStop = true;
            Link_Lbl_Writer.Text = "Choose the Writer";
            Link_Lbl_Writer.Click += Choose_Writer_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tabContr_Writer, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.41361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5863876F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(765, 473);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 473);
            Controls.Add(tableLayoutPanel1);
            Name = "FormBook";
            Text = "FormBook";
            Load += FormBook_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabContr_Writer.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_writer).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private TextBox txt_Abstract;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox combo_BookSubject;
        private Label label1;
        private TextBox txt_BookName;
        private Label label2;
        private TextBox txt_ISBN;
        private TabPage tabPage1;
        private TabControl tabContr_Writer;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage2;
        private LinkLabel Link_Lbl_Writer;
        private DataGridView Grid_writer;
        private DataGridViewLinkColumn CellRemove;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Biography;
        private DataGridViewTextBoxColumn CelId;
    }
}