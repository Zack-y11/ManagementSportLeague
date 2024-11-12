namespace PresentationLayer.Forms
{
    partial class TeamsForm
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
            headerTeamsPanel = new Panel();
            searchTeamTextBox = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            teamsLabel = new Label();
            addTeamBtn = new FontAwesome.Sharp.IconButton();
            contentTeamsPanel = new Panel();
            tapControlTeams = new TabControl();
            tapTeamsControl = new TabPage();
            activeTeamsDataGrip = new DataGridView();
            teamNameColumn = new DataGridViewTextBoxColumn();
            divisionTeam = new DataGridViewTextBoxColumn();
            coachColumn = new DataGridViewTextBoxColumn();
            membersTeamColumn = new DataGridViewTextBoxColumn();
            pointsColumn = new DataGridViewTextBoxColumn();
            winsOrLose = new DataGridViewTextBoxColumn();
            statusTeamColumn = new DataGridViewTextBoxColumn();
            pendingTeamsPage = new TabPage();
            pendingTeamsDataGrip = new DataGridView();
            pendingTeamsColumn = new DataGridViewTextBoxColumn();
            divisionPendingColumn = new DataGridViewTextBoxColumn();
            pendingCoachColumn = new DataGridViewTextBoxColumn();
            pendingMembersColumn = new DataGridViewTextBoxColumn();
            pendingPointsColumn = new DataGridViewTextBoxColumn();
            windoRLoseColumn = new DataGridViewTextBoxColumn();
            pendingStatusColumn = new DataGridViewTextBoxColumn();
            inactiveTeamsPage = new TabPage();
            inactiveTeamsDataGrip = new DataGridView();
            inactiveTeamColumn = new DataGridViewTextBoxColumn();
            inactiveDivision = new DataGridViewTextBoxColumn();
            inactiveCoachColumn = new DataGridViewTextBoxColumn();
            inactiveMembersColumn = new DataGridViewTextBoxColumn();
            inactivePointsColumn = new DataGridViewTextBoxColumn();
            inactivewinOrLose = new DataGridViewTextBoxColumn();
            inactiveStatusColumn = new DataGridViewTextBoxColumn();
            editTeamBtn = new FontAwesome.Sharp.IconButton();
            deleteTeamBtn = new FontAwesome.Sharp.IconButton();
            headerTeamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            contentTeamsPanel.SuspendLayout();
            tapControlTeams.SuspendLayout();
            tapTeamsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).BeginInit();
            pendingTeamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pendingTeamsDataGrip).BeginInit();
            inactiveTeamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inactiveTeamsDataGrip).BeginInit();
            SuspendLayout();
            // 
            // headerTeamsPanel
            // 
            headerTeamsPanel.Controls.Add(searchTeamTextBox);
            headerTeamsPanel.Controls.Add(searchIcon);
            headerTeamsPanel.Controls.Add(teamsLabel);
            headerTeamsPanel.Dock = DockStyle.Top;
            headerTeamsPanel.Location = new Point(0, 0);
            headerTeamsPanel.Name = "headerTeamsPanel";
            headerTeamsPanel.Size = new Size(1392, 126);
            headerTeamsPanel.TabIndex = 0;
            // 
            // searchTeamTextBox
            // 
            searchTeamTextBox.Location = new Point(98, 82);
            searchTeamTextBox.Multiline = true;
            searchTeamTextBox.Name = "searchTeamTextBox";
            searchTeamTextBox.PlaceholderText = "All teams";
            searchTeamTextBox.Size = new Size(656, 34);
            searchTeamTextBox.TabIndex = 2;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.White;
            searchIcon.ForeColor = SystemColors.ControlText;
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = SystemColors.ControlText;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 40;
            searchIcon.Location = new Point(30, 76);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(40, 40);
            searchIcon.TabIndex = 1;
            searchIcon.TabStop = false;
            // 
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamsLabel.Location = new Point(30, 22);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(292, 34);
            teamsLabel.TabIndex = 0;
            teamsLabel.Text = "Teams Management";
            // 
            // addTeamBtn
            // 
            addTeamBtn.BackColor = SystemColors.ActiveCaptionText;
            addTeamBtn.ForeColor = Color.White;
            addTeamBtn.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addTeamBtn.IconColor = Color.White;
            addTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addTeamBtn.IconSize = 40;
            addTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTeamBtn.Location = new Point(973, 167);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(166, 46);
            addTeamBtn.TabIndex = 3;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = false;
            // 
            // contentTeamsPanel
            // 
            contentTeamsPanel.Controls.Add(tapControlTeams);
            contentTeamsPanel.Location = new Point(0, 126);
            contentTeamsPanel.Name = "contentTeamsPanel";
            contentTeamsPanel.Size = new Size(971, 566);
            contentTeamsPanel.TabIndex = 1;
            // 
            // tapControlTeams
            // 
            tapControlTeams.Appearance = TabAppearance.Buttons;
            tapControlTeams.Controls.Add(tapTeamsControl);
            tapControlTeams.Controls.Add(pendingTeamsPage);
            tapControlTeams.Controls.Add(inactiveTeamsPage);
            tapControlTeams.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tapControlTeams.Location = new Point(0, 0);
            tapControlTeams.Name = "tapControlTeams";
            tapControlTeams.SelectedIndex = 0;
            tapControlTeams.Size = new Size(971, 566);
            tapControlTeams.TabIndex = 0;
            // 
            // tapTeamsControl
            // 
            tapTeamsControl.BackColor = Color.White;
            tapTeamsControl.Controls.Add(activeTeamsDataGrip);
            tapTeamsControl.Location = new Point(4, 35);
            tapTeamsControl.Name = "tapTeamsControl";
            tapTeamsControl.Padding = new Padding(3);
            tapTeamsControl.Size = new Size(963, 527);
            tapTeamsControl.TabIndex = 1;
            tapTeamsControl.Text = "Active Teams ";
            // 
            // activeTeamsDataGrip
            // 
            activeTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            activeTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeTeamsDataGrip.Columns.AddRange(new DataGridViewColumn[] { teamNameColumn, divisionTeam, coachColumn, membersTeamColumn, pointsColumn, winsOrLose, statusTeamColumn });
            activeTeamsDataGrip.Location = new Point(3, 3);
            activeTeamsDataGrip.Name = "activeTeamsDataGrip";
            activeTeamsDataGrip.RowHeadersWidth = 51;
            activeTeamsDataGrip.Size = new Size(960, 527);
            activeTeamsDataGrip.TabIndex = 0;
            // 
            // teamNameColumn
            // 
            teamNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            teamNameColumn.HeaderText = "Team Name";
            teamNameColumn.MinimumWidth = 6;
            teamNameColumn.Name = "teamNameColumn";
            teamNameColumn.Width = 158;
            // 
            // divisionTeam
            // 
            divisionTeam.HeaderText = "Division";
            divisionTeam.MinimumWidth = 6;
            divisionTeam.Name = "divisionTeam";
            divisionTeam.Width = 125;
            // 
            // coachColumn
            // 
            coachColumn.HeaderText = "Coach";
            coachColumn.MinimumWidth = 6;
            coachColumn.Name = "coachColumn";
            coachColumn.Width = 125;
            // 
            // membersTeamColumn
            // 
            membersTeamColumn.HeaderText = "Members";
            membersTeamColumn.MinimumWidth = 6;
            membersTeamColumn.Name = "membersTeamColumn";
            membersTeamColumn.Width = 125;
            // 
            // pointsColumn
            // 
            pointsColumn.HeaderText = "Points";
            pointsColumn.MinimumWidth = 6;
            pointsColumn.Name = "pointsColumn";
            pointsColumn.Width = 125;
            // 
            // winsOrLose
            // 
            winsOrLose.HeaderText = "W/L";
            winsOrLose.MinimumWidth = 6;
            winsOrLose.Name = "winsOrLose";
            winsOrLose.Width = 125;
            // 
            // statusTeamColumn
            // 
            statusTeamColumn.HeaderText = "Status";
            statusTeamColumn.MinimumWidth = 6;
            statusTeamColumn.Name = "statusTeamColumn";
            statusTeamColumn.Width = 125;
            // 
            // pendingTeamsPage
            // 
            pendingTeamsPage.Controls.Add(pendingTeamsDataGrip);
            pendingTeamsPage.Location = new Point(4, 35);
            pendingTeamsPage.Name = "pendingTeamsPage";
            pendingTeamsPage.Padding = new Padding(3);
            pendingTeamsPage.Size = new Size(963, 527);
            pendingTeamsPage.TabIndex = 0;
            pendingTeamsPage.Text = "Pending Teams";
            pendingTeamsPage.UseVisualStyleBackColor = true;
            // 
            // pendingTeamsDataGrip
            // 
            pendingTeamsDataGrip.AllowDrop = true;
            pendingTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            pendingTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingTeamsDataGrip.Columns.AddRange(new DataGridViewColumn[] { pendingTeamsColumn, divisionPendingColumn, pendingCoachColumn, pendingMembersColumn, pendingPointsColumn, windoRLoseColumn, pendingStatusColumn });
            pendingTeamsDataGrip.Dock = DockStyle.Fill;
            pendingTeamsDataGrip.Location = new Point(3, 3);
            pendingTeamsDataGrip.Name = "pendingTeamsDataGrip";
            pendingTeamsDataGrip.RowHeadersWidth = 51;
            pendingTeamsDataGrip.Size = new Size(957, 521);
            pendingTeamsDataGrip.TabIndex = 1;
            // 
            // pendingTeamsColumn
            // 
            pendingTeamsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            pendingTeamsColumn.HeaderText = "Team Name";
            pendingTeamsColumn.MinimumWidth = 6;
            pendingTeamsColumn.Name = "pendingTeamsColumn";
            pendingTeamsColumn.Width = 158;
            // 
            // divisionPendingColumn
            // 
            divisionPendingColumn.HeaderText = "Division";
            divisionPendingColumn.MinimumWidth = 6;
            divisionPendingColumn.Name = "divisionPendingColumn";
            divisionPendingColumn.Width = 125;
            // 
            // pendingCoachColumn
            // 
            pendingCoachColumn.HeaderText = "Coach";
            pendingCoachColumn.MinimumWidth = 6;
            pendingCoachColumn.Name = "pendingCoachColumn";
            pendingCoachColumn.Width = 125;
            // 
            // pendingMembersColumn
            // 
            pendingMembersColumn.HeaderText = "Members";
            pendingMembersColumn.MinimumWidth = 6;
            pendingMembersColumn.Name = "pendingMembersColumn";
            pendingMembersColumn.Width = 125;
            // 
            // pendingPointsColumn
            // 
            pendingPointsColumn.HeaderText = "Points";
            pendingPointsColumn.MinimumWidth = 6;
            pendingPointsColumn.Name = "pendingPointsColumn";
            pendingPointsColumn.Width = 125;
            // 
            // windoRLoseColumn
            // 
            windoRLoseColumn.HeaderText = "W/L";
            windoRLoseColumn.MinimumWidth = 6;
            windoRLoseColumn.Name = "windoRLoseColumn";
            windoRLoseColumn.Width = 125;
            // 
            // pendingStatusColumn
            // 
            pendingStatusColumn.HeaderText = "Status";
            pendingStatusColumn.MinimumWidth = 6;
            pendingStatusColumn.Name = "pendingStatusColumn";
            pendingStatusColumn.Width = 125;
            // 
            // inactiveTeamsPage
            // 
            inactiveTeamsPage.Controls.Add(inactiveTeamsDataGrip);
            inactiveTeamsPage.Location = new Point(4, 35);
            inactiveTeamsPage.Name = "inactiveTeamsPage";
            inactiveTeamsPage.Padding = new Padding(3);
            inactiveTeamsPage.Size = new Size(963, 527);
            inactiveTeamsPage.TabIndex = 2;
            inactiveTeamsPage.Text = "Inactive Teams";
            inactiveTeamsPage.UseVisualStyleBackColor = true;
            // 
            // inactiveTeamsDataGrip
            // 
            inactiveTeamsDataGrip.AllowDrop = true;
            inactiveTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            inactiveTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inactiveTeamsDataGrip.Columns.AddRange(new DataGridViewColumn[] { inactiveTeamColumn, inactiveDivision, inactiveCoachColumn, inactiveMembersColumn, inactivePointsColumn, inactivewinOrLose, inactiveStatusColumn });
            inactiveTeamsDataGrip.Dock = DockStyle.Fill;
            inactiveTeamsDataGrip.Location = new Point(3, 3);
            inactiveTeamsDataGrip.Name = "inactiveTeamsDataGrip";
            inactiveTeamsDataGrip.RowHeadersWidth = 51;
            inactiveTeamsDataGrip.Size = new Size(957, 521);
            inactiveTeamsDataGrip.TabIndex = 1;
            // 
            // inactiveTeamColumn
            // 
            inactiveTeamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            inactiveTeamColumn.HeaderText = "Team Name";
            inactiveTeamColumn.MinimumWidth = 6;
            inactiveTeamColumn.Name = "inactiveTeamColumn";
            inactiveTeamColumn.Width = 158;
            // 
            // inactiveDivision
            // 
            inactiveDivision.HeaderText = "Division";
            inactiveDivision.MinimumWidth = 6;
            inactiveDivision.Name = "inactiveDivision";
            inactiveDivision.Width = 125;
            // 
            // inactiveCoachColumn
            // 
            inactiveCoachColumn.HeaderText = "Coach";
            inactiveCoachColumn.MinimumWidth = 6;
            inactiveCoachColumn.Name = "inactiveCoachColumn";
            inactiveCoachColumn.Width = 125;
            // 
            // inactiveMembersColumn
            // 
            inactiveMembersColumn.HeaderText = "Members";
            inactiveMembersColumn.MinimumWidth = 6;
            inactiveMembersColumn.Name = "inactiveMembersColumn";
            inactiveMembersColumn.Width = 125;
            // 
            // inactivePointsColumn
            // 
            inactivePointsColumn.HeaderText = "Points";
            inactivePointsColumn.MinimumWidth = 6;
            inactivePointsColumn.Name = "inactivePointsColumn";
            inactivePointsColumn.Width = 125;
            // 
            // inactivewinOrLose
            // 
            inactivewinOrLose.HeaderText = "W/L";
            inactivewinOrLose.MinimumWidth = 6;
            inactivewinOrLose.Name = "inactivewinOrLose";
            inactivewinOrLose.Width = 125;
            // 
            // inactiveStatusColumn
            // 
            inactiveStatusColumn.HeaderText = "Status";
            inactiveStatusColumn.MinimumWidth = 6;
            inactiveStatusColumn.Name = "inactiveStatusColumn";
            inactiveStatusColumn.Width = 125;
            // 
            // editTeamBtn
            // 
            editTeamBtn.BackColor = SystemColors.ActiveCaptionText;
            editTeamBtn.ForeColor = Color.White;
            editTeamBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            editTeamBtn.IconColor = Color.White;
            editTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editTeamBtn.Location = new Point(973, 350);
            editTeamBtn.Name = "editTeamBtn";
            editTeamBtn.Size = new Size(166, 49);
            editTeamBtn.TabIndex = 4;
            editTeamBtn.Text = "Edit Team";
            editTeamBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTeamBtn
            // 
            deleteTeamBtn.BackColor = SystemColors.ActiveCaptionText;
            deleteTeamBtn.ForeColor = Color.White;
            deleteTeamBtn.IconChar = FontAwesome.Sharp.IconChar.LandmarkFlag;
            deleteTeamBtn.IconColor = Color.White;
            deleteTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteTeamBtn.Location = new Point(973, 521);
            deleteTeamBtn.Name = "deleteTeamBtn";
            deleteTeamBtn.Size = new Size(166, 49);
            deleteTeamBtn.TabIndex = 5;
            deleteTeamBtn.Text = "    Delete Team";
            deleteTeamBtn.UseVisualStyleBackColor = false;
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1392, 692);
            Controls.Add(deleteTeamBtn);
            Controls.Add(editTeamBtn);
            Controls.Add(addTeamBtn);
            Controls.Add(contentTeamsPanel);
            Controls.Add(headerTeamsPanel);
            Name = "TeamsForm";
            Text = "TeamsForm";
            headerTeamsPanel.ResumeLayout(false);
            headerTeamsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            contentTeamsPanel.ResumeLayout(false);
            tapControlTeams.ResumeLayout(false);
            tapTeamsControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).EndInit();
            pendingTeamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pendingTeamsDataGrip).EndInit();
            inactiveTeamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inactiveTeamsDataGrip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerTeamsPanel;
        private Label teamsLabel;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private TextBox searchTeamTextBox;
        private Panel contentTeamsPanel;
        private TabControl tapControlTeams;
        private TabPage pendingTeamsPage;
        private TabPage tapTeamsControl;
        private TabPage inactiveTeamsPage;
        private DataGridView activeTeamsDataGrip;
        private DataGridView pendingTeamsDataGrip;
        private DataGridView inactiveTeamsDataGrip;
        private DataGridViewTextBoxColumn managerPending;
        private DataGridViewTextBoxColumn pendingleaderColumn;
        private DataGridViewTextBoxColumn pendingLeagueColumn;
        private DataGridViewTextBoxColumn inactiveManager;
        private DataGridViewTextBoxColumn inactiveLeaderColumn;
        private DataGridViewTextBoxColumn inactiveLeagueColumn;
        private DataGridViewTextBoxColumn teamNameColumn;
        private DataGridViewTextBoxColumn divisionTeam;
        private DataGridViewTextBoxColumn coachColumn;
        private DataGridViewTextBoxColumn membersTeamColumn;
        private DataGridViewTextBoxColumn pointsColumn;
        private DataGridViewTextBoxColumn winsOrLose;
        private DataGridViewTextBoxColumn statusTeamColumn;
        private DataGridViewTextBoxColumn pendingTeamsColumn;
        private DataGridViewTextBoxColumn divisionPendingColumn;
        private DataGridViewTextBoxColumn pendingCoachColumn;
        private DataGridViewTextBoxColumn pendingMembersColumn;
        private DataGridViewTextBoxColumn pendingPointsColumn;
        private DataGridViewTextBoxColumn windoRLoseColumn;
        private DataGridViewTextBoxColumn pendingStatusColumn;
        private DataGridViewTextBoxColumn inactiveTeamColumn;
        private DataGridViewTextBoxColumn inactiveDivision;
        private DataGridViewTextBoxColumn inactiveCoachColumn;
        private DataGridViewTextBoxColumn inactiveMembersColumn;
        private DataGridViewTextBoxColumn inactivePointsColumn;
        private DataGridViewTextBoxColumn inactivewinOrLose;
        private DataGridViewTextBoxColumn inactiveStatusColumn;
        private FontAwesome.Sharp.IconButton addTeamBtn;
        private FontAwesome.Sharp.IconButton editTeamBtn;
        private FontAwesome.Sharp.IconButton deleteTeamBtn;
    }
}