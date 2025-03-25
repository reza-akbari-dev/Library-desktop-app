namespace Presentation.WriterView
{
    partial class FormWriter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWriter));
            button1 = new Button();
            label1 = new Label();
            imageList1 = new ImageList(components);
            lbl_Selectedperson = new Label();
            button6 = new Button();
            button3 = new Button();
            txt_Bio = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(155, 45);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 14;
            button1.Text = "Person";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Select_Person_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 13;
            label1.Text = "Choose the Person :";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lbl_Selectedperson
            // 
            lbl_Selectedperson.AutoSize = true;
            lbl_Selectedperson.FlatStyle = FlatStyle.Flat;
            lbl_Selectedperson.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Selectedperson.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_Selectedperson.ImageAlign = ContentAlignment.MiddleRight;
            lbl_Selectedperson.Location = new Point(266, 54);
            lbl_Selectedperson.Name = "lbl_Selectedperson";
            lbl_Selectedperson.Size = new Size(229, 21);
            lbl_Selectedperson.TabIndex = 19;
            lbl_Selectedperson.Text = "No one has been selected";
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
            button6.Location = new Point(330, 212);
            button6.Margin = new Padding(5, 10, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(115, 38);
            button6.TabIndex = 18;
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
            button3.Location = new Point(177, 212);
            button3.Margin = new Padding(5, 10, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(115, 38);
            button3.TabIndex = 17;
            button3.Text = "Submit";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Register_Click;
            // 
            // txt_Bio
            // 
            txt_Bio.Location = new Point(117, 109);
            txt_Bio.Multiline = true;
            txt_Bio.Name = "txt_Bio";
            txt_Bio.Size = new Size(328, 79);
            txt_Bio.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "Biography :";
            // 
            // FormWriter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 284);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lbl_Selectedperson);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(txt_Bio);
            Controls.Add(label2);
            Name = "FormWriter";
            Text = "FormWriter";
            Load += FormWriter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ImageList imageList1;
        private Label lbl_Selectedperson;
        private Button button6;
        private Button button3;
        private TextBox txt_Bio;
        private Label label2;
    }
}