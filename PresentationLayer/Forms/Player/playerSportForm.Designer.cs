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
            nuceringBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            CalendarBtn = new FontAwesome.Sharp.IconButton();
            settingsPlayerBtn = new FontAwesome.Sharp.IconButton();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            positionTablePlayerBtn = new FontAwesome.Sharp.IconButton();
            playerSportTeamBtn = new FontAwesome.Sharp.IconButton();
            soccerIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            dashboardPlayerLabel = new Label();
            panel1 = new Panel();
            BannerPictureBox = new PictureBox();
            titlePlayerLabel = new Label();
            searchPlayerComboBox = new ComboBox();
            searchPlayerLabel = new Label();
            searchIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            playerSportInformation = new DataGridView();
            playerInformationLabel = new Label();
            dashboardPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            SuspendLayout();
            // 
            // dashboardPlayerPanel
            // 
            dashboardPlayerPanel.BackColor = Color.White;
            dashboardPlayerPanel.Controls.Add(nuceringBtn);
            dashboardPlayerPanel.Controls.Add(panel2);
            dashboardPlayerPanel.Controls.Add(CalendarBtn);
            dashboardPlayerPanel.Controls.Add(settingsPlayerBtn);
            dashboardPlayerPanel.Controls.Add(logOutBtn);
            dashboardPlayerPanel.Controls.Add(positionTablePlayerBtn);
            dashboardPlayerPanel.Controls.Add(playerSportTeamBtn);
            dashboardPlayerPanel.Controls.Add(soccerIconPictureBox);
            dashboardPlayerPanel.Controls.Add(dashboardPlayerLabel);
            dashboardPlayerPanel.Dock = DockStyle.Left;
            dashboardPlayerPanel.Location = new Point(0, 0);
            dashboardPlayerPanel.Name = "dashboardPlayerPanel";
            dashboardPlayerPanel.Size = new Size(263, 584);
            dashboardPlayerPanel.TabIndex = 2;
            // 
            // nuceringBtn
            // 
            nuceringBtn.FlatStyle = FlatStyle.Flat;
            nuceringBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            nuceringBtn.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            nuceringBtn.IconColor = Color.Black;
            nuceringBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nuceringBtn.ImageAlign = ContentAlignment.MiddleLeft;
            nuceringBtn.Location = new Point(0, 160);
            nuceringBtn.Name = "nuceringBtn";
            nuceringBtn.Size = new Size(263, 59);
            nuceringBtn.TabIndex = 8;
            nuceringBtn.Text = "Nucering";
            nuceringBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 139);
            panel2.TabIndex = 0;
            // 
            // CalendarBtn
            // 
            CalendarBtn.FlatStyle = FlatStyle.Flat;
            CalendarBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            CalendarBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            CalendarBtn.IconColor = Color.Black;
            CalendarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CalendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CalendarBtn.Location = new Point(0, 106);
            CalendarBtn.Name = "CalendarBtn";
            CalendarBtn.Size = new Size(263, 59);
            CalendarBtn.TabIndex = 7;
            CalendarBtn.Text = "Calendar";
            CalendarBtn.UseVisualStyleBackColor = true;
            // 
            // settingsPlayerBtn
            // 
            settingsPlayerBtn.FlatStyle = FlatStyle.Flat;
            settingsPlayerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            settingsPlayerBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            settingsPlayerBtn.IconColor = Color.Black;
            settingsPlayerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsPlayerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsPlayerBtn.Location = new Point(0, 325);
            settingsPlayerBtn.Name = "settingsPlayerBtn";
            settingsPlayerBtn.Size = new Size(263, 59);
            settingsPlayerBtn.TabIndex = 6;
            settingsPlayerBtn.Text = "Settings";
            settingsPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            logOutBtn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logOutBtn.IconColor = Color.Black;
            logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(0, 381);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(263, 59);
            logOutBtn.TabIndex = 5;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = true;
            // 
            // positionTablePlayerBtn
            // 
            positionTablePlayerBtn.FlatStyle = FlatStyle.Flat;
            positionTablePlayerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            positionTablePlayerBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            positionTablePlayerBtn.IconColor = Color.Gold;
            positionTablePlayerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            positionTablePlayerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            positionTablePlayerBtn.Location = new Point(0, 269);
            positionTablePlayerBtn.Name = "positionTablePlayerBtn";
            positionTablePlayerBtn.Size = new Size(263, 59);
            positionTablePlayerBtn.TabIndex = 4;
            positionTablePlayerBtn.Text = "Position Table";
            positionTablePlayerBtn.UseVisualStyleBackColor = true;
            // 
            // playerSportTeamBtn
            // 
            playerSportTeamBtn.FlatStyle = FlatStyle.Flat;
            playerSportTeamBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            playerSportTeamBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            playerSportTeamBtn.IconColor = Color.Black;
            playerSportTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playerSportTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            playerSportTeamBtn.Location = new Point(0, 213);
            playerSportTeamBtn.Name = "playerSportTeamBtn";
            playerSportTeamBtn.Size = new Size(263, 59);
            playerSportTeamBtn.TabIndex = 3;
            playerSportTeamBtn.Text = "Player's Team";
            playerSportTeamBtn.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Controls.Add(playerSportInformation);
            panel1.Controls.Add(playerInformationLabel);
            panel1.Controls.Add(searchIconPictureBox);
            panel1.Controls.Add(searchPlayerLabel);
            panel1.Controls.Add(searchPlayerComboBox);
            panel1.Controls.Add(titlePlayerLabel);
            panel1.Location = new Point(263, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 507);
            panel1.TabIndex = 3;
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
            // searchPlayerComboBox
            // 
            searchPlayerComboBox.FormattingEnabled = true;
            searchPlayerComboBox.Location = new Point(93, 110);
            searchPlayerComboBox.Name = "searchPlayerComboBox";
            searchPlayerComboBox.Size = new Size(253, 28);
            searchPlayerComboBox.TabIndex = 15;
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
            // playerSportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 584);
            Controls.Add(BannerPictureBox);
            Controls.Add(panel1);
            Controls.Add(dashboardPlayerPanel);
            Name = "playerSportForm";
            Text = "playerSportForm";
            dashboardPlayerPanel.ResumeLayout(false);
            dashboardPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPlayerPanel;
        private FontAwesome.Sharp.IconButton nuceringBtn;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton CalendarBtn;
        private FontAwesome.Sharp.IconButton settingsPlayerBtn;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private FontAwesome.Sharp.IconButton positionTablePlayerBtn;
        private FontAwesome.Sharp.IconButton playerSportTeamBtn;
        private FontAwesome.Sharp.IconPictureBox soccerIconPictureBox;
        private Label dashboardPlayerLabel;
        private Panel panel1;
        private PictureBox BannerPictureBox;
        private Label titlePlayerLabel;
        private ComboBox searchPlayerComboBox;
        private FontAwesome.Sharp.IconPictureBox searchIconPictureBox;
        private Label searchPlayerLabel;
        private DataGridView playerSportInformation;
        private Label playerInformationLabel;
    }
}