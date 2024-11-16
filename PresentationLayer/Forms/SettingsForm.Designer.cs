namespace PresentationLayer.Forms
{
    partial class SettingsForm
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
            headerPanel = new Panel();
            managementIcon = new FontAwesome.Sharp.IconPictureBox();
            userManagementLabel = new Label();
            administrationGroupBox = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            addUserTextBox = new TextBox();
            addUserLabel = new Label();
            deleteUserLabel = new Label();
            editUserLabel = new Label();
            deleteUserBtn = new FontAwesome.Sharp.IconButton();
            editUserBtn = new FontAwesome.Sharp.IconButton();
            addUserBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            userRoleColumn = new DataGridViewTextBoxColumn();
            actionsUserColumn = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            editPermissonBtn = new FontAwesome.Sharp.IconButton();
            rolesDataGrip = new DataGridView();
            roleColumn = new DataGridViewTextBoxColumn();
            descriptionColumn = new DataGridViewTextBoxColumn();
            seachTextBox = new TextBox();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            administrationGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rolesDataGrip).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(managementIcon);
            headerPanel.Controls.Add(userManagementLabel);
            headerPanel.Controls.Add(administrationGroupBox);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.ForeColor = Color.White;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1370, 611);
            headerPanel.TabIndex = 0;
            // 
            // managementIcon
            // 
            managementIcon.BackColor = SystemColors.Control;
            managementIcon.ForeColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            managementIcon.IconColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            managementIcon.IconSize = 40;
            managementIcon.Location = new Point(25, 12);
            managementIcon.Name = "managementIcon";
            managementIcon.Size = new Size(40, 40);
            managementIcon.TabIndex = 2;
            managementIcon.TabStop = false;
            // 
            // userManagementLabel
            // 
            userManagementLabel.AutoSize = true;
            userManagementLabel.BackColor = Color.Transparent;
            userManagementLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userManagementLabel.ForeColor = Color.Black;
            userManagementLabel.Location = new Point(85, 25);
            userManagementLabel.Name = "userManagementLabel";
            userManagementLabel.Size = new Size(218, 27);
            userManagementLabel.TabIndex = 1;
            userManagementLabel.Text = "User Management";
            // 
            // administrationGroupBox
            // 
            administrationGroupBox.Controls.Add(tabControl1);
            administrationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrationGroupBox.Location = new Point(12, 81);
            administrationGroupBox.Name = "administrationGroupBox";
            administrationGroupBox.Size = new Size(1307, 509);
            administrationGroupBox.TabIndex = 0;
            administrationGroupBox.TabStop = false;
            administrationGroupBox.Text = "Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1265, 427);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addUserTextBox);
            tabPage1.Controls.Add(addUserLabel);
            tabPage1.Controls.Add(deleteUserLabel);
            tabPage1.Controls.Add(editUserLabel);
            tabPage1.Controls.Add(deleteUserBtn);
            tabPage1.Controls.Add(editUserBtn);
            tabPage1.Controls.Add(addUserBtn);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1257, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(784, 57);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(277, 32);
            addUserTextBox.TabIndex = 7;
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.ForeColor = Color.Black;
            addUserLabel.Location = new Point(784, 18);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(98, 23);
            addUserLabel.TabIndex = 6;
            addUserLabel.Text = "Add User";
            // 
            // deleteUserLabel
            // 
            deleteUserLabel.AutoSize = true;
            deleteUserLabel.ForeColor = Color.Black;
            deleteUserLabel.Location = new Point(784, 267);
            deleteUserLabel.Name = "deleteUserLabel";
            deleteUserLabel.Size = new Size(127, 23);
            deleteUserLabel.TabIndex = 5;
            deleteUserLabel.Text = "Delete User ";
            // 
            // editUserLabel
            // 
            editUserLabel.AutoSize = true;
            editUserLabel.ForeColor = Color.Black;
            editUserLabel.Location = new Point(784, 174);
            editUserLabel.Name = "editUserLabel";
            editUserLabel.Size = new Size(91, 23);
            editUserLabel.TabIndex = 4;
            editUserLabel.Text = "Edit User";
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BackColor = Color.Red;
            deleteUserBtn.ForeColor = Color.White;
            deleteUserBtn.IconChar = FontAwesome.Sharp.IconChar.UsersSlash;
            deleteUserBtn.IconColor = Color.White;
            deleteUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteUserBtn.Location = new Point(784, 314);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(279, 42);
            deleteUserBtn.TabIndex = 3;
            deleteUserBtn.Text = "Delete User";
            deleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // editUserBtn
            // 
            editUserBtn.BackColor = Color.FromArgb(0, 123, 250);
            editUserBtn.ForeColor = Color.White;
            editUserBtn.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            editUserBtn.IconColor = Color.White;
            editUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editUserBtn.Location = new Point(782, 210);
            editUserBtn.Name = "editUserBtn";
            editUserBtn.Size = new Size(279, 42);
            editUserBtn.TabIndex = 2;
            editUserBtn.Text = "Edit User";
            editUserBtn.UseVisualStyleBackColor = false;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.Green;
            addUserBtn.ForeColor = Color.White;
            addUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addUserBtn.IconColor = Color.White;
            addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addUserBtn.Location = new Point(784, 110);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(279, 42);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, userRoleColumn, actionsUserColumn });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 382);
            dataGridView1.TabIndex = 0;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Name";
            userNameColumn.MinimumWidth = 6;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.Width = 125;
            // 
            // userRoleColumn
            // 
            userRoleColumn.HeaderText = "User";
            userRoleColumn.MinimumWidth = 6;
            userRoleColumn.Name = "userRoleColumn";
            userRoleColumn.Width = 125;
            // 
            // actionsUserColumn
            // 
            actionsUserColumn.HeaderText = "Actions";
            actionsUserColumn.MinimumWidth = 6;
            actionsUserColumn.Name = "actionsUserColumn";
            actionsUserColumn.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(editPermissonBtn);
            tabPage2.Controls.Add(rolesDataGrip);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1257, 391);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // editPermissonBtn
            // 
            editPermissonBtn.BackColor = Color.FromArgb(0, 123, 250);
            editPermissonBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            editPermissonBtn.IconColor = Color.White;
            editPermissonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editPermissonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editPermissonBtn.Location = new Point(786, 334);
            editPermissonBtn.Name = "editPermissonBtn";
            editPermissonBtn.Size = new Size(275, 51);
            editPermissonBtn.TabIndex = 1;
            editPermissonBtn.Text = "Edit Permisson";
            editPermissonBtn.UseVisualStyleBackColor = false;
            // 
            // rolesDataGrip
            // 
            rolesDataGrip.AllowUserToAddRows = false;
            rolesDataGrip.AllowUserToDeleteRows = false;
            rolesDataGrip.AllowUserToResizeColumns = false;
            rolesDataGrip.AllowUserToResizeRows = false;
            rolesDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rolesDataGrip.Columns.AddRange(new DataGridViewColumn[] { roleColumn, descriptionColumn });
            rolesDataGrip.Location = new Point(6, 6);
            rolesDataGrip.Name = "rolesDataGrip";
            rolesDataGrip.RowHeadersWidth = 51;
            rolesDataGrip.Size = new Size(774, 379);
            rolesDataGrip.TabIndex = 0;
            // 
            // roleColumn
            // 
            roleColumn.HeaderText = "Role";
            roleColumn.MinimumWidth = 6;
            roleColumn.Name = "roleColumn";
            roleColumn.Width = 82;
            // 
            // descriptionColumn
            // 
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.MinimumWidth = 6;
            descriptionColumn.Name = "descriptionColumn";
            descriptionColumn.Width = 125;
            // 
            // seachTextBox
            // 
            seachTextBox.Location = new Point(25, 660);
            seachTextBox.Name = "seachTextBox";
            seachTextBox.PlaceholderText = "Search teams, coachs, players...";
            seachTextBox.Size = new Size(238, 27);
            seachTextBox.TabIndex = 8;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.Red;
            logOutBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            logOutBtn.IconColor = Color.White;
            logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(811, 638);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(279, 49);
            logOutBtn.TabIndex = 9;
            logOutBtn.Text = "Log out";
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 712);
            Controls.Add(logOutBtn);
            Controls.Add(seachTextBox);
            Controls.Add(headerPanel);
            Name = "SettingsForm";
            Text = "SettingsForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)managementIcon).EndInit();
            administrationGroupBox.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rolesDataGrip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private GroupBox administrationGroupBox;
        private Label userManagementLabel;
        private FontAwesome.Sharp.IconPictureBox managementIcon;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView rolesDataGrip;
        private FontAwesome.Sharp.IconButton editPermissonBtn;
        private FontAwesome.Sharp.IconButton addUserBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn userRoleColumn;
        private DataGridViewTextBoxColumn actionsUserColumn;
        private DataGridViewTextBoxColumn roleColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private FontAwesome.Sharp.IconButton editUserBtn;
        private FontAwesome.Sharp.IconButton deleteUserBtn;
        private Label editUserLabel;
        private Label deleteUserLabel;
        private Label addUserLabel;
        private TextBox addUserTextBox;
        private TextBox seachTextBox;
        private FontAwesome.Sharp.IconButton logOutBtn;
    }
}