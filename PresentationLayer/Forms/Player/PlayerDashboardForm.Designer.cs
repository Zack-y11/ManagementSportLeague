namespace PresentationLayer.Forms.Player
{
    partial class PlayerDashboardForm
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
            dashboardPlayerPanel = new Panel();
            dashboardBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            calendarBtn = new FontAwesome.Sharp.IconButton();
            settingsPlayerBtn = new FontAwesome.Sharp.IconButton();
            positionTableBtn = new FontAwesome.Sharp.IconButton();
            playerTeamBtn = new FontAwesome.Sharp.IconButton();
            soccerIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            dashboardPlayerLabel = new Label();
            contentPanel = new Panel();
            playerDataGrip = new DataGridView();
            playerSportInformation = new DataGridView();
            playerInformationLabel = new Label();
            titlePlayerLabel = new Label();
            dashboardPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            SuspendLayout();
            // 
            // dashboardPlayerPanel
            // 
            dashboardPlayerPanel.BackColor = Color.Snow;
            dashboardPlayerPanel.Controls.Add(dashboardBtn);
            dashboardPlayerPanel.Controls.Add(panel2);
            dashboardPlayerPanel.Controls.Add(calendarBtn);
            dashboardPlayerPanel.Controls.Add(settingsPlayerBtn);
            dashboardPlayerPanel.Controls.Add(positionTableBtn);
            dashboardPlayerPanel.Controls.Add(playerTeamBtn);
            dashboardPlayerPanel.Controls.Add(soccerIconPictureBox);
            dashboardPlayerPanel.Controls.Add(dashboardPlayerLabel);
            dashboardPlayerPanel.Dock = DockStyle.Left;
            dashboardPlayerPanel.Location = new Point(0, 0);
            dashboardPlayerPanel.Name = "dashboardPlayerPanel";
            dashboardPlayerPanel.Size = new Size(263, 697);
            dashboardPlayerPanel.TabIndex = 2;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            dashboardBtn.IconColor = Color.Black;
            dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 144);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(263, 59);
            dashboardBtn.TabIndex = 8;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 139);
            panel2.TabIndex = 0;
            // 
            // calendarBtn
            // 
            calendarBtn.FlatStyle = FlatStyle.Flat;
            calendarBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            calendarBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            calendarBtn.IconColor = Color.Black;
            calendarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(0, 202);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(263, 59);
            calendarBtn.TabIndex = 7;
            calendarBtn.Text = "Calendar";
            calendarBtn.UseVisualStyleBackColor = true;
            // 
            // settingsPlayerBtn
            // 
            settingsPlayerBtn.FlatStyle = FlatStyle.Flat;
            settingsPlayerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            settingsPlayerBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            settingsPlayerBtn.IconColor = Color.Black;
            settingsPlayerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsPlayerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsPlayerBtn.Location = new Point(0, 366);
            settingsPlayerBtn.Name = "settingsPlayerBtn";
            settingsPlayerBtn.Size = new Size(263, 59);
            settingsPlayerBtn.TabIndex = 6;
            settingsPlayerBtn.Text = "Settings";
            settingsPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // positionTableBtn
            // 
            positionTableBtn.FlatStyle = FlatStyle.Flat;
            positionTableBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            positionTableBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            positionTableBtn.IconColor = Color.Gold;
            positionTableBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            positionTableBtn.ImageAlign = ContentAlignment.MiddleLeft;
            positionTableBtn.Location = new Point(0, 310);
            positionTableBtn.Name = "positionTableBtn";
            positionTableBtn.Size = new Size(263, 59);
            positionTableBtn.TabIndex = 4;
            positionTableBtn.Text = "Position Table";
            positionTableBtn.UseVisualStyleBackColor = true;
            // 
            // playerTeamBtn
            // 
            playerTeamBtn.FlatStyle = FlatStyle.Flat;
            playerTeamBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            playerTeamBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            playerTeamBtn.IconColor = Color.Black;
            playerTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playerTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            playerTeamBtn.Location = new Point(0, 256);
            playerTeamBtn.Name = "playerTeamBtn";
            playerTeamBtn.Size = new Size(263, 59);
            playerTeamBtn.TabIndex = 3;
            playerTeamBtn.Text = "Player's Team";
            playerTeamBtn.UseVisualStyleBackColor = true;
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
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.ControlLightLight;
            contentPanel.Controls.Add(playerDataGrip);
            contentPanel.Controls.Add(playerSportInformation);
            contentPanel.Controls.Add(playerInformationLabel);
            contentPanel.Controls.Add(titlePlayerLabel);
            contentPanel.Location = new Point(263, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1060, 694);
            contentPanel.TabIndex = 3;
            // 
            // playerDataGrip
            // 
            playerDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerDataGrip.Location = new Point(82, 243);
            playerDataGrip.Name = "playerDataGrip";
            playerDataGrip.RowHeadersWidth = 51;
            playerDataGrip.Size = new Size(907, 315);
            playerDataGrip.TabIndex = 19;
            // 
            // playerSportInformation
            // 
            playerSportInformation.BackgroundColor = Color.White;
            playerSportInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerSportInformation.GridColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.Location = new Point(55, 199);
            playerSportInformation.Name = "playerSportInformation";
            playerSportInformation.RowHeadersWidth = 51;
            playerSportInformation.Size = new Size(956, 395);
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
            // PlayerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 697);
            Controls.Add(contentPanel);
            Controls.Add(dashboardPlayerPanel);
            Name = "PlayerDashboardForm";
            Text = "playerSportForm";
            dashboardPlayerPanel.ResumeLayout(false);
            dashboardPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPlayerPanel;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton calendarBtn;
        private FontAwesome.Sharp.IconButton settingsPlayerBtn;
        private FontAwesome.Sharp.IconButton positionTableBtn;
        private FontAwesome.Sharp.IconButton playerTeamBtn;
        private FontAwesome.Sharp.IconPictureBox soccerIconPictureBox;
        private Label dashboardPlayerLabel;
        private Panel contentPanel;
        private Label titlePlayerLabel;
        private DataGridView playerSportInformation;
        private Label playerInformationLabel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private DataGridView playerDataGrip;
    }
}