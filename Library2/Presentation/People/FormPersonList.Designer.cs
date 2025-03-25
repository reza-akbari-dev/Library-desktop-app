namespace Presentation.People
{
    partial class FormPersonList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonList));
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txt_BookName = new TextBox();
            label2 = new Label();
            txt_ISBN = new TextBox();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button11 = new Button();
            button12 = new Button();
            button9 = new Button();
            button10 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label6 = new Label();
            txt_FristName = new TextBox();
            label7 = new Label();
            txt_LastName = new TextBox();
            label5 = new Label();
            txt_NationalCode = new TextBox();
            Btn_Register = new Button();
            button13 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button18 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            Grid_People_List = new MyGridView();
            CelId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_People_List).BeginInit();
            SuspendLayout();
            // 
            // Column3
            // 
            Column3.HeaderText = "Id";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 11, 0, 0);
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            // 
            // txt_BookName
            // 
            txt_BookName.Location = new Point(3, 41);
            txt_BookName.Margin = new Padding(3, 10, 3, 3);
            txt_BookName.Name = "txt_BookName";
            txt_BookName.Size = new Size(145, 27);
            txt_BookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 11, 0, 0);
            label2.Size = new Size(105, 31);
            label2.TabIndex = 2;
            label2.Text = "National Code";
            // 
            // txt_ISBN
            // 
            txt_ISBN.Location = new Point(3, 112);
            txt_ISBN.Margin = new Padding(3, 10, 3, 3);
            txt_ISBN.Name = "txt_ISBN";
            txt_ISBN.Size = new Size(145, 27);
            txt_ISBN.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(5, 152);
            button1.Margin = new Padding(5, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Full Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "National Code";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 43);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 54);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBox2);
            flowLayoutPanel3.Controls.Add(button7);
            flowLayoutPanel3.Controls.Add(button8);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(188, 1);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 11, 0, 0);
            label3.Size = new Size(83, 31);
            label3.TabIndex = 0;
            label3.Text = "Full Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 41);
            textBox1.Margin = new Padding(3, 10, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 71);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 11, 0, 0);
            label4.Size = new Size(105, 31);
            label4.TabIndex = 2;
            label4.Text = "National Code";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 112);
            textBox2.Margin = new Padding(3, 10, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(5, 152);
            button7.Margin = new Padding(5, 10, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(115, 38);
            button7.TabIndex = 6;
            button7.Text = "Search";
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
            button8.Location = new Point(5, 203);
            button8.Margin = new Padding(5, 10, 3, 3);
            button8.Name = "button8";
            button8.Size = new Size(129, 38);
            button8.TabIndex = 7;
            button8.Text = "Print";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button11);
            flowLayoutPanel4.Controls.Add(button12);
            flowLayoutPanel4.Controls.Add(button9);
            flowLayoutPanel4.Controls.Add(button10);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, -6);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(188, 57);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLightLight;
            button11.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleRight;
            button11.Location = new Point(5, 10);
            button11.Margin = new Padding(5, 10, 3, 3);
            button11.Name = "button11";
            button11.Size = new Size(115, 38);
            button11.TabIndex = 7;
            button11.Text = "Submit";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLightLight;
            button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleRight;
            button12.Location = new Point(5, 61);
            button12.Margin = new Padding(5, 10, 3, 3);
            button12.Name = "button12";
            button12.Size = new Size(115, 38);
            button12.TabIndex = 8;
            button12.Text = "Edit";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleRight;
            button9.Location = new Point(5, 112);
            button9.Margin = new Padding(5, 10, 3, 3);
            button9.Name = "button9";
            button9.Size = new Size(115, 38);
            button9.TabIndex = 9;
            button9.Text = "Remove";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLightLight;
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleRight;
            button10.Location = new Point(5, 163);
            button10.Margin = new Padding(5, 10, 3, 3);
            button10.Name = "button10";
            button10.Size = new Size(115, 38);
            button10.TabIndex = 10;
            button10.Text = "Back";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_BookName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txt_ISBN);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(194, 14);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(5, 203);
            button2.Margin = new Padding(5, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 7;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 23);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(194, 74);
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
            button4.Location = new Point(5, 61);
            button4.Margin = new Padding(5, 10, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(115, 38);
            button4.TabIndex = 8;
            button4.Text = "Edit";
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
            button5.Location = new Point(5, 112);
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
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(5, 163);
            button6.Margin = new Padding(5, 10, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(115, 38);
            button6.TabIndex = 10;
            button6.Text = "Back";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label6);
            flowLayoutPanel5.Controls.Add(txt_FristName);
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Controls.Add(txt_LastName);
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(txt_NationalCode);
            flowLayoutPanel5.Controls.Add(Btn_Register);
            flowLayoutPanel5.Controls.Add(button13);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(784, 103);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 11, 0, 0);
            label6.Size = new Size(87, 31);
            label6.TabIndex = 14;
            label6.Text = "First Name :";
            // 
            // txt_FristName
            // 
            txt_FristName.Location = new Point(96, 10);
            txt_FristName.Margin = new Padding(3, 10, 3, 3);
            txt_FristName.Name = "txt_FristName";
            txt_FristName.Size = new Size(145, 27);
            txt_FristName.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 11, 0, 0);
            label7.Size = new Size(82, 31);
            label7.TabIndex = 16;
            label7.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(335, 10);
            txt_LastName.Margin = new Padding(3, 10, 3, 3);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(145, 27);
            txt_LastName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 11, 0, 0);
            label5.Size = new Size(108, 31);
            label5.TabIndex = 18;
            label5.Text = "National Code:";
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Location = new Point(600, 10);
            txt_NationalCode.Margin = new Padding(3, 10, 3, 3);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.Size = new Size(145, 27);
            txt_NationalCode.TabIndex = 19;
            // 
            // Btn_Register
            // 
            Btn_Register.BackColor = SystemColors.ControlLightLight;
            Btn_Register.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            Btn_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            Btn_Register.FlatStyle = FlatStyle.Flat;
            Btn_Register.Image = (Image)resources.GetObject("Btn_Register.Image");
            Btn_Register.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Register.Location = new Point(5, 50);
            Btn_Register.Margin = new Padding(5, 10, 3, 3);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(115, 38);
            Btn_Register.TabIndex = 20;
            Btn_Register.Text = "Search";
            Btn_Register.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Register.UseVisualStyleBackColor = false;
            Btn_Register.Click += Search_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlLightLight;
            button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleRight;
            button13.Location = new Point(128, 50);
            button13.Margin = new Padding(5, 10, 3, 3);
            button13.Name = "button13";
            button13.Size = new Size(115, 38);
            button13.TabIndex = 21;
            button13.Text = "Print";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ControlLightLight;
            button15.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button15.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleRight;
            button15.Location = new Point(251, 10);
            button15.Margin = new Padding(5, 10, 3, 3);
            button15.Name = "button15";
            button15.Size = new Size(115, 38);
            button15.TabIndex = 9;
            button15.Text = "Remove";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = false;
            button15.Click += Remove_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ControlLightLight;
            button16.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button16.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.ImageAlign = ContentAlignment.MiddleRight;
            button16.Location = new Point(374, 10);
            button16.Margin = new Padding(5, 10, 3, 3);
            button16.Name = "button16";
            button16.Size = new Size(115, 38);
            button16.TabIndex = 10;
            button16.Text = "Back";
            button16.TextAlign = ContentAlignment.MiddleLeft;
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ControlLightLight;
            button17.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.ImageAlign = ContentAlignment.MiddleRight;
            button17.Location = new Point(5, 10);
            button17.Margin = new Padding(5, 10, 3, 3);
            button17.Name = "button17";
            button17.Size = new Size(115, 38);
            button17.TabIndex = 7;
            button17.Text = "Submit";
            button17.TextAlign = ContentAlignment.MiddleLeft;
            button17.UseVisualStyleBackColor = false;
            button17.Click += Submit_Person_Click;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(button17);
            flowLayoutPanel6.Controls.Add(button18);
            flowLayoutPanel6.Controls.Add(button15);
            flowLayoutPanel6.Controls.Add(button16);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(3, 413);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(784, 57);
            flowLayoutPanel6.TabIndex = 2;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ControlLightLight;
            button18.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button18.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button18.FlatStyle = FlatStyle.Flat;
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.ImageAlign = ContentAlignment.MiddleRight;
            button18.Location = new Point(128, 10);
            button18.Margin = new Padding(5, 10, 3, 3);
            button18.Name = "button18";
            button18.Size = new Size(115, 38);
            button18.TabIndex = 8;
            button18.Text = "Edit";
            button18.TextAlign = ContentAlignment.MiddleLeft;
            button18.UseVisualStyleBackColor = false;
            button18.Click += Edit_Clik;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(Grid_People_List, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 301F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(790, 473);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // Grid_People_List
            // 
            Grid_People_List.AllowUserToAddRows = false;
            Grid_People_List.AllowUserToDeleteRows = false;
            Grid_People_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_People_List.BackgroundColor = Color.White;
            Grid_People_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_People_List.Columns.AddRange(new DataGridViewColumn[] { CelId, FullName, NationalCode });
            Grid_People_List.Dock = DockStyle.Fill;
            Grid_People_List.Location = new Point(3, 112);
            Grid_People_List.Name = "Grid_People_List";
            Grid_People_List.ReadOnly = true;
            Grid_People_List.RowHeadersWidth = 51;
            Grid_People_List.RowTemplate.Height = 29;
            Grid_People_List.Size = new Size(784, 295);
            Grid_People_List.TabIndex = 3;
            Grid_People_List.CellMouseClick += Grid_People_List_CellMouseClick;
            Grid_People_List.CellMouseDoubleClick += Grid_People_List_CellMouseDoubleClick;
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
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // NationalCode
            // 
            NationalCode.DataPropertyName = "NationalCode";
            NationalCode.HeaderText = "National Code";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            // 
            // FormPersonList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 473);
            Controls.Add(tableLayoutPanel3);
            Name = "FormPersonList";
            Text = "FormPersonList";
            Load += FormPersonList_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_People_List).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private TextBox txt_BookName;
        private Label label2;
        private TextBox txt_ISBN;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button11;
        private Button button12;
        private Button button9;
        private Button button10;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button button15;
        private Button button16;
        private Button button17;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button18;
        private TableLayoutPanel tableLayoutPanel3;
        private MyGridView Grid_People_List;
        private Label label6;
        private TextBox txt_FristName;
        private Label label7;
        private TextBox txt_NationalCode;
        private Label label5;
        private TextBox txt_LastName;
        private Button Btn_Register;
        private Button button13;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn NationalCode;
    }
}