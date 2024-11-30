namespace PresentationLayer.Forms.Player
{
    partial class PositionForm
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
            positionGroupBox = new GroupBox();
            leaguePositionDataGrip = new DataGridView();
            positionContentPanel = new Panel();
            positionLabel = new Label();
            titleIcon = new FontAwesome.Sharp.IconPictureBox();
            positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leaguePositionDataGrip).BeginInit();
            positionContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).BeginInit();
            SuspendLayout();
            // 
            // positionGroupBox
            // 
            positionGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            positionGroupBox.BackColor = Color.White;
            positionGroupBox.Controls.Add(leaguePositionDataGrip);
            positionGroupBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionGroupBox.Location = new Point(153, 72);
            positionGroupBox.Name = "positionGroupBox";
            positionGroupBox.Size = new Size(936, 585);
            positionGroupBox.TabIndex = 1;
            positionGroupBox.TabStop = false;
            positionGroupBox.Text = "Position Table ";
            // 
            // leaguePositionDataGrip
            // 
            leaguePositionDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leaguePositionDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaguePositionDataGrip.Location = new Point(40, 57);
            leaguePositionDataGrip.Name = "leaguePositionDataGrip";
            leaguePositionDataGrip.RowHeadersWidth = 51;
            leaguePositionDataGrip.Size = new Size(849, 484);
            leaguePositionDataGrip.TabIndex = 0;
            // 
            // positionContentPanel
            // 
            positionContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            positionContentPanel.BackColor = SystemColors.ControlLightLight;
            positionContentPanel.Controls.Add(titleIcon);
            positionContentPanel.Controls.Add(positionLabel);
            positionContentPanel.Controls.Add(positionGroupBox);
            positionContentPanel.Location = new Point(0, 0);
            positionContentPanel.Name = "positionContentPanel";
            positionContentPanel.Size = new Size(1227, 721);
            positionContentPanel.TabIndex = 2;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BackColor = Color.Transparent;
            positionLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionLabel.ForeColor = Color.FromArgb(0, 123, 252);
            positionLabel.Location = new Point(118, 18);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(299, 34);
            positionLabel.TabIndex = 1;
            positionLabel.Text = "Team's Table Position";
            // 
            // titleIcon
            // 
            titleIcon.BackColor = Color.Transparent;
            titleIcon.ForeColor = Color.FromArgb(0, 123, 252);
            titleIcon.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            titleIcon.IconColor = Color.FromArgb(0, 123, 252);
            titleIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            titleIcon.IconSize = 40;
            titleIcon.Location = new Point(24, 12);
            titleIcon.Name = "titleIcon";
            titleIcon.Size = new Size(40, 40);
            titleIcon.TabIndex = 2;
            titleIcon.TabStop = false;
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 721);
            Controls.Add(positionContentPanel);
            Name = "PositionForm";
            Text = "PositionForm";
            positionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leaguePositionDataGrip).EndInit();
            positionContentPanel.ResumeLayout(false);
            positionContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox positionGroupBox;
        private DataGridView leaguePositionDataGrip;
        private Panel positionContentPanel;
        private Label positionLabel;
        private FontAwesome.Sharp.IconPictureBox titleIcon;
    }
}