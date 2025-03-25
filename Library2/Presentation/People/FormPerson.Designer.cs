namespace Presentation.People
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            tableLayoutPanel1 = new TableLayoutPanel();
            tab_Person = new TabControl();
            tabPage1 = new TabPage();
            pic_Person = new PictureBox();
            btn_Remove_pic = new Button();
            Btn_SelectPic = new Button();
            txt_NationalCode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_FristName = new TextBox();
            label2 = new Label();
            txt_LastName = new TextBox();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label7 = new Label();
            combo_communicationType = new ComboBox();
            label8 = new Label();
            txt_Value = new TextBox();
            button2 = new Button();
            button4 = new Button();
            Grid_Communication = new MyGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_Register = new Button();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tab_Person.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Person).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Communication).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tab_Person, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.41361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5863876F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(620, 433);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tab_Person
            // 
            tab_Person.AllowDrop = true;
            tab_Person.Controls.Add(tabPage1);
            tab_Person.Controls.Add(tabPage2);
            tab_Person.Dock = DockStyle.Fill;
            tab_Person.Location = new Point(3, 3);
            tab_Person.Name = "tab_Person";
            tab_Person.SelectedIndex = 0;
            tab_Person.Size = new Size(614, 346);
            tab_Person.TabIndex = 0;
            tab_Person.SelectedIndexChanged += tab_Person_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pic_Person);
            tabPage1.Controls.Add(btn_Remove_pic);
            tabPage1.Controls.Add(Btn_SelectPic);
            tabPage1.Controls.Add(txt_NationalCode);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_FristName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_LastName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(606, 313);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Peoples' Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pic_Person
            // 
            pic_Person.BackgroundImageLayout = ImageLayout.Stretch;
            pic_Person.Location = new Point(267, 10);
            pic_Person.Name = "pic_Person";
            pic_Person.Size = new Size(173, 181);
            pic_Person.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_Person.TabIndex = 0;
            pic_Person.TabStop = false;
            // 
            // btn_Remove_pic
            // 
            btn_Remove_pic.Location = new Point(271, 262);
            btn_Remove_pic.Name = "btn_Remove_pic";
            btn_Remove_pic.Size = new Size(173, 29);
            btn_Remove_pic.TabIndex = 2;
            btn_Remove_pic.Text = "Remove Pic";
            btn_Remove_pic.UseVisualStyleBackColor = true;
            btn_Remove_pic.Click += Remove_pic_Click;
            // 
            // Btn_SelectPic
            // 
            Btn_SelectPic.Location = new Point(267, 218);
            Btn_SelectPic.Name = "Btn_SelectPic";
            Btn_SelectPic.Size = new Size(177, 29);
            Btn_SelectPic.TabIndex = 1;
            Btn_SelectPic.Text = "............";
            Btn_SelectPic.UseVisualStyleBackColor = true;
            Btn_SelectPic.Click += Select_Pic;
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Location = new Point(33, 175);
            txt_NationalCode.Margin = new Padding(3, 10, 3, 3);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.Size = new Size(145, 27);
            txt_NationalCode.TabIndex = 13;
            txt_NationalCode.KeyPress += txt_NationalCode_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(2, 141);
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
            label5.Location = new Point(2, 71);
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
            label4.Location = new Point(6, 10);
            label4.Name = "label4";
            label4.Size = new Size(29, 38);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 11, 0, 0);
            label3.Size = new Size(108, 31);
            label3.TabIndex = 8;
            label3.Text = "National Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 7);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(87, 31);
            label1.TabIndex = 4;
            label1.Text = "First Name :";
            // 
            // txt_FristName
            // 
            txt_FristName.Location = new Point(35, 41);
            txt_FristName.Margin = new Padding(3, 10, 3, 3);
            txt_FristName.Name = "txt_FristName";
            txt_FristName.Size = new Size(145, 27);
            txt_FristName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 0);
            label2.Size = new Size(82, 31);
            label2.TabIndex = 6;
            label2.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(35, 106);
            txt_LastName.Margin = new Padding(3, 10, 3, 3);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(145, 27);
            txt_LastName.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(606, 313);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Communication";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.30128F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.69872F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel2.Controls.Add(Grid_Communication, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(600, 307);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(combo_communicationType);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(txt_Value);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(223, 301);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 10, 0, 0);
            label7.Size = new Size(172, 30);
            label7.TabIndex = 0;
            label7.Text = "Type Of Communication:";
            // 
            // combo_communicationType
            // 
            combo_communicationType.FormattingEnabled = true;
            combo_communicationType.Location = new Point(3, 33);
            combo_communicationType.Name = "combo_communicationType";
            combo_communicationType.Size = new Size(191, 28);
            combo_communicationType.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 64);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 10, 0, 0);
            label8.Size = new Size(62, 30);
            label8.TabIndex = 2;
            label8.Text = "content:";
            // 
            // txt_Value
            // 
            txt_Value.Location = new Point(3, 97);
            txt_Value.Name = "txt_Value";
            txt_Value.Size = new Size(191, 27);
            txt_Value.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(5, 137);
            button2.Margin = new Padding(5, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Add_Communication_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(5, 193);
            button4.Margin = new Padding(5, 15, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(115, 38);
            button4.TabIndex = 10;
            button4.Text = "Remove";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // Grid_Communication
            // 
            Grid_Communication.AllowUserToAddRows = false;
            Grid_Communication.AllowUserToDeleteRows = false;
            Grid_Communication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Communication.BackgroundColor = Color.White;
            Grid_Communication.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Communication.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            Grid_Communication.Dock = DockStyle.Fill;
            Grid_Communication.Location = new Point(232, 3);
            Grid_Communication.Name = "Grid_Communication";
            Grid_Communication.ReadOnly = true;
            Grid_Communication.RowHeadersWidth = 51;
            Grid_Communication.RowTemplate.Height = 29;
            Grid_Communication.Size = new Size(365, 301);
            Grid_Communication.TabIndex = 1;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "CommunicationTypeName";
            Column3.HeaderText = "Type";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Value";
            Column4.HeaderText = "Context";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_Register);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(614, 75);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Btn_Register
            // 
            Btn_Register.BackColor = SystemColors.ControlLightLight;
            Btn_Register.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Btn_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            Btn_Register.FlatStyle = FlatStyle.Flat;
            Btn_Register.Image = (Image)resources.GetObject("Btn_Register.Image");
            Btn_Register.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Register.Location = new Point(5, 10);
            Btn_Register.Margin = new Padding(5, 10, 3, 3);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(115, 38);
            Btn_Register.TabIndex = 8;
            Btn_Register.Text = "Confirm";
            Btn_Register.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Register.UseVisualStyleBackColor = false;
            Btn_Register.Click += Register_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.DialogResult = DialogResult.Cancel;
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
            // Column1
            // 
            Column1.HeaderText = "Type";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Content";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 433);
            Controls.Add(tableLayoutPanel1);
            Name = "FormPerson";
            Text = "FormPerson";
            Load += FormPerson_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tab_Person.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Person).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Communication).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tab_Person;
        private TabPage tabPage1;
        private TextBox txt_NationalCode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txt_FristName;
        private Label label2;
        private TextBox txt_LastName;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
        private ComboBox combo_communicationType;
        private Label label8;
        private TextBox txt_Value;
        private Button button2;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_Register;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pic_Person;
        private Button Btn_SelectPic;
        private Button btn_Remove_pic;
        private MyGridView Grid_Communication;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}