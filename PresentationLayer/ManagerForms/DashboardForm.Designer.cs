namespace PresentationLayer.ManagerForms
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
            label1 = new Label();
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            labelPositionTable = new Label();
            panelWins = new Panel();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panelInjuredPlayers = new Panel();
            label2 = new Label();
            labelInjuredPlayersNUmber = new Label();
            ipbInjured = new FontAwesome.Sharp.IconPictureBox();
            labelInjuredPlayers = new Label();
            panelNextMach = new Panel();
            ipbCalendar = new FontAwesome.Sharp.IconPictureBox();
            labelTimeNextMatch = new Label();
            labelRival = new Label();
            labelNextMatch = new Label();
            panelObjetiveSeason = new Panel();
            ipbTrophy = new FontAwesome.Sharp.IconPictureBox();
            labelObjetiveStatus = new Label();
            labelObejtiveCompetition = new Label();
            labelPlayerOnTeam = new Label();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelInjuredPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbInjured).BeginInit();
            panelNextMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).BeginInit();
            panelObjetiveSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 245);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // panelPositionTable
            // 
            panelPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            panelPositionTable.Controls.Add(ipbPositionTable);
            panelPositionTable.Controls.Add(dataGridView1);
            panelPositionTable.Controls.Add(labelPositionTable);
            panelPositionTable.Location = new Point(612, 39);
            panelPositionTable.Name = "panelPositionTable";
            panelPositionTable.Size = new Size(406, 347);
            panelPositionTable.TabIndex = 10;
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
            // panelWins
            // 
            panelWins.BackColor = Color.FromArgb(22, 163, 74);
            panelWins.Controls.Add(ipbStar);
            panelWins.Controls.Add(labelWinsNumber);
            panelWins.Controls.Add(labelWins);
            panelWins.Location = new Point(43, 39);
            panelWins.Name = "panelWins";
            panelWins.Size = new Size(505, 152);
            panelWins.TabIndex = 8;
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
            // panelInjuredPlayers
            // 
            panelInjuredPlayers.BackColor = Color.FromArgb(220, 38, 38);
            panelInjuredPlayers.Controls.Add(label2);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayersNUmber);
            panelInjuredPlayers.Controls.Add(ipbInjured);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayers);
            panelInjuredPlayers.Location = new Point(612, 449);
            panelInjuredPlayers.Name = "panelInjuredPlayers";
            panelInjuredPlayers.Size = new Size(406, 152);
            panelInjuredPlayers.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 5;
            label2.Text = "En la temporada";
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
            // panelNextMach
            // 
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbCalendar);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextMatch);
            panelNextMach.Location = new Point(43, 234);
            panelNextMach.Name = "panelNextMach";
            panelNextMach.Size = new Size(505, 152);
            panelNextMach.TabIndex = 7;
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
            // panelObjetiveSeason
            // 
            panelObjetiveSeason.BackColor = Color.FromArgb(202, 138, 4);
            panelObjetiveSeason.Controls.Add(ipbTrophy);
            panelObjetiveSeason.Controls.Add(labelObjetiveStatus);
            panelObjetiveSeason.Controls.Add(labelObejtiveCompetition);
            panelObjetiveSeason.Controls.Add(labelPlayerOnTeam);
            panelObjetiveSeason.Location = new Point(43, 449);
            panelObjetiveSeason.Name = "panelObjetiveSeason";
            panelObjetiveSeason.Size = new Size(505, 152);
            panelObjetiveSeason.TabIndex = 9;
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 654);
            Controls.Add(panelPositionTable);
            Controls.Add(panelWins);
            Controls.Add(panelInjuredPlayers);
            Controls.Add(panelNextMach);
            Controls.Add(panelObjetiveSeason);
            Controls.Add(label1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelWins.ResumeLayout(false);
            panelWins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            panelInjuredPlayers.ResumeLayout(false);
            panelInjuredPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbInjured).EndInit();
            panelNextMach.ResumeLayout(false);
            panelNextMach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).EndInit();
            panelObjetiveSeason.ResumeLayout(false);
            panelObjetiveSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private DataGridView dataGridView1;
        private Label labelPositionTable;
        private Panel panelWins;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private Label labelWinsNumber;
        private Label labelWins;
        private Panel panelInjuredPlayers;
        private Label label2;
        private Label labelInjuredPlayersNUmber;
        private FontAwesome.Sharp.IconPictureBox ipbInjured;
        private Label labelInjuredPlayers;
        private Panel panelNextMach;
        private FontAwesome.Sharp.IconPictureBox ipbCalendar;
        private Label labelTimeNextMatch;
        private Label labelRival;
        private Label labelNextMatch;
        private Panel panelObjetiveSeason;
        private FontAwesome.Sharp.IconPictureBox ipbTrophy;
        private Label labelObjetiveStatus;
        private Label labelObejtiveCompetition;
        private Label labelPlayerOnTeam;
    }
}