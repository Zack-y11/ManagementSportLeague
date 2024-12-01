namespace PresentationLayer.Forms
{
    partial class FeaturesForm
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
            headerLabel = new Label();
            leagueGroupBox = new GroupBox();
            seasonNameComboBox = new ComboBox();
            seasonLabel = new Label();
            leagNameTextBox = new TextBox();
            leagueNameLabel = new Label();
            teamSettingsGroupBox = new GroupBox();
            numberTeamComboBox = new ComboBox();
            playerComboBox = new ComboBox();
            teamPlayerLabel = new Label();
            teamNumberLabel = new Label();
            matchRulesGroupBox = new GroupBox();
            matchDurationComboBox = new ComboBox();
            substitutionsComboBox = new ComboBox();
            substitutionLabel = new Label();
            matchDurationLabel = new Label();
            pointsRulesGroupBox = new GroupBox();
            losePointsComboBox = new ComboBox();
            losePointsLabel = new Label();
            pointsWinComboBox = new ComboBox();
            drawPoints = new ComboBox();
            pointsDrawLabel = new Label();
            pointsWinLabel = new Label();
            settingsLeagueBtn = new Button();
            headerPanel.SuspendLayout();
            leagueGroupBox.SuspendLayout();
            teamSettingsGroupBox.SuspendLayout();
            matchRulesGroupBox.SuspendLayout();
            pointsRulesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 2, 3, 2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1199, 52);
            headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(25, 14);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(220, 26);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Sport League SetUp";
            // 
            // leagueGroupBox
            // 
            leagueGroupBox.Controls.Add(seasonNameComboBox);
            leagueGroupBox.Controls.Add(seasonLabel);
            leagueGroupBox.Controls.Add(leagNameTextBox);
            leagueGroupBox.Controls.Add(leagueNameLabel);
            leagueGroupBox.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);

            leagueGroupBox.Location = new Point(65, 75);

            leagueGroupBox.Name = "leagueGroupBox";
            leagueGroupBox.Padding = new Padding(3, 2, 3, 2);
            leagueGroupBox.Size = new Size(393, 156);
            leagueGroupBox.TabIndex = 1;
            leagueGroupBox.TabStop = false;
            leagueGroupBox.Text = "League Information";
            // 
            // seasonNameComboBox
            // 
            seasonNameComboBox.FormattingEnabled = true;
            seasonNameComboBox.Location = new Point(175, 101);
            seasonNameComboBox.Margin = new Padding(3, 2, 3, 2);
            seasonNameComboBox.Name = "seasonNameComboBox";
            seasonNameComboBox.Size = new Size(155, 27);
            seasonNameComboBox.TabIndex = 3;
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            seasonLabel.Location = new Point(16, 100);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(60, 17);
            seasonLabel.TabIndex = 2;
            seasonLabel.Text = "Season:";
            // 
            // leagNameTextBox
            // 
            leagNameTextBox.Location = new Point(175, 34);
            leagNameTextBox.Margin = new Padding(3, 2, 3, 2);
            leagNameTextBox.Name = "leagNameTextBox";
            leagNameTextBox.Size = new Size(155, 27);
            leagNameTextBox.TabIndex = 1;
            // 
            // leagueNameLabel
            // 
            leagueNameLabel.AutoSize = true;
            leagueNameLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            leagueNameLabel.Location = new Point(16, 39);
            leagueNameLabel.Name = "leagueNameLabel";
            leagueNameLabel.Size = new Size(108, 17);
            leagueNameLabel.TabIndex = 0;
            leagueNameLabel.Text = "League Name:";
            // 
            // teamSettingsGroupBox
            // 
            teamSettingsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            teamSettingsGroupBox.Controls.Add(numberTeamComboBox);
            teamSettingsGroupBox.Controls.Add(playerComboBox);
            teamSettingsGroupBox.Controls.Add(teamPlayerLabel);
            teamSettingsGroupBox.Controls.Add(teamNumberLabel);
            teamSettingsGroupBox.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);

            teamSettingsGroupBox.Location = new Point(879, 75);

            teamSettingsGroupBox.Name = "teamSettingsGroupBox";
            teamSettingsGroupBox.Padding = new Padding(3, 2, 3, 2);
            teamSettingsGroupBox.Size = new Size(393, 156);
            teamSettingsGroupBox.TabIndex = 4;
            teamSettingsGroupBox.TabStop = false;
            teamSettingsGroupBox.Text = "Team Settings";
            // 
            // numberTeamComboBox
            // 
            numberTeamComboBox.FormattingEnabled = true;
            numberTeamComboBox.Location = new Point(175, 39);
            numberTeamComboBox.Margin = new Padding(3, 2, 3, 2);
            numberTeamComboBox.Name = "numberTeamComboBox";
            numberTeamComboBox.Size = new Size(155, 27);
            numberTeamComboBox.TabIndex = 5;
            // 
            // playerComboBox
            // 
            playerComboBox.FormattingEnabled = true;
            playerComboBox.Location = new Point(175, 101);
            playerComboBox.Margin = new Padding(3, 2, 3, 2);
            playerComboBox.Name = "playerComboBox";
            playerComboBox.Size = new Size(155, 27);
            playerComboBox.TabIndex = 3;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            teamPlayerLabel.Location = new Point(16, 100);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(127, 17);
            teamPlayerLabel.TabIndex = 2;
            teamPlayerLabel.Text = "Players per Team:";
            // 
            // teamNumberLabel
            // 
            teamNumberLabel.AutoSize = true;
            teamNumberLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            teamNumberLabel.Location = new Point(16, 39);
            teamNumberLabel.Name = "teamNumberLabel";
            teamNumberLabel.Size = new Size(131, 17);
            teamNumberLabel.TabIndex = 0;
            teamNumberLabel.Text = "Number of Teams:";
            // 
            // matchRulesGroupBox
            // 
            matchRulesGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            matchRulesGroupBox.Controls.Add(matchDurationComboBox);
            matchRulesGroupBox.Controls.Add(substitutionsComboBox);
            matchRulesGroupBox.Controls.Add(substitutionLabel);
            matchRulesGroupBox.Controls.Add(matchDurationLabel);
            matchRulesGroupBox.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);

            matchRulesGroupBox.Location = new Point(65, 338);

            matchRulesGroupBox.Name = "matchRulesGroupBox";
            matchRulesGroupBox.Padding = new Padding(3, 2, 3, 2);
            matchRulesGroupBox.Size = new Size(393, 156);
            matchRulesGroupBox.TabIndex = 4;
            matchRulesGroupBox.TabStop = false;
            matchRulesGroupBox.Text = "Match Rules ";
            // 
            // matchDurationComboBox
            // 
            matchDurationComboBox.FormattingEnabled = true;
            matchDurationComboBox.Location = new Point(175, 39);
            matchDurationComboBox.Margin = new Padding(3, 2, 3, 2);
            matchDurationComboBox.Name = "matchDurationComboBox";
            matchDurationComboBox.Size = new Size(155, 27);
            matchDurationComboBox.TabIndex = 4;
            // 
            // substitutionsComboBox
            // 
            substitutionsComboBox.FormattingEnabled = true;
            substitutionsComboBox.Location = new Point(175, 101);
            substitutionsComboBox.Margin = new Padding(3, 2, 3, 2);
            substitutionsComboBox.Name = "substitutionsComboBox";
            substitutionsComboBox.Size = new Size(155, 27);
            substitutionsComboBox.TabIndex = 3;
            // 
            // substitutionLabel
            // 
            substitutionLabel.AutoSize = true;
            substitutionLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            substitutionLabel.Location = new Point(16, 100);
            substitutionLabel.Name = "substitutionLabel";
            substitutionLabel.Size = new Size(89, 17);
            substitutionLabel.TabIndex = 2;
            substitutionLabel.Text = "Substitutions";
            // 
            // matchDurationLabel
            // 
            matchDurationLabel.AutoSize = true;
            matchDurationLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            matchDurationLabel.Location = new Point(16, 39);
            matchDurationLabel.Name = "matchDurationLabel";
            matchDurationLabel.Size = new Size(115, 17);
            matchDurationLabel.TabIndex = 0;
            matchDurationLabel.Text = "Match Duration:";
            // 
            // pointsRulesGroupBox
            // 
            pointsRulesGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pointsRulesGroupBox.Controls.Add(losePointsComboBox);
            pointsRulesGroupBox.Controls.Add(losePointsLabel);
            pointsRulesGroupBox.Controls.Add(pointsWinComboBox);
            pointsRulesGroupBox.Controls.Add(drawPoints);
            pointsRulesGroupBox.Controls.Add(pointsDrawLabel);
            pointsRulesGroupBox.Controls.Add(pointsWinLabel);
            pointsRulesGroupBox.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);

            pointsRulesGroupBox.Location = new Point(879, 338);

            pointsRulesGroupBox.Name = "pointsRulesGroupBox";
            pointsRulesGroupBox.Padding = new Padding(3, 2, 3, 2);
            pointsRulesGroupBox.Size = new Size(393, 156);
            pointsRulesGroupBox.TabIndex = 5;
            pointsRulesGroupBox.TabStop = false;
            pointsRulesGroupBox.Text = "Points Systems";
            // 
            // losePointsComboBox
            // 
            losePointsComboBox.FormattingEnabled = true;
            losePointsComboBox.Location = new Point(175, 109);
            losePointsComboBox.Margin = new Padding(3, 2, 3, 2);
            losePointsComboBox.Name = "losePointsComboBox";
            losePointsComboBox.Size = new Size(155, 27);
            losePointsComboBox.TabIndex = 6;
            // 
            // losePointsLabel
            // 
            losePointsLabel.AutoSize = true;
            losePointsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            losePointsLabel.Location = new Point(16, 118);
            losePointsLabel.Name = "losePointsLabel";
            losePointsLabel.Size = new Size(85, 17);
            losePointsLabel.TabIndex = 5;
            losePointsLabel.Text = "Lose Points:";
            // 
            // pointsWinComboBox
            // 
            pointsWinComboBox.FormattingEnabled = true;
            pointsWinComboBox.Location = new Point(175, 30);
            pointsWinComboBox.Margin = new Padding(3, 2, 3, 2);
            pointsWinComboBox.Name = "pointsWinComboBox";
            pointsWinComboBox.Size = new Size(155, 27);
            pointsWinComboBox.TabIndex = 4;
            // 
            // drawPoints
            // 
            drawPoints.FormattingEnabled = true;
            drawPoints.Location = new Point(175, 70);
            drawPoints.Margin = new Padding(3, 2, 3, 2);
            drawPoints.Name = "drawPoints";
            drawPoints.Size = new Size(155, 27);
            drawPoints.TabIndex = 3;
            // 
            // pointsDrawLabel
            // 
            pointsDrawLabel.AutoSize = true;
            pointsDrawLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            pointsDrawLabel.Location = new Point(16, 80);
            pointsDrawLabel.Name = "pointsDrawLabel";
            pointsDrawLabel.Size = new Size(89, 17);
            pointsDrawLabel.TabIndex = 2;
            pointsDrawLabel.Text = "Draw Points:";
            // 
            // pointsWinLabel
            // 
            pointsWinLabel.AutoSize = true;
            pointsWinLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            pointsWinLabel.Location = new Point(16, 39);
            pointsWinLabel.Name = "pointsWinLabel";
            pointsWinLabel.Size = new Size(80, 17);
            pointsWinLabel.TabIndex = 0;
            pointsWinLabel.Text = "Win Points:";
            // 
            // settingsLeagueBtn
            // 
            settingsLeagueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsLeagueBtn.BackColor = Color.LawnGreen;
            settingsLeagueBtn.FlatStyle = FlatStyle.Popup;
            settingsLeagueBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsLeagueBtn.ForeColor = Color.Transparent;

            settingsLeagueBtn.Location = new Point(440, 596);
            settingsLeagueBtn.Name = "settingsLeagueBtn";
            settingsLeagueBtn.Size = new Size(509, 55);

            settingsLeagueBtn.TabIndex = 6;
            settingsLeagueBtn.Text = "Save League Settings";
            settingsLeagueBtn.UseVisualStyleBackColor = false;
            settingsLeagueBtn.Click += settingsLeagueBtn_Click;
            // 
            // FeaturesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 520);
            Controls.Add(settingsLeagueBtn);
            Controls.Add(pointsRulesGroupBox);
            Controls.Add(matchRulesGroupBox);
            Controls.Add(teamSettingsGroupBox);
            Controls.Add(leagueGroupBox);
            Controls.Add(headerPanel);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FeaturesForm";
            Text = "FeaturesForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            leagueGroupBox.ResumeLayout(false);
            leagueGroupBox.PerformLayout();
            teamSettingsGroupBox.ResumeLayout(false);
            teamSettingsGroupBox.PerformLayout();
            matchRulesGroupBox.ResumeLayout(false);
            matchRulesGroupBox.PerformLayout();
            pointsRulesGroupBox.ResumeLayout(false);
            pointsRulesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private GroupBox leagueGroupBox;
        private Label leagueNameLabel;
        private Label seasonLabel;
        private TextBox leagNameTextBox;
        private ComboBox seasonNameComboBox;
        private GroupBox teamSettingsGroupBox;
        private ComboBox playerComboBox;
        private Label teamPlayerLabel;
        private Label teamNumberLabel;
        private ComboBox numberTeamComboBox;
        private GroupBox matchRulesGroupBox;
        private ComboBox substitutionsComboBox;
        private Label substitutionLabel;
        private Label matchDurationLabel;
        private ComboBox matchDurationComboBox;
        private GroupBox pointsRulesGroupBox;
        private ComboBox pointsWinComboBox;
        private ComboBox drawPoints;
        private Label pointsDrawLabel;
        private Label pointsWinLabel;
        private Label losePointsLabel;
        private ComboBox losePointsComboBox;
        private Button settingsLeagueBtn;
    }
}