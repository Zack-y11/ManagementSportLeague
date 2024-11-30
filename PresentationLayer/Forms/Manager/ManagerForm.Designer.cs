namespace PresentationLayer.ManagerForms
{
    partial class ManagerForm
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
            panelNextMach = new Panel();
            ipbActivities = new FontAwesome.Sharp.IconPictureBox();
            labelTimeNextMatch = new Label();
            labelRival = new Label();
            labelNextMatch = new Label();
            panelWins = new Panel();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panelObjetiveSeason = new Panel();
            ipbPlayers = new FontAwesome.Sharp.IconPictureBox();
            labelPlayersStatus = new Label();
            labelPlayersNumber = new Label();
            labelPlayers = new Label();
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            positionTableDataGridView = new DataGridView();
            labelPositionTable = new Label();
            panelGoals = new Panel();
            labelGoalsStatus = new Label();
            labelGoalsNUmber = new Label();
            ipbGoals = new FontAwesome.Sharp.IconPictureBox();
            labelGoals = new Label();
            sidePanel = new Panel();
            activitiesBtn = new FontAwesome.Sharp.IconButton();
            dashboardBtn = new FontAwesome.Sharp.IconButton();
            playersBtn = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            coachLabel = new Label();
            ipbManager = new FontAwesome.Sharp.IconPictureBox();
            panelHeader = new Panel();
            IconsPanel = new Panel();
            resetBtn = new FontAwesome.Sharp.IconButton();
            maximizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            contentPanel = new Panel();
            panelNextMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelObjetiveSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).BeginInit();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positionTableDataGridView).BeginInit();
            panelGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbGoals).BeginInit();
            sidePanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).BeginInit();
            panelHeader.SuspendLayout();
            IconsPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelNextMach
            // 
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbActivities);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextMatch);
            panelNextMach.Location = new Point(22, 216);
            panelNextMach.Name = "panelNextMach";
            panelNextMach.Size = new Size(505, 152);
            panelNextMach.TabIndex = 2;
            // 
            // ipbActivities
            // 
            ipbActivities.BackColor = Color.Transparent;
            ipbActivities.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ipbActivities.IconColor = Color.White;
            ipbActivities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbActivities.IconSize = 40;
            ipbActivities.Location = new Point(454, 9);
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
            labelTimeNextMatch.Location = new Point(23, 118);
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
            labelRival.Location = new Point(30, 52);
            labelRival.Name = "labelRival";
            labelRival.Size = new Size(336, 52);
            labelRival.TabIndex = 1;
            labelRival.Text = "Vs. Shibidis FC";
            // 
            // labelNextMatch
            // 
            labelNextMatch.AutoSize = true;
            labelNextMatch.BackColor = Color.FromArgb(37, 99, 235);
            labelNextMatch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNextMatch.ForeColor = Color.White;
            labelNextMatch.Location = new Point(229, 9);
            labelNextMatch.Name = "labelNextMatch";
            labelNextMatch.Size = new Size(121, 25);
            labelNextMatch.TabIndex = 0;
            labelNextMatch.Text = "Next Match";
            // 
            // panelWins
            // 
            panelWins.BackColor = Color.FromArgb(22, 163, 74);
            panelWins.Controls.Add(ipbStar);
            panelWins.Controls.Add(labelWinsNumber);
            panelWins.Controls.Add(labelWins);
            panelWins.Location = new Point(22, 21);
            panelWins.Name = "panelWins";
            panelWins.Size = new Size(505, 152);
            panelWins.TabIndex = 3;
            // 
            // ipbStar
            // 
            ipbStar.BackColor = Color.Transparent;
            ipbStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            ipbStar.IconColor = Color.White;
            ipbStar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbStar.IconSize = 40;
            ipbStar.Location = new Point(454, 16);
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
            labelWinsNumber.Location = new Point(13, 58);
            labelWinsNumber.Name = "labelWinsNumber";
            labelWinsNumber.Size = new Size(162, 52);
            labelWinsNumber.TabIndex = 3;
            labelWinsNumber.Text = "5 Wins";
            // 
            // labelWins
            // 
            labelWins.AutoSize = true;
            labelWins.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWins.ForeColor = Color.White;
            labelWins.Location = new Point(229, 16);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(96, 25);
            labelWins.TabIndex = 0;
            labelWins.Text = "Victorias";
            // 
            // panelObjetiveSeason
            // 
            panelObjetiveSeason.BackColor = Color.FromArgb(202, 138, 4);
            panelObjetiveSeason.Controls.Add(ipbPlayers);
            panelObjetiveSeason.Controls.Add(labelPlayersStatus);
            panelObjetiveSeason.Controls.Add(labelPlayersNumber);
            panelObjetiveSeason.Controls.Add(labelPlayers);
            panelObjetiveSeason.Location = new Point(22, 431);
            panelObjetiveSeason.Name = "panelObjetiveSeason";
            panelObjetiveSeason.Size = new Size(505, 152);
            panelObjetiveSeason.TabIndex = 4;
            // 
            // ipbPlayers
            // 
            ipbPlayers.BackColor = Color.Transparent;
            ipbPlayers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ipbPlayers.IconColor = Color.White;
            ipbPlayers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbPlayers.IconSize = 40;
            ipbPlayers.Location = new Point(454, 11);
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
            labelPlayersStatus.Location = new Point(23, 115);
            labelPlayersStatus.Name = "labelPlayersStatus";
            labelPlayersStatus.Size = new Size(99, 25);
            labelPlayersStatus.TabIndex = 4;
            labelPlayersStatus.Text = "en activo";
            // 
            // labelPlayersNumber
            // 
            labelPlayersNumber.AutoSize = true;
            labelPlayersNumber.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersNumber.ForeColor = Color.White;
            labelPlayersNumber.Location = new Point(13, 50);
            labelPlayersNumber.Name = "labelPlayersNumber";
            labelPlayersNumber.Size = new Size(238, 52);
            labelPlayersNumber.TabIndex = 3;
            labelPlayersNumber.Text = "21 Players";
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(134, 11);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(175, 25);
            labelPlayers.TabIndex = 0;
            labelPlayers.Text = "Players on Team";
            // 
            // panelPositionTable
            // 
            panelPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            panelPositionTable.Controls.Add(ipbPositionTable);
            panelPositionTable.Controls.Add(positionTableDataGridView);
            panelPositionTable.Controls.Add(labelPositionTable);
            panelPositionTable.Location = new Point(591, 21);
            panelPositionTable.Name = "panelPositionTable";
            panelPositionTable.Size = new Size(406, 347);
            panelPositionTable.TabIndex = 5;
            // 
            // ipbPositionTable
            // 
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
            // positionTableDataGridView
            // 
            positionTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            positionTableDataGridView.Location = new Point(30, 58);
            positionTableDataGridView.Name = "positionTableDataGridView";
            positionTableDataGridView.RowHeadersWidth = 51;
            positionTableDataGridView.Size = new Size(345, 268);
            positionTableDataGridView.TabIndex = 1;
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
            // panelGoals
            // 
            panelGoals.BackColor = Color.FromArgb(220, 38, 38);
            panelGoals.Controls.Add(labelGoalsStatus);
            panelGoals.Controls.Add(labelGoalsNUmber);
            panelGoals.Controls.Add(ipbGoals);
            panelGoals.Controls.Add(labelGoals);
            panelGoals.Location = new Point(591, 431);
            panelGoals.Name = "panelGoals";
            panelGoals.Size = new Size(406, 152);
            panelGoals.TabIndex = 6;
            // 
            // labelGoalsStatus
            // 
            labelGoalsStatus.AutoSize = true;
            labelGoalsStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoalsStatus.ForeColor = Color.White;
            labelGoalsStatus.Location = new Point(15, 115);
            labelGoalsStatus.Name = "labelGoalsStatus";
            labelGoalsStatus.Size = new Size(169, 25);
            labelGoalsStatus.TabIndex = 5;
            labelGoalsStatus.Text = "En la temporada";
            // 
            // labelGoalsNUmber
            // 
            labelGoalsNUmber.AutoSize = true;
            labelGoalsNUmber.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoalsNUmber.ForeColor = Color.White;
            labelGoalsNUmber.Location = new Point(179, 50);
            labelGoalsNUmber.Name = "labelGoalsNUmber";
            labelGoalsNUmber.Size = new Size(72, 52);
            labelGoalsNUmber.TabIndex = 4;
            labelGoalsNUmber.Text = "34";
            // 
            // ipbGoals
            // 
            ipbGoals.BackColor = Color.FromArgb(220, 38, 38);
            ipbGoals.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            ipbGoals.IconColor = Color.White;
            ipbGoals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbGoals.IconSize = 40;
            ipbGoals.Location = new Point(354, 11);
            ipbGoals.Name = "ipbGoals";
            ipbGoals.Size = new Size(40, 40);
            ipbGoals.TabIndex = 1;
            ipbGoals.TabStop = false;
            // 
            // labelGoals
            // 
            labelGoals.AutoSize = true;
            labelGoals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoals.ForeColor = Color.White;
            labelGoals.Location = new Point(132, 0);
            labelGoals.Name = "labelGoals";
            labelGoals.Size = new Size(143, 25);
            labelGoals.TabIndex = 0;
            labelGoals.Text = "Goals Scored";
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.WhiteSmoke;
            sidePanel.Controls.Add(activitiesBtn);
            sidePanel.Controls.Add(dashboardBtn);
            sidePanel.Controls.Add(playersBtn);
            sidePanel.Controls.Add(panelLogo);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(302, 754);
            sidePanel.TabIndex = 7;
            // 
            // activitiesBtn
            // 
            activitiesBtn.FlatAppearance.BorderSize = 0;
            activitiesBtn.FlatStyle = FlatStyle.Flat;
            activitiesBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activitiesBtn.ForeColor = Color.Black;
            activitiesBtn.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            activitiesBtn.IconColor = Color.Black;
            activitiesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            activitiesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            activitiesBtn.Location = new Point(0, 179);
            activitiesBtn.Name = "activitiesBtn";
            activitiesBtn.Padding = new Padding(12, 0, 0, 0);
            activitiesBtn.Size = new Size(302, 60);
            activitiesBtn.TabIndex = 9;
            activitiesBtn.Text = "Activities";
            activitiesBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.Black;
            dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            dashboardBtn.IconColor = Color.Black;
            dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 122);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(12, 0, 0, 0);
            dashboardBtn.Size = new Size(302, 60);
            dashboardBtn.TabIndex = 8;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // playersBtn
            // 
            playersBtn.FlatAppearance.BorderSize = 0;
            playersBtn.FlatStyle = FlatStyle.Flat;
            playersBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playersBtn.ForeColor = Color.Black;
            playersBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            playersBtn.IconColor = Color.Black;
            playersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            playersBtn.Location = new Point(0, 257);
            playersBtn.Name = "playersBtn";
            playersBtn.Padding = new Padding(12, 0, 0, 0);
            playersBtn.Size = new Size(302, 60);
            playersBtn.TabIndex = 5;
            playersBtn.Text = "Players";
            playersBtn.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.WhiteSmoke;
            panelLogo.Controls.Add(coachLabel);
            panelLogo.Controls.Add(ipbManager);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(302, 125);
            panelLogo.TabIndex = 3;
            // 
            // coachLabel
            // 
            coachLabel.AutoSize = true;
            coachLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            coachLabel.ForeColor = Color.Black;
            coachLabel.Location = new Point(58, 24);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new Size(221, 29);
            coachLabel.TabIndex = 6;
            coachLabel.Text = "Coach Dashboard";
            // 
            // ipbManager
            // 
            ipbManager.BackColor = Color.WhiteSmoke;
            ipbManager.ForeColor = Color.Black;
            ipbManager.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ipbManager.IconColor = Color.Black;
            ipbManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbManager.IconSize = 40;
            ipbManager.Location = new Point(12, 12);
            ipbManager.Name = "ipbManager";
            ipbManager.Size = new Size(40, 40);
            ipbManager.TabIndex = 5;
            ipbManager.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 123, 250);
            panelHeader.Controls.Add(IconsPanel);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(302, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1046, 100);
            panelHeader.TabIndex = 8;
            // 
            // IconsPanel
            // 
            IconsPanel.Controls.Add(resetBtn);
            IconsPanel.Controls.Add(maximizeBtn);
            IconsPanel.Controls.Add(closeBtn);
            IconsPanel.Dock = DockStyle.Right;
            IconsPanel.Location = new Point(875, 0);
            IconsPanel.Name = "IconsPanel";
            IconsPanel.Size = new Size(171, 100);
            IconsPanel.TabIndex = 7;
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
            maximizeBtn.Click += maximizeBtn_Click;
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
            closeBtn.Click += closeBtn_Click;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(panelPositionTable);
            contentPanel.Controls.Add(panelWins);
            contentPanel.Controls.Add(panelGoals);
            contentPanel.Controls.Add(panelNextMach);
            contentPanel.Controls.Add(panelObjetiveSeason);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(302, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1046, 654);
            contentPanel.TabIndex = 9;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1348, 754);
            Controls.Add(contentPanel);
            Controls.Add(panelHeader);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerForm";
            Text = "ManagerForm";
            panelNextMach.ResumeLayout(false);
            panelNextMach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).EndInit();
            panelWins.ResumeLayout(false);
            panelWins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            panelObjetiveSeason.ResumeLayout(false);
            panelObjetiveSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).EndInit();
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)positionTableDataGridView).EndInit();
            panelGoals.ResumeLayout(false);
            panelGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbGoals).EndInit();
            sidePanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).EndInit();
            panelHeader.ResumeLayout(false);
            IconsPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNextMach;
        private Label labelNextMatch;
        private Label labelTimeNextMatch;
        private Label labelRival;
        private Panel panelWins;
        private Label labelWins;
        private Panel panelObjetiveSeason;
        private Label label7;
        private Label label8;
        private Label labelPlayers;
        private Label labelPositionTable;
        private Label labelWinsNumber;
        private Label labelPlayersStatus;
        private Label labelPlayersNumber;
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private FontAwesome.Sharp.IconPictureBox ipbActivities;
        private Panel panelGoals;
        private Label labelGoals;
        private FontAwesome.Sharp.IconPictureBox ipbGoals;
        private Label labelGoalsNUmber;
        private DataGridView positionTableDataGridView;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private Panel sidePanel;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton playersBtn;
        private FontAwesome.Sharp.IconPictureBox ipbManager;
        private Panel panelHeader;
        private Label coachLabel;
        private Panel contentPanel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private Label labelGoalsStatus;
        private FontAwesome.Sharp.IconButton activitiesBtn;
        private Panel IconsPanel;
        private FontAwesome.Sharp.IconButton resetBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
    }
}