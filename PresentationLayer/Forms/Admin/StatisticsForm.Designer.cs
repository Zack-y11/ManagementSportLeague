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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            totalMatchesLabel = new Label();
            totalMatchsLabel = new Label();
            panel2 = new Panel();
            leagueTapControl = new TabControl();
            teamPage = new TabPage();
            leagueTableDataGrip = new DataGridView();
            statsHeaderTable.SuspendLayout();
            avgPanel.SuspendLayout();
            seasonPanel.SuspendLayout();
            goalsPanel.SuspendLayout();
            matchesPanel.SuspendLayout();
            panel2.SuspendLayout();
            leagueTapControl.SuspendLayout();
            teamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leagueTableDataGrip).BeginInit();
            SuspendLayout();
            // 
            // statsHeaderTable
            // 
            statsHeaderTable.BackColor = Color.White;
            statsHeaderTable.ColumnCount = 4;
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3567848F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.6432152F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 366F));
            statsHeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 286F));
            statsHeaderTable.Controls.Add(avgPanel, 2, 0);
            statsHeaderTable.Controls.Add(seasonPanel, 3, 0);
            statsHeaderTable.Controls.Add(goalsPanel, 1, 0);
            statsHeaderTable.Controls.Add(matchesPanel, 0, 0);
            statsHeaderTable.Dock = DockStyle.Top;
            statsHeaderTable.Location = new Point(0, 0);
            statsHeaderTable.Name = "statsHeaderTable";
            statsHeaderTable.RowCount = 1;
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            statsHeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            statsHeaderTable.Size = new Size(1370, 125);
            statsHeaderTable.TabIndex = 0;
            // 
            // avgPanel
            // 
            avgPanel.Controls.Add(displayCornersLabel);
            avgPanel.Controls.Add(avgAttendance);
            avgPanel.Location = new Point(720, 3);
            avgPanel.Name = "avgPanel";
            avgPanel.Size = new Size(359, 119);
            avgPanel.TabIndex = 2;
            // 
            // displayCornersLabel
            // 
            displayCornersLabel.AutoSize = true;
            displayCornersLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayCornersLabel.ForeColor = Color.Green;
            displayCornersLabel.Location = new Point(29, 59);
            displayCornersLabel.Name = "displayCornersLabel";
            displayCornersLabel.Size = new Size(60, 21);
            displayCornersLabel.TabIndex = 2;
            displayCornersLabel.Text = "label1";
            // 
            // avgAttendance
            // 
            avgAttendance.AutoSize = true;
            avgAttendance.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            avgAttendance.Location = new Point(29, 16);
            avgAttendance.Name = "avgAttendance";
            avgAttendance.Size = new Size(125, 21);
            avgAttendance.TabIndex = 2;
            avgAttendance.Text = "Total Corners: ";
            // 
            // seasonPanel
            // 
            seasonPanel.BackColor = Color.Transparent;
            seasonPanel.Controls.Add(displaySeasonProgressLabel);
            seasonPanel.Controls.Add(seasonProgressLabel);
            seasonPanel.Location = new Point(1086, 3);
            seasonPanel.Name = "seasonPanel";
            seasonPanel.Size = new Size(279, 119);
            seasonPanel.TabIndex = 3;
            // 
            // displaySeasonProgressLabel
            // 
            displaySeasonProgressLabel.AutoSize = true;
            displaySeasonProgressLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaySeasonProgressLabel.ForeColor = Color.Indigo;
            displaySeasonProgressLabel.Location = new Point(61, 59);
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
            goalsPanel.Controls.Add(displayTotaFoulsLabel);
            goalsPanel.Controls.Add(totalGoalsLabel);
            goalsPanel.Location = new Point(335, 3);
            goalsPanel.Name = "goalsPanel";
            goalsPanel.Size = new Size(378, 119);
            goalsPanel.TabIndex = 1;
            // 
            // displayTotaFoulsLabel
            // 
            displayTotaFoulsLabel.AutoSize = true;
            displayTotaFoulsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayTotaFoulsLabel.ForeColor = Color.DeepSkyBlue;
            displayTotaFoulsLabel.Location = new Point(14, 59);
            displayTotaFoulsLabel.Name = "displayTotaFoulsLabel";
            displayTotaFoulsLabel.Size = new Size(60, 21);
            displayTotaFoulsLabel.TabIndex = 2;
            displayTotaFoulsLabel.Text = "label1";
            // 
            // totalGoalsLabel
            // 
            totalGoalsLabel.AutoSize = true;
            totalGoalsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalGoalsLabel.Location = new Point(14, 16);
            totalGoalsLabel.Name = "totalGoalsLabel";
            totalGoalsLabel.Size = new Size(98, 21);
            totalGoalsLabel.TabIndex = 1;
            totalGoalsLabel.Text = "Total Fouls:";
            // 
            // matchesPanel
            // 
            matchesPanel.BackColor = Color.Transparent;
            matchesPanel.Controls.Add(totalMatchesLabel);
            matchesPanel.Controls.Add(totalMatchsLabel);
            matchesPanel.Location = new Point(3, 3);
            matchesPanel.Name = "matchesPanel";
            matchesPanel.Size = new Size(326, 119);
            matchesPanel.TabIndex = 0;
            // 
            // totalMatchesLabel
            // 
            totalMatchesLabel.AutoSize = true;
            totalMatchesLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalMatchesLabel.ForeColor = Color.Red;
            totalMatchesLabel.Location = new Point(26, 59);
            totalMatchesLabel.Name = "totalMatchesLabel";
            totalMatchesLabel.Size = new Size(60, 21);
            totalMatchesLabel.TabIndex = 3;
            totalMatchesLabel.Text = "label1";
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
            panel2.Size = new Size(1370, 598);
            panel2.TabIndex = 2;
            // 
            // leagueTapControl
            // 
            leagueTapControl.Appearance = TabAppearance.FlatButtons;
            leagueTapControl.Controls.Add(teamPage);
            leagueTapControl.Dock = DockStyle.Fill;
            leagueTapControl.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leagueTapControl.Location = new Point(0, 0);
            leagueTapControl.Name = "leagueTapControl";
            leagueTapControl.SelectedIndex = 0;
            leagueTapControl.Size = new Size(1370, 598);
            leagueTapControl.TabIndex = 0;
            // 
            // teamPage
            // 
            teamPage.Controls.Add(leagueTableDataGrip);
            teamPage.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamPage.Location = new Point(4, 35);
            teamPage.Name = "teamPage";
            teamPage.Padding = new Padding(3, 3, 3, 3);
            teamPage.Size = new Size(1362, 559);
            teamPage.TabIndex = 0;
            teamPage.Text = "League Table";
            teamPage.UseVisualStyleBackColor = true;
            // 
            // leagueTableDataGrip
            // 
            leagueTableDataGrip.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            leagueTableDataGrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            leagueTableDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            leagueTableDataGrip.DefaultCellStyle = dataGridViewCellStyle2;
            leagueTableDataGrip.Dock = DockStyle.Fill;
            leagueTableDataGrip.GridColor = SystemColors.ScrollBar;
            leagueTableDataGrip.Location = new Point(3, 3);
            leagueTableDataGrip.Name = "leagueTableDataGrip";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            leagueTableDataGrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            leagueTableDataGrip.RowHeadersWidth = 51;
            leagueTableDataGrip.Size = new Size(1356, 553);
            leagueTableDataGrip.TabIndex = 1;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 723);
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
        private DataGridView leagueTableDataGrip;
        private Label totalMatchesLabel;

    }
}