namespace PresentationLayer.Forms.Player
{
    partial class playerSportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerSportForm));
            dashboardPlayerPanel = new Panel();
            nuceringButtom = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            CalendarButtom = new FontAwesome.Sharp.IconButton();
            settingsPlayerButtom = new FontAwesome.Sharp.IconButton();
            logOutButtom = new FontAwesome.Sharp.IconButton();
            positionTablePlayerButtom = new FontAwesome.Sharp.IconButton();
            playerSportTeamButtom = new FontAwesome.Sharp.IconButton();
            soccerIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            dashboardPlayerLabel = new Label();
            playerSearchStatsPanel = new Panel();
            playerSportInformation = new DataGridView();
            playerInformationLabel = new Label();
            searchIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            searchPlayerLabel = new Label();
            searchPlayerComboBox = new ComboBox();
            titlePlayerLabel = new Label();
            BannerPictureBox = new PictureBox();
            dashboardPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).BeginInit();
            playerSearchStatsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dashboardPlayerPanel
            // 
            dashboardPlayerPanel.BackColor = Color.White;
            dashboardPlayerPanel.Controls.Add(nuceringButtom);
            dashboardPlayerPanel.Controls.Add(panel2);
            dashboardPlayerPanel.Controls.Add(CalendarButtom);
            dashboardPlayerPanel.Controls.Add(settingsPlayerButtom);
            dashboardPlayerPanel.Controls.Add(logOutButtom);
            dashboardPlayerPanel.Controls.Add(positionTablePlayerButtom);
            dashboardPlayerPanel.Controls.Add(playerSportTeamButtom);
            dashboardPlayerPanel.Controls.Add(soccerIconPictureBox);
            dashboardPlayerPanel.Controls.Add(dashboardPlayerLabel);
            dashboardPlayerPanel.Dock = DockStyle.Left;
            dashboardPlayerPanel.Location = new Point(0, 0);
            dashboardPlayerPanel.Name = "dashboardPlayerPanel";
            dashboardPlayerPanel.Size = new Size(263, 584);
            dashboardPlayerPanel.TabIndex = 2;
            // 
            // nuceringButtom
            // 
            nuceringButtom.FlatStyle = FlatStyle.Flat;
            nuceringButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            nuceringButtom.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            nuceringButtom.IconColor = Color.Black;
            nuceringButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nuceringButtom.ImageAlign = ContentAlignment.MiddleLeft;
            nuceringButtom.Location = new Point(0, 160);
            nuceringButtom.Name = "nuceringButtom";
            nuceringButtom.Size = new Size(263, 59);
            nuceringButtom.TabIndex = 8;
            nuceringButtom.Text = "Nucering";
            nuceringButtom.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 139);
            panel2.TabIndex = 0;
            // 
            // CalendarButtom
            // 
            CalendarButtom.FlatStyle = FlatStyle.Flat;
            CalendarButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            CalendarButtom.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            CalendarButtom.IconColor = Color.Black;
            CalendarButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CalendarButtom.ImageAlign = ContentAlignment.MiddleLeft;
            CalendarButtom.Location = new Point(0, 106);
            CalendarButtom.Name = "CalendarButtom";
            CalendarButtom.Size = new Size(263, 59);
            CalendarButtom.TabIndex = 7;
            CalendarButtom.Text = "Calendar";
            CalendarButtom.UseVisualStyleBackColor = true;
            // 
            // settingsPlayerButtom
            // 
            settingsPlayerButtom.FlatStyle = FlatStyle.Flat;
            settingsPlayerButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            settingsPlayerButtom.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            settingsPlayerButtom.IconColor = Color.Black;
            settingsPlayerButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsPlayerButtom.ImageAlign = ContentAlignment.MiddleLeft;
            settingsPlayerButtom.Location = new Point(0, 325);
            settingsPlayerButtom.Name = "settingsPlayerButtom";
            settingsPlayerButtom.Size = new Size(263, 59);
            settingsPlayerButtom.TabIndex = 6;
            settingsPlayerButtom.Text = "Settings";
            settingsPlayerButtom.UseVisualStyleBackColor = true;
            // 
            // logOutButtom
            // 
            logOutButtom.FlatStyle = FlatStyle.Flat;
            logOutButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            logOutButtom.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logOutButtom.IconColor = Color.Black;
            logOutButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutButtom.ImageAlign = ContentAlignment.MiddleLeft;
            logOutButtom.Location = new Point(0, 381);
            logOutButtom.Name = "logOutButtom";
            logOutButtom.Size = new Size(263, 59);
            logOutButtom.TabIndex = 5;
            logOutButtom.Text = "Log Out";
            logOutButtom.UseVisualStyleBackColor = true;
            // 
            // positionTablePlayerButtom
            // 
            positionTablePlayerButtom.FlatStyle = FlatStyle.Flat;
            positionTablePlayerButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            positionTablePlayerButtom.IconChar = FontAwesome.Sharp.IconChar.Star;
            positionTablePlayerButtom.IconColor = Color.Gold;
            positionTablePlayerButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            positionTablePlayerButtom.ImageAlign = ContentAlignment.MiddleLeft;
            positionTablePlayerButtom.Location = new Point(0, 269);
            positionTablePlayerButtom.Name = "positionTablePlayerButtom";
            positionTablePlayerButtom.Size = new Size(263, 59);
            positionTablePlayerButtom.TabIndex = 4;
            positionTablePlayerButtom.Text = "Position Table";
            positionTablePlayerButtom.UseVisualStyleBackColor = true;
            // 
            // playerSportTeamButtom
            // 
            playerSportTeamButtom.FlatStyle = FlatStyle.Flat;
            playerSportTeamButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            playerSportTeamButtom.IconChar = FontAwesome.Sharp.IconChar.Users;
            playerSportTeamButtom.IconColor = Color.Black;
            playerSportTeamButtom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playerSportTeamButtom.ImageAlign = ContentAlignment.MiddleLeft;
            playerSportTeamButtom.Location = new Point(0, 213);
            playerSportTeamButtom.Name = "playerSportTeamButtom";
            playerSportTeamButtom.Size = new Size(263, 59);
            playerSportTeamButtom.TabIndex = 3;
            playerSportTeamButtom.Text = "Player's Team";
            playerSportTeamButtom.UseVisualStyleBackColor = true;
            // 
            // soccerIconPictureBox
            // 
            soccerIconPictureBox.BackColor = Color.White;
            soccerIconPictureBox.ForeColor = SystemColors.HotTrack;
            soccerIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            soccerIconPictureBox.IconColor = SystemColors.HotTrack;
            soccerIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            soccerIconPictureBox.IconSize = 40;
            soccerIconPictureBox.Location = new Point(28, 30);
            soccerIconPictureBox.Name = "soccerIconPictureBox";
            soccerIconPictureBox.Size = new Size(40, 40);
            soccerIconPictureBox.TabIndex = 2;
            soccerIconPictureBox.TabStop = false;
            // 
            // dashboardPlayerLabel
            // 
            dashboardPlayerLabel.AutoSize = true;
            dashboardPlayerLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            dashboardPlayerLabel.Location = new Point(74, 21);
            dashboardPlayerLabel.Name = "dashboardPlayerLabel";
            dashboardPlayerLabel.Size = new Size(159, 64);
            dashboardPlayerLabel.TabIndex = 2;
            dashboardPlayerLabel.Text = "Dashboard\r\nPlayer";
            // 
            // playerSearchStatsPanel
            // 
            playerSearchStatsPanel.Controls.Add(playerSportInformation);
            playerSearchStatsPanel.Controls.Add(playerInformationLabel);
            playerSearchStatsPanel.Controls.Add(searchIconPictureBox);
            playerSearchStatsPanel.Controls.Add(searchPlayerLabel);
            playerSearchStatsPanel.Controls.Add(searchPlayerComboBox);
            playerSearchStatsPanel.Controls.Add(titlePlayerLabel);
            playerSearchStatsPanel.Location = new Point(263, 81);
            playerSearchStatsPanel.Name = "playerSearchStatsPanel";
            playerSearchStatsPanel.Size = new Size(1006, 507);
            playerSearchStatsPanel.TabIndex = 3;
            // 
            // playerSportInformation
            // 
            playerSportInformation.BackgroundColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerSportInformation.GridColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.Location = new Point(55, 199);
            playerSportInformation.Name = "playerSportInformation";
            playerSportInformation.RowHeadersWidth = 51;
            playerSportInformation.Size = new Size(736, 259);
            playerSportInformation.TabIndex = 18;
            // 
            // playerInformationLabel
            // 
            playerInformationLabel.AutoSize = true;
            playerInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerInformationLabel.Location = new Point(55, 168);
            playerInformationLabel.Name = "playerInformationLabel";
            playerInformationLabel.Size = new Size(193, 23);
            playerInformationLabel.TabIndex = 17;
            playerInformationLabel.Text = "Player Information:";
            // 
            // searchIconPictureBox
            // 
            searchIconPictureBox.BackColor = Color.Transparent;
            searchIconPictureBox.ForeColor = SystemColors.HotTrack;
            searchIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIconPictureBox.IconColor = SystemColors.HotTrack;
            searchIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIconPictureBox.IconSize = 28;
            searchIconPictureBox.Location = new Point(55, 110);
            searchIconPictureBox.Name = "searchIconPictureBox";
            searchIconPictureBox.Size = new Size(32, 28);
            searchIconPictureBox.TabIndex = 9;
            searchIconPictureBox.TabStop = false;
            // 
            // searchPlayerLabel
            // 
            searchPlayerLabel.AutoSize = true;
            searchPlayerLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            searchPlayerLabel.Location = new Point(55, 79);
            searchPlayerLabel.Name = "searchPlayerLabel";
            searchPlayerLabel.Size = new Size(135, 19);
            searchPlayerLabel.TabIndex = 16;
            searchPlayerLabel.Text = "Search Players:";
            // 
            // searchPlayerComboBox
            // 
            searchPlayerComboBox.FormattingEnabled = true;
            searchPlayerComboBox.Location = new Point(93, 110);
            searchPlayerComboBox.Name = "searchPlayerComboBox";
            searchPlayerComboBox.Size = new Size(253, 28);
            searchPlayerComboBox.TabIndex = 15;
            // 
            // titlePlayerLabel
            // 
            titlePlayerLabel.AutoSize = true;
            titlePlayerLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlePlayerLabel.ForeColor = SystemColors.HotTrack;
            titlePlayerLabel.Location = new Point(55, 34);
            titlePlayerLabel.Name = "titlePlayerLabel";
            titlePlayerLabel.Size = new Size(499, 23);
            titlePlayerLabel.TabIndex = 11;
            titlePlayerLabel.Text = "\"Player Stats: Rankings, Wins, Upcoming Matches \"";
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.BackgroundImage = (Image)resources.GetObject("BannerPictureBox.BackgroundImage");
            BannerPictureBox.Location = new Point(264, 1);
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.Size = new Size(1005, 84);
            BannerPictureBox.TabIndex = 4;
            BannerPictureBox.TabStop = false;
            // 
            // playerSportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 584);
            Controls.Add(BannerPictureBox);
            Controls.Add(playerSearchStatsPanel);
            Controls.Add(dashboardPlayerPanel);
            Name = "playerSportForm";
            Text = "playerSportForm";
            dashboardPlayerPanel.ResumeLayout(false);
            dashboardPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).EndInit();
            playerSearchStatsPanel.ResumeLayout(false);
            playerSearchStatsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPlayerPanel;
        private FontAwesome.Sharp.IconButton nuceringButtom;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton CalendarButtom;
        private FontAwesome.Sharp.IconButton settingsPlayerButtom;
        private FontAwesome.Sharp.IconButton logOutButtom;
        private FontAwesome.Sharp.IconButton positionTablePlayerButtom;
        private FontAwesome.Sharp.IconButton playerSportTeamButtom;
        private FontAwesome.Sharp.IconPictureBox soccerIconPictureBox;
        private Label dashboardPlayerLabel;
        private Panel playerSearchStatsPanel;
        private PictureBox BannerPictureBox;
        private Label titlePlayerLabel;
        private ComboBox searchPlayerComboBox;
        private FontAwesome.Sharp.IconPictureBox searchIconPictureBox;
        private Label searchPlayerLabel;
        private DataGridView playerSportInformation;
        private Label playerInformationLabel;
    }
}