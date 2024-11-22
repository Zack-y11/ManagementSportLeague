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
            ipbCalendar = new FontAwesome.Sharp.IconPictureBox();
            labelTimeNextMatch = new Label();
            labelRival = new Label();
            labelNextMatch = new Label();
            panelWins = new Panel();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panelObjetiveSeason = new Panel();
            ipbTrophy = new FontAwesome.Sharp.IconPictureBox();
            labelObjetiveStatus = new Label();
            labelObejtiveCompetition = new Label();
            labelPlayerOnTeam = new Label();
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            labelPositionTable = new Label();
            panelInjuredPlayers = new Panel();
            label1 = new Label();
            labelInjuredPlayersNUmber = new Label();
            ipbInjured = new FontAwesome.Sharp.IconPictureBox();
            labelInjuredPlayers = new Label();
            sidePanel = new Panel();
            btnActivities = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnPositionTable = new FontAwesome.Sharp.IconButton();
            btnStats = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelObjetiveSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).BeginInit();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelInjuredPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbInjured).BeginInit();
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
            panelNextMach.Controls.Add(ipbCalendar);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextMatch);
            panelNextMach.Location = new Point(22, 216);
            panelNextMach.Name = "panelNextMach";
            panelNextMach.Size = new Size(505, 152);
            panelNextMach.TabIndex = 2;
            // 
            // ipbCalendar
            // 
            ipbCalendar.BackColor = Color.Transparent;
            ipbCalendar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ipbCalendar.IconColor = Color.White;
            ipbCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbCalendar.IconSize = 40;
            ipbCalendar.Location = new Point(454, 9);
            ipbCalendar.Name = "ipbCalendar";
            ipbCalendar.Size = new Size(40, 40);
            ipbCalendar.TabIndex = 4;
            ipbCalendar.TabStop = false;
            // 
            // labelTimeNextMatch
            // 
            labelTimeNextMatch.AutoSize = true;
            labelTimeNextMatch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimeNextMatch.ForeColor = Color.White;
            labelTimeNextMatch.Location = new Point(23, 118);
            labelTimeNextMatch.Name = "labelTimeNextMatch";
            labelTimeNextMatch.Size = new Size(95, 23);
            labelTimeNextMatch.TabIndex = 2;
            labelTimeNextMatch.Text = "En 3 dias";
            // 
            // labelRival
            // 
            labelRival.AutoSize = true;
            labelRival.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRival.ForeColor = Color.White;
            labelRival.Location = new Point(30, 52);
            labelRival.Name = "labelRival";
            labelRival.Size = new Size(322, 51);
            labelRival.TabIndex = 1;
            labelRival.Text = "Vs. Shibidis FC";
            // 
            // labelNextMatch
            // 
            labelNextMatch.AutoSize = true;
            labelNextMatch.BackColor = Color.FromArgb(37, 99, 235);
            labelNextMatch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNextMatch.ForeColor = Color.White;
            labelNextMatch.Location = new Point(229, 9);
            labelNextMatch.Name = "labelNextMatch";
            labelNextMatch.Size = new Size(123, 23);
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
            labelWinsNumber.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWinsNumber.ForeColor = Color.White;
            labelWinsNumber.Location = new Point(13, 58);
            labelWinsNumber.Name = "labelWinsNumber";
            labelWinsNumber.Size = new Size(155, 51);
            labelWinsNumber.TabIndex = 3;
            labelWinsNumber.Text = "5 Wins";
            // 
            // labelWins
            // 
            labelWins.AutoSize = true;
            labelWins.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWins.ForeColor = Color.White;
            labelWins.Location = new Point(229, 16);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(94, 23);
            labelWins.TabIndex = 0;
            labelWins.Text = "Victorias";
            // 
            // panelObjetiveSeason
            // 
            panelObjetiveSeason.BackColor = Color.FromArgb(202, 138, 4);
            panelObjetiveSeason.Controls.Add(ipbTrophy);
            panelObjetiveSeason.Controls.Add(labelObjetiveStatus);
            panelObjetiveSeason.Controls.Add(labelObejtiveCompetition);
            panelObjetiveSeason.Controls.Add(labelPlayerOnTeam);
            panelObjetiveSeason.Location = new Point(22, 431);
            panelObjetiveSeason.Name = "panelObjetiveSeason";
            panelObjetiveSeason.Size = new Size(505, 152);
            panelObjetiveSeason.TabIndex = 4;
            panelObjetiveSeason.Paint += panelObjetiveSeason_Paint;
            // 
            // ipbTrophy
            // 
            ipbTrophy.BackColor = Color.Transparent;
            ipbTrophy.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ipbTrophy.IconColor = Color.White;
            ipbTrophy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbTrophy.IconSize = 40;
            ipbTrophy.Location = new Point(454, 11);
            ipbTrophy.Name = "ipbTrophy";
            ipbTrophy.Size = new Size(40, 40);
            ipbTrophy.TabIndex = 3;
            ipbTrophy.TabStop = false;
            // 
            // labelObjetiveStatus
            // 
            labelObjetiveStatus.AutoSize = true;
            labelObjetiveStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObjetiveStatus.ForeColor = Color.White;
            labelObjetiveStatus.Location = new Point(23, 115);
            labelObjetiveStatus.Name = "labelObjetiveStatus";
            labelObjetiveStatus.Size = new Size(102, 23);
            labelObjetiveStatus.TabIndex = 4;
            labelObjetiveStatus.Text = "en activo";
            // 
            // labelObejtiveCompetition
            // 
            labelObejtiveCompetition.AutoSize = true;
            labelObejtiveCompetition.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObejtiveCompetition.ForeColor = Color.White;
            labelObejtiveCompetition.Location = new Point(13, 50);
            labelObejtiveCompetition.Name = "labelObejtiveCompetition";
            labelObejtiveCompetition.Size = new Size(236, 51);
            labelObejtiveCompetition.TabIndex = 3;
            labelObejtiveCompetition.Text = "21 Players";
            // 
            // labelPlayerOnTeam
            // 
            labelPlayerOnTeam.AutoSize = true;
            labelPlayerOnTeam.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerOnTeam.ForeColor = Color.White;
            labelPlayerOnTeam.Location = new Point(134, 11);
            labelPlayerOnTeam.Name = "labelPlayerOnTeam";
            labelPlayerOnTeam.Size = new Size(169, 23);
            labelPlayerOnTeam.TabIndex = 0;
            labelPlayerOnTeam.Text = "Players on Team";
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
            dataGridView1.Location = new Point(35, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(345, 268);
            dataGridView1.TabIndex = 1;
            // 
            // labelPositionTable
            // 
            labelPositionTable.AutoSize = true;
            labelPositionTable.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPositionTable.ForeColor = Color.White;
            labelPositionTable.Location = new Point(120, 6);
            labelPositionTable.Name = "labelPositionTable";
            labelPositionTable.Size = new Size(165, 27);
            labelPositionTable.TabIndex = 0;
            labelPositionTable.Text = "Position Table";
            // 
            // panelInjuredPlayers
            // 
            panelInjuredPlayers.BackColor = Color.FromArgb(220, 38, 38);
            panelInjuredPlayers.Controls.Add(label1);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayersNUmber);
            panelInjuredPlayers.Controls.Add(ipbInjured);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayers);
            panelInjuredPlayers.Location = new Point(591, 431);
            panelInjuredPlayers.Name = "panelInjuredPlayers";
            panelInjuredPlayers.Size = new Size(406, 152);
            panelInjuredPlayers.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 115);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 5;
            label1.Text = "En la temporada";
            // 
            // labelInjuredPlayersNUmber
            // 
            labelInjuredPlayersNUmber.AutoSize = true;
            labelInjuredPlayersNUmber.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInjuredPlayersNUmber.ForeColor = Color.White;
            labelInjuredPlayersNUmber.Location = new Point(179, 50);
            labelInjuredPlayersNUmber.Name = "labelInjuredPlayersNUmber";
            labelInjuredPlayersNUmber.Size = new Size(72, 51);
            labelInjuredPlayersNUmber.TabIndex = 4;
            labelInjuredPlayersNUmber.Text = "34";
            // 
            // ipbInjured
            // 
            ipbInjured.BackColor = Color.FromArgb(220, 38, 38);
            ipbInjured.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            ipbInjured.IconColor = Color.White;
            ipbInjured.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbInjured.IconSize = 40;
            ipbInjured.Location = new Point(354, 11);
            ipbInjured.Name = "ipbInjured";
            ipbInjured.Size = new Size(40, 40);
            ipbInjured.TabIndex = 1;
            ipbInjured.TabStop = false;
            // 
            // labelInjuredPlayers
            // 
            labelInjuredPlayers.AutoSize = true;
            labelInjuredPlayers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInjuredPlayers.ForeColor = Color.White;
            labelInjuredPlayers.Location = new Point(132, 0);
            labelInjuredPlayers.Name = "labelInjuredPlayers";
            labelInjuredPlayers.Size = new Size(141, 23);
            labelInjuredPlayers.TabIndex = 0;
            labelInjuredPlayers.Text = "Goals Scored";
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.WhiteSmoke;
            sidePanel.Controls.Add(btnActivities);
            sidePanel.Controls.Add(btnDashboard);
            sidePanel.Controls.Add(btnPositionTable);
            sidePanel.Controls.Add(btnStats);
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
            btnActivities.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // btnPositionTable
            // 
            btnPositionTable.FlatAppearance.BorderSize = 0;
            btnPositionTable.FlatStyle = FlatStyle.Flat;
            btnPositionTable.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPositionTable.ForeColor = Color.Black;
            btnPositionTable.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            btnPositionTable.IconColor = Color.Black;
            btnPositionTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPositionTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnPositionTable.Location = new Point(0, 386);
            btnPositionTable.Name = "btnPositionTable";
            btnPositionTable.Padding = new Padding(12, 0, 0, 0);
            btnPositionTable.Size = new Size(302, 66);
            btnPositionTable.TabIndex = 7;
            btnPositionTable.Text = "Position Table";
            btnPositionTable.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStats.ForeColor = Color.Black;
            btnStats.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            btnStats.IconColor = Color.Black;
            btnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStats.ImageAlign = ContentAlignment.MiddleLeft;
            btnStats.Location = new Point(0, 323);
            btnStats.Name = "btnStats";
            btnStats.Padding = new Padding(12, 0, 0, 0);
            btnStats.Size = new Size(302, 60);
            btnStats.TabIndex = 6;
            btnStats.Text = "Stats";
            btnStats.UseVisualStyleBackColor = true;
            // 
            // btnPlayers
            // 
            btnPlayers.FlatAppearance.BorderSize = 0;
            btnPlayers.FlatStyle = FlatStyle.Flat;
            btnPlayers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            coachLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            coachLabel.ForeColor = Color.Black;
            coachLabel.Location = new Point(58, 24);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new Size(227, 28);
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
            ibtnRestaurar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            ibtnMaximizar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            ibtnCerrar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            contentPanel.Controls.Add(panelInjuredPlayers);
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
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).EndInit();
            panelWins.ResumeLayout(false);
            panelWins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            panelObjetiveSeason.ResumeLayout(false);
            panelObjetiveSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).EndInit();
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelInjuredPlayers.ResumeLayout(false);
            panelInjuredPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbInjured).EndInit();
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
        private Label labelPlayerOnTeam;
        private Label labelPositionTable;
        private Label labelWinsNumber;
        private Label labelObjetiveStatus;
        private Label labelObejtiveCompetition;
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbTrophy;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private FontAwesome.Sharp.IconPictureBox ipbCalendar;
        private Panel panelInjuredPlayers;
        private Label labelInjuredPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbInjured;
        private Label labelInjuredPlayersNUmber;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private Panel sidePanel;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPositionTable;
        private FontAwesome.Sharp.IconButton btnStats;
        private FontAwesome.Sharp.IconButton btnPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbManager;
        private Panel panelHeader;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton ibtnRestaurar;
        private FontAwesome.Sharp.IconButton ibtnMaximizar;
        private Label coachLabel;
        private Panel contentPanel;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnActivities;
    }
}