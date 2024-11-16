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
            pointsColumn = new DataGridViewTextBoxColumn();
            winsOrLose = new DataGridViewTextBoxColumn();
            editTeamBtn = new FontAwesome.Sharp.IconButton();
            deleteTeamBtn = new FontAwesome.Sharp.IconButton();
            teamPanel = new Panel();
            deleteTeamLabel = new Label();
            editTeamLabel = new Label();
            addTeamTextBox = new TextBox();
            addReamLabel = new Label();
            headerTeamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            contentTeamsPanel.SuspendLayout();
            tapControlTeams.SuspendLayout();
            tapTeamsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).BeginInit();
            teamPanel.SuspendLayout();
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
            addTeamBtn.BackColor = Color.Green;
            addTeamBtn.ForeColor = Color.White;
            addTeamBtn.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addTeamBtn.IconColor = Color.White;
            addTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addTeamBtn.IconSize = 40;
            addTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTeamBtn.Location = new Point(20, 123);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(194, 46);
            addTeamBtn.TabIndex = 3;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = false;
            // 
            // contentTeamsPanel
            // 
            contentTeamsPanel.Controls.Add(tapControlTeams);
            contentTeamsPanel.Location = new Point(0, 126);
            contentTeamsPanel.Name = "contentTeamsPanel";
            contentTeamsPanel.Size = new Size(726, 566);
            contentTeamsPanel.TabIndex = 1;
            // 
            // tapControlTeams
            // 
            tapControlTeams.Appearance = TabAppearance.Buttons;
            tapControlTeams.Controls.Add(tapTeamsControl);
            tapControlTeams.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tapControlTeams.Location = new Point(0, 0);
            tapControlTeams.Name = "tapControlTeams";
            tapControlTeams.SelectedIndex = 0;
            tapControlTeams.Size = new Size(726, 566);
            tapControlTeams.TabIndex = 0;
            // 
            // tapTeamsControl
            // 
            tapTeamsControl.BackColor = Color.White;
            tapTeamsControl.Controls.Add(activeTeamsDataGrip);
            tapTeamsControl.Location = new Point(4, 35);
            tapTeamsControl.Name = "tapTeamsControl";
            tapTeamsControl.Padding = new Padding(3);
            tapTeamsControl.Size = new Size(718, 527);
            tapTeamsControl.TabIndex = 1;
            tapTeamsControl.Text = "Active Teams ";
            // 
            // activeTeamsDataGrip
            // 
            activeTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            activeTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeTeamsDataGrip.Columns.AddRange(new DataGridViewColumn[] { teamNameColumn, divisionTeam, coachColumn, pointsColumn, winsOrLose });
            activeTeamsDataGrip.Location = new Point(3, 3);
            activeTeamsDataGrip.Name = "activeTeamsDataGrip";
            activeTeamsDataGrip.RowHeadersWidth = 51;
            activeTeamsDataGrip.Size = new Size(713, 527);
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
            // pointsColumn
            // 
            pointsColumn.HeaderText = "Points";
            pointsColumn.MinimumWidth = 6;
            pointsColumn.Name = "pointsColumn";
            pointsColumn.Width = 125;
            // 
            // winsOrLose
            // 
            winsOrLose.HeaderText = "W/L/D";
            winsOrLose.MinimumWidth = 6;
            winsOrLose.Name = "winsOrLose";
            winsOrLose.Width = 125;
            // 
            // editTeamBtn
            // 
            editTeamBtn.BackColor = Color.FromArgb(0, 123, 250);
            editTeamBtn.ForeColor = Color.White;
            editTeamBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            editTeamBtn.IconColor = Color.White;
            editTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editTeamBtn.Location = new Point(20, 244);
            editTeamBtn.Name = "editTeamBtn";
            editTeamBtn.Size = new Size(194, 49);
            editTeamBtn.TabIndex = 4;
            editTeamBtn.Text = "Edit Team";
            editTeamBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTeamBtn
            // 
            deleteTeamBtn.BackColor = Color.Red;
            deleteTeamBtn.ForeColor = Color.White;
            deleteTeamBtn.IconChar = FontAwesome.Sharp.IconChar.LandmarkFlag;
            deleteTeamBtn.IconColor = Color.White;
            deleteTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteTeamBtn.Location = new Point(20, 386);
            deleteTeamBtn.Name = "deleteTeamBtn";
            deleteTeamBtn.Size = new Size(194, 49);
            deleteTeamBtn.TabIndex = 5;
            deleteTeamBtn.Text = "    Delete Team";
            deleteTeamBtn.UseVisualStyleBackColor = false;
            // 
            // teamPanel
            // 
            teamPanel.BackColor = Color.WhiteSmoke;
            teamPanel.Controls.Add(deleteTeamLabel);
            teamPanel.Controls.Add(editTeamLabel);
            teamPanel.Controls.Add(addTeamTextBox);
            teamPanel.Controls.Add(editTeamBtn);
            teamPanel.Controls.Add(addReamLabel);
            teamPanel.Controls.Add(deleteTeamBtn);
            teamPanel.Controls.Add(addTeamBtn);
            teamPanel.Dock = DockStyle.Right;
            teamPanel.Location = new Point(968, 126);
            teamPanel.Name = "teamPanel";
            teamPanel.Size = new Size(424, 566);
            teamPanel.TabIndex = 2;
            // 
            // deleteTeamLabel
            // 
            deleteTeamLabel.AutoSize = true;
            deleteTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTeamLabel.Location = new Point(20, 349);
            deleteTeamLabel.Name = "deleteTeamLabel";
            deleteTeamLabel.Size = new Size(133, 23);
            deleteTeamLabel.TabIndex = 9;
            deleteTeamLabel.Text = "Delete Team";
            // 
            // editTeamLabel
            // 
            editTeamLabel.AutoSize = true;
            editTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTeamLabel.Location = new Point(20, 204);
            editTeamLabel.Name = "editTeamLabel";
            editTeamLabel.Size = new Size(103, 23);
            editTeamLabel.TabIndex = 8;
            editTeamLabel.Text = "Edit Team";
            // 
            // addTeamTextBox
            // 
            addTeamTextBox.Location = new Point(20, 76);
            addTeamTextBox.Name = "addTeamTextBox";
            addTeamTextBox.Size = new Size(194, 27);
            addTeamTextBox.TabIndex = 7;
            // 
            // addReamLabel
            // 
            addReamLabel.AutoSize = true;
            addReamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addReamLabel.Location = new Point(32, 29);
            addReamLabel.Name = "addReamLabel";
            addReamLabel.Size = new Size(110, 23);
            addReamLabel.TabIndex = 6;
            addReamLabel.Text = "Add Team";
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1392, 692);
            Controls.Add(teamPanel);
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
            teamPanel.ResumeLayout(false);
            teamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerTeamsPanel;
        private Label teamsLabel;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private TextBox searchTeamTextBox;
        private Panel contentTeamsPanel;
        private TabControl tapControlTeams;
        private TabPage tapTeamsControl;
        private DataGridView activeTeamsDataGrip;
        private DataGridViewTextBoxColumn managerPending;
        private DataGridViewTextBoxColumn pendingleaderColumn;
        private DataGridViewTextBoxColumn pendingLeagueColumn;
        private DataGridViewTextBoxColumn inactiveManager;
        private DataGridViewTextBoxColumn inactiveLeaderColumn;
        private DataGridViewTextBoxColumn inactiveLeagueColumn;
        private FontAwesome.Sharp.IconButton addTeamBtn;
        private FontAwesome.Sharp.IconButton editTeamBtn;
        private FontAwesome.Sharp.IconButton deleteTeamBtn;
        private DataGridViewTextBoxColumn teamNameColumn;
        private DataGridViewTextBoxColumn divisionTeam;
        private DataGridViewTextBoxColumn coachColumn;
        private DataGridViewTextBoxColumn pointsColumn;
        private DataGridViewTextBoxColumn winsOrLose;
        private Panel teamPanel;
        private Label addReamLabel;
        private TextBox addTeamTextBox;
        private Label editTeamLabel;
        private Label deleteTeamLabel;
    }
}