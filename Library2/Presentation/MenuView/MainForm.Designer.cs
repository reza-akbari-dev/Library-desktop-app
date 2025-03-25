namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            infoManagementToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem1 = new ToolStripMenuItem();
            borrowManagmentToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            membersReportToolStripMenuItem = new ToolStripMenuItem();
            booksReportToolStripMenuItem = new ToolStripMenuItem();
            borrowsReportToolStripMenuItem = new ToolStripMenuItem();
            softSettingToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            addFieldToolStripMenuItem = new ToolStripMenuItem();
            securityToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            defineRoleToolStripMenuItem = new ToolStripMenuItem();
            assignActivityToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            statusStrip1 = new StatusStrip();
            lbl_Time = new ToolStripStatusLabel();
            Timer_Now = new System.Windows.Forms.Timer(components);
            lbl_UserName = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoManagementToolStripMenuItem, borrowToolStripMenuItem1, reportToolStripMenuItem, softSettingToolStripMenuItem, securityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1116, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoManagementToolStripMenuItem
            // 
            infoManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { memberToolStripMenuItem, bookToolStripMenuItem, borrowToolStripMenuItem, peopleToolStripMenuItem });
            infoManagementToolStripMenuItem.Image = (Image)resources.GetObject("infoManagementToolStripMenuItem.Image");
            infoManagementToolStripMenuItem.Name = "infoManagementToolStripMenuItem";
            infoManagementToolStripMenuItem.Size = new Size(161, 24);
            infoManagementToolStripMenuItem.Text = "Info Management";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Image = (Image)resources.GetObject("memberToolStripMenuItem.Image");
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(148, 26);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += Member_Click;
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Image = (Image)resources.GetObject("bookToolStripMenuItem.Image");
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(148, 26);
            bookToolStripMenuItem.Text = "Book";
            bookToolStripMenuItem.Click += FormBookList_click;
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Image = (Image)resources.GetObject("borrowToolStripMenuItem.Image");
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(148, 26);
            borrowToolStripMenuItem.Text = "Writer";
            borrowToolStripMenuItem.Click += Writer_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(148, 26);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.TextAlign = ContentAlignment.BottomRight;
            peopleToolStripMenuItem.Click += People_Click;
            // 
            // borrowToolStripMenuItem1
            // 
            borrowToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { borrowManagmentToolStripMenuItem });
            borrowToolStripMenuItem1.Image = (Image)resources.GetObject("borrowToolStripMenuItem1.Image");
            borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            borrowToolStripMenuItem1.Size = new Size(91, 24);
            borrowToolStripMenuItem1.Text = "Borrow";
            // 
            // borrowManagmentToolStripMenuItem
            // 
            borrowManagmentToolStripMenuItem.Image = (Image)resources.GetObject("borrowManagmentToolStripMenuItem.Image");
            borrowManagmentToolStripMenuItem.Name = "borrowManagmentToolStripMenuItem";
            borrowManagmentToolStripMenuItem.Size = new Size(224, 26);
            borrowManagmentToolStripMenuItem.Text = "Borrow Managment";
            borrowManagmentToolStripMenuItem.Click += Borrow_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { membersReportToolStripMenuItem, booksReportToolStripMenuItem, borrowsReportToolStripMenuItem });
            reportToolStripMenuItem.Image = (Image)resources.GetObject("reportToolStripMenuItem.Image");
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(88, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // membersReportToolStripMenuItem
            // 
            membersReportToolStripMenuItem.Name = "membersReportToolStripMenuItem";
            membersReportToolStripMenuItem.Size = new Size(206, 26);
            membersReportToolStripMenuItem.Text = "Members' Report";
            // 
            // booksReportToolStripMenuItem
            // 
            booksReportToolStripMenuItem.Name = "booksReportToolStripMenuItem";
            booksReportToolStripMenuItem.Size = new Size(206, 26);
            booksReportToolStripMenuItem.Text = "Books' Report";
            // 
            // borrowsReportToolStripMenuItem
            // 
            borrowsReportToolStripMenuItem.Name = "borrowsReportToolStripMenuItem";
            borrowsReportToolStripMenuItem.Size = new Size(206, 26);
            borrowsReportToolStripMenuItem.Text = "Borrows' Report";
            // 
            // softSettingToolStripMenuItem
            // 
            softSettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, addFieldToolStripMenuItem });
            softSettingToolStripMenuItem.Image = (Image)resources.GetObject("softSettingToolStripMenuItem.Image");
            softSettingToolStripMenuItem.Name = "softSettingToolStripMenuItem";
            softSettingToolStripMenuItem.Size = new Size(121, 24);
            softSettingToolStripMenuItem.Text = "Soft Setting";
            softSettingToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Image = (Image)resources.GetObject("addBookToolStripMenuItem.Image");
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(173, 26);
            addBookToolStripMenuItem.Text = "Add Subject";
            addBookToolStripMenuItem.Click += Subject_Click;
            // 
            // addFieldToolStripMenuItem
            // 
            addFieldToolStripMenuItem.Image = (Image)resources.GetObject("addFieldToolStripMenuItem.Image");
            addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            addFieldToolStripMenuItem.Size = new Size(173, 26);
            addFieldToolStripMenuItem.Text = "Add Major";
            addFieldToolStripMenuItem.Click += Major_Click;
            // 
            // securityToolStripMenuItem
            // 
            securityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, defineRoleToolStripMenuItem, assignActivityToolStripMenuItem });
            securityToolStripMenuItem.Image = (Image)resources.GetObject("securityToolStripMenuItem.Image");
            securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            securityToolStripMenuItem.Size = new Size(95, 24);
            securityToolStripMenuItem.Text = "Security";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Image = (Image)resources.GetObject("addUserToolStripMenuItem.Image");
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(186, 26);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += User_Click;
            // 
            // defineRoleToolStripMenuItem
            // 
            defineRoleToolStripMenuItem.Image = (Image)resources.GetObject("defineRoleToolStripMenuItem.Image");
            defineRoleToolStripMenuItem.Name = "defineRoleToolStripMenuItem";
            defineRoleToolStripMenuItem.Size = new Size(186, 26);
            defineRoleToolStripMenuItem.Text = "Define role";
            defineRoleToolStripMenuItem.Click += Role_Click;
            // 
            // assignActivityToolStripMenuItem
            // 
            assignActivityToolStripMenuItem.Image = (Image)resources.GetObject("assignActivityToolStripMenuItem.Image");
            assignActivityToolStripMenuItem.Name = "assignActivityToolStripMenuItem";
            assignActivityToolStripMenuItem.Size = new Size(186, 26);
            assignActivityToolStripMenuItem.Text = "Assign activity";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "222.jpg");
            imageList1.Images.SetKeyName(1, "back.jpg");
            imageList1.Images.SetKeyName(2, "close.jpg");
            imageList1.Images.SetKeyName(3, "download.jpg");
            imageList1.Images.SetKeyName(4, "edit.jpg");
            imageList1.Images.SetKeyName(5, "Go-back-icon.jpg");
            imageList1.Images.SetKeyName(6, "icon-of-delete-in-flat-style-trash-bin-vector.jpg");
            imageList1.Images.SetKeyName(7, "images.jpg");
            imageList1.Images.SetKeyName(8, "kisspng-computer-icons-button-5ae031e2bf0904.7825510515246422747825aaa.jpg");
            imageList1.Images.SetKeyName(9, "open.jpg");
            imageList1.Images.SetKeyName(10, "Screenshot (431)0.jpg");
            imageList1.Images.SetKeyName(11, "Screenshot (431)1.jpg");
            imageList1.Images.SetKeyName(12, "Screenshot (431)2.jpg");
            imageList1.Images.SetKeyName(13, "Screenshot (431)3.jpg");
            imageList1.Images.SetKeyName(14, "Screenshot (431)4.jpg");
            imageList1.Images.SetKeyName(15, "Screenshot (431)5.jpg");
            imageList1.Images.SetKeyName(16, "Screenshot (431)8.jpg");
            imageList1.Images.SetKeyName(17, "Screenshot 45.jpg");
            imageList1.Images.SetKeyName(18, "settings-icon-28.png");
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_Time, lbl_UserName });
            statusStrip1.Location = new Point(0, 540);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1116, 26);
            statusStrip1.TabIndex = 2;
            // 
            // lbl_Time
            // 
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(151, 20);
            lbl_Time.Text = "toolStripStatusLabel1";
            // 
            // Timer_Now
            // 
            Timer_Now.Enabled = true;
            Timer_Now.Interval = 1000;
            Timer_Now.Tick += Timer_Now_Tick;
            // 
            // lbl_UserName
            // 
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(0, 20);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 566);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoManagementToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem membersReportToolStripMenuItem;
        private ToolStripMenuItem booksReportToolStripMenuItem;
        private ToolStripMenuItem borrowsReportToolStripMenuItem;
        private ToolStripMenuItem softSettingToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem addFieldToolStripMenuItem;
        private ToolStripMenuItem securityToolStripMenuItem;
        private ImageList imageList1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_Time;
        private System.Windows.Forms.Timer Timer_Now;
        private ToolStripMenuItem borrowToolStripMenuItem1;
        private ToolStripMenuItem borrowManagmentToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem defineRoleToolStripMenuItem;
        private ToolStripMenuItem assignActivityToolStripMenuItem;
        private ToolStripStatusLabel lbl_UserName;
    }
}