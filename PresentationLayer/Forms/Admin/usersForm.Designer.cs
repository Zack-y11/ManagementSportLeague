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
            administrationGroupBox = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            userPasswordTextBox = new TextBox();
            userMailTextBox = new TextBox();
            userMailLabel = new Label();
            userPassword = new Label();
            deleteUserBtn = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            editPermissonBtn = new FontAwesome.Sharp.IconButton();
            roleLabel = new Label();
            addUserTextBox = new TextBox();
            addUserLabel = new Label();
            addUserBtn = new FontAwesome.Sharp.IconButton();
            usersDataGrip = new DataGridView();
            userManagementLabel = new Label();
            managementIcon = new FontAwesome.Sharp.IconPictureBox();
            administrationGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            SuspendLayout();
            // 
            // administrationGroupBox
            // 
            administrationGroupBox.Controls.Add(tabControl1);
            administrationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrationGroupBox.Location = new Point(21, 151);
            administrationGroupBox.Name = "administrationGroupBox";
            administrationGroupBox.Size = new Size(1307, 509);
            administrationGroupBox.TabIndex = 1;
            administrationGroupBox.TabStop = false;
            administrationGroupBox.Text = "Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(13, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1265, 427);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(userPasswordTextBox);
            tabPage1.Controls.Add(userMailTextBox);
            tabPage1.Controls.Add(userMailLabel);
            tabPage1.Controls.Add(userPassword);
            tabPage1.Controls.Add(deleteUserBtn);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(editPermissonBtn);
            tabPage1.Controls.Add(roleLabel);
            tabPage1.Controls.Add(addUserTextBox);
            tabPage1.Controls.Add(addUserLabel);
            tabPage1.Controls.Add(addUserBtn);
            tabPage1.Controls.Add(usersDataGrip);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1257, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Location = new Point(592, 327);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(216, 32);
            userPasswordTextBox.TabIndex = 15;
            // 
            // userMailTextBox
            // 
            userMailTextBox.Location = new Point(592, 222);
            userMailTextBox.Name = "userMailTextBox";
            userMailTextBox.Size = new Size(216, 32);
            userMailTextBox.TabIndex = 14;
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.ForeColor = Color.Black;
            userMailLabel.Location = new Point(592, 184);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new Size(99, 23);
            userMailLabel.TabIndex = 13;
            userMailLabel.Text = "User mail";
            // 
            // userPassword
            // 
            userPassword.AutoSize = true;
            userPassword.ForeColor = Color.Black;
            userPassword.Location = new Point(592, 289);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(147, 23);
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
            deleteUserBtn.Location = new Point(827, 318);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(240, 41);
            deleteUserBtn.TabIndex = 11;
            deleteUserBtn.Text = "Edit Permisson";
            deleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(592, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 31);
            comboBox1.TabIndex = 10;
            // 
            // editPermissonBtn
            // 
            editPermissonBtn.BackColor = Color.FromArgb(0, 123, 250);
            editPermissonBtn.ForeColor = SystemColors.Control;
            editPermissonBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            editPermissonBtn.IconColor = Color.White;
            editPermissonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editPermissonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editPermissonBtn.Location = new Point(827, 184);
            editPermissonBtn.Name = "editPermissonBtn";
            editPermissonBtn.Size = new Size(240, 42);
            editPermissonBtn.TabIndex = 1;
            editPermissonBtn.Text = "Edit Permisson";
            editPermissonBtn.UseVisualStyleBackColor = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(592, 101);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(53, 23);
            roleLabel.TabIndex = 9;
            roleLabel.Text = "Role";
            // 
            // addUserTextBox
            // 
            addUserTextBox.Location = new Point(592, 48);
            addUserTextBox.Name = "addUserTextBox";
            addUserTextBox.Size = new Size(216, 32);
            addUserTextBox.TabIndex = 7;
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.ForeColor = Color.Black;
            addUserLabel.Location = new Point(592, 13);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(108, 23);
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
            addUserBtn.Location = new Point(827, 41);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(240, 42);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = false;
            // 
            // usersDataGrip
            // 
            usersDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrip.Location = new Point(3, 3);
            usersDataGrip.Name = "usersDataGrip";
            usersDataGrip.RowHeadersWidth = 51;
            usersDataGrip.Size = new Size(583, 382);
            usersDataGrip.TabIndex = 0;
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
            // usersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 716);
            Controls.Add(managementIcon);
            Controls.Add(userManagementLabel);
            Controls.Add(administrationGroupBox);
            Name = "usersForm";
            Text = "CoachForm";
            administrationGroupBox.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)managementIcon).EndInit();
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
        private ComboBox comboBox1;
        private TextBox userMailTextBox;
        private TextBox userPasswordTextBox;
    }
}