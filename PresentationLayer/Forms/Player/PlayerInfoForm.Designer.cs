namespace PresentationLayer.Forms.Player
{
    partial class PlayerInfoForm
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
            contentPanel = new Panel();
            statsIcon = new FontAwesome.Sharp.IconPictureBox();
            playerDataGrip = new DataGridView();
            playerSportInformation = new DataGridView();
            headerLabel = new Label();
            playerInformationLabel = new Label();
            titlePlayerLabel = new Label();
            contentPlayerPanel = new Panel();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            contentPlayerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.ControlLightLight;
            contentPanel.Controls.Add(statsIcon);
            contentPanel.Controls.Add(playerDataGrip);
            contentPanel.Controls.Add(playerSportInformation);
            contentPanel.Controls.Add(headerLabel);
            contentPanel.Controls.Add(playerInformationLabel);
            contentPanel.Controls.Add(titlePlayerLabel);
            contentPanel.Location = new Point(3, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1339, 693);
            contentPanel.TabIndex = 4;
            // 
            // statsIcon
            // 
            statsIcon.BackColor = Color.FromArgb(0, 123, 252);
            statsIcon.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            statsIcon.IconColor = Color.White;
            statsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            statsIcon.IconSize = 40;
            statsIcon.Location = new Point(25, 19);
            statsIcon.Name = "statsIcon";
            statsIcon.Size = new Size(40, 40);
            statsIcon.TabIndex = 1;
            statsIcon.TabStop = false;
            // 
            // playerDataGrip
            // 
            playerDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerDataGrip.Location = new Point(209, 193);
            playerDataGrip.Name = "playerDataGrip";
            playerDataGrip.RowHeadersWidth = 51;
            playerDataGrip.Size = new Size(917, 376);
            playerDataGrip.TabIndex = 20;
            // 
            // playerSportInformation
            // 
            playerSportInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playerSportInformation.BackgroundColor = Color.White;
            playerSportInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerSportInformation.GridColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.Location = new Point(145, 148);
            playerSportInformation.Name = "playerSportInformation";
            playerSportInformation.RowHeadersWidth = 51;
            playerSportInformation.Size = new Size(1028, 467);
            playerSportInformation.TabIndex = 18;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(0, 123, 252);
            headerLabel.Location = new Point(112, 25);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(168, 34);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Player Stats";
            // 
            // playerInformationLabel
            // 
            playerInformationLabel.AutoSize = true;
            playerInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerInformationLabel.Location = new Point(25, 75);
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
            titlePlayerLabel.Location = new Point(394, 36);
            titlePlayerLabel.Name = "titlePlayerLabel";
            titlePlayerLabel.Size = new Size(499, 23);
            titlePlayerLabel.TabIndex = 11;
            titlePlayerLabel.Text = "\"Player Stats: Rankings, Wins, Upcoming Matches \"";
            // 
            // contentPlayerPanel
            // 
            contentPlayerPanel.Controls.Add(contentPanel);
            contentPlayerPanel.Dock = DockStyle.Fill;
            contentPlayerPanel.Location = new Point(0, 0);
            contentPlayerPanel.Name = "contentPlayerPanel";
            contentPlayerPanel.Size = new Size(1340, 696);
            contentPlayerPanel.TabIndex = 6;
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 696);
            Controls.Add(contentPlayerPanel);
            Name = "PlayerInfoForm";
            Text = "PlayerInfo";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            contentPlayerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private DataGridView playerSportInformation;
        private Label playerInformationLabel;
        private Label titlePlayerLabel;
        private Label headerLabel;
        private FontAwesome.Sharp.IconPictureBox statsIcon;
        private DataGridView playerDataGrip;
        private Panel contentPlayerPanel;
    }
}