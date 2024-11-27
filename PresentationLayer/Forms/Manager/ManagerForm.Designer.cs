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
            dataGridView1 = new DataGridView();
            labelPositionTable = new Label();
            panelGoals = new Panel();
            labelGoalsStatus = new Label();
            labelGoalsNUmber = new Label();
            ipbGoals = new FontAwesome.Sharp.IconPictureBox();
            labelGoals = new Label();
            sidePanel = new Panel();
            btnActivities = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnPlayers = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            coachLabel = new Label();
            ipbManager = new FontAwesome.Sharp.IconPictureBox();
            panelHeader = new Panel();
            ibtnRestaurar = new FontAwesome.Sharp.IconButton();
            ibtnMaximizar = new FontAwesome.Sharp.IconButton();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            contentPanel = new Panel();
            panelNextMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelObjetiveSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).BeginInit();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbGoals).BeginInit();
            sidePanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).BeginInit();
            panelHeader.SuspendLayout();
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
            panelPositionTable.Controls.Add(dataGridView1);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(345, 268);
            dataGridView1.TabIndex = 1;
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
            sidePanel.Controls.Add(btnActivities);
            sidePanel.Controls.Add(btnDashboard);
            sidePanel.Controls.Add(btnPlayers);
            sidePanel.Controls.Add(panelLogo);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(302, 754);
            sidePanel.TabIndex = 7;
            // 
            // btnActivities
            // 
            btnActivities.FlatAppearance.BorderSize = 0;
            btnActivities.FlatStyle = FlatStyle.Flat;
            btnActivities.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivities.ForeColor = Color.Black;
            btnActivities.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnActivities.IconColor = Color.Black;
            btnActivities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivities.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivities.Location = new Point(0, 179);
            btnActivities.Name = "btnActivities";
            btnActivities.Padding = new Padding(12, 0, 0, 0);
            btnActivities.Size = new Size(302, 60);
            btnActivities.TabIndex = 9;
            btnActivities.Text = "Activities";
            btnActivities.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 122);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(302, 60);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnPlayers
            // 
            btnPlayers.FlatAppearance.BorderSize = 0;
            btnPlayers.FlatStyle = FlatStyle.Flat;
            btnPlayers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayers.ForeColor = Color.Black;
            btnPlayers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnPlayers.IconColor = Color.Black;
            btnPlayers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlayers.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlayers.Location = new Point(0, 257);
            btnPlayers.Name = "btnPlayers";
            btnPlayers.Padding = new Padding(12, 0, 0, 0);
            btnPlayers.Size = new Size(302, 60);
            btnPlayers.TabIndex = 5;
            btnPlayers.Text = "Players";
            btnPlayers.UseVisualStyleBackColor = true;
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
            panelHeader.Controls.Add(ibtnRestaurar);
            panelHeader.Controls.Add(ibtnMaximizar);
            panelHeader.Controls.Add(ibtnCerrar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(302, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1046, 52);
            panelHeader.TabIndex = 8;
            // 
            // ibtnRestaurar
            // 
            ibtnRestaurar.Dock = DockStyle.Right;
            ibtnRestaurar.FlatStyle = FlatStyle.Flat;
            ibtnRestaurar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Clone;
            ibtnRestaurar.IconColor = Color.White;
            ibtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRestaurar.Location = new Point(899, 0);
            ibtnRestaurar.Name = "ibtnRestaurar";
            ibtnRestaurar.Size = new Size(49, 52);
            ibtnRestaurar.TabIndex = 2;
            ibtnRestaurar.UseVisualStyleBackColor = true;
            ibtnRestaurar.Click += ibtnRestaurar_Click;
            // 
            // ibtnMaximizar
            // 
            ibtnMaximizar.Dock = DockStyle.Right;
            ibtnMaximizar.FlatStyle = FlatStyle.Flat;
            ibtnMaximizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            ibtnMaximizar.IconColor = Color.White;
            ibtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnMaximizar.Location = new Point(948, 0);
            ibtnMaximizar.Name = "ibtnMaximizar";
            ibtnMaximizar.Size = new Size(49, 52);
            ibtnMaximizar.TabIndex = 1;
            ibtnMaximizar.UseVisualStyleBackColor = true;
            ibtnMaximizar.Click += ibtnMaximizar_Click;
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.Dock = DockStyle.Right;
            ibtnCerrar.FlatStyle = FlatStyle.Flat;
            ibtnCerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            ibtnCerrar.IconColor = Color.White;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.Location = new Point(997, 0);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(49, 52);
            ibtnCerrar.TabIndex = 0;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(panelPositionTable);
            contentPanel.Controls.Add(panelWins);
            contentPanel.Controls.Add(panelGoals);
            contentPanel.Controls.Add(panelNextMach);
            contentPanel.Controls.Add(panelObjetiveSeason);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(302, 52);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1046, 702);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGoals.ResumeLayout(false);
            panelGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbGoals).EndInit();
            sidePanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).EndInit();
            panelHeader.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private Panel sidePanel;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbManager;
        private Panel panelHeader;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton ibtnRestaurar;
        private FontAwesome.Sharp.IconButton ibtnMaximizar;
        private Label coachLabel;
        private Panel contentPanel;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label labelGoalsStatus;
        private FontAwesome.Sharp.IconButton btnActivities;
    }
}