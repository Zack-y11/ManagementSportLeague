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
            calendarBtn = new FontAwesome.Sharp.IconButton();
            settingsPlayerBtn = new FontAwesome.Sharp.IconButton();
            positionTableBtn = new FontAwesome.Sharp.IconButton();
            playerTeamBtn = new FontAwesome.Sharp.IconButton();
            soccerIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            dashboardPlayerLabel = new Label();
            contentPanel = new Panel();
            statsIcon = new FontAwesome.Sharp.IconPictureBox();
            headerLabel = new Label();
            playerDataGrip = new DataGridView();
            playerSportInformation = new DataGridView();
            playerInformationLabel = new Label();
            titlePlayerLabel = new Label();
            buttonsPanel = new Panel();
            IconsPanel = new Panel();
            resetBtn = new FontAwesome.Sharp.IconButton();
            maximizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            dashboardPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            buttonsPanel.SuspendLayout();
            IconsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardPlayerPanel
            // 
            dashboardPlayerPanel.BackColor = Color.WhiteSmoke;
            dashboardPlayerPanel.Controls.Add(dashboardBtn);
            dashboardPlayerPanel.Controls.Add(calendarBtn);
            dashboardPlayerPanel.Controls.Add(settingsPlayerBtn);
            dashboardPlayerPanel.Controls.Add(positionTableBtn);
            dashboardPlayerPanel.Controls.Add(playerTeamBtn);
            dashboardPlayerPanel.Controls.Add(soccerIconPictureBox);
            dashboardPlayerPanel.Controls.Add(dashboardPlayerLabel);
            dashboardPlayerPanel.Dock = DockStyle.Left;
            dashboardPlayerPanel.Location = new Point(0, 0);
            dashboardPlayerPanel.Name = "dashboardPlayerPanel";
            dashboardPlayerPanel.Size = new Size(263, 682);
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
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.ControlLightLight;
            contentPanel.Controls.Add(statsIcon);
            contentPanel.Controls.Add(headerLabel);
            contentPanel.Controls.Add(playerDataGrip);
            contentPanel.Controls.Add(playerSportInformation);
            contentPanel.Controls.Add(playerInformationLabel);
            contentPanel.Controls.Add(titlePlayerLabel);
            contentPanel.Location = new Point(263, 99);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1118, 583);
            contentPanel.TabIndex = 3;
            // 
            // statsIcon
            // 
            statsIcon.BackColor = Color.FromArgb(0, 123, 252);
            statsIcon.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            statsIcon.IconColor = Color.White;
            statsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            statsIcon.IconSize = 40;
            statsIcon.Location = new Point(55, 21);
            statsIcon.Name = "statsIcon";
            statsIcon.Size = new Size(42, 40);
            statsIcon.TabIndex = 21;
            statsIcon.TabStop = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(0, 123, 252);
            headerLabel.Location = new Point(103, 27);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(168, 34);
            headerLabel.TabIndex = 20;
            headerLabel.Text = "Player Stats";
            // 
            // playerDataGrip
            // 
            playerDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerDataGrip.Location = new Point(81, 157);
            playerDataGrip.Name = "playerDataGrip";
            playerDataGrip.RowHeadersWidth = 51;
            playerDataGrip.Size = new Size(907, 351);
            playerDataGrip.TabIndex = 19;
            // 
            // playerSportInformation
            // 
            playerSportInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerSportInformation.BackgroundColor = Color.White;
            playerSportInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerSportInformation.GridColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.Location = new Point(55, 125);
            playerSportInformation.Name = "playerSportInformation";
            playerSportInformation.RowHeadersWidth = 51;
            playerSportInformation.Size = new Size(956, 414);
            playerSportInformation.TabIndex = 18;
            // 
            // playerInformationLabel
            // 
            playerInformationLabel.AutoSize = true;
            playerInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerInformationLabel.Location = new Point(55, 81);
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
            titlePlayerLabel.Location = new Point(489, 34);
            titlePlayerLabel.Name = "titlePlayerLabel";
            titlePlayerLabel.Size = new Size(499, 23);
            titlePlayerLabel.TabIndex = 11;
            titlePlayerLabel.Text = "\"Player Stats: Rankings, Wins, Upcoming Matches \"";
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.FromArgb(0, 123, 253);
            buttonsPanel.Controls.Add(IconsPanel);
            buttonsPanel.Dock = DockStyle.Top;
            buttonsPanel.Location = new Point(263, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(1120, 100);
            buttonsPanel.TabIndex = 20;
            // 
            // IconsPanel
            // 
            IconsPanel.Controls.Add(resetBtn);
            IconsPanel.Controls.Add(maximizeBtn);
            IconsPanel.Controls.Add(closeBtn);
            IconsPanel.Dock = DockStyle.Right;
            IconsPanel.Location = new Point(949, 0);
            IconsPanel.Name = "IconsPanel";
            IconsPanel.Size = new Size(171, 100);
            IconsPanel.TabIndex = 8;
            // 
            // resetBtn
            // 
            resetBtn.Dock = DockStyle.Right;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
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
            maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Clone;
            maximizeBtn.IconColor = Color.White;
            maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizeBtn.Location = new Point(62, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(58, 100);
            maximizeBtn.TabIndex = 3;
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click_1;
            // 
            // closeBtn
            // 
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatStyle = FlatStyle.Popup;
            closeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.IconChar = FontAwesome.Sharp.IconChar.Close;
            closeBtn.IconColor = Color.White;
            closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeBtn.Location = new Point(120, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(51, 100);
            closeBtn.TabIndex = 5;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click_1;
            // 
            // PlayerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1383, 682);
            ControlBox = false;
            Controls.Add(buttonsPanel);
            Controls.Add(contentPanel);
            Controls.Add(dashboardPlayerPanel);
            Name = "PlayerDashboardForm";
            Text = "playerSportForm";
            dashboardPlayerPanel.ResumeLayout(false);
            dashboardPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soccerIconPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            buttonsPanel.ResumeLayout(false);
            IconsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPlayerPanel;
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
        private Panel buttonsPanel;
        private Panel IconsPanel;
        private FontAwesome.Sharp.IconButton resetBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
        private Label headerLabel;
        private FontAwesome.Sharp.IconPictureBox statsIcon;
    }
}