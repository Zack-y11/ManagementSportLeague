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
            usersBtn = new IconButton();
            panel2 = new Panel();
            matchesBtn = new IconButton();
            settingsBtn = new IconButton();
            statisticsBtn = new IconButton();
            featuresBtn = new IconButton();
            teamsBtn = new IconButton();
            iconPictureBox1 = new IconPictureBox();
            sportLabel = new Label();
            headerPanel = new Panel();
            IconsPanel = new Panel();
            resetBtn = new IconButton();
            maximizeBtn = new IconButton();
            closeBtn = new IconButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contentPanel = new Panel();
            matchPanel = new Panel();
            statusComboBox = new ComboBox();
            matchDateTimePicker = new DateTimePicker();
            scoreTextBox = new TextBox();
            scoreLabel = new Label();
            matchStatusLabel = new Label();
            cornersLabel = new Label();
            foulsLabel = new Label();
            foulsTextBox = new TextBox();
            cornersTextBox = new TextBox();
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
            matchInformation = new DataGridView();
            matchInformationLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            IconsPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            matchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(usersBtn);
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
            panel1.Size = new Size(263, 749);
            panel1.TabIndex = 1;
            // 
            // usersBtn
            // 
            usersBtn.FlatStyle = FlatStyle.Flat;
            usersBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            usersBtn.IconChar = IconChar.PeopleGroup;
            usersBtn.IconColor = Color.Black;
            usersBtn.IconFont = IconFont.Auto;
            usersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            usersBtn.Location = new Point(0, 330);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(263, 59);
            usersBtn.TabIndex = 8;
            usersBtn.Text = "Users";
            usersBtn.UseVisualStyleBackColor = true;
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
            statisticsBtn.Location = new Point(0, 271);
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
            featuresBtn.Location = new Point(0, 217);
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
            teamsBtn.Location = new Point(0, 160);
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
            headerPanel.BackColor = Color.FromArgb(0, 123, 255);
            headerPanel.Controls.Add(IconsPanel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(263, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1107, 100);
            headerPanel.TabIndex = 2;
            // 
            // IconsPanel
            // 
            IconsPanel.Controls.Add(resetBtn);
            IconsPanel.Controls.Add(maximizeBtn);
            IconsPanel.Controls.Add(closeBtn);
            IconsPanel.Dock = DockStyle.Right;
            IconsPanel.Location = new Point(936, 0);
            IconsPanel.Name = "IconsPanel";
            IconsPanel.Size = new Size(171, 100);
            IconsPanel.TabIndex = 8;
            // 
            // resetBtn
            // 
            resetBtn.Dock = DockStyle.Right;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.IconChar = IconChar.Subtract;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = IconFont.Auto;
            resetBtn.Location = new Point(4, 0);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(58, 100);
            resetBtn.TabIndex = 4;
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatStyle = FlatStyle.Popup;
            maximizeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maximizeBtn.IconChar = IconChar.Clone;
            maximizeBtn.IconColor = Color.White;
            maximizeBtn.IconFont = IconFont.Auto;
            maximizeBtn.Location = new Point(62, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(58, 100);
            maximizeBtn.TabIndex = 3;
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatStyle = FlatStyle.Popup;
            closeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.IconChar = IconChar.Close;
            closeBtn.IconColor = Color.White;
            closeBtn.IconFont = IconFont.Auto;
            closeBtn.Location = new Point(120, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(51, 100);
            closeBtn.TabIndex = 5;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.Control;
            contentPanel.Controls.Add(matchPanel);
            contentPanel.Controls.Add(matchInformation);
            contentPanel.Controls.Add(matchInformationLabel);
            contentPanel.Location = new Point(263, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1107, 649);
            contentPanel.TabIndex = 5;
            // 
            // matchPanel
            // 
            matchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            matchPanel.Controls.Add(statusComboBox);
            matchPanel.Controls.Add(matchDateTimePicker);
            matchPanel.Controls.Add(scoreTextBox);
            matchPanel.Controls.Add(scoreLabel);
            matchPanel.Controls.Add(matchStatusLabel);
            matchPanel.Controls.Add(cornersLabel);
            matchPanel.Controls.Add(foulsLabel);
            matchPanel.Controls.Add(foulsTextBox);
            matchPanel.Controls.Add(cornersTextBox);
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
            matchPanel.Location = new Point(0, 0);
            matchPanel.Name = "matchPanel";
            matchPanel.Size = new Size(1104, 353);
            matchPanel.TabIndex = 15;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(560, 99);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(192, 26);
            statusComboBox.TabIndex = 32;
            // 
            // matchDateTimePicker
            // 
            matchDateTimePicker.Location = new Point(297, 99);
            matchDateTimePicker.Name = "matchDateTimePicker";
            matchDateTimePicker.Size = new Size(226, 26);
            matchDateTimePicker.TabIndex = 31;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(560, 188);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(191, 26);
            scoreTextBox.TabIndex = 30;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            scoreLabel.Location = new Point(560, 156);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(61, 19);
            scoreLabel.TabIndex = 29;
            scoreLabel.Text = "Score:";
            // 
            // matchStatusLabel
            // 
            matchStatusLabel.AutoSize = true;
            matchStatusLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            matchStatusLabel.Location = new Point(560, 60);
            matchStatusLabel.Name = "matchStatusLabel";
            matchStatusLabel.Size = new Size(60, 19);
            matchStatusLabel.TabIndex = 28;
            matchStatusLabel.Text = "Status:";
            // 
            // cornersLabel
            // 
            cornersLabel.AutoSize = true;
            cornersLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            cornersLabel.Location = new Point(806, 60);
            cornersLabel.Name = "cornersLabel";
            cornersLabel.Size = new Size(77, 19);
            cornersLabel.TabIndex = 27;
            cornersLabel.Text = "Corners:";
            // 
            // foulsLabel
            // 
            foulsLabel.AutoSize = true;
            foulsLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            foulsLabel.Location = new Point(297, 156);
            foulsLabel.Name = "foulsLabel";
            foulsLabel.Size = new Size(55, 19);
            foulsLabel.TabIndex = 26;
            foulsLabel.Text = "Fouls:";
            // 
            // foulsTextBox
            // 
            foulsTextBox.Location = new Point(300, 188);
            foulsTextBox.Name = "foulsTextBox";
            foulsTextBox.Size = new Size(191, 26);
            foulsTextBox.TabIndex = 25;
            // 
            // cornersTextBox
            // 
            cornersTextBox.Location = new Point(807, 98);
            cornersTextBox.Name = "cornersTextBox";
            cornersTextBox.Size = new Size(191, 26);
            cornersTextBox.TabIndex = 24;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            timeLabel.Location = new Point(300, 63);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(52, 19);
            timeLabel.TabIndex = 21;
            timeLabel.Text = "Time:";
            // 
            // editMatchLabel
            // 
            editMatchLabel.AutoSize = true;
            editMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchLabel.Location = new Point(356, 248);
            editMatchLabel.Name = "editMatchLabel";
            editMatchLabel.Size = new Size(112, 23);
            editMatchLabel.TabIndex = 15;
            editMatchLabel.Text = "Edit Match";
            // 
            // deleteMatchLabel
            // 
            deleteMatchLabel.AutoSize = true;
            deleteMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMatchLabel.Location = new Point(657, 248);
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
            deleteMatchBtn.Location = new Point(657, 285);
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
            editMatchBtn.Location = new Point(356, 285);
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
            addMatchBtn.Location = new Point(15, 285);
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
            // matchInformation
            // 
            matchInformation.ColumnHeadersHeight = 29;
            matchInformation.Location = new Point(0, 0);
            matchInformation.Name = "matchInformation";
            matchInformation.RowHeadersWidth = 51;
            matchInformation.Size = new Size(240, 150);
            matchInformation.TabIndex = 16;
            // 
            // matchInformationLabel
            // 
            matchInformationLabel.Location = new Point(0, 0);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(100, 23);
            matchInformationLabel.TabIndex = 17;
            // 
            // dashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1370, 749);
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
            headerPanel.ResumeLayout(false);
            IconsPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            matchPanel.ResumeLayout(false);
            matchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).EndInit();
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
        private IconButton usersBtn;
        private Panel matchPanel;
        private ComboBox statusComboBox;
        private DateTimePicker matchDateTimePicker;
        private TextBox scoreTextBox;
        private Label scoreLabel;
        private Label matchStatusLabel;
        private Label cornersLabel;
        private Label foulsLabel;
        private TextBox foulsTextBox;
        private TextBox cornersTextBox;
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
        private DataGridView matchInformation;
        private Panel IconsPanel;
        private IconButton resetBtn;
        private IconButton maximizeBtn;
        private IconButton closeBtn;
    }
}