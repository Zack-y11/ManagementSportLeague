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
            displayCornersLabel = new Label();
            avgAttendance = new Label();
            seasonPanel = new Panel();
            displaySeasonProgressLabel = new Label();
            seasonProgressLabel = new Label();
            goalsPanel = new Panel();
            displayTotaFoulsLabel = new Label();
            totalGoalsLabel = new Label();
            matchesPanel = new Panel();
            totalMatchsLabel = new Label();
            panel2 = new Panel();
            leagueTapControl = new TabControl();
            teamPage = new TabPage();
            leagueTableDataGrip = new DataGridView();
            scoresPage = new TabPage();
            topScoresDataGrip = new DataGridView();
            perfomancePage = new TabPage();
            updateChartBtn = new FontAwesome.Sharp.IconButton();
            perfomanceChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            perfomanceDataGrip = new DataGridView();
            totalMatchesLabel = new Label();
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
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            statsHeaderTable.Controls.Add(avgPanel, 2, 0);
            statsHeaderTable.Controls.Add(seasonPanel, 3, 0);
            statsHeaderTable.Controls.Add(goalsPanel, 1, 0);
            statsHeaderTable.Controls.Add(matchesPanel, 0, 0);
            statsHeaderTable.Dock = DockStyle.Top;
            statsHeaderTable.Location = new Point(0, 0);
            statsHeaderTable.Margin = new Padding(3, 2, 3, 2);
            statsHeaderTable.Name = "statsHeaderTable";
            statsHeaderTable.RowCount = 1;
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            statsHeaderTable.Size = new Size(1199, 94);
            statsHeaderTable.TabIndex = 0;
            // 
            // avgPanel
            // 
            avgPanel.Controls.Add(displayCornersLabel);
            avgPanel.Controls.Add(avgAttendance);
            avgPanel.Location = new Point(632, 2);
            avgPanel.Margin = new Padding(3, 2, 3, 2);
            avgPanel.Name = "avgPanel";
            avgPanel.Size = new Size(314, 89);
            avgPanel.TabIndex = 2;
            // 
            // displayCornersLabel
            // 
            displayCornersLabel.AutoSize = true;
            displayCornersLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayCornersLabel.ForeColor = Color.Green;
            displayCornersLabel.Location = new Point(25, 44);
            displayCornersLabel.Name = "displayCornersLabel";
            displayCornersLabel.Size = new Size(52, 19);
            displayCornersLabel.TabIndex = 2;
            displayCornersLabel.Text = "label1";
            // 
            // avgAttendance
            // 
            avgAttendance.AutoSize = true;
            avgAttendance.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            avgAttendance.Location = new Point(25, 12);
            avgAttendance.Name = "avgAttendance";
            avgAttendance.Size = new Size(105, 17);
            avgAttendance.TabIndex = 2;
            avgAttendance.Text = "Total Corners: ";
            // 
            // seasonPanel
            // 
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.Controls.Add(displaySeasonProgressLabel);
            seasonPanel.Controls.Add(seasonProgressLabel);
            seasonPanel.Location = new Point(952, 2);
            seasonPanel.Margin = new Padding(3, 2, 3, 2);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(244, 89);
            seasonPanel.TabIndex = 3;
            // 
            // displaySeasonProgressLabel
            // 
            displaySeasonProgressLabel.AutoSize = true;
            displaySeasonProgressLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaySeasonProgressLabel.ForeColor = Color.Indigo;
            displaySeasonProgressLabel.Location = new Point(53, 44);
            displaySeasonProgressLabel.Name = "displaySeasonProgressLabel";
            displaySeasonProgressLabel.Size = new Size(52, 19);
            displaySeasonProgressLabel.TabIndex = 2;
            displaySeasonProgressLabel.Text = "label1";
            // 
            // seasonProgressLabel
            // 
            seasonProgressLabel.AutoSize = true;
            seasonProgressLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            seasonProgressLabel.Location = new Point(45, 12);
            seasonProgressLabel.Name = "seasonProgressLabel";
            seasonProgressLabel.Size = new Size(121, 17);
            seasonProgressLabel.TabIndex = 3;
            seasonProgressLabel.Text = "Season Progress:";
            // 
            // goalsPanel
            // 
            goalsPanel.BackColor = Color.Transparent;
            goalsPanel.Controls.Add(displayTotaFoulsLabel);
            goalsPanel.Controls.Add(totalGoalsLabel);
            goalsPanel.Location = new Point(295, 2);
            goalsPanel.Margin = new Padding(3, 2, 3, 2);
            goalsPanel.Name = "goalsPanel";
            goalsPanel.Size = new Size(331, 89);
            goalsPanel.TabIndex = 1;
            // 
            // displayTotaFoulsLabel
            // 
            displayTotaFoulsLabel.AutoSize = true;
            displayTotaFoulsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayTotaFoulsLabel.ForeColor = Color.DeepSkyBlue;
            displayTotaFoulsLabel.Location = new Point(12, 44);
            displayTotaFoulsLabel.Name = "displayTotaFoulsLabel";
            displayTotaFoulsLabel.Size = new Size(52, 19);
            displayTotaFoulsLabel.TabIndex = 2;
            displayTotaFoulsLabel.Text = "label1";
            // 
            // totalGoalsLabel
            // 
            totalGoalsLabel.AutoSize = true;
            totalGoalsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalGoalsLabel.Location = new Point(12, 12);
            totalGoalsLabel.Name = "totalGoalsLabel";
            totalGoalsLabel.Size = new Size(82, 17);
            totalGoalsLabel.TabIndex = 1;
            totalGoalsLabel.Text = "Total Fouls:";
            // 
            // matchesPanel
            // 
            matchesPanel.BackColor = Color.Transparent;
            matchesPanel.Controls.Add(totalMatchesLabel);
            matchesPanel.Controls.Add(totalMatchsLabel);
            matchesPanel.Location = new Point(3, 2);
            matchesPanel.Margin = new Padding(3, 2, 3, 2);
            matchesPanel.Name = "matchesPanel";
            matchesPanel.Size = new Size(286, 89);
            matchesPanel.TabIndex = 0;
            // 
            // totalMatchsLabel
            // 
            totalMatchsLabel.AutoSize = true;
            totalMatchsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalMatchsLabel.Location = new Point(23, 12);
            totalMatchsLabel.Name = "totalMatchsLabel";
            totalMatchsLabel.Size = new Size(106, 17);
            totalMatchsLabel.TabIndex = 0;
            totalMatchsLabel.Text = "Total Matches:";
            // 
            // panel2
            // 
            panel2.Controls.Add(leagueTapControl);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 448);
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
            leagueTapControl.Margin = new Padding(3, 2, 3, 2);
            leagueTapControl.Name = "leagueTapControl";
            leagueTapControl.SelectedIndex = 0;
            leagueTapControl.Size = new Size(1199, 448);
            leagueTapControl.TabIndex = 0;
            // 
            // teamPage
            // 
            teamPage.Controls.Add(leagueTableDataGrip);
            teamPage.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamPage.Location = new Point(4, 31);
            teamPage.Margin = new Padding(3, 2, 3, 2);
            teamPage.Name = "teamPage";
            teamPage.Padding = new Padding(3, 2, 3, 2);
            teamPage.Size = new Size(1191, 413);
            teamPage.TabIndex = 0;
            teamPage.Text = "League Table";
            teamPage.UseVisualStyleBackColor = true;
            // 
            // leagueTableDataGrip
            // 
            leagueTableDataGrip.BackgroundColor = SystemColors.ControlLight;
            leagueTableDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leagueTableDataGrip.Dock = DockStyle.Fill;
            leagueTableDataGrip.GridColor = SystemColors.ScrollBar;
            leagueTableDataGrip.Location = new Point(3, 2);
            leagueTableDataGrip.Margin = new Padding(3, 2, 3, 2);
            leagueTableDataGrip.Name = "leagueTableDataGrip";
            leagueTableDataGrip.RowHeadersWidth = 51;
            leagueTableDataGrip.Size = new Size(1185, 409);
            leagueTableDataGrip.TabIndex = 1;
            // 
            // scoresPage
            // 
            scoresPage.Controls.Add(topScoresDataGrip);
            scoresPage.Location = new Point(4, 31);
            scoresPage.Margin = new Padding(3, 2, 3, 2);
            scoresPage.Name = "scoresPage";
            scoresPage.Padding = new Padding(3, 2, 3, 2);
            scoresPage.Size = new Size(1191, 413);
            scoresPage.TabIndex = 1;
            scoresPage.Text = "Top Scores";
            scoresPage.UseVisualStyleBackColor = true;
            // 
            // topScoresDataGrip
            // 
            topScoresDataGrip.BackgroundColor = SystemColors.ControlLight;
            topScoresDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            topScoresDataGrip.Location = new Point(129, 0);
            topScoresDataGrip.Margin = new Padding(3, 2, 3, 2);
            topScoresDataGrip.Name = "topScoresDataGrip";
            topScoresDataGrip.RowHeadersWidth = 51;
            topScoresDataGrip.Size = new Size(484, 288);

            topScoresDataGrip.TabIndex = 0;
            // 
            // perfomancePage
            // 
            perfomancePage.Controls.Add(updateChartBtn);
            perfomancePage.Controls.Add(perfomanceChart);
            perfomancePage.Controls.Add(perfomanceDataGrip);
            perfomancePage.Location = new Point(4, 31);
            perfomancePage.Margin = new Padding(3, 2, 3, 2);
            perfomancePage.Name = "perfomancePage";
            perfomancePage.Padding = new Padding(3, 2, 3, 2);
            perfomancePage.Size = new Size(1191, 413);
            perfomancePage.TabIndex = 2;
            perfomancePage.Text = "Perfomance";
            perfomancePage.UseVisualStyleBackColor = true;
            // 
            // updateChartBtn
            // 
            updateChartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateChartBtn.BackColor = SystemColors.HotTrack;
            updateChartBtn.ForeColor = SystemColors.ControlLight;
            updateChartBtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            updateChartBtn.IconColor = Color.White;
            updateChartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            updateChartBtn.ImageAlign = ContentAlignment.MiddleLeft;

            updateChartBtn.Location = new Point(357, 352);
            updateChartBtn.Margin = new Padding(3, 2, 3, 2);
            updateChartBtn.Name = "updateChartBtn";
            updateChartBtn.Size = new Size(236, 40);

            updateChartBtn.TabIndex = 3;
            updateChartBtn.Text = "Update Data";
            updateChartBtn.UseVisualStyleBackColor = false;
            updateChartBtn.Click += updateChartBtn_Click;
            // 
            // perfomanceChart
            // 
            perfomanceChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            perfomanceChart.BackColor = SystemColors.ControlDark;

            perfomanceChart.Location = new Point(4, 122);
            perfomanceChart.Margin = new Padding(3, 2, 3, 2);
            perfomanceChart.Name = "perfomanceChart";
            perfomanceChart.Size = new Size(971, 214);

            perfomanceChart.TabIndex = 2;
            // 
            // perfomanceDataGrip
            // 
            perfomanceDataGrip.AllowUserToDeleteRows = false;
            perfomanceDataGrip.AllowUserToResizeColumns = false;
            perfomanceDataGrip.AllowUserToResizeRows = false;
            perfomanceDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            perfomanceDataGrip.BackgroundColor = SystemColors.ControlLight;
            perfomanceDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            perfomanceDataGrip.Location = new Point(4, 0);
            perfomanceDataGrip.Margin = new Padding(3, 2, 3, 2);
            perfomanceDataGrip.Name = "perfomanceDataGrip";
            perfomanceDataGrip.RowHeadersWidth = 51;
            perfomanceDataGrip.Size = new Size(971, 118);

            perfomanceDataGrip.TabIndex = 1;
            // 
            // totalMatchesLabel
            // 
            totalMatchesLabel.AutoSize = true;
            totalMatchesLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalMatchesLabel.ForeColor = Color.Red;
            totalMatchesLabel.Location = new Point(23, 44);
            totalMatchesLabel.Name = "totalMatchesLabel";
            totalMatchesLabel.Size = new Size(52, 19);
            totalMatchesLabel.TabIndex = 3;
            totalMatchesLabel.Text = "label1";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 542);
            Controls.Add(panel2);
            Controls.Add(statsHeaderTable);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label avgAttendance;
        private Label totalGoalsLabel;
        private Label seasonProgressLabel;
        private Label displayTotaFoulsLabel;
        private Label displayCornersLabel;
        private Label displaySeasonProgressLabel;
        private Panel panel2;
        private TabControl leagueTapControl;
        private TabPage teamPage;
        private TabPage scoresPage;
        private TabPage perfomancePage;
        private DataGridView leagueTableDataGrip;
        private DataGridView topScoresDataGrip;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart perfomanceChart;
        private DataGridView perfomanceDataGrip;
        private FontAwesome.Sharp.IconButton updateChartBtn;
        private Label totalMatchesLabel;
    }
}