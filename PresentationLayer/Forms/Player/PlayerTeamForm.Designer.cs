namespace PresentationLayer.Forms.Player
{
    partial class PlayerTeamForm
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
            titleIcon = new FontAwesome.Sharp.IconPictureBox();
            titleLabel = new Label();
            teamGroupBox = new GroupBox();
            teamDataGrip = new DataGridView();
            contentTeamPanel = new Panel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).BeginInit();
            teamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teamDataGrip).BeginInit();
            contentTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.Highlight;
            headerPanel.Controls.Add(titleIcon);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1381, 100);
            headerPanel.TabIndex = 0;
            // 
            // titleIcon
            // 
            titleIcon.BackColor = Color.Transparent;
            titleIcon.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            titleIcon.IconColor = Color.White;
            titleIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            titleIcon.IconSize = 40;
            titleIcon.Location = new Point(34, 34);
            titleIcon.Name = "titleIcon";
            titleIcon.Size = new Size(40, 40);
            titleIcon.TabIndex = 1;
            titleIcon.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(107, 40);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(251, 34);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Team Information";
            // 
            // teamGroupBox
            // 
            teamGroupBox.BackColor = Color.White;
            teamGroupBox.Controls.Add(teamDataGrip);
            teamGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamGroupBox.Location = new Point(67, 31);
            teamGroupBox.Name = "teamGroupBox";
            teamGroupBox.Size = new Size(1006, 511);
            teamGroupBox.TabIndex = 1;
            teamGroupBox.TabStop = false;
            teamGroupBox.Text = "Team content";
            // 
            // teamDataGrip
            // 
            teamDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamDataGrip.Location = new Point(47, 73);
            teamDataGrip.Name = "teamDataGrip";
            teamDataGrip.RowHeadersWidth = 51;
            teamDataGrip.Size = new Size(883, 373);
            teamDataGrip.TabIndex = 0;
            // 
            // contentTeamPanel
            // 
            contentTeamPanel.BackColor = SystemColors.ControlLightLight;
            contentTeamPanel.Controls.Add(teamGroupBox);
            contentTeamPanel.Dock = DockStyle.Fill;
            contentTeamPanel.Location = new Point(0, 100);
            contentTeamPanel.Name = "contentTeamPanel";
            contentTeamPanel.Size = new Size(1381, 595);
            contentTeamPanel.TabIndex = 2;
            // 
            // PlayerTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 695);
            Controls.Add(contentTeamPanel);
            Controls.Add(headerPanel);
            Name = "PlayerTeamForm";
            Text = "PlayerTeamForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).EndInit();
            teamGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teamDataGrip).EndInit();
            contentTeamPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label titleLabel;
        private FontAwesome.Sharp.IconPictureBox titleIcon;
        private GroupBox teamGroupBox;
        private DataGridView teamDataGrip;
        private Panel contentTeamPanel;
    }
}