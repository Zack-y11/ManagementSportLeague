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
            labelObejtive = new Label();
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            labelPositionTable = new Label();
            panelInjuredPlayers = new Panel();
            labelInjuredPlayersNUmber = new Label();
            ipbInjured = new FontAwesome.Sharp.IconPictureBox();
            labelInjuredPlayers = new Label();
            panelMenu = new Panel();
            ibtnPositionTable = new FontAwesome.Sharp.IconButton();
            ibtnNucering = new FontAwesome.Sharp.IconButton();
            ibtnPlayers = new FontAwesome.Sharp.IconButton();
            ibtnCalendar = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            labelCoach = new Label();
            ipbManager = new FontAwesome.Sharp.IconPictureBox();
            panelHeader = new Panel();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
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
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelNextMach
            // 
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbCalendar);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextMatch);
            panelNextMach.Location = new Point(324, 142);
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
            labelRival.Location = new Point(13, 53);
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
            panelWins.Location = new Point(324, 340);
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
            panelObjetiveSeason.Controls.Add(labelObejtive);
            panelObjetiveSeason.Location = new Point(324, 538);
            panelObjetiveSeason.Name = "panelObjetiveSeason";
            panelObjetiveSeason.Size = new Size(505, 152);
            panelObjetiveSeason.TabIndex = 4;
            // 
            // ipbTrophy
            // 
            ipbTrophy.BackColor = Color.Transparent;
            ipbTrophy.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            ipbTrophy.IconColor = Color.White;
            ipbTrophy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbTrophy.IconSize = 40;
            ipbTrophy.Location = new Point(454, 11);
            ipbTrophy.Name = "ipbTrophy";
            ipbTrophy.Size = new Size(40, 40);
            ipbTrophy.TabIndex = 3;
            ipbTrophy.TabStop = false;
            ipbTrophy.Click += iconPictureBox1_Click;
            // 
            // labelObjetiveStatus
            // 
            labelObjetiveStatus.AutoSize = true;
            labelObjetiveStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObjetiveStatus.ForeColor = Color.White;
            labelObjetiveStatus.Location = new Point(23, 115);
            labelObjetiveStatus.Name = "labelObjetiveStatus";
            labelObjetiveStatus.Size = new Size(164, 23);
            labelObjetiveStatus.TabIndex = 4;
            labelObjetiveStatus.Text = "Second Position";
            // 
            // labelObejtiveCompetition
            // 
            labelObejtiveCompetition.AutoSize = true;
            labelObejtiveCompetition.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObejtiveCompetition.ForeColor = Color.White;
            labelObejtiveCompetition.Location = new Point(13, 50);
            labelObejtiveCompetition.Name = "labelObejtiveCompetition";
            labelObejtiveCompetition.Size = new Size(436, 51);
            labelObejtiveCompetition.TabIndex = 3;
            labelObejtiveCompetition.Text = "League Champions";
            // 
            // labelObejtive
            // 
            labelObejtive.AutoSize = true;
            labelObejtive.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObejtive.ForeColor = Color.White;
            labelObejtive.Location = new Point(134, 11);
            labelObejtive.Name = "labelObejtive";
            labelObejtive.Size = new Size(273, 23);
            labelObejtive.TabIndex = 0;
            labelObejtive.Text = "Objetivos de la temporada";
            // 
            // panelPositionTable
            // 
            panelPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            panelPositionTable.Controls.Add(ipbPositionTable);
            panelPositionTable.Controls.Add(dataGridView1);
            panelPositionTable.Controls.Add(labelPositionTable);
            panelPositionTable.Location = new Point(926, 142);
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
            panelInjuredPlayers.Controls.Add(labelInjuredPlayersNUmber);
            panelInjuredPlayers.Controls.Add(ipbInjured);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayers);
            panelInjuredPlayers.Location = new Point(926, 538);
            panelInjuredPlayers.Name = "panelInjuredPlayers";
            panelInjuredPlayers.Size = new Size(406, 152);
            panelInjuredPlayers.TabIndex = 6;
            // 
            // labelInjuredPlayersNUmber
            // 
            labelInjuredPlayersNUmber.AutoSize = true;
            labelInjuredPlayersNUmber.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInjuredPlayersNUmber.ForeColor = Color.White;
            labelInjuredPlayersNUmber.Location = new Point(179, 50);
            labelInjuredPlayersNUmber.Name = "labelInjuredPlayersNUmber";
            labelInjuredPlayersNUmber.Size = new Size(47, 51);
            labelInjuredPlayersNUmber.TabIndex = 4;
            labelInjuredPlayersNUmber.Text = "5";
            // 
            // ipbInjured
            // 
            ipbInjured.BackColor = Color.FromArgb(220, 38, 38);
            ipbInjured.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
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
            labelInjuredPlayers.Location = new Point(120, 11);
            labelInjuredPlayers.Name = "labelInjuredPlayers";
            labelInjuredPlayers.Size = new Size(153, 23);
            labelInjuredPlayers.TabIndex = 0;
            labelInjuredPlayers.Text = "injured players";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(ibtnPositionTable);
            panelMenu.Controls.Add(ibtnNucering);
            panelMenu.Controls.Add(ibtnPlayers);
            panelMenu.Controls.Add(ibtnCalendar);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(302, 754);
            panelMenu.TabIndex = 7;
            // 
            // ibtnPositionTable
            // 
            ibtnPositionTable.Dock = DockStyle.Top;
            ibtnPositionTable.FlatAppearance.BorderSize = 0;
            ibtnPositionTable.FlatStyle = FlatStyle.Flat;
            ibtnPositionTable.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnPositionTable.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            ibtnPositionTable.IconColor = Color.White;
            ibtnPositionTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnPositionTable.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnPositionTable.Location = new Point(0, 305);
            ibtnPositionTable.Name = "ibtnPositionTable";
            ibtnPositionTable.Padding = new Padding(12, 0, 0, 0);
            ibtnPositionTable.Size = new Size(302, 60);
            ibtnPositionTable.TabIndex = 7;
            ibtnPositionTable.Text = "Position Table";
            ibtnPositionTable.TextAlign = ContentAlignment.MiddleLeft;
            ibtnPositionTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnPositionTable.UseVisualStyleBackColor = true;
            // 
            // ibtnNucering
            // 
            ibtnNucering.Dock = DockStyle.Top;
            ibtnNucering.FlatAppearance.BorderSize = 0;
            ibtnNucering.FlatStyle = FlatStyle.Flat;
            ibtnNucering.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnNucering.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            ibtnNucering.IconColor = Color.White;
            ibtnNucering.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnNucering.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnNucering.Location = new Point(0, 245);
            ibtnNucering.Name = "ibtnNucering";
            ibtnNucering.Padding = new Padding(12, 0, 0, 0);
            ibtnNucering.Size = new Size(302, 60);
            ibtnNucering.TabIndex = 6;
            ibtnNucering.Text = "Nucering";
            ibtnNucering.TextAlign = ContentAlignment.MiddleLeft;
            ibtnNucering.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnNucering.UseVisualStyleBackColor = true;
            // 
            // ibtnPlayers
            // 
            ibtnPlayers.Dock = DockStyle.Top;
            ibtnPlayers.FlatAppearance.BorderSize = 0;
            ibtnPlayers.FlatStyle = FlatStyle.Flat;
            ibtnPlayers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnPlayers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ibtnPlayers.IconColor = Color.White;
            ibtnPlayers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnPlayers.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnPlayers.Location = new Point(0, 185);
            ibtnPlayers.Name = "ibtnPlayers";
            ibtnPlayers.Padding = new Padding(12, 0, 0, 0);
            ibtnPlayers.Size = new Size(302, 60);
            ibtnPlayers.TabIndex = 5;
            ibtnPlayers.Text = "Players";
            ibtnPlayers.TextAlign = ContentAlignment.MiddleLeft;
            ibtnPlayers.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnPlayers.UseVisualStyleBackColor = true;
            // 
            // ibtnCalendar
            // 
            ibtnCalendar.Dock = DockStyle.Top;
            ibtnCalendar.FlatAppearance.BorderSize = 0;
            ibtnCalendar.FlatStyle = FlatStyle.Flat;
            ibtnCalendar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnCalendar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ibtnCalendar.IconColor = Color.White;
            ibtnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnCalendar.Location = new Point(0, 125);
            ibtnCalendar.Name = "ibtnCalendar";
            ibtnCalendar.Padding = new Padding(12, 0, 0, 0);
            ibtnCalendar.Size = new Size(302, 60);
            ibtnCalendar.TabIndex = 4;
            ibtnCalendar.Text = "Calendar";
            ibtnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            ibtnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCalendar.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(labelCoach);
            panelLogo.Controls.Add(ipbManager);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(302, 125);
            panelLogo.TabIndex = 3;
            // 
            // labelCoach
            // 
            labelCoach.AutoSize = true;
            labelCoach.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoach.Location = new Point(5, 65);
            labelCoach.Name = "labelCoach";
            labelCoach.Size = new Size(294, 34);
            labelCoach.TabIndex = 1;
            labelCoach.Text = "Dashboard Manager";
            // 
            // ipbManager
            // 
            ipbManager.BackColor = Color.FromArgb(39, 39, 58);
            ipbManager.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ipbManager.IconColor = Color.White;
            ipbManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbManager.IconSize = 40;
            ipbManager.Location = new Point(123, 12);
            ipbManager.Name = "ipbManager";
            ipbManager.Size = new Size(40, 40);
            ipbManager.TabIndex = 5;
            ipbManager.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 39, 58);
            panelHeader.Controls.Add(iconButton2);
            panelHeader.Controls.Add(iconButton1);
            panelHeader.Controls.Add(ibtnCerrar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(302, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1046, 52);
            panelHeader.TabIndex = 8;
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
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(948, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(49, 52);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Right;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(899, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(49, 52);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 754);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Controls.Add(panelInjuredPlayers);
            Controls.Add(panelPositionTable);
            Controls.Add(panelObjetiveSeason);
            Controls.Add(panelWins);
            Controls.Add(panelNextMach);
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
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).EndInit();
            panelHeader.ResumeLayout(false);
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
        private Label labelObejtive;
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
        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton ibtnCalendar;
        private FontAwesome.Sharp.IconButton ibtnPositionTable;
        private FontAwesome.Sharp.IconButton ibtnNucering;
        private FontAwesome.Sharp.IconButton ibtnPlayers;
        private FontAwesome.Sharp.IconPictureBox ipbManager;
        private Label labelCoach;
        private Panel panelHeader;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}