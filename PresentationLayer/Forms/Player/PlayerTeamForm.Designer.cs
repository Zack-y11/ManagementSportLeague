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
            titleIcon = new FontAwesome.Sharp.IconPictureBox();
            titleLabel = new Label();
            teamGroupBox = new GroupBox();
            teamDataGrip = new DataGridView();
            PDFBtn = new FontAwesome.Sharp.IconButton();
            contentTeamPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)titleIcon).BeginInit();
            teamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teamDataGrip).BeginInit();
            contentTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleIcon
            // 
            titleIcon.BackColor = Color.Transparent;
            titleIcon.ForeColor = Color.FromArgb(0, 123, 252);
            titleIcon.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            titleIcon.IconColor = Color.FromArgb(0, 123, 252);
            titleIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            titleIcon.IconSize = 40;
            titleIcon.Location = new Point(26, 31);
            titleIcon.Name = "titleIcon";
            titleIcon.Size = new Size(40, 40);
            titleIcon.TabIndex = 1;
            titleIcon.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(0, 123, 252);
            titleLabel.Location = new Point(154, 37);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(251, 34);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Team Information";
            // 
            // teamGroupBox
            // 
            teamGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamGroupBox.BackColor = Color.White;
            teamGroupBox.Controls.Add(teamDataGrip);
            teamGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamGroupBox.Location = new Point(218, 118);
            teamGroupBox.Name = "teamGroupBox";
            teamGroupBox.Size = new Size(1006, 541);
            teamGroupBox.TabIndex = 1;
            teamGroupBox.TabStop = false;
            teamGroupBox.Text = "Team content";
            // 
            // teamDataGrip
            // 
            teamDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamDataGrip.Location = new Point(47, 73);
            teamDataGrip.Name = "teamDataGrip";
            teamDataGrip.RowHeadersWidth = 51;
            teamDataGrip.Size = new Size(883, 430);
            teamDataGrip.TabIndex = 0;
            // 
            // PDFBtn
            // 
            PDFBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PDFBtn.BackColor = Color.YellowGreen;
            PDFBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            PDFBtn.ForeColor = Color.White;
            PDFBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            PDFBtn.IconColor = Color.White;
            PDFBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PDFBtn.Location = new Point(915, 57);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(233, 45);
            PDFBtn.TabIndex = 44;
            PDFBtn.Text = "       Generate PDF";
            PDFBtn.UseVisualStyleBackColor = false;
            PDFBtn.Click += PDFBtn_Click;
            // 
            // contentTeamPanel
            // 
            contentTeamPanel.BackColor = SystemColors.ControlLightLight;
            contentTeamPanel.Controls.Add(PDFBtn);
            contentTeamPanel.Controls.Add(titleIcon);
            contentTeamPanel.Controls.Add(teamGroupBox);
            contentTeamPanel.Controls.Add(titleLabel);
            contentTeamPanel.Dock = DockStyle.Fill;
            contentTeamPanel.Location = new Point(0, 0);
            contentTeamPanel.Name = "contentTeamPanel";
            contentTeamPanel.Size = new Size(1381, 695);
            contentTeamPanel.TabIndex = 2;
            // 
            // PlayerTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 695);
            Controls.Add(contentTeamPanel);
            Name = "PlayerTeamForm";
            Text = "PlayerTeamForm";
            ((System.ComponentModel.ISupportInitialize)titleIcon).EndInit();
            teamGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teamDataGrip).EndInit();
            contentTeamPanel.ResumeLayout(false);
            contentTeamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label titleLabel;
        private FontAwesome.Sharp.IconPictureBox titleIcon;
        private GroupBox teamGroupBox;
        private DataGridView teamDataGrip;
        private Panel contentTeamPanel;
        private FontAwesome.Sharp.IconButton PDFBtn;
    }
}