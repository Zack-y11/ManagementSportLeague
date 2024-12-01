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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            leagueTableDataGrip = new DataGridView();
            teamPage = new TabPage();
            topScoresDataGrip = new DataGridView();
            scoresPage = new TabPage();
            perfomanceDataGrip = new DataGridView();
            perfomanceChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            updateChartBtn = new FontAwesome.Sharp.IconButton();
            perfomancePage = new TabPage();
            statsHeaderTable.SuspendLayout();
            avgPanel.SuspendLayout();
            seasonPanel.SuspendLayout();
            goalsPanel.SuspendLayout();
            matchesPanel.SuspendLayout();
            panel2.SuspendLayout();
            leagueTapControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leagueTableDataGrip).BeginInit();
            teamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)topScoresDataGrip).BeginInit();
            scoresPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)perfomanceDataGrip).BeginInit();
            perfomancePage.SuspendLayout();
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
            // leagueTableDataGrip
            // 
            leagueTableDataGrip.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            leagueTableDataGrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            leagueTableDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            leagueTableDataGrip.DefaultCellStyle = dataGridViewCellStyle11;
            leagueTableDataGrip.Dock = DockStyle.Fill;
            leagueTableDataGrip.GridColor = SystemColors.ScrollBar;
            leagueTableDataGrip.Location = new Point(3, 3);
            leagueTableDataGrip.Name = "leagueTableDataGrip";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            leagueTableDataGrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            leagueTableDataGrip.RowHeadersWidth = 51;
            leagueTableDataGrip.Size = new Size(1364, 553);
            leagueTableDataGrip.TabIndex = 1;
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
            // topScoresDataGrip
            // 
            topScoresDataGrip.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            topScoresDataGrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            topScoresDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            topScoresDataGrip.DefaultCellStyle = dataGridViewCellStyle5;
            topScoresDataGrip.Dock = DockStyle.Fill;
            topScoresDataGrip.Location = new Point(3, 3);
            topScoresDataGrip.Name = "topScoresDataGrip";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            topScoresDataGrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            topScoresDataGrip.RowHeadersWidth = 51;
            topScoresDataGrip.Size = new Size(1364, 553);
            topScoresDataGrip.TabIndex = 0;
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
            // perfomanceDataGrip
            // 
            perfomanceDataGrip.AllowUserToDeleteRows = false;
            perfomanceDataGrip.AllowUserToResizeColumns = false;
            perfomanceDataGrip.AllowUserToResizeRows = false;
            perfomanceDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            perfomanceDataGrip.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            perfomanceDataGrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            perfomanceDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            perfomanceDataGrip.DefaultCellStyle = dataGridViewCellStyle8;
            perfomanceDataGrip.Location = new Point(3, 3);
            perfomanceDataGrip.Name = "perfomanceDataGrip";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            perfomanceDataGrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            perfomanceDataGrip.RowHeadersWidth = 51;
            perfomanceDataGrip.Size = new Size(1364, 184);
            perfomanceDataGrip.TabIndex = 1;
            // 
            // perfomanceChart
            // 
            perfomanceChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            perfomanceChart.BackColor = SystemColors.ControlDark;
            perfomanceChart.Location = new Point(3, 193);
            perfomanceChart.Name = "perfomanceChart";
            perfomanceChart.Size = new Size(1359, 298);
            perfomanceChart.TabIndex = 2;
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
            updateChartBtn.Location = new Point(392, 499);
            updateChartBtn.Name = "updateChartBtn";
            updateChartBtn.Size = new Size(514, 54);
            updateChartBtn.TabIndex = 3;
            updateChartBtn.Text = "Update Data";
            updateChartBtn.UseVisualStyleBackColor = false;
            updateChartBtn.Click += updateChartBtn_Click;
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
            ((System.ComponentModel.ISupportInitialize)leagueTableDataGrip).EndInit();
            teamPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)topScoresDataGrip).EndInit();
            scoresPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)perfomanceDataGrip).EndInit();
            perfomancePage.ResumeLayout(false);
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
        private DataGridView leagueTableDataGrip;
        private TabPage scoresPage;
        private DataGridView topScoresDataGrip;
        private TabPage perfomancePage;
        private FontAwesome.Sharp.IconButton updateChartBtn;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart perfomanceChart;
        private DataGridView perfomanceDataGrip;
    }
}