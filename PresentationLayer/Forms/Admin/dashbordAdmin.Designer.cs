using FontAwesome.Sharp;

namespace PresentationLayer.Forms
{
    partial class dashboardAdmin
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
            panel1 = new Panel();
            coachBtn = new IconButton();
            panel2 = new Panel();
            matchesBtn = new IconButton();
            settingsBtn = new IconButton();
            statisticsBtn = new IconButton();
            featuresBtn = new IconButton();
            teamsBtn = new IconButton();
            iconPictureBox1 = new IconPictureBox();
            sportLabel = new Label();
            headerPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contentPanel = new Panel();
            matchInformation = new DataGridView();
            matchInformationLabel = new Label();
            matchPanel = new Panel();
            scoreTextBox = new TextBox();
            scoreLabel = new Label();
            matchStatusLabel = new Label();
            cornersLabel = new Label();
            foulsLabel = new Label();
            foulsTextBox = new TextBox();
            cornersTextBox = new TextBox();
            matchStatusTextBox = new TextBox();
            matchDateTextBox = new TextBox();
            timeLabel = new Label();
            editMatchLabel = new Label();
            deleteMatchLabel = new Label();
            awayTeamLabel = new Label();
            deleteMatchBtn = new IconButton();
            editMatchBtn = new IconButton();
            addMatchBtn = new IconButton();
            awayTeamComboBox = new ComboBox();
            vsLabel = new Label();
            homeTeamLabels = new Label();
            homeTeamComboBox = new ComboBox();
            createMatchLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).BeginInit();
            matchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(coachBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(matchesBtn);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(statisticsBtn);
            panel1.Controls.Add(featuresBtn);
            panel1.Controls.Add(teamsBtn);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(sportLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 753);
            panel1.TabIndex = 1;
            // 
            // coachBtn
            // 
            coachBtn.FlatStyle = FlatStyle.Flat;
            coachBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            coachBtn.IconChar = IconChar.PeopleGroup;
            coachBtn.IconColor = Color.Black;
            coachBtn.IconFont = IconFont.Auto;
            coachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            coachBtn.Location = new Point(0, 160);
            coachBtn.Name = "coachBtn";
            coachBtn.Size = new Size(263, 59);
            coachBtn.TabIndex = 8;
            coachBtn.Text = "Coach";
            coachBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 139);
            panel2.TabIndex = 0;
            // 
            // matchesBtn
            // 
            matchesBtn.FlatStyle = FlatStyle.Flat;
            matchesBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            matchesBtn.IconChar = IconChar.Newspaper;
            matchesBtn.IconColor = Color.Black;
            matchesBtn.IconFont = IconFont.Auto;
            matchesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            matchesBtn.Location = new Point(0, 106);
            matchesBtn.Name = "matchesBtn";
            matchesBtn.Size = new Size(263, 59);
            matchesBtn.TabIndex = 7;
            matchesBtn.Text = "Matches";
            matchesBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            settingsBtn.IconChar = IconChar.Cogs;
            settingsBtn.IconColor = Color.Black;
            settingsBtn.IconFont = IconFont.Auto;
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(0, 385);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(263, 59);
            settingsBtn.TabIndex = 6;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // statisticsBtn
            // 
            statisticsBtn.FlatStyle = FlatStyle.Flat;
            statisticsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            statisticsBtn.IconChar = IconChar.Squarespace;
            statisticsBtn.IconColor = Color.Black;
            statisticsBtn.IconFont = IconFont.Auto;
            statisticsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            statisticsBtn.Location = new Point(0, 329);
            statisticsBtn.Name = "statisticsBtn";
            statisticsBtn.Size = new Size(263, 59);
            statisticsBtn.TabIndex = 5;
            statisticsBtn.Text = "Statistics";
            statisticsBtn.UseVisualStyleBackColor = true;
            // 
            // featuresBtn
            // 
            featuresBtn.FlatStyle = FlatStyle.Flat;
            featuresBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            featuresBtn.IconChar = IconChar.FileText;
            featuresBtn.IconColor = Color.Black;
            featuresBtn.IconFont = IconFont.Auto;
            featuresBtn.ImageAlign = ContentAlignment.MiddleLeft;
            featuresBtn.Location = new Point(0, 269);
            featuresBtn.Name = "featuresBtn";
            featuresBtn.Size = new Size(263, 59);
            featuresBtn.TabIndex = 4;
            featuresBtn.Text = "Features";
            featuresBtn.UseVisualStyleBackColor = true;
            // 
            // teamsBtn
            // 
            teamsBtn.FlatStyle = FlatStyle.Flat;
            teamsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            teamsBtn.IconChar = IconChar.Users;
            teamsBtn.IconColor = Color.Black;
            teamsBtn.IconFont = IconFont.Auto;
            teamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            teamsBtn.Location = new Point(0, 213);
            teamsBtn.Name = "teamsBtn";
            teamsBtn.Size = new Size(263, 59);
            teamsBtn.TabIndex = 3;
            teamsBtn.Text = "Teams";
            teamsBtn.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.HotTrack;
            iconPictureBox1.IconChar = IconChar.Trophy;
            iconPictureBox1.IconColor = SystemColors.HotTrack;
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // sportLabel
            // 
            sportLabel.AutoSize = true;
            sportLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            sportLabel.Location = new Point(58, 21);
            sportLabel.Name = "sportLabel";
            sportLabel.Size = new Size(186, 32);
            sportLabel.TabIndex = 2;
            sportLabel.Text = "Sport League";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(263, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1156, 61);
            headerPanel.TabIndex = 2;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.Control;
            contentPanel.Controls.Add(matchPanel);
            contentPanel.Controls.Add(matchInformation);
            contentPanel.Controls.Add(matchInformationLabel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(263, 61);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1156, 692);
            contentPanel.TabIndex = 5;
            // 
            // matchInformation
            // 
            matchInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matchInformation.Location = new Point(6, 442);
            matchInformation.Name = "matchInformation";
            matchInformation.RowHeadersWidth = 51;
            matchInformation.Size = new Size(736, 226);
            matchInformation.TabIndex = 14;
            // 
            // matchInformationLabel
            // 
            matchInformationLabel.AutoSize = true;
            matchInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchInformationLabel.Location = new Point(6, 398);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(189, 23);
            matchInformationLabel.TabIndex = 13;
            matchInformationLabel.Text = "Match Information";
            // 
            // matchPanel
            // 
            matchPanel.Controls.Add(scoreTextBox);
            matchPanel.Controls.Add(scoreLabel);
            matchPanel.Controls.Add(matchStatusLabel);
            matchPanel.Controls.Add(cornersLabel);
            matchPanel.Controls.Add(foulsLabel);
            matchPanel.Controls.Add(foulsTextBox);
            matchPanel.Controls.Add(cornersTextBox);
            matchPanel.Controls.Add(matchStatusTextBox);
            matchPanel.Controls.Add(matchDateTextBox);
            matchPanel.Controls.Add(timeLabel);
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
            matchPanel.Size = new Size(1156, 353);
            matchPanel.TabIndex = 15;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(585, 188);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(191, 26);
            scoreTextBox.TabIndex = 30;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            scoreLabel.Location = new Point(585, 156);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(60, 19);
            scoreLabel.TabIndex = 29;
            scoreLabel.Text = "Status:";
            // 
            // matchStatusLabel
            // 
            matchStatusLabel.AutoSize = true;
            matchStatusLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            matchStatusLabel.Location = new Point(585, 63);
            matchStatusLabel.Name = "matchStatusLabel";
            matchStatusLabel.Size = new Size(60, 19);
            matchStatusLabel.TabIndex = 28;
            matchStatusLabel.Text = "Status:";
            // 
            // cornersLabel
            // 
            cornersLabel.AutoSize = true;
            cornersLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            cornersLabel.Location = new Point(332, 250);
            cornersLabel.Name = "cornersLabel";
            cornersLabel.Size = new Size(77, 19);
            cornersLabel.TabIndex = 27;
            cornersLabel.Text = "Corners:";
            // 
            // foulsLabel
            // 
            foulsLabel.AutoSize = true;
            foulsLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            foulsLabel.Location = new Point(332, 156);
            foulsLabel.Name = "foulsLabel";
            foulsLabel.Size = new Size(55, 19);
            foulsLabel.TabIndex = 26;
            foulsLabel.Text = "Fouls:";
            // 
            // foulsTextBox
            // 
            foulsTextBox.Location = new Point(332, 188);
            foulsTextBox.Name = "foulsTextBox";
            foulsTextBox.Size = new Size(191, 26);
            foulsTextBox.TabIndex = 25;
            // 
            // cornersTextBox
            // 
            cornersTextBox.Location = new Point(332, 285);
            cornersTextBox.Name = "cornersTextBox";
            cornersTextBox.Size = new Size(191, 26);
            cornersTextBox.TabIndex = 24;
            // 
            // matchStatusTextBox
            // 
            matchStatusTextBox.Location = new Point(585, 99);
            matchStatusTextBox.Name = "matchStatusTextBox";
            matchStatusTextBox.Size = new Size(191, 26);
            matchStatusTextBox.TabIndex = 23;
            // 
            // matchDateTextBox
            // 
            matchDateTextBox.Location = new Point(332, 99);
            matchDateTextBox.Name = "matchDateTextBox";
            matchDateTextBox.Size = new Size(191, 26);
            matchDateTextBox.TabIndex = 22;
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
            deleteMatchBtn.IconChar = IconChar.UserSlash;
            deleteMatchBtn.IconColor = Color.White;
            deleteMatchBtn.IconFont = IconFont.Auto;
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
            editMatchBtn.IconChar = IconChar.UserCheck;
            editMatchBtn.IconColor = Color.White;
            editMatchBtn.IconFont = IconFont.Auto;
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
            addMatchBtn.IconChar = IconChar.UserPlus;
            addMatchBtn.IconColor = Color.White;
            addMatchBtn.IconFont = IconFont.Auto;
            addMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMatchBtn.Location = new Point(846, 83);
            addMatchBtn.Name = "addMatchBtn";
            addMatchBtn.Size = new Size(226, 43);
            addMatchBtn.TabIndex = 10;
            addMatchBtn.Text = "Create Match";
            addMatchBtn.UseVisualStyleBackColor = false;
            // 
            // awayTeamComboBox
            // 
            awayTeamComboBox.FormattingEnabled = true;
            awayTeamComboBox.Location = new Point(0, 241);
            awayTeamComboBox.Name = "awayTeamComboBox";
            awayTeamComboBox.Size = new Size(238, 26);
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
            homeTeamComboBox.Location = new Point(3, 98);
            homeTeamComboBox.Name = "homeTeamComboBox";
            homeTeamComboBox.Size = new Size(238, 26);
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
            // dashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1419, 753);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashbordAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).EndInit();
            matchPanel.ResumeLayout(false);
            matchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label sportLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel headerPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton teamsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private IconButton featuresBtn;
        private IconButton statisticsBtn;
        private IconButton settingsBtn;
        private IconButton matchesBtn;
        private Panel panel2;
        private Panel contentPanel;
        private Label matchInformationLabel;
        private DataGridView matchInformation;
        private IconButton coachBtn;
        private Panel matchPanel;
        private TextBox scoreTextBox;
        private Label scoreLabel;
        private Label matchStatusLabel;
        private Label cornersLabel;
        private Label foulsLabel;
        private TextBox foulsTextBox;
        private TextBox cornersTextBox;
        private TextBox matchStatusTextBox;
        private TextBox matchDateTextBox;
        private Label timeLabel;
        private Label editMatchLabel;
        private Label deleteMatchLabel;
        private Label awayTeamLabel;
        private IconButton deleteMatchBtn;
        private IconButton editMatchBtn;
        private IconButton addMatchBtn;
        private ComboBox awayTeamComboBox;
        private Label vsLabel;
        private Label homeTeamLabels;
        private ComboBox homeTeamComboBox;
        private Label createMatchLabel;
    }
}