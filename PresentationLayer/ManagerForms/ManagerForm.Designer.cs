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
            panelHeader = new Panel();
            ipbManager = new FontAwesome.Sharp.IconPictureBox();
            ibPositionTable = new FontAwesome.Sharp.IconButton();
            ibtInjured = new FontAwesome.Sharp.IconButton();
            ibtCalendar = new FontAwesome.Sharp.IconButton();
            labelCoach = new Label();
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
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).BeginInit();
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
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(ipbManager);
            panelHeader.Controls.Add(ibPositionTable);
            panelHeader.Controls.Add(ibtInjured);
            panelHeader.Controls.Add(ibtCalendar);
            panelHeader.Controls.Add(labelCoach);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1182, 125);
            panelHeader.TabIndex = 0;
            // 
            // ipbManager
            // 
            ipbManager.BackColor = SystemColors.Control;
            ipbManager.ForeColor = SystemColors.ControlText;
            ipbManager.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ipbManager.IconColor = SystemColors.ControlText;
            ipbManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbManager.IconSize = 40;
            ipbManager.Location = new Point(12, 55);
            ipbManager.Name = "ipbManager";
            ipbManager.Size = new Size(40, 40);
            ipbManager.TabIndex = 5;
            ipbManager.TabStop = false;
            // 
            // ibPositionTable
            // 
            ibPositionTable.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibPositionTable.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            ibPositionTable.IconColor = Color.Black;
            ibPositionTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibPositionTable.ImageAlign = ContentAlignment.MiddleRight;
            ibPositionTable.Location = new Point(833, 50);
            ibPositionTable.Name = "ibPositionTable";
            ibPositionTable.Size = new Size(191, 49);
            ibPositionTable.TabIndex = 4;
            ibPositionTable.Text = "Position Table";
            ibPositionTable.TextAlign = ContentAlignment.MiddleLeft;
            ibPositionTable.UseVisualStyleBackColor = true;
            // 
            // ibtInjured
            // 
            ibtInjured.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtInjured.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            ibtInjured.IconColor = Color.Black;
            ibtInjured.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtInjured.ImageAlign = ContentAlignment.MiddleRight;
            ibtInjured.Location = new Point(623, 50);
            ibtInjured.Name = "ibtInjured";
            ibtInjured.Size = new Size(191, 49);
            ibtInjured.TabIndex = 3;
            ibtInjured.Text = "Nucering";
            ibtInjured.TextAlign = ContentAlignment.MiddleLeft;
            ibtInjured.UseVisualStyleBackColor = true;
            // 
            // ibtCalendar
            // 
            ibtCalendar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtCalendar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            ibtCalendar.IconColor = Color.Black;
            ibtCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtCalendar.ImageAlign = ContentAlignment.MiddleRight;
            ibtCalendar.Location = new Point(413, 50);
            ibtCalendar.Name = "ibtCalendar";
            ibtCalendar.Size = new Size(191, 49);
            ibtCalendar.TabIndex = 2;
            ibtCalendar.Text = "Calendar";
            ibtCalendar.TextAlign = ContentAlignment.MiddleLeft;
            ibtCalendar.UseVisualStyleBackColor = true;
            // 
            // labelCoach
            // 
            labelCoach.AutoSize = true;
            labelCoach.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoach.Location = new Point(52, 55);
            labelCoach.Name = "labelCoach";
            labelCoach.Size = new Size(264, 34);
            labelCoach.TabIndex = 1;
            labelCoach.Text = "Dashboard Coach";
            // 
            // panelNextMach
            // 
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbCalendar);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextMatch);
            panelNextMach.Location = new Point(80, 192);
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
            panelWins.Location = new Point(80, 387);
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
            panelObjetiveSeason.Location = new Point(80, 574);
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
            panelPositionTable.Location = new Point(739, 192);
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
            panelInjuredPlayers.Location = new Point(739, 574);
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
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 754);
            Controls.Add(panelInjuredPlayers);
            Controls.Add(panelPositionTable);
            Controls.Add(panelObjetiveSeason);
            Controls.Add(panelWins);
            Controls.Add(panelNextMach);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerForm";
            Text = "ManagerForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbManager).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelCoach;
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
        private FontAwesome.Sharp.IconButton ibtCalendar;
        private FontAwesome.Sharp.IconButton ibtInjured;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private FontAwesome.Sharp.IconButton ibPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbManager;
    }
}