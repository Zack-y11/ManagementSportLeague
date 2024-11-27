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
            playerDataGrip = new DataGridView();
            playerSportInformation = new DataGridView();
            playerInformationLabel = new Label();
            titlePlayerLabel = new Label();
            panel1 = new Panel();
            statsIcon = new FontAwesome.Sharp.IconPictureBox();
            headerLabel = new Label();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(playerDataGrip);
            contentPanel.Controls.Add(playerSportInformation);
            contentPanel.Controls.Add(playerInformationLabel);
            contentPanel.Controls.Add(titlePlayerLabel);
            contentPanel.Location = new Point(12, 125);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1000, 539);
            contentPanel.TabIndex = 4;
            
            // 
            // playerDataGrip
            // 
            playerDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerDataGrip.Location = new Point(49, 144);
            playerDataGrip.Name = "playerDataGrip";
            playerDataGrip.RowHeadersWidth = 51;
            playerDataGrip.Size = new Size(893, 347);
            playerDataGrip.TabIndex = 20;
            // 
            // playerSportInformation
            // 
            playerSportInformation.BackgroundColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerSportInformation.GridColor = SystemColors.GradientInactiveCaption;
            playerSportInformation.Location = new Point(25, 115);
            playerSportInformation.Name = "playerSportInformation";
            playerSportInformation.RowHeadersWidth = 51;
            playerSportInformation.Size = new Size(946, 399);
            playerSportInformation.TabIndex = 18;
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
            titlePlayerLabel.Location = new Point(25, 21);
            titlePlayerLabel.Name = "titlePlayerLabel";
            titlePlayerLabel.Size = new Size(499, 23);
            titlePlayerLabel.TabIndex = 11;
            titlePlayerLabel.Text = "\"Player Stats: Rankings, Wins, Upcoming Matches \"";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(statsIcon);
            panel1.Controls.Add(headerLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 100);
            panel1.TabIndex = 5;
            // 
            // statsIcon
            // 
            statsIcon.BackColor = Color.Transparent;
            statsIcon.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            statsIcon.IconColor = Color.White;
            statsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            statsIcon.IconSize = 40;
            statsIcon.Location = new Point(46, 33);
            statsIcon.Name = "statsIcon";
            statsIcon.Size = new Size(40, 40);
            statsIcon.TabIndex = 1;
            statsIcon.TabStop = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(135, 39);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(168, 34);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Player Stats";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 691);
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Name = "PlayerInfoForm";
            Text = "PlayerInfo";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSportInformation).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)statsIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private DataGridView playerSportInformation;
        private Label playerInformationLabel;
        private Label titlePlayerLabel;
        private Panel panel1;
        private Label headerLabel;
        private FontAwesome.Sharp.IconPictureBox statsIcon;
        private DataGridView playerDataGrip;
    }
}