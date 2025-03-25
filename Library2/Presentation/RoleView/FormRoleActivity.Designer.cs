namespace Presentation.RoleView
{
    partial class FormRoleActivity
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
            Grid_RoleActivity = new MyGridView();
            CelId = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Grid_RoleActivity).BeginInit();
            SuspendLayout();
            // 
            // Grid_RoleActivity
            // 
            Grid_RoleActivity.AllowUserToAddRows = false;
            Grid_RoleActivity.AllowUserToDeleteRows = false;
            Grid_RoleActivity.BackgroundColor = Color.White;
            Grid_RoleActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_RoleActivity.Columns.AddRange(new DataGridViewColumn[] { CelId, Column2, Column3 });
            Grid_RoleActivity.Dock = DockStyle.Fill;
            Grid_RoleActivity.Location = new Point(0, 0);
            Grid_RoleActivity.Name = "Grid_RoleActivity";
            Grid_RoleActivity.RowHeadersWidth = 51;
            Grid_RoleActivity.RowTemplate.Height = 29;
            Grid_RoleActivity.Size = new Size(463, 487);
            Grid_RoleActivity.TabIndex = 0;
            Grid_RoleActivity.CellEndEdit += Grid_RoleActivity_CellEndEdit;
            // 
            // CelId
            // 
            CelId.DataPropertyName = "Id";
            CelId.HeaderText = "Id";
            CelId.MinimumWidth = 6;
            CelId.Name = "CelId";
            CelId.ReadOnly = true;
            CelId.Visible = false;
            CelId.Width = 110;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ActivityDiscription";
            Column2.HeaderText = "Activity";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 205;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "IsSelected";
            Column3.HeaderText = "Select";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 205;
            // 
            // FormRoleActivity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 487);
            Controls.Add(Grid_RoleActivity);
            Name = "FormRoleActivity";
            Text = "FormRoleActivity";
            FormClosing += FormRoleActivity_FormClosing;
            Load += FormRoleActivity_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_RoleActivity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MyGridView Grid_RoleActivity;
        private DataGridViewTextBoxColumn CelId;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
    }
}