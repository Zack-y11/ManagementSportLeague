﻿namespace PresentationLayer.ManagerForms
{
    partial class DashboardForm
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
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            teamsStandingDGV = new DataGridView();
            labelPositionTable = new Label();
            panelWins = new Panel();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panelNextMach = new Panel();
            ipbActivities = new FontAwesome.Sharp.IconPictureBox();
            labelTimeNextMatch = new Label();
            labelRival = new Label();
            labelNextActivity = new Label();
            panelPlayers = new Panel();
            ipbPlayers = new FontAwesome.Sharp.IconPictureBox();
            labelPlayersStatus = new Label();
            labelPlayersNumber = new Label();
            labelPlayers = new Label();
            playersPDF = new Label();
            PDFBtn = new FontAwesome.Sharp.IconButton();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamsStandingDGV).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelNextMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).BeginInit();
            panelPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).BeginInit();
            SuspendLayout();
            // 
            // panelPositionTable
            // 
            panelPositionTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            panelPositionTable.Controls.Add(ipbPositionTable);
            panelPositionTable.Controls.Add(teamsStandingDGV);
            panelPositionTable.Controls.Add(labelPositionTable);
            panelPositionTable.Location = new Point(612, 39);
            panelPositionTable.Name = "panelPositionTable";
            panelPositionTable.Size = new Size(443, 562);
            panelPositionTable.TabIndex = 10;
            // 
            // ipbPositionTable
            // 
            ipbPositionTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ipbPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            ipbPositionTable.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            ipbPositionTable.IconColor = Color.White;
            ipbPositionTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbPositionTable.IconSize = 40;
            ipbPositionTable.Location = new Point(354, 9);
            ipbPositionTable.Name = "ipbPositionTable";
            ipbPositionTable.Size = new Size(40, 40);
            ipbPositionTable.TabIndex = 2;
            ipbPositionTable.TabStop = false;
            // 
            // teamsStandingDGV
            // 
            teamsStandingDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            teamsStandingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamsStandingDGV.Location = new Point(31, 63);
            teamsStandingDGV.Name = "teamsStandingDGV";
            teamsStandingDGV.RowHeadersWidth = 51;
            teamsStandingDGV.Size = new Size(386, 446);
            teamsStandingDGV.TabIndex = 1;
            // 
            // labelPositionTable
            // 
            labelPositionTable.AutoSize = true;
            labelPositionTable.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPositionTable.ForeColor = Color.White;
            labelPositionTable.Location = new Point(120, 6);
            labelPositionTable.Name = "labelPositionTable";
            labelPositionTable.Size = new Size(183, 29);
            labelPositionTable.TabIndex = 0;
            labelPositionTable.Text = "Position Table";
            // 
            // panelWins
            // 
            panelWins.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelWins.BackColor = Color.FromArgb(22, 163, 74);
            panelWins.Controls.Add(ipbStar);
            panelWins.Controls.Add(labelWinsNumber);
            panelWins.Controls.Add(labelWins);
            panelWins.Location = new Point(43, 39);
            panelWins.Name = "panelWins";
            panelWins.Size = new Size(529, 128);
            panelWins.TabIndex = 8;
            // 
            // ipbStar
            // 
            ipbStar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ipbStar.BackColor = Color.Transparent;
            ipbStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            ipbStar.IconColor = Color.White;
            ipbStar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbStar.IconSize = 40;
            ipbStar.Location = new Point(478, 16);
            ipbStar.Name = "ipbStar";
            ipbStar.Size = new Size(40, 40);
            ipbStar.TabIndex = 4;
            ipbStar.TabStop = false;
            // 
            // labelWinsNumber
            // 
            labelWinsNumber.AutoSize = true;
            labelWinsNumber.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWinsNumber.ForeColor = Color.White;
            labelWinsNumber.Location = new Point(23, 48);
            labelWinsNumber.Name = "labelWinsNumber";
            labelWinsNumber.Size = new Size(162, 52);
            labelWinsNumber.TabIndex = 3;
            labelWinsNumber.Text = "5 Wins";
            // 
            // labelWins
            // 
            labelWins.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelWins.AutoSize = true;
            labelWins.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWins.ForeColor = Color.White;
            labelWins.Location = new Point(190, -2);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(61, 25);
            labelWins.TabIndex = 0;
            labelWins.Text = "Wins";
            // 
            // panelNextMach
            // 
            panelNextMach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbActivities);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextActivity);
            panelNextMach.Location = new Point(43, 199);
            panelNextMach.Name = "panelNextMach";
            panelNextMach.Size = new Size(529, 137);
            panelNextMach.TabIndex = 7;
            // 
            // ipbActivities
            // 
            ipbActivities.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ipbActivities.BackColor = Color.Transparent;
            ipbActivities.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ipbActivities.IconColor = Color.White;
            ipbActivities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbActivities.IconSize = 40;
            ipbActivities.Location = new Point(478, 9);
            ipbActivities.Name = "ipbActivities";
            ipbActivities.Size = new Size(40, 40);
            ipbActivities.TabIndex = 4;
            ipbActivities.TabStop = false;
            // 
            // labelTimeNextMatch
            // 
            labelTimeNextMatch.AutoSize = true;
            labelTimeNextMatch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimeNextMatch.ForeColor = Color.White;
            labelTimeNextMatch.Location = new Point(23, 102);
            labelTimeNextMatch.Name = "labelTimeNextMatch";
            labelTimeNextMatch.Size = new Size(102, 25);
            labelTimeNextMatch.TabIndex = 2;
            labelTimeNextMatch.Text = "En 3 dias";
            // 
            // labelRival
            // 
            labelRival.AutoSize = true;
            labelRival.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRival.ForeColor = Color.White;
            labelRival.Location = new Point(23, 35);
            labelRival.Name = "labelRival";
            labelRival.Size = new Size(336, 52);
            labelRival.TabIndex = 1;
            labelRival.Text = "Vs. Shibidis FC";
            // 
            // labelNextActivity
            // 
            labelNextActivity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelNextActivity.AutoSize = true;
            labelNextActivity.BackColor = Color.FromArgb(37, 99, 235);
            labelNextActivity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNextActivity.ForeColor = Color.White;
            labelNextActivity.Location = new Point(190, 1);
            labelNextActivity.Name = "labelNextActivity";
            labelNextActivity.Size = new Size(121, 25);
            labelNextActivity.TabIndex = 0;
            labelNextActivity.Text = "Next Match";
            // 
            // panelPlayers
            // 
            panelPlayers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlayers.BackColor = Color.FromArgb(202, 138, 4);
            panelPlayers.Controls.Add(ipbPlayers);
            panelPlayers.Controls.Add(labelPlayersStatus);
            panelPlayers.Controls.Add(labelPlayersNumber);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Location = new Point(43, 360);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(529, 135);
            panelPlayers.TabIndex = 9;
            // 
            // ipbPlayers
            // 
            ipbPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ipbPlayers.BackColor = Color.Transparent;
            ipbPlayers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ipbPlayers.IconColor = Color.White;
            ipbPlayers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbPlayers.IconSize = 40;
            ipbPlayers.Location = new Point(478, 11);
            ipbPlayers.Name = "ipbPlayers";
            ipbPlayers.Size = new Size(40, 40);
            ipbPlayers.TabIndex = 3;
            ipbPlayers.TabStop = false;
            // 
            // labelPlayersStatus
            // 
            labelPlayersStatus.AutoSize = true;
            labelPlayersStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersStatus.ForeColor = Color.White;
            labelPlayersStatus.Location = new Point(23, 98);
            labelPlayersStatus.Name = "labelPlayersStatus";
            labelPlayersStatus.Size = new Size(83, 25);
            labelPlayersStatus.TabIndex = 4;
            labelPlayersStatus.Text = "Actives";
            // 
            // labelPlayersNumber
            // 
            labelPlayersNumber.AutoSize = true;
            labelPlayersNumber.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersNumber.ForeColor = Color.White;
            labelPlayersNumber.Location = new Point(13, 36);
            labelPlayersNumber.Name = "labelPlayersNumber";
            labelPlayersNumber.Size = new Size(238, 52);
            labelPlayersNumber.TabIndex = 3;
            labelPlayersNumber.Text = "21 Players";
            // 
            // labelPlayers
            // 
            labelPlayers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(190, 2);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(175, 25);
            labelPlayers.TabIndex = 0;
            labelPlayers.Text = "Players on Team";
            // 
            // playersPDF
            // 
            playersPDF.AutoSize = true;
            playersPDF.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playersPDF.Location = new Point(43, 507);
            playersPDF.Name = "playersPDF";
            playersPDF.Size = new Size(201, 22);
            playersPDF.TabIndex = 45;
            playersPDF.Text = "Generate players PDF";
            // 
            // PDFBtn
            // 
            PDFBtn.BackColor = Color.YellowGreen;
            PDFBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            PDFBtn.ForeColor = Color.White;
            PDFBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            PDFBtn.IconColor = Color.White;
            PDFBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PDFBtn.Location = new Point(43, 543);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(231, 45);
            PDFBtn.TabIndex = 46;
            PDFBtn.Text = "   Generate PDF";
            PDFBtn.UseVisualStyleBackColor = false;
            PDFBtn.Click += PDFBtn_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 654);
            Controls.Add(PDFBtn);
            Controls.Add(playersPDF);
            Controls.Add(panelPositionTable);
            Controls.Add(panelWins);
            Controls.Add(panelNextMach);
            Controls.Add(panelPlayers);
            Name = "DashboardForm";
            Text = "DashboardForm";
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamsStandingDGV).EndInit();
            panelWins.ResumeLayout(false);
            panelWins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            panelNextMach.ResumeLayout(false);
            panelNextMach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).EndInit();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private DataGridView teamsStandingDGV;
        private Label labelPositionTable;
        private Panel panelWins;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private Label labelWinsNumber;
        private Label labelWins;
        private Panel panelNextMach;
        private FontAwesome.Sharp.IconPictureBox ipbActivities;
        private Label labelTimeNextMatch;
        private Label labelRival;
        private Label labelNextActivity;
        private Panel panelPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbPlayers;
        private Label labelPlayersStatus;
        private Label labelPlayersNumber;
        private Label labelPlayers;
        private Label playersPDF;
        private FontAwesome.Sharp.IconButton PDFBtn;
    }
}