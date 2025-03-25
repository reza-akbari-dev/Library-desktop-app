namespace Presentation.WriterView
{
    partial class FormWriterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWriterList));
            button4 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button2 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            FullName = new DataGridViewTextBoxColumn();
            CelId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_FirstName = new TextBox();
            label2 = new Label();
            txt_LastName = new TextBox();
            label3 = new Label();
            txt_Bioghraphy = new TextBox();
            Search = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button6 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            Grid_Writers = new MyGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            colid = new DataGridViewTextBoxColumn();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Writers).BeginInit();
            SuspendLayout();
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(textBox2);
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(textBox3);
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(939, 1);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 11, 0, 0);
            label4.Size = new Size(87, 31);
            label4.TabIndex = 14;
            label4.Text = "First Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 10);
            textBox1.Margin = new Padding(3, 10, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 11, 0, 0);
            label5.Size = new Size(82, 31);
            label5.TabIndex = 16;
            label5.Text = "Last Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 10);
            textBox2.Margin = new Padding(3, 10, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 11, 0, 0);
            label6.Size = new Size(108, 31);
            label6.TabIndex = 18;
            label6.Text = "National Code:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(600, 10);
            textBox3.Margin = new Padding(3, 10, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 27);
            textBox3.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(768, 10);
            button1.Margin = new Padding(20, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            button3.Click += Add_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button2);
            flowLayoutPanel4.Controls.Add(button7);
            flowLayoutPanel4.Controls.Add(button8);
            flowLayoutPanel4.Controls.Add(button9);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, -59);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(939, 57);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(5, 10);
            button2.Margin = new Padding(5, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 7;
            button2.Text = "Submit";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(128, 10);
            button7.Margin = new Padding(5, 10, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(115, 38);
            button7.TabIndex = 8;
            button7.Text = "Edit";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(251, 10);
            button8.Margin = new Padding(5, 10, 3, 3);
            button8.Name = "button8";
            button8.Size = new Size(115, 38);
            button8.TabIndex = 9;
            button8.Text = "Remove";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleRight;
            button9.Location = new Point(374, 10);
            button9.Margin = new Padding(5, 10, 3, 3);
            button9.Name = "button9";
            button9.Size = new Size(115, 38);
            button9.TabIndex = 10;
            button9.Text = "Back";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.FillWeight = 39.57219F;
            FullName.HeaderText = "Full Name";
            FullName.MaxInputLength = 22000;
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
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
            Column1.DataPropertyName = "Biography";
            Column1.FillWeight = 160.427811F;
            Column1.HeaderText = "Biography";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
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
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NationalCode";
            dataGridViewTextBoxColumn3.HeaderText = "National Code";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_FirstName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txt_LastName);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txt_Bioghraphy);
            flowLayoutPanel1.Controls.Add(Search);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(944, 98);
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
            label3.Size = new Size(85, 31);
            label3.TabIndex = 18;
            label3.Text = "Bioghraphy";
            // 
            // txt_Bioghraphy
            // 
            txt_Bioghraphy.Location = new Point(577, 10);
            txt_Bioghraphy.Margin = new Padding(3, 10, 3, 3);
            txt_Bioghraphy.Name = "txt_Bioghraphy";
            txt_Bioghraphy.Size = new Size(145, 27);
            txt_Bioghraphy.TabIndex = 19;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.ControlLightLight;
            Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            Search.FlatStyle = FlatStyle.Flat;
            Search.Image = (Image)resources.GetObject("Search.Image");
            Search.ImageAlign = ContentAlignment.MiddleRight;
            Search.Location = new Point(745, 10);
            Search.Margin = new Padding(20, 10, 3, 3);
            Search.Name = "Search";
            Search.Size = new Size(129, 38);
            Search.TabIndex = 7;
            Search.Text = "Search";
            Search.TextAlign = ContentAlignment.MiddleLeft;
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(Grid_Writers, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(950, 534);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 474);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(944, 57);
            flowLayoutPanel2.TabIndex = 2;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 54);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(945, 0);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // Grid_Writers
            // 
            Grid_Writers.AllowUserToAddRows = false;
            Grid_Writers.AllowUserToDeleteRows = false;
            Grid_Writers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Writers.BackgroundColor = Color.White;
            Grid_Writers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Writers.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, colid });
            Grid_Writers.Dock = DockStyle.Fill;
            Grid_Writers.Location = new Point(3, 107);
            Grid_Writers.Name = "Grid_Writers";
            Grid_Writers.ReadOnly = true;
            Grid_Writers.RowHeadersWidth = 51;
            Grid_Writers.RowTemplate.Height = 29;
            Grid_Writers.Size = new Size(944, 361);
            Grid_Writers.TabIndex = 3;
            Grid_Writers.CellMouseClick += Grid_Writers_CellMouseClick;
            Grid_Writers.CellMouseDoubleClick += Grid_Writers_CellMouseDoubleClick;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.FillWeight = 46.7914429F;
            Column2.HeaderText = "Full Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Biography";
            Column3.FillWeight = 128.208557F;
            Column3.HeaderText = "Biography";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // colid
            // 
            colid.DataPropertyName = "Id";
            colid.HeaderText = "Id";
            colid.MinimumWidth = 6;
            colid.Name = "colid";
            colid.ReadOnly = true;
            colid.Visible = false;
            // 
            // FormWriterList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 534);
            Controls.Add(tableLayoutPanel1);
            Name = "FormWriterList";
            Text = "FormWriterList";
            Load += FormWriterList_Load;
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Writers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Button button1;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button2;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn Column1;
        private Button button5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_FirstName;
        private Label label2;
        private TextBox txt_LastName;
        private Label label3;
        private TextBox txt_Bioghraphy;
        private Button Search;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel2;
        private MyGridView Grid_Writers;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn colid;
    }
}