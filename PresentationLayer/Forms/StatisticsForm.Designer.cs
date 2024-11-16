namespace PresentationLayer.Forms
{
    partial class StatisticsForm
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
            statsHeaderTable = new TableLayoutPanel();
            avgPanel = new Panel();
            displayAvgLabel = new Label();
            AvgAttendance = new Label();
            seasonPanel = new Panel();
            displaySeasonProgressLabel = new Label();
            seasonProgressLabel = new Label();
            goalsPanel = new Panel();
            displayTotalGoalsLabel = new Label();
            totalGoalsLabel = new Label();
            matchesPanel = new Panel();
            displayMatchesLabel = new Label();
            totalMatchsLabel = new Label();
            panel2 = new Panel();
            leagueTapControl = new TabControl();
            teamPage = new TabPage();
            leagueTableDataGrip = new DataGridView();
            teamsColumn = new DataGridViewTextBoxColumn();
            playedColumn = new DataGridViewTextBoxColumn();
            winColumn = new DataGridViewTextBoxColumn();
            loseColumn = new DataGridViewTextBoxColumn();
            drawColumn = new DataGridViewTextBoxColumn();
            goalsFcolumn = new DataGridViewTextBoxColumn();
            goalsAcolumn = new DataGridViewTextBoxColumn();
            pointsColumn = new DataGridViewTextBoxColumn();
            scoresPage = new TabPage();
            topScoresDataGrip = new DataGridView();
            playerColumn = new DataGridViewTextBoxColumn();
            teamColumn = new DataGridViewTextBoxColumn();
            goalsColumn = new DataGridViewTextBoxColumn();
            assistsColumn = new DataGridViewTextBoxColumn();
            perfomancePage = new TabPage();
            updateChartBtn = new FontAwesome.Sharp.IconButton();
            perfomanceChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            perfomanceDataGrip = new DataGridView();
            statsHeaderTable.SuspendLayout();
            avgPanel.SuspendLayout();
            seasonPanel.SuspendLayout();
            goalsPanel.SuspendLayout();
            matchesPanel.SuspendLayout();
            panel2.SuspendLayout();
            leagueTapControl.SuspendLayout();
            teamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leagueTableDataGrip).BeginInit();
            scoresPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)topScoresDataGrip).BeginInit();
            perfomancePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)perfomanceDataGrip).BeginInit();
            SuspendLayout();
            // 
            // statsHeaderTable
            // 
            statsHeaderTable.BackColor = Color.White;
            statsHeaderTable.ColumnCount = 4;
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3567848F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.6432152F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 366F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 284F));
            statsHeaderTable.Controls.Add(avgPanel, 2, 0);
            statsHeaderTable.Controls.Add(seasonPanel, 3, 0);
            statsHeaderTable.Controls.Add(goalsPanel, 1, 0);
            statsHeaderTable.Controls.Add(matchesPanel, 0, 0);
            statsHeaderTable.Dock = DockStyle.Top;
            statsHeaderTable.Location = new Point(0, 0);
            statsHeaderTable.Name = "statsHeaderTable";
            statsHeaderTable.RowCount = 1;
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            statsHeaderTable.Size = new Size(1378, 125);
            statsHeaderTable.TabIndex = 0;
            // 
            // avgPanel
            // 
            avgPanel.Controls.Add(displayAvgLabel);
            avgPanel.Controls.Add(AvgAttendance);
            avgPanel.Location = new Point(730, 3);
            avgPanel.Name = "avgPanel";
            avgPanel.Size = new Size(360, 119);
            avgPanel.TabIndex = 2;
            // 
            // displayAvgLabel
            // 
            displayAvgLabel.AutoSize = true;
            displayAvgLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayAvgLabel.ForeColor = Color.Green;
            displayAvgLabel.Location = new Point(29, 58);
            displayAvgLabel.Name = "displayAvgLabel";
            displayAvgLabel.Size = new Size(60, 21);
            displayAvgLabel.TabIndex = 2;
            displayAvgLabel.Text = "label1";
            // 
            // AvgAttendance
            // 
            AvgAttendance.AutoSize = true;
            AvgAttendance.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AvgAttendance.Location = new Point(29, 16);
            AvgAttendance.Name = "AvgAttendance";
            AvgAttendance.Size = new Size(151, 21);
            AvgAttendance.TabIndex = 2;
            AvgAttendance.Text = "Avg Attendance:";
            // 
            // seasonPanel
            // 
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.Controls.Add(displaySeasonProgressLabel);
            seasonPanel.Controls.Add(seasonProgressLabel);
            seasonPanel.Location = new Point(1096, 3);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(279, 119);
            seasonPanel.TabIndex = 3;
            // 
            // displaySeasonProgressLabel
            // 
            displaySeasonProgressLabel.AutoSize = true;
            displaySeasonProgressLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaySeasonProgressLabel.ForeColor = Color.Indigo;
            displaySeasonProgressLabel.Location = new Point(61, 58);
            displaySeasonProgressLabel.Name = "displaySeasonProgressLabel";
            displaySeasonProgressLabel.Size = new Size(60, 21);
            displaySeasonProgressLabel.TabIndex = 2;
            displaySeasonProgressLabel.Text = "label1";
            // 
            // seasonProgressLabel
            // 
            seasonProgressLabel.AutoSize = true;
            seasonProgressLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            seasonProgressLabel.Location = new Point(51, 16);
            seasonProgressLabel.Name = "seasonProgressLabel";
            seasonProgressLabel.Size = new Size(146, 21);
            seasonProgressLabel.TabIndex = 3;
            seasonProgressLabel.Text = "Season Progress:";
            // 
            // goalsPanel
            // 
            goalsPanel.BackColor = Color.Transparent;
            goalsPanel.Controls.Add(displayTotalGoalsLabel);
            goalsPanel.Controls.Add(totalGoalsLabel);
            goalsPanel.Location = new Point(340, 3);
            goalsPanel.Name = "goalsPanel";
            goalsPanel.Size = new Size(384, 119);
            goalsPanel.TabIndex = 1;
            // 
            // displayTotalGoalsLabel
            // 
            displayTotalGoalsLabel.AutoSize = true;
            displayTotalGoalsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayTotalGoalsLabel.ForeColor = Color.DeepSkyBlue;
            displayTotalGoalsLabel.Location = new Point(14, 58);
            displayTotalGoalsLabel.Name = "displayTotalGoalsLabel";
            displayTotalGoalsLabel.Size = new Size(60, 21);
            displayTotalGoalsLabel.TabIndex = 2;
            displayTotalGoalsLabel.Text = "label1";
            // 
            // totalGoalsLabel
            // 
            totalGoalsLabel.AutoSize = true;
            totalGoalsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalGoalsLabel.Location = new Point(14, 16);
            totalGoalsLabel.Name = "totalGoalsLabel";
            totalGoalsLabel.Size = new Size(105, 21);
            totalGoalsLabel.TabIndex = 1;
            totalGoalsLabel.Text = "Total Goals:";
            // 
            // matchesPanel
            // 
            matchesPanel.BackColor = Color.Transparent;
            matchesPanel.Controls.Add(displayMatchesLabel);
            matchesPanel.Controls.Add(totalMatchsLabel);
            matchesPanel.Location = new Point(3, 3);
            matchesPanel.Name = "matchesPanel";
            matchesPanel.Size = new Size(331, 119);
            matchesPanel.TabIndex = 0;
            // 
            // displayMatchesLabel
            // 
            displayMatchesLabel.AutoSize = true;
            displayMatchesLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayMatchesLabel.ForeColor = Color.Goldenrod;
            displayMatchesLabel.Location = new Point(26, 58);
            displayMatchesLabel.Name = "displayMatchesLabel";
            displayMatchesLabel.Size = new Size(60, 21);
            displayMatchesLabel.TabIndex = 1;
            displayMatchesLabel.Text = "label1";
            // 
            // totalMatchsLabel
            // 
            totalMatchsLabel.AutoSize = true;
            totalMatchsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalMatchsLabel.Location = new Point(26, 16);
            totalMatchsLabel.Name = "totalMatchsLabel";
            totalMatchsLabel.Size = new Size(128, 21);
            totalMatchsLabel.TabIndex = 0;
            totalMatchsLabel.Text = "Total Matches:";
            // 
            // panel2
            // 
            panel2.Controls.Add(leagueTapControl);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1378, 598);
            panel2.TabIndex = 2;
            // 
            // leagueTapControl
            // 
            leagueTapControl.Appearance = TabAppearance.FlatButtons;
            leagueTapControl.Controls.Add(teamPage);
            leagueTapControl.Controls.Add(scoresPage);
            leagueTapControl.Controls.Add(perfomancePage);
            leagueTapControl.Dock = DockStyle.Fill;
            leagueTapControl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leagueTapControl.Location = new Point(0, 0);
            leagueTapControl.Name = "leagueTapControl";
            leagueTapControl.SelectedIndex = 0;
            leagueTapControl.Size = new Size(1378, 598);
            leagueTapControl.TabIndex = 0;
            // 
            // teamPage
            // 
            teamPage.Controls.Add(leagueTableDataGrip);
            teamPage.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamPage.Location = new Point(4, 35);
            teamPage.Name = "teamPage";
            teamPage.Padding = new Padding(3);
            teamPage.Size = new Size(1370, 559);
            teamPage.TabIndex = 0;
            teamPage.Text = "League Table";
            teamPage.UseVisualStyleBackColor = true;
            // 
            // leagueTableDataGrip
            // 
            leagueTableDataGrip.BackgroundColor = SystemColors.ControlLight;
            leagueTableDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leagueTableDataGrip.Columns.AddRange(new DataGridViewColumn[] { teamsColumn, playedColumn, winColumn, loseColumn, drawColumn, goalsFcolumn, goalsAcolumn, pointsColumn });
            leagueTableDataGrip.Dock = DockStyle.Fill;
            leagueTableDataGrip.GridColor = SystemColors.ScrollBar;
            leagueTableDataGrip.Location = new Point(3, 3);
            leagueTableDataGrip.Name = "leagueTableDataGrip";
            leagueTableDataGrip.RowHeadersWidth = 51;
            leagueTableDataGrip.Size = new Size(1364, 553);
            leagueTableDataGrip.TabIndex = 1;
            // 
            // teamsColumn
            // 
            teamsColumn.HeaderText = "Team";
            teamsColumn.MinimumWidth = 6;
            teamsColumn.Name = "teamsColumn";
            teamsColumn.Resizable = DataGridViewTriState.False;
            teamsColumn.Width = 125;
            // 
            // playedColumn
            // 
            playedColumn.HeaderText = "Played";
            playedColumn.MinimumWidth = 6;
            playedColumn.Name = "playedColumn";
            playedColumn.Width = 125;
            // 
            // winColumn
            // 
            winColumn.HeaderText = "Wins";
            winColumn.MinimumWidth = 6;
            winColumn.Name = "winColumn";
            winColumn.Width = 125;
            // 
            // loseColumn
            // 
            loseColumn.HeaderText = "Losses";
            loseColumn.MinimumWidth = 6;
            loseColumn.Name = "loseColumn";
            loseColumn.Width = 125;
            // 
            // drawColumn
            // 
            drawColumn.HeaderText = "Draws";
            drawColumn.MinimumWidth = 6;
            drawColumn.Name = "drawColumn";
            drawColumn.Width = 125;
            // 
            // goalsFcolumn
            // 
            goalsFcolumn.HeaderText = "Goals For";
            goalsFcolumn.MinimumWidth = 6;
            goalsFcolumn.Name = "goalsFcolumn";
            goalsFcolumn.Width = 125;
            // 
            // goalsAcolumn
            // 
            goalsAcolumn.HeaderText = "Goals Agains";
            goalsAcolumn.MinimumWidth = 6;
            goalsAcolumn.Name = "goalsAcolumn";
            goalsAcolumn.Width = 125;
            // 
            // pointsColumn
            // 
            pointsColumn.HeaderText = "Points";
            pointsColumn.MinimumWidth = 6;
            pointsColumn.Name = "pointsColumn";
            pointsColumn.Width = 125;
            // 
            // scoresPage
            // 
            scoresPage.Controls.Add(topScoresDataGrip);
            scoresPage.Location = new Point(4, 35);
            scoresPage.Name = "scoresPage";
            scoresPage.Padding = new Padding(3);
            scoresPage.Size = new Size(1370, 559);
            scoresPage.TabIndex = 1;
            scoresPage.Text = "Top Scores";
            scoresPage.UseVisualStyleBackColor = true;
            // 
            // topScoresDataGrip
            // 
            topScoresDataGrip.BackgroundColor = SystemColors.ControlLight;
            topScoresDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            topScoresDataGrip.Columns.AddRange(new DataGridViewColumn[] { playerColumn, teamColumn, goalsColumn, assistsColumn });
            topScoresDataGrip.Location = new Point(147, 0);
            topScoresDataGrip.Name = "topScoresDataGrip";
            topScoresDataGrip.RowHeadersWidth = 51;
            topScoresDataGrip.Size = new Size(553, 384);
            topScoresDataGrip.TabIndex = 0;
            // 
            // playerColumn
            // 
            playerColumn.HeaderText = "Player";
            playerColumn.MinimumWidth = 6;
            playerColumn.Name = "playerColumn";
            playerColumn.Resizable = DataGridViewTriState.False;
            playerColumn.Width = 125;
            // 
            // teamColumn
            // 
            teamColumn.HeaderText = "Team";
            teamColumn.MinimumWidth = 6;
            teamColumn.Name = "teamColumn";
            teamColumn.Width = 125;
            // 
            // goalsColumn
            // 
            goalsColumn.HeaderText = "Goals";
            goalsColumn.MinimumWidth = 6;
            goalsColumn.Name = "goalsColumn";
            goalsColumn.Width = 125;
            // 
            // assistsColumn
            // 
            assistsColumn.HeaderText = "Assists";
            assistsColumn.MinimumWidth = 6;
            assistsColumn.Name = "assistsColumn";
            assistsColumn.Width = 125;
            // 
            // perfomancePage
            // 
            perfomancePage.Controls.Add(updateChartBtn);
            perfomancePage.Controls.Add(perfomanceChart);
            perfomancePage.Controls.Add(perfomanceDataGrip);
            perfomancePage.Location = new Point(4, 35);
            perfomancePage.Name = "perfomancePage";
            perfomancePage.Padding = new Padding(3);
            perfomancePage.Size = new Size(1370, 559);
            perfomancePage.TabIndex = 2;
            perfomancePage.Text = "Perfomance";
            perfomancePage.UseVisualStyleBackColor = true;
            // 
            // updateChartBtn
            // 
            updateChartBtn.BackColor = SystemColors.HotTrack;
            updateChartBtn.ForeColor = SystemColors.ControlLight;
            updateChartBtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            updateChartBtn.IconColor = Color.White;
            updateChartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateChartBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateChartBtn.Location = new Point(408, 470);
            updateChartBtn.Name = "updateChartBtn";
            updateChartBtn.Size = new Size(270, 54);
            updateChartBtn.TabIndex = 3;
            updateChartBtn.Text = "Update Data";
            updateChartBtn.UseVisualStyleBackColor = false;
            updateChartBtn.Click += updateChartBtn_Click;
            // 
            // perfomanceChart
            // 
            perfomanceChart.BackColor = SystemColors.ControlDark;
            perfomanceChart.Location = new Point(4, 163);
            perfomanceChart.Name = "perfomanceChart";
            perfomanceChart.Size = new Size(1110, 286);
            perfomanceChart.TabIndex = 2;
            // 
            // perfomanceDataGrip
            // 
            perfomanceDataGrip.AllowUserToDeleteRows = false;
            perfomanceDataGrip.AllowUserToResizeColumns = false;
            perfomanceDataGrip.AllowUserToResizeRows = false;
            perfomanceDataGrip.BackgroundColor = SystemColors.ControlLight;
            perfomanceDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            perfomanceDataGrip.Location = new Point(4, 0);
            perfomanceDataGrip.Name = "perfomanceDataGrip";
            perfomanceDataGrip.RowHeadersWidth = 51;
            perfomanceDataGrip.Size = new Size(1110, 157);
            perfomanceDataGrip.TabIndex = 1;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 723);
            Controls.Add(panel2);
            Controls.Add(statsHeaderTable);
            Name = "StatisticsForm";
            Text = "x";
            statsHeaderTable.ResumeLayout(false);
            avgPanel.ResumeLayout(false);
            avgPanel.PerformLayout();
            seasonPanel.ResumeLayout(false);
            seasonPanel.PerformLayout();
            goalsPanel.ResumeLayout(false);
            goalsPanel.PerformLayout();
            matchesPanel.ResumeLayout(false);
            matchesPanel.PerformLayout();
            panel2.ResumeLayout(false);
            leagueTapControl.ResumeLayout(false);
            teamPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leagueTableDataGrip).EndInit();
            scoresPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)topScoresDataGrip).EndInit();
            perfomancePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)perfomanceDataGrip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel statsHeaderTable;
        private Panel seasonPanel;
        private Panel avgPanel;
        private Panel goalsPanel;
        private Panel matchesPanel;
        private Label totalMatchsLabel;
        private Label AvgAttendance;
        private Label totalGoalsLabel;
        private Label seasonProgressLabel;
        private Label displayTotalGoalsLabel;
        private Label displayMatchesLabel;
        private Label displayAvgLabel;
        private Label displaySeasonProgressLabel;
        private Panel panel2;
        private TabControl leagueTapControl;
        private TabPage teamPage;
        private TabPage scoresPage;
        private TabPage perfomancePage;
        private DataGridView leagueTableDataGrip;
        private DataGridView topScoresDataGrip;
        private DataGridViewTextBoxColumn teamsColumn;
        private DataGridViewTextBoxColumn playedColumn;
        private DataGridViewTextBoxColumn winColumn;
        private DataGridViewTextBoxColumn loseColumn;
        private DataGridViewTextBoxColumn drawColumn;
        private DataGridViewTextBoxColumn goalsFcolumn;
        private DataGridViewTextBoxColumn goalsAcolumn;
        private DataGridViewTextBoxColumn pointsColumn;
        private DataGridViewTextBoxColumn playerColumn;
        private DataGridViewTextBoxColumn teamColumn;
        private DataGridViewTextBoxColumn goalsColumn;
        private DataGridViewTextBoxColumn assistsColumn;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart perfomanceChart;
        private DataGridView perfomanceDataGrip;
        private FontAwesome.Sharp.IconButton updateChartBtn;
    }
}