namespace PresentationLayer.Forms
{
    partial class usersForm
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
            administrationGroupBox = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            userPasswordTextBox = new TextBox();
            userMailTextBox = new TextBox();
            userMailLabel = new Label();
            userPassword = new Label();
            deleteUserBtn = new FontAwesome.Sharp.IconButton();
            rolComboBox = new ComboBox();
            editPermissonBtn = new FontAwesome.Sharp.IconButton();
            roleLabel = new Label();
            addUserTextBox = new TextBox();
            addUserLabel = new Label();
            addUserBtn = new FontAwesome.Sharp.IconButton();
            usersDataGrip = new DataGridView();
            userManagementLabel = new Label();
            managementIcon = new FontAwesome.Sharp.IconPictureBox();
            searchUserTextBox = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            searchUserBtn = new FontAwesome.Sharp.IconButton();
            userErrorProvider = new ErrorProvider(components);
            administrationGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // administrationGroupBox
            // 
            administrationGroupBox.Controls.Add(tabControl1);
            administrationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrationGroupBox.Location = new Point(18, 113);
            administrationGroupBox.Margin = new Padding(3, 2, 3, 2);
            administrationGroupBox.Name = "administrationGroupBox";
            administrationGroupBox.Padding = new Padding(3, 2, 3, 2);
            administrationGroupBox.Size = new Size(1144, 382);
            administrationGroupBox.TabIndex = 1;
            administrationGroupBox.TabStop = false;
            administrationGroupBox.Text = "Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(11, 44);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1107, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(userPasswordTextBox);
            tabPage1.Controls.Add(userMailTextBox);
            tabPage1.Controls.Add(userMailLabel);
            tabPage1.Controls.Add(userPassword);
            tabPage1.Controls.Add(deleteUserBtn);
            tabPage1.Controls.Add(rolComboBox);
            tabPage1.Controls.Add(editPermissonBtn);
            tabPage1.Controls.Add(roleLabel);
            tabPage1.Controls.Add(addUserTextBox);
            tabPage1.Controls.Add(addUserLabel);
            tabPage1.Controls.Add(addUserBtn);
            tabPage1.Controls.Add(usersDataGrip);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1099, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Location = new Point(519, 244);
            userPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(190, 27);
            userPasswordTextBox.TabIndex = 15;
            // 
            // userMailTextBox
            // 
            userMailTextBox.Location = new Point(518, 166);
            userMailTextBox.Margin = new Padding(3, 2, 3, 2);
            userMailTextBox.Name = "userMailTextBox";
            userMailTextBox.Size = new Size(190, 27);
            userMailTextBox.TabIndex = 14;
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.ForeColor = Color.Black;
            userMailLabel.Location = new Point(518, 138);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new Size(79, 19);
            userMailLabel.TabIndex = 13;
            userMailLabel.Text = "User mail";
            // 
            // userPassword
            // 
            userPassword.AutoSize = true;
            userPassword.ForeColor = Color.Black;
            userPassword.Location = new Point(518, 217);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(115, 19);
            userPassword.TabIndex = 12;
            userPassword.Text = "User Password";
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BackColor = Color.Red;
            deleteUserBtn.ForeColor = SystemColors.Control;
            deleteUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            deleteUserBtn.IconColor = Color.White;
            deleteUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteUserBtn.Location = new Point(724, 238);
            deleteUserBtn.Margin = new Padding(3, 2, 3, 2);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(210, 31);
            deleteUserBtn.TabIndex = 11;
            deleteUserBtn.Text = "Delete User";
            deleteUserBtn.UseVisualStyleBackColor = false;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(518, 104);
            rolComboBox.Margin = new Padding(3, 2, 3, 2);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(190, 27);
            rolComboBox.TabIndex = 10;
            // 
            // editPermissonBtn
            // 
            editPermissonBtn.BackColor = Color.FromArgb(0, 123, 250);
            editPermissonBtn.ForeColor = SystemColors.Control;
            editPermissonBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            editPermissonBtn.IconColor = Color.White;
            editPermissonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editPermissonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editPermissonBtn.Location = new Point(724, 138);
            editPermissonBtn.Margin = new Padding(3, 2, 3, 2);
            editPermissonBtn.Name = "editPermissonBtn";
            editPermissonBtn.Size = new Size(210, 32);
            editPermissonBtn.TabIndex = 1;
            editPermissonBtn.Text = "Edit Permisson";
            editPermissonBtn.UseVisualStyleBackColor = false;
            editPermissonBtn.Click += editPermissonBtn_Click;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(518, 76);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(42, 19);
            roleLabel.TabIndex = 9;
            roleLabel.Text = "Role";
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(518, 36);
            addUserTextBox.Margin = new Padding(3, 2, 3, 2);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(190, 27);
            addUserTextBox.TabIndex = 7;
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.ForeColor = Color.Black;
            addUserLabel.Location = new Point(518, 10);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(87, 19);
            addUserLabel.TabIndex = 6;
            addUserLabel.Text = "Username";
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.Green;
            addUserBtn.ForeColor = Color.White;
            addUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addUserBtn.IconColor = Color.White;
            addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addUserBtn.Location = new Point(724, 31);
            addUserBtn.Margin = new Padding(3, 2, 3, 2);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(210, 32);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // usersDataGrip
            // 
            usersDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrip.Location = new Point(3, 2);
            usersDataGrip.Margin = new Padding(3, 2, 3, 2);
            usersDataGrip.Name = "usersDataGrip";
            usersDataGrip.RowHeadersWidth = 51;
            usersDataGrip.Size = new Size(510, 286);
            usersDataGrip.TabIndex = 0;
            // 
            // userManagementLabel
            // 
            userManagementLabel.AutoSize = true;
            userManagementLabel.BackColor = Color.Transparent;
            userManagementLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userManagementLabel.ForeColor = Color.Black;
            userManagementLabel.Location = new Point(67, 24);
            userManagementLabel.Name = "userManagementLabel";
            userManagementLabel.Size = new Size(180, 23);
            userManagementLabel.TabIndex = 2;
            userManagementLabel.Text = "User Management";
            // 
            // managementIcon
            // 
            managementIcon.BackColor = SystemColors.Control;
            managementIcon.ForeColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            managementIcon.IconColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            managementIcon.IconSize = 30;
            managementIcon.Location = new Point(18, 14);
            managementIcon.Margin = new Padding(3, 2, 3, 2);
            managementIcon.Name = "managementIcon";
            managementIcon.Size = new Size(35, 30);
            managementIcon.TabIndex = 3;
            managementIcon.TabStop = false;
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Location = new Point(140, 76);
            searchUserTextBox.Margin = new Padding(3, 2, 3, 2);
            searchUserTextBox.Multiline = true;
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.PlaceholderText = "All Users";
            searchUserTextBox.Size = new Size(574, 26);
            searchUserTextBox.TabIndex = 4;
            searchUserTextBox.TextChanged += searchUserTextBox_TextChanged;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.White;
            searchIcon.ForeColor = SystemColors.ControlText;
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = SystemColors.ControlText;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 30;
            searchIcon.Location = new Point(76, 71);
            searchIcon.Margin = new Padding(3, 2, 3, 2);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(35, 30);
            searchIcon.TabIndex = 5;
            searchIcon.TabStop = false;
            // 
            // searchUserBtn
            // 
            searchUserBtn.BackColor = Color.YellowGreen;
            searchUserBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            searchUserBtn.IconColor = Color.Black;
            searchUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchUserBtn.Location = new Point(757, 80);
            searchUserBtn.Margin = new Padding(3, 2, 3, 2);
            searchUserBtn.Name = "searchUserBtn";
            searchUserBtn.Size = new Size(210, 29);
            searchUserBtn.TabIndex = 6;
            searchUserBtn.Text = "Search";
            searchUserBtn.UseVisualStyleBackColor = false;
            // 
            // userErrorProvider
            // 
            userErrorProvider.ContainerControl = this;
            // 
            // usersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 537);
            Controls.Add(searchUserBtn);
            Controls.Add(searchIcon);
            Controls.Add(searchUserTextBox);
            Controls.Add(managementIcon);
            Controls.Add(userManagementLabel);
            Controls.Add(administrationGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "usersForm";
            Text = "CoachForm";
            administrationGroupBox.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox administrationGroupBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FontAwesome.Sharp.IconButton editPermissonBtn;
        private Label roleLabel;
        private TextBox addUserTextBox;
        private Label addUserLabel;
        private FontAwesome.Sharp.IconButton addUserBtn;
        private DataGridView usersDataGrip;
        private Label userManagementLabel;
        private FontAwesome.Sharp.IconPictureBox managementIcon;
        private Label userMailLabel;
        private Label userPassword;
        private FontAwesome.Sharp.IconButton deleteUserBtn;
        private ComboBox rolComboBox;
        private TextBox userMailTextBox;
        private TextBox userPasswordTextBox;
        private TextBox searchUserTextBox;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private FontAwesome.Sharp.IconButton searchUserBtn;
        private ErrorProvider userErrorProvider;
    }
}