namespace PresentationLayer.Forms
{
    partial class DashboardForm
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
            centerPanel = new Panel();
            contentPanel = new Panel();
            matchInformation = new DataGridView();
            matchInformationLabel = new Label();
            matchPanel = new Panel();
            editMatchLabel = new Label();
            deleteMatchLabel = new Label();
            vsTeamLabel = new Label();
            deleteMatchBtn = new FontAwesome.Sharp.IconButton();
            editMatchBtn = new FontAwesome.Sharp.IconButton();
            addMatchBtn = new FontAwesome.Sharp.IconButton();
            vsTeamComboBox = new ComboBox();
            vsLabel = new Label();
            teamLabel = new Label();
            matchTeamComboBox = new ComboBox();
            createMatchLabel = new Label();
            timeTextBox = new ComboBox();
            timeLabel = new Label();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).BeginInit();
            matchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 0);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(1371, 716);
            centerPanel.TabIndex = 10;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(matchInformation);
            contentPanel.Controls.Add(matchInformationLabel);
            contentPanel.Controls.Add(matchPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1371, 716);
            contentPanel.TabIndex = 11;
            // 
            // matchInformation
            // 
            matchInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matchInformation.Location = new Point(24, 431);
            matchInformation.Name = "matchInformation";
            matchInformation.RowHeadersWidth = 51;
            matchInformation.Size = new Size(885, 255);
            matchInformation.TabIndex = 13;
            // 
            // matchInformationLabel
            // 
            matchInformationLabel.AutoSize = true;
            matchInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchInformationLabel.Location = new Point(24, 378);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(189, 23);
            matchInformationLabel.TabIndex = 12;
            matchInformationLabel.Text = "Match Information";
            // 
            // matchPanel
            // 
            matchPanel.Controls.Add(timeLabel);
            matchPanel.Controls.Add(timeTextBox);
            matchPanel.Controls.Add(editMatchLabel);
            matchPanel.Controls.Add(deleteMatchLabel);
            matchPanel.Controls.Add(vsTeamLabel);
            matchPanel.Controls.Add(deleteMatchBtn);
            matchPanel.Controls.Add(editMatchBtn);
            matchPanel.Controls.Add(addMatchBtn);
            matchPanel.Controls.Add(vsTeamComboBox);
            matchPanel.Controls.Add(vsLabel);
            matchPanel.Controls.Add(teamLabel);
            matchPanel.Controls.Add(matchTeamComboBox);
            matchPanel.Controls.Add(createMatchLabel);
            matchPanel.Dock = DockStyle.Top;
            matchPanel.Location = new Point(0, 0);
            matchPanel.Name = "matchPanel";
            matchPanel.Size = new Size(1371, 353);
            matchPanel.TabIndex = 11;
            // 
            // editMatchLabel
            // 
            editMatchLabel.AutoSize = true;
            editMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchLabel.Location = new Point(846, 156);
            editMatchLabel.Name = "editMatchLabel";
            editMatchLabel.Size = new Size(112, 23);
            editMatchLabel.TabIndex = 15;
            editMatchLabel.Text = "Edit Match";
            // 
            // deleteMatchLabel
            // 
            deleteMatchLabel.AutoSize = true;
            deleteMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMatchLabel.Location = new Point(846, 269);
            deleteMatchLabel.Name = "deleteMatchLabel";
            deleteMatchLabel.Size = new Size(142, 23);
            deleteMatchLabel.TabIndex = 15;
            deleteMatchLabel.Text = "Delete Match";
            // 
            // vsTeamLabel
            // 
            vsTeamLabel.AutoSize = true;
            vsTeamLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            vsTeamLabel.Location = new Point(3, 209);
            vsTeamLabel.Name = "vsTeamLabel";
            vsTeamLabel.Size = new Size(59, 19);
            vsTeamLabel.TabIndex = 15;
            vsTeamLabel.Text = "Team:";
            // 
            // deleteMatchBtn
            // 
            deleteMatchBtn.BackColor = Color.Red;
            deleteMatchBtn.FlatStyle = FlatStyle.Flat;
            deleteMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMatchBtn.ForeColor = Color.White;
            deleteMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            deleteMatchBtn.IconColor = Color.White;
            deleteMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteMatchBtn.Location = new Point(846, 295);
            deleteMatchBtn.Name = "deleteMatchBtn";
            deleteMatchBtn.Size = new Size(226, 43);
            deleteMatchBtn.TabIndex = 10;
            deleteMatchBtn.Text = "Delete Match";
            deleteMatchBtn.UseVisualStyleBackColor = false;
            // 
            // editMatchBtn
            // 
            editMatchBtn.BackColor = Color.FromArgb(0, 123, 250);
            editMatchBtn.FlatStyle = FlatStyle.Flat;
            editMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchBtn.ForeColor = Color.White;
            editMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            editMatchBtn.IconColor = Color.White;
            editMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editMatchBtn.Location = new Point(846, 209);
            editMatchBtn.Name = "editMatchBtn";
            editMatchBtn.Size = new Size(226, 43);
            editMatchBtn.TabIndex = 10;
            editMatchBtn.Text = "Edit Match";
            editMatchBtn.UseVisualStyleBackColor = false;
            // 
            // addMatchBtn
            // 
            addMatchBtn.BackColor = Color.Green;
            addMatchBtn.FlatStyle = FlatStyle.Flat;
            addMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMatchBtn.ForeColor = Color.White;
            addMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addMatchBtn.IconColor = Color.White;
            addMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMatchBtn.Location = new Point(846, 83);
            addMatchBtn.Name = "addMatchBtn";
            addMatchBtn.Size = new Size(226, 43);
            addMatchBtn.TabIndex = 10;
            addMatchBtn.Text = "Create Match";
            addMatchBtn.UseVisualStyleBackColor = false;
            // 
            // vsTeamComboBox
            // 
            vsTeamComboBox.FormattingEnabled = true;
            vsTeamComboBox.Location = new Point(0, 241);
            vsTeamComboBox.Name = "vsTeamComboBox";
            vsTeamComboBox.Size = new Size(238, 28);
            vsTeamComboBox.TabIndex = 14;
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            vsLabel.ForeColor = Color.Gold;
            vsLabel.Location = new Point(3, 156);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(83, 23);
            vsLabel.TabIndex = 13;
            vsLabel.Text = "Agains:";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            teamLabel.Location = new Point(3, 63);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(59, 19);
            teamLabel.TabIndex = 12;
            teamLabel.Text = "Team:";
            // 
            // matchTeamComboBox
            // 
            matchTeamComboBox.FormattingEnabled = true;
            matchTeamComboBox.Location = new Point(3, 98);
            matchTeamComboBox.Name = "matchTeamComboBox";
            matchTeamComboBox.Size = new Size(238, 28);
            matchTeamComboBox.TabIndex = 11;
            // 
            // createMatchLabel
            // 
            createMatchLabel.AutoSize = true;
            createMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMatchLabel.Location = new Point(3, 21);
            createMatchLabel.Name = "createMatchLabel";
            createMatchLabel.Size = new Size(145, 23);
            createMatchLabel.TabIndex = 10;
            createMatchLabel.Text = "Create Match";
            // 
            // timeTextBox
            // 
            timeTextBox.FormattingEnabled = true;
            timeTextBox.Location = new Point(332, 98);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(238, 28);
            timeTextBox.TabIndex = 20;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            timeLabel.Location = new Point(332, 63);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(52, 19);
            timeLabel.TabIndex = 21;
            timeLabel.Text = "Time:";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 716);
            Controls.Add(contentPanel);
            Controls.Add(centerPanel);
            Name = "DashboardForm";
            Text = "DashboardForm";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).EndInit();
            matchPanel.ResumeLayout(false);
            matchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel centerPanel;
        private Panel contentPanel;
        private Label createMatchLabel;
        private Panel matchPanel;
        private Label teamLabel;
        private ComboBox matchTeamComboBox;
        private Label vsLabel;
        private ComboBox vsTeamComboBox;
        private FontAwesome.Sharp.IconButton addMatchBtn;
        private FontAwesome.Sharp.IconButton editMatchBtn;
        private FontAwesome.Sharp.IconButton deleteMatchBtn;
        private Label vsTeamLabel;
        private Label matchInformationLabel;
        private DataGridView matchInformation;
        private Label deleteMatchLabel;
        private Label editMatchLabel;
        private Label timeLabel;
        private ComboBox timeTextBox;
    }
}