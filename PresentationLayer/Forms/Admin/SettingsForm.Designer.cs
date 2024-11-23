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
            roleLabel = new Label();
            textBox1 = new TextBox();
            addUserTextBox = new TextBox();
            addUserLabel = new Label();
            addUserBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            seachTextBox = new TextBox();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            editPermissonBtn = new FontAwesome.Sharp.IconButton();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            administrationGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Location = new Point(13, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1265, 427);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(editPermissonBtn);
            tabPage1.Controls.Add(roleLabel);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(addUserTextBox);
            tabPage1.Controls.Add(addUserLabel);
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
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.Black;
            roleLabel.Location = new Point(784, 141);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(53, 23);
            roleLabel.TabIndex = 9;
            roleLabel.Text = "Role";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(786, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 32);
            textBox1.TabIndex = 8;
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
            addUserLabel.Size = new Size(123, 23);
            addUserLabel.TabIndex = 6;
            addUserLabel.Text = "Name  User";
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.Green;
            addUserBtn.ForeColor = Color.White;
            addUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addUserBtn.IconColor = Color.White;
            addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addUserBtn.Location = new Point(784, 262);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(279, 42);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 382);
            dataGridView1.TabIndex = 0;
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
            // editPermissonBtn
            // 
            editPermissonBtn.BackColor = Color.FromArgb(0, 123, 250);
            editPermissonBtn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            editPermissonBtn.IconColor = Color.White;
            editPermissonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editPermissonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editPermissonBtn.Location = new Point(788, 320);
            editPermissonBtn.Name = "editPermissonBtn";
            editPermissonBtn.Size = new Size(275, 51);
            editPermissonBtn.TabIndex = 1;
            editPermissonBtn.Text = "Edit Permisson";
            editPermissonBtn.UseVisualStyleBackColor = false;
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
        private FontAwesome.Sharp.IconButton addUserBtn;
        private DataGridView dataGridView1;
        private Label addUserLabel;
        private TextBox addUserTextBox;
        private TextBox seachTextBox;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private Label roleLabel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton editPermissonBtn;
    }
}