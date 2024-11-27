﻿namespace PresentationLayer.Forms.Player
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
            headerPanel = new Panel();
            leaguePositionLabel = new Label();
            trophieIcon = new FontAwesome.Sharp.IconPictureBox();
            positionGroupBox = new GroupBox();
            leaguePositionDataGrip = new DataGridView();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trophieIcon).BeginInit();
            positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leaguePositionDataGrip).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.Highlight;
            headerPanel.Controls.Add(leaguePositionLabel);
            headerPanel.Controls.Add(trophieIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1227, 100);
            headerPanel.TabIndex = 0;
            // 
            // leaguePositionLabel
            // 
            leaguePositionLabel.AutoSize = true;
            leaguePositionLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leaguePositionLabel.ForeColor = Color.White;
            leaguePositionLabel.Location = new Point(113, 39);
            leaguePositionLabel.Name = "leaguePositionLabel";
            leaguePositionLabel.Size = new Size(303, 34);
            leaguePositionLabel.TabIndex = 4;
            leaguePositionLabel.Text = "Sport League Position";
            // 
            // trophieIcon
            // 
            trophieIcon.BackColor = Color.Transparent;
            trophieIcon.ForeColor = SystemColors.Control;
            trophieIcon.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            trophieIcon.IconColor = SystemColors.Control;
            trophieIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            trophieIcon.IconSize = 58;
            trophieIcon.Location = new Point(21, 24);
            trophieIcon.Name = "trophieIcon";
            trophieIcon.Size = new Size(60, 58);
            trophieIcon.TabIndex = 3;
            trophieIcon.TabStop = false;
            // 
            // positionGroupBox
            // 
            positionGroupBox.BackColor = Color.White;
            positionGroupBox.Controls.Add(leaguePositionDataGrip);
            positionGroupBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionGroupBox.Location = new Point(71, 154);
            positionGroupBox.Name = "positionGroupBox";
            positionGroupBox.Size = new Size(936, 474);
            positionGroupBox.TabIndex = 1;
            positionGroupBox.TabStop = false;
            positionGroupBox.Text = "Position Table ";
            // 
            // leaguePositionDataGrip
            // 
            leaguePositionDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaguePositionDataGrip.Location = new Point(40, 57);
            leaguePositionDataGrip.Name = "leaguePositionDataGrip";
            leaguePositionDataGrip.RowHeadersWidth = 51;
            leaguePositionDataGrip.Size = new Size(849, 316);
            leaguePositionDataGrip.TabIndex = 0;
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 721);
            Controls.Add(positionGroupBox);
            Controls.Add(headerPanel);
            Name = "PositionForm";
            Text = "PositionForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trophieIcon).EndInit();
            positionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leaguePositionDataGrip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private FontAwesome.Sharp.IconPictureBox trophieIcon;
        private Label leaguePositionLabel;
        private GroupBox positionGroupBox;
        private DataGridView leaguePositionDataGrip;
    }
}