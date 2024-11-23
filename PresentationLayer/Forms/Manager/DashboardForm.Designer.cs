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
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            labelPositionTable = new Label();
            panelWins = new Panel();
            ipbStar = new FontAwesome.Sharp.IconPictureBox();
            labelWinsNumber = new Label();
            labelWins = new Label();
            panelGoals = new Panel();
            labelGoalsstatus = new Label();
            labelIGoalsNumber = new Label();
            ipbIGoals = new FontAwesome.Sharp.IconPictureBox();
            labelGoals = new Label();
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
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelWins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).BeginInit();
            panelGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbIGoals).BeginInit();
            panelNextMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).BeginInit();
            panelPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).BeginInit();
            SuspendLayout();
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
            // panelGoals
            // 
            panelGoals.BackColor = Color.FromArgb(220, 38, 38);
            panelGoals.Controls.Add(labelGoalsstatus);
            panelGoals.Controls.Add(labelIGoalsNumber);
            panelGoals.Controls.Add(ipbIGoals);
            panelGoals.Controls.Add(labelGoals);
            panelGoals.Location = new Point(612, 449);
            panelGoals.Name = "panelGoals";
            panelGoals.Size = new Size(406, 152);
            panelGoals.TabIndex = 11;
            // 
            // labelGoalsstatus
            // 
            labelGoalsstatus.AutoSize = true;
            labelGoalsstatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoalsstatus.ForeColor = Color.White;
            labelGoalsstatus.Location = new Point(15, 115);
            labelGoalsstatus.Name = "labelGoalsstatus";
            labelGoalsstatus.Size = new Size(171, 23);
            labelGoalsstatus.TabIndex = 5;
            labelGoalsstatus.Text = "En la temporada";
            // 
            // labelIGoalsNumber
            // 
            labelIGoalsNumber.AutoSize = true;
            labelIGoalsNumber.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIGoalsNumber.ForeColor = Color.White;
            labelIGoalsNumber.Location = new Point(179, 50);
            labelIGoalsNumber.Name = "labelIGoalsNumber";
            labelIGoalsNumber.Size = new Size(72, 51);
            labelIGoalsNumber.TabIndex = 4;
            labelIGoalsNumber.Text = "34";
            // 
            // ipbIGoals
            // 
            ipbIGoals.BackColor = Color.FromArgb(220, 38, 38);
            ipbIGoals.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            ipbIGoals.IconColor = Color.White;
            ipbIGoals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbIGoals.IconSize = 40;
            ipbIGoals.Location = new Point(354, 11);
            ipbIGoals.Name = "ipbIGoals";
            ipbIGoals.Size = new Size(40, 40);
            ipbIGoals.TabIndex = 1;
            ipbIGoals.TabStop = false;
            // 
            // labelGoals
            // 
            labelGoals.AutoSize = true;
            labelGoals.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoals.ForeColor = Color.White;
            labelGoals.Location = new Point(132, 0);
            labelGoals.Name = "labelGoals";
            labelGoals.Size = new Size(141, 23);
            labelGoals.TabIndex = 0;
            labelGoals.Text = "Goals Scored";
            // 
            // panelNextMach
            // 
            panelNextMach.BackColor = Color.FromArgb(37, 99, 235);
            panelNextMach.Controls.Add(ipbActivities);
            panelNextMach.Controls.Add(labelTimeNextMatch);
            panelNextMach.Controls.Add(labelRival);
            panelNextMach.Controls.Add(labelNextActivity);
            panelNextMach.Location = new Point(43, 234);
            panelNextMach.Name = "panelNextMach";
            panelNextMach.Size = new Size(505, 152);
            panelNextMach.TabIndex = 7;
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
            // labelNextActivity
            // 
            labelNextActivity.AutoSize = true;
            labelNextActivity.BackColor = Color.FromArgb(37, 99, 235);
            labelNextActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNextActivity.ForeColor = Color.White;
            labelNextActivity.Location = new Point(229, 9);
            labelNextActivity.Name = "labelNextActivity";
            labelNextActivity.Size = new Size(123, 23);
            labelNextActivity.TabIndex = 0;
            labelNextActivity.Text = "Next Match";
            // 
            // panelPlayers
            // 
            panelPlayers.BackColor = Color.FromArgb(202, 138, 4);
            panelPlayers.Controls.Add(ipbPlayers);
            panelPlayers.Controls.Add(labelPlayersStatus);
            panelPlayers.Controls.Add(labelPlayersNumber);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Location = new Point(43, 449);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(505, 152);
            panelPlayers.TabIndex = 9;
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
            labelPlayersStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersStatus.ForeColor = Color.White;
            labelPlayersStatus.Location = new Point(23, 115);
            labelPlayersStatus.Name = "labelPlayersStatus";
            labelPlayersStatus.Size = new Size(102, 23);
            labelPlayersStatus.TabIndex = 4;
            labelPlayersStatus.Text = "en activo";
            // 
            // labelPlayersNumber
            // 
            labelPlayersNumber.AutoSize = true;
            labelPlayersNumber.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayersNumber.ForeColor = Color.White;
            labelPlayersNumber.Location = new Point(13, 50);
            labelPlayersNumber.Name = "labelPlayersNumber";
            labelPlayersNumber.Size = new Size(236, 51);
            labelPlayersNumber.TabIndex = 3;
            labelPlayersNumber.Text = "21 Players";
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(134, 11);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(169, 23);
            labelPlayers.TabIndex = 0;
            labelPlayers.Text = "Players on Team";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 654);
            Controls.Add(panelPositionTable);
            Controls.Add(panelWins);
            Controls.Add(panelGoals);
            Controls.Add(panelNextMach);
            Controls.Add(panelPlayers);
            Name = "DashboardForm";
            Text = "DashboardForm";
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelWins.ResumeLayout(false);
            panelWins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbStar).EndInit();
            panelGoals.ResumeLayout(false);
            panelGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbIGoals).EndInit();
            panelNextMach.ResumeLayout(false);
            panelNextMach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbActivities).EndInit();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private DataGridView dataGridView1;
        private Label labelPositionTable;
        private Panel panelWins;
        private FontAwesome.Sharp.IconPictureBox ipbStar;
        private Label labelWinsNumber;
        private Label labelWins;
        private Panel panelGoals;
        private Label labelGoalsstatus;
        private Label labelIGoalsNumber;
        private FontAwesome.Sharp.IconPictureBox ipbIGoals;
        private Label labelGoals;
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
    }
}