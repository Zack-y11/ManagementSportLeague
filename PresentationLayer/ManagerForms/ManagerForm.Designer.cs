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
            labelLeague = new Label();
            labelSeason = new Label();
            labelCoach = new Label();
            panel1 = new Panel();
            labelTimeNextMatch = new Label();
            labelRival = new Label();
            labelNextMatch = new Label();
            panel2 = new Panel();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panel3 = new Panel();
            ipbTrophy = new FontAwesome.Sharp.IconPictureBox();
            labelObjetiveStatus = new Label();
            labelObejtiveCompetition = new Label();
            labelObejtive = new Label();
            panelPositionTable = new Panel();
            label1 = new Label();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            ipbCalendar = new FontAwesome.Sharp.IconPictureBox();
            panelInjuredPlayers = new Panel();
            labelInjuredPlayers = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).BeginInit();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).BeginInit();
            panelInjuredPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelLeague);
            panelHeader.Controls.Add(labelSeason);
            panelHeader.Controls.Add(labelCoach);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1182, 125);
            panelHeader.TabIndex = 0;
            // 
            // labelLeague
            // 
            labelLeague.AutoSize = true;
            labelLeague.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLeague.Location = new Point(975, 54);
            labelLeague.Name = "labelLeague";
            labelLeague.Size = new Size(70, 19);
            labelLeague.TabIndex = 2;
            labelLeague.Text = "League";
            // 
            // labelSeason
            // 
            labelSeason.AutoSize = true;
            labelSeason.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeason.Location = new Point(362, 31);
            labelSeason.Name = "labelSeason";
            labelSeason.Size = new Size(74, 19);
            labelSeason.TabIndex = 1;
            labelSeason.Text = "Season ";
            // 
            // labelCoach
            // 
            labelCoach.AutoSize = true;
            labelCoach.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoach.Location = new Point(12, 21);
            labelCoach.Name = "labelCoach";
            labelCoach.Size = new Size(264, 34);
            labelCoach.TabIndex = 1;
            labelCoach.Text = "Dashboard Coach";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 99, 235);
            panel1.Controls.Add(ipbCalendar);
            panel1.Controls.Add(labelTimeNextMatch);
            panel1.Controls.Add(labelRival);
            panel1.Controls.Add(labelNextMatch);
            panel1.Location = new Point(80, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 152);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 163, 74);
            panel2.Controls.Add(ipbStar);
            panel2.Controls.Add(labelWinsNumber);
            panel2.Controls.Add(labelWins);
            panel2.Location = new Point(80, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 152);
            panel2.TabIndex = 3;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 138, 4);
            panel3.Controls.Add(ipbTrophy);
            panel3.Controls.Add(labelObjetiveStatus);
            panel3.Controls.Add(labelObejtiveCompetition);
            panel3.Controls.Add(labelObejtive);
            panel3.Location = new Point(80, 574);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 152);
            panel3.TabIndex = 4;
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
            panelPositionTable.Controls.Add(dataGridView1);
            panelPositionTable.Controls.Add(label1);
            panelPositionTable.Location = new Point(739, 192);
            panelPositionTable.Name = "panelPositionTable";
            panelPositionTable.Size = new Size(406, 347);
            panelPositionTable.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 6);
            label1.Name = "label1";
            label1.Size = new Size(165, 27);
            label1.TabIndex = 0;
            label1.Text = "Position Table";
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
            // panelInjuredPlayers
            // 
            panelInjuredPlayers.BackColor = Color.FromArgb(220, 38, 38);
            panelInjuredPlayers.Controls.Add(label2);
            panelInjuredPlayers.Controls.Add(iconPictureBox1);
            panelInjuredPlayers.Controls.Add(labelInjuredPlayers);
            panelInjuredPlayers.Location = new Point(739, 574);
            panelInjuredPlayers.Name = "panelInjuredPlayers";
            panelInjuredPlayers.Size = new Size(406, 152);
            panelInjuredPlayers.TabIndex = 6;
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
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(220, 38, 38);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(354, 11);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(179, 50);
            label2.Name = "label2";
            label2.Size = new Size(47, 51);
            label2.TabIndex = 4;
            label2.Text = "5";
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
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 754);
            Controls.Add(panelInjuredPlayers);
            Controls.Add(panelPositionTable);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerForm";
            Text = "ManagerForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).EndInit();
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ipbCalendar).EndInit();
            panelInjuredPlayers.ResumeLayout(false);
            panelInjuredPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelCoach;
        private Label labelLeague;
        private Label labelSeason;
        private Panel panel1;
        private Label labelNextMatch;
        private Label labelTimeNextMatch;
        private Label labelRival;
        private Panel panel2;
        private Label labelWins;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label labelObejtive;
        private Label label1;
        private Label labelWinsNumber;
        private Label labelObjetiveStatus;
        private Label labelObejtiveCompetition;
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbTrophy;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private FontAwesome.Sharp.IconPictureBox ipbCalendar;
        private Panel panelInjuredPlayers;
        private Label labelInjuredPlayers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}