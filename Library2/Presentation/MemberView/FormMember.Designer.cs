namespace Presentation.MemberView
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            date_MemberDate = new DateTimePicker();
            lbl_Selectedperson = new Label();
            button6 = new Button();
            button3 = new Button();
            label2 = new Label();
            Combo_Proof = new Shared.MyComboBox();
            Combo_Major = new Shared.MyComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(159, 18);
            button1.Name = "button1";
            button1.Size = new Size(132, 35);
            button1.TabIndex = 25;
            button1.Text = "Person";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Select_Person_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 24;
            label1.Text = "Choose the Person :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 32;
            label4.Text = "Feild :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 31;
            label3.Text = "Education Level :";
            // 
            // date_MemberDate
            // 
            date_MemberDate.Location = new Point(159, 72);
            date_MemberDate.Name = "date_MemberDate";
            date_MemberDate.Size = new Size(250, 27);
            date_MemberDate.TabIndex = 30;
            // 
            // lbl_Selectedperson
            // 
            lbl_Selectedperson.AutoSize = true;
            lbl_Selectedperson.FlatStyle = FlatStyle.Flat;
            lbl_Selectedperson.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Selectedperson.ForeColor = Color.Red;
            lbl_Selectedperson.ImageAlign = ContentAlignment.MiddleRight;
            lbl_Selectedperson.Location = new Point(297, 24);
            lbl_Selectedperson.Name = "lbl_Selectedperson";
            lbl_Selectedperson.Size = new Size(137, 16);
            lbl_Selectedperson.TabIndex = 29;
            lbl_Selectedperson.Text = "Person not selected";
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
            button6.Location = new Point(347, 227);
            button6.Margin = new Padding(5, 9, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(115, 34);
            button6.TabIndex = 28;
            button6.Text = "Back";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(159, 227);
            button3.Margin = new Padding(5, 9, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(115, 34);
            button3.TabIndex = 27;
            button3.Text = "Submit";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Add_Member_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 26;
            label2.Text = "Membership date :";
            // 
            // Combo_Proof
            // 
            Combo_Proof.DisplayMember = "Name";
            Combo_Proof.FormattingEnabled = true;
            Combo_Proof.Location = new Point(159, 124);
            Combo_Proof.Name = "Combo_Proof";
            Combo_Proof.Size = new Size(184, 28);
            Combo_Proof.TabIndex = 35;
            Combo_Proof.ValueMember = "Id";
            // 
            // Combo_Major
            // 
            Combo_Major.DisplayMember = "Name";
            Combo_Major.FormattingEnabled = true;
            Combo_Major.Location = new Point(159, 176);
            Combo_Major.Name = "Combo_Major";
            Combo_Major.Size = new Size(184, 28);
            Combo_Major.TabIndex = 36;
            Combo_Major.ValueMember = "Id";
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 314);
            Controls.Add(Combo_Major);
            Controls.Add(Combo_Proof);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(date_MemberDate);
            Controls.Add(lbl_Selectedperson);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(label2);
            Name = "FormMember";
            Text = "FormMember";
            Load += FormMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker date_MemberDate;
        private Label lbl_Selectedperson;
        private Button button6;
        private Button button3;
        private Label label2;
        private Shared.MyComboBox Combo_Proof;
        private Shared.MyComboBox Combo_Major;
    }
}