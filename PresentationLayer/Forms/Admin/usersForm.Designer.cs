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
            PDFBtn = new FontAwesome.Sharp.IconButton();
            deleteUserBtn = new FontAwesome.Sharp.IconButton();
            editPermissonBtn = new FontAwesome.Sharp.IconButton();
            addUserBtn = new FontAwesome.Sharp.IconButton();
            usersDataGrip = new DataGridView();
            userPassword = new Label();
            addUserLabel = new Label();
            userPasswordTextBox = new TextBox();
            userMailLabel = new Label();
            roleLabel = new Label();
            addUserTextBox = new TextBox();
            rolComboBox = new ComboBox();
            userMailTextBox = new TextBox();
            userManagementLabel = new Label();
            managementIcon = new FontAwesome.Sharp.IconPictureBox();
            searchUserTextBox = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            searchUserBtn = new FontAwesome.Sharp.IconButton();
            userErrorProvider = new ErrorProvider(components);
            administrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // administrationGroupBox
            // 
            administrationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            administrationGroupBox.Controls.Add(PDFBtn);
            administrationGroupBox.Controls.Add(deleteUserBtn);
            administrationGroupBox.Controls.Add(editPermissonBtn);
            administrationGroupBox.Controls.Add(addUserBtn);
            administrationGroupBox.Controls.Add(usersDataGrip);
            administrationGroupBox.Controls.Add(userPassword);
            administrationGroupBox.Controls.Add(addUserLabel);
            administrationGroupBox.Controls.Add(userPasswordTextBox);
            administrationGroupBox.Controls.Add(userMailLabel);
            administrationGroupBox.Controls.Add(roleLabel);
            administrationGroupBox.Controls.Add(addUserTextBox);
            administrationGroupBox.Controls.Add(rolComboBox);
            administrationGroupBox.Controls.Add(userMailTextBox);
            administrationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrationGroupBox.Location = new Point(21, 151);
            administrationGroupBox.Name = "administrationGroupBox";
            administrationGroupBox.Size = new Size(1321, 535);
            administrationGroupBox.TabIndex = 1;
            administrationGroupBox.TabStop = false;
            administrationGroupBox.Text = "Management";
            // 
            // PDFBtn
            // 
            PDFBtn.BackColor = Color.YellowGreen;
            PDFBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            PDFBtn.ForeColor = Color.White;
            PDFBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            PDFBtn.IconColor = Color.White;
            PDFBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PDFBtn.Location = new Point(818, 138);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(231, 40);
            PDFBtn.TabIndex = 40;
            PDFBtn.Text = "   Generate PDF";
            PDFBtn.UseVisualStyleBackColor = false;
            PDFBtn.Click += PDFBtn_Click;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BackColor = Color.Red;
            deleteUserBtn.ForeColor = SystemColors.Control;
            deleteUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            deleteUserBtn.IconColor = Color.White;
            deleteUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteUserBtn.Location = new Point(563, 137);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(240, 41);
            deleteUserBtn.TabIndex = 11;
            deleteUserBtn.Text = "Delete User";
            deleteUserBtn.UseVisualStyleBackColor = false;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // editPermissonBtn
            // 
            editPermissonBtn.BackColor = Color.FromArgb(0, 123, 250);
            editPermissonBtn.ForeColor = SystemColors.Control;
            editPermissonBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            editPermissonBtn.IconColor = Color.White;
            editPermissonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editPermissonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editPermissonBtn.Location = new Point(286, 135);
            editPermissonBtn.Name = "editPermissonBtn";
            editPermissonBtn.Size = new Size(240, 43);
            editPermissonBtn.TabIndex = 1;
            editPermissonBtn.Text = "Edit Permisson";
            editPermissonBtn.UseVisualStyleBackColor = false;
            editPermissonBtn.Click += editPermissonBtn_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.Green;
            addUserBtn.ForeColor = Color.White;
            addUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addUserBtn.IconColor = Color.White;
            addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addUserBtn.Location = new Point(6, 135);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(240, 43);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // usersDataGrip
            // 
            usersDataGrip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrip.Location = new Point(84, 252);
            usersDataGrip.Name = "usersDataGrip";
            usersDataGrip.RowHeadersWidth = 51;
            usersDataGrip.Size = new Size(1150, 250);
            usersDataGrip.TabIndex = 0;
            // 
            // userPassword
            // 
            userPassword.AutoSize = true;
            userPassword.ForeColor = Color.Black;
            userPassword.Location = new Point(767, 33);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(147, 23);
            userPassword.TabIndex = 12;
            userPassword.Text = "User Password";
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.ForeColor = Color.Black;
            addUserLabel.Location = new Point(6, 33);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(108, 23);
            addUserLabel.TabIndex = 6;
            addUserLabel.Text = "Username";
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Location = new Point(767, 71);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(217, 32);
            userPasswordTextBox.TabIndex = 15;
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.ForeColor = Color.Black;
            userMailLabel.Location = new Point(525, 33);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new Size(99, 23);
            userMailLabel.TabIndex = 13;
            userMailLabel.Text = "User mail";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(274, 28);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(53, 23);
            roleLabel.TabIndex = 9;
            roleLabel.Text = "Role";
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(6, 70);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(217, 32);
            addUserTextBox.TabIndex = 7;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(274, 71);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(217, 31);
            rolComboBox.TabIndex = 10;
            // 
            // userMailTextBox
            // 
            userMailTextBox.Location = new Point(525, 70);
            userMailTextBox.Name = "userMailTextBox";
            userMailTextBox.Size = new Size(217, 32);
            userMailTextBox.TabIndex = 14;
            // 
            // userManagementLabel
            // 
            userManagementLabel.AutoSize = true;
            userManagementLabel.BackColor = Color.Transparent;
            userManagementLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userManagementLabel.ForeColor = Color.Black;
            userManagementLabel.Location = new Point(77, 32);
            userManagementLabel.Name = "userManagementLabel";
            userManagementLabel.Size = new Size(218, 27);
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
            managementIcon.IconSize = 40;
            managementIcon.Location = new Point(21, 19);
            managementIcon.Name = "managementIcon";
            managementIcon.Size = new Size(40, 40);
            managementIcon.TabIndex = 3;
            managementIcon.TabStop = false;
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchUserTextBox.Location = new Point(160, 101);
            searchUserTextBox.Multiline = true;
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.PlaceholderText = "All Users";
            searchUserTextBox.Size = new Size(655, 33);
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
            searchIcon.IconSize = 40;
            searchIcon.Location = new Point(87, 95);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(40, 40);
            searchIcon.TabIndex = 5;
            searchIcon.TabStop = false;
            // 
            // searchUserBtn
            // 
            searchUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchUserBtn.BackColor = Color.YellowGreen;
            searchUserBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            searchUserBtn.IconColor = Color.Black;
            searchUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchUserBtn.Location = new Point(867, 94);
            searchUserBtn.Name = "searchUserBtn";
            searchUserBtn.Size = new Size(240, 39);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 716);
            Controls.Add(searchUserBtn);
            Controls.Add(searchIcon);
            Controls.Add(searchUserTextBox);
            Controls.Add(managementIcon);
            Controls.Add(userManagementLabel);
            Controls.Add(administrationGroupBox);
            Name = "usersForm";
            Text = "CoachForm";
            administrationGroupBox.ResumeLayout(false);
            administrationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox administrationGroupBox;
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
        private FontAwesome.Sharp.IconButton PDFBtn;
    }
}