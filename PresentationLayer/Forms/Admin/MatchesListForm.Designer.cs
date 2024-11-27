﻿namespace PresentationLayer.Forms
{
    partial class MatchesListForm
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
            matchDateTimePicker = new DateTimePicker();
            timeLabel = new Label();
            statusComboBox = new ComboBox();
            cornersLabel = new Label();
            scoreTextBox = new TextBox();
            foulsLabel = new Label();
            scoreLabel = new Label();
            foulsTextBox = new TextBox();
            matchStatusLabel = new Label();
            cornersTextBox = new TextBox();
            editMatchLabel = new Label();
            deleteMatchLabel = new Label();
            awayTeamLabel = new Label();
            deleteMatchBtn = new FontAwesome.Sharp.IconButton();
            editMatchBtn = new FontAwesome.Sharp.IconButton();
            addMatchBtn = new FontAwesome.Sharp.IconButton();
            awayTeamComboBox = new ComboBox();
            vsLabel = new Label();
            homeTeamLabels = new Label();
            homeTeamComboBox = new ComboBox();
            createMatchLabel = new Label();
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
            centerPanel.Size = new Size(1370, 716);
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
            contentPanel.Size = new Size(1370, 716);
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
            matchInformationLabel.Location = new Point(24, 379);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(189, 23);
            matchInformationLabel.TabIndex = 12;
            matchInformationLabel.Text = "Match Information";
            // 
            // matchPanel
            // 
            matchPanel.Controls.Add(matchDateTimePicker);
            matchPanel.Controls.Add(timeLabel);
            matchPanel.Controls.Add(statusComboBox);
            matchPanel.Controls.Add(cornersLabel);
            matchPanel.Controls.Add(scoreTextBox);
            matchPanel.Controls.Add(foulsLabel);
            matchPanel.Controls.Add(scoreLabel);
            matchPanel.Controls.Add(foulsTextBox);
            matchPanel.Controls.Add(matchStatusLabel);
            matchPanel.Controls.Add(cornersTextBox);
            matchPanel.Controls.Add(editMatchLabel);
            matchPanel.Controls.Add(deleteMatchLabel);
            matchPanel.Controls.Add(awayTeamLabel);
            matchPanel.Controls.Add(deleteMatchBtn);
            matchPanel.Controls.Add(editMatchBtn);
            matchPanel.Controls.Add(addMatchBtn);
            matchPanel.Controls.Add(awayTeamComboBox);
            matchPanel.Controls.Add(vsLabel);
            matchPanel.Controls.Add(homeTeamLabels);
            matchPanel.Controls.Add(homeTeamComboBox);
            matchPanel.Controls.Add(createMatchLabel);
            matchPanel.Dock = DockStyle.Top;
            matchPanel.Location = new Point(0, 0);
            matchPanel.Name = "matchPanel";
            matchPanel.Size = new Size(1370, 353);
            matchPanel.TabIndex = 11;
            // 
            // matchDateTimePicker
            // 
            matchDateTimePicker.Location = new Point(299, 99);
            matchDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            matchDateTimePicker.Name = "matchDateTimePicker";
            matchDateTimePicker.Size = new Size(258, 27);
            matchDateTimePicker.TabIndex = 33;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            timeLabel.Location = new Point(339, 51);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(52, 19);
            timeLabel.TabIndex = 32;
            timeLabel.Text = "Time:";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(591, 99);
            statusComboBox.Margin = new Padding(3, 4, 3, 4);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(219, 28);
            statusComboBox.TabIndex = 36;
            // 
            // cornersLabel
            // 
            cornersLabel.AutoSize = true;
            cornersLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            cornersLabel.Location = new Point(331, 251);
            cornersLabel.Name = "cornersLabel";
            cornersLabel.Size = new Size(77, 19);
            cornersLabel.TabIndex = 27;
            cornersLabel.Text = "Corners:";
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(592, 229);
            scoreTextBox.Margin = new Padding(3, 4, 3, 4);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(218, 27);
            scoreTextBox.TabIndex = 35;
            // 
            // foulsLabel
            // 
            foulsLabel.AutoSize = true;
            foulsLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            foulsLabel.Location = new Point(331, 156);
            foulsLabel.Name = "foulsLabel";
            foulsLabel.Size = new Size(55, 19);
            foulsLabel.TabIndex = 26;
            foulsLabel.Text = "Fouls:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            scoreLabel.Location = new Point(592, 187);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(61, 19);
            scoreLabel.TabIndex = 34;
            scoreLabel.Text = "Score:";
            // 
            // foulsTextBox
            // 
            foulsTextBox.Location = new Point(331, 188);
            foulsTextBox.Name = "foulsTextBox";
            foulsTextBox.Size = new Size(191, 27);
            foulsTextBox.TabIndex = 25;
            // 
            // matchStatusLabel
            // 
            matchStatusLabel.AutoSize = true;
            matchStatusLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            matchStatusLabel.Location = new Point(592, 51);
            matchStatusLabel.Name = "matchStatusLabel";
            matchStatusLabel.Size = new Size(60, 19);
            matchStatusLabel.TabIndex = 33;
            matchStatusLabel.Text = "Status:";
            // 
            // cornersTextBox
            // 
            cornersTextBox.Location = new Point(331, 285);
            cornersTextBox.Name = "cornersTextBox";
            cornersTextBox.Size = new Size(191, 27);
            cornersTextBox.TabIndex = 24;
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
            // awayTeamLabel
            // 
            awayTeamLabel.AutoSize = true;
            awayTeamLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            awayTeamLabel.Location = new Point(3, 209);
            awayTeamLabel.Name = "awayTeamLabel";
            awayTeamLabel.Size = new Size(112, 19);
            awayTeamLabel.TabIndex = 15;
            awayTeamLabel.Text = "Away Team:";
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
            deleteMatchBtn.Click += deleteMatchBtn_Click;
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
            editMatchBtn.Click += editMatchBtn_Click;
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
            addMatchBtn.Click += addMatchBtn_Click;
            // 
            // awayTeamComboBox
            // 
            awayTeamComboBox.FormattingEnabled = true;
            awayTeamComboBox.Location = new Point(0, 241);
            awayTeamComboBox.Name = "awayTeamComboBox";
            awayTeamComboBox.Size = new Size(238, 28);
            awayTeamComboBox.TabIndex = 14;
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
            // homeTeamLabels
            // 
            homeTeamLabels.AutoSize = true;
            homeTeamLabels.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            homeTeamLabels.Location = new Point(3, 63);
            homeTeamLabels.Name = "homeTeamLabels";
            homeTeamLabels.Size = new Size(109, 19);
            homeTeamLabels.TabIndex = 12;
            homeTeamLabels.Text = "Home Team";
            // 
            // homeTeamComboBox
            // 
            homeTeamComboBox.FormattingEnabled = true;
            homeTeamComboBox.Location = new Point(3, 99);
            homeTeamComboBox.Name = "homeTeamComboBox";
            homeTeamComboBox.Size = new Size(238, 28);
            homeTeamComboBox.TabIndex = 11;
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 716);
            Controls.Add(contentPanel);
            Controls.Add(centerPanel);
            Name = "DashboardForm";
            Text = "2";
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
        private Label homeTeamLabels;
        private ComboBox homeTeamComboBox;
        private Label vsLabel;
        private ComboBox awayTeamComboBox;
        private FontAwesome.Sharp.IconButton addMatchBtn;
        private FontAwesome.Sharp.IconButton editMatchBtn;
        private FontAwesome.Sharp.IconButton deleteMatchBtn;
        private Label awayTeamLabel;
        private Label matchInformationLabel;
        private DataGridView matchInformation;
        private Label deleteMatchLabel;
        private Label editMatchLabel;
        private TextBox foulsTextBox;
        private TextBox cornersTextBox;
        private Label foulsLabel;
        private Label cornersLabel;
        private ComboBox statusComboBox;
        private TextBox scoreTextBox;
        private Label scoreLabel;
        private Label matchStatusLabel;
        private DateTimePicker matchDateTimePicker;
        private Label timeLabel;
    }
}