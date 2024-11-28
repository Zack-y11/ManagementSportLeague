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
            components = new System.ComponentModel.Container();
            headerTeamsPanel = new Panel();
            searchTeamBtn = new FontAwesome.Sharp.IconButton();
            searchTeamTextBox = new TextBox();
            searchIcon = new FontAwesome.Sharp.IconPictureBox();
            teamsLabel = new Label();
            addTeamBtn = new FontAwesome.Sharp.IconButton();
            contentTeamsPanel = new Panel();
            tapControlTeams = new TabControl();
            tapTeamsControl = new TabPage();
            activeTeamsDataGrip = new DataGridView();
            editTeamBtn = new FontAwesome.Sharp.IconButton();
            deleteTeamBtn = new FontAwesome.Sharp.IconButton();
            teamPanel = new Panel();
            pointsTextBox = new TextBox();
            pointsLabel = new Label();
            loosesTextBox = new TextBox();
            loosesLabel = new Label();
            winsTextBox = new TextBox();
            winsLabel = new Label();
            coachComboBox = new ComboBox();
            coachLabel = new Label();
            deleteTeamLabel = new Label();
            editTeamLabel = new Label();
            teamNameTextBox = new TextBox();
            teamNameLabel = new Label();
            teamErrorProvider = new ErrorProvider(components);
            headerTeamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            contentTeamsPanel.SuspendLayout();
            tapControlTeams.SuspendLayout();
            tapTeamsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).BeginInit();
            teamPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teamErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // headerTeamsPanel
            // 
            headerTeamsPanel.Controls.Add(searchTeamBtn);
            headerTeamsPanel.Controls.Add(searchTeamTextBox);
            headerTeamsPanel.Controls.Add(searchIcon);
            headerTeamsPanel.Controls.Add(teamsLabel);
            headerTeamsPanel.Dock = DockStyle.Top;
            headerTeamsPanel.Location = new Point(0, 0);
            headerTeamsPanel.Margin = new Padding(3, 2, 3, 2);
            headerTeamsPanel.Name = "headerTeamsPanel";
            headerTeamsPanel.Size = new Size(1199, 94);
            headerTeamsPanel.TabIndex = 0;
            // 
            // searchTeamBtn
            // 
            searchTeamBtn.BackColor = Color.YellowGreen;
            searchTeamBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTeamBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            searchTeamBtn.IconColor = Color.Black;
            searchTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchTeamBtn.Location = new Point(686, 60);
            searchTeamBtn.Margin = new Padding(3, 2, 3, 2);
            searchTeamBtn.Name = "searchTeamBtn";
            searchTeamBtn.Size = new Size(210, 29);
            searchTeamBtn.TabIndex = 7;
            searchTeamBtn.Text = "Search";
            searchTeamBtn.UseVisualStyleBackColor = false;
            // 
            // searchTeamTextBox
            // 
            searchTeamTextBox.Location = new Point(86, 62);
            searchTeamTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTeamTextBox.Multiline = true;
            searchTeamTextBox.Name = "searchTeamTextBox";
            searchTeamTextBox.PlaceholderText = "All teams";
            searchTeamTextBox.Size = new Size(574, 26);
            searchTeamTextBox.TabIndex = 2;
            // 
            // searchIcon
            // 
            searchIcon.BackColor = Color.White;
            searchIcon.ForeColor = SystemColors.ControlText;
            searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchIcon.IconColor = SystemColors.ControlText;
            searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIcon.IconSize = 30;
            searchIcon.Location = new Point(26, 57);
            searchIcon.Margin = new Padding(3, 2, 3, 2);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(35, 30);
            searchIcon.TabIndex = 1;
            searchIcon.TabStop = false;
            // 
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamsLabel.Location = new Point(26, 16);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(234, 26);
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
            addTeamBtn.Location = new Point(209, 194);
            addTeamBtn.Margin = new Padding(3, 2, 3, 2);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(170, 34);
            addTeamBtn.TabIndex = 3;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = false;
            addTeamBtn.Click += addTeamBtn_Click;
            // 
            // contentTeamsPanel
            // 
            contentTeamsPanel.Controls.Add(tapControlTeams);
            contentTeamsPanel.Location = new Point(0, 94);
            contentTeamsPanel.Margin = new Padding(3, 2, 3, 2);
            contentTeamsPanel.Name = "contentTeamsPanel";
            contentTeamsPanel.Size = new Size(612, 424);
            contentTeamsPanel.TabIndex = 1;
            // 
            // tapControlTeams
            // 
            tapControlTeams.Appearance = TabAppearance.Buttons;
            tapControlTeams.Controls.Add(tapTeamsControl);
            tapControlTeams.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tapControlTeams.Location = new Point(0, 0);
            tapControlTeams.Margin = new Padding(3, 2, 3, 2);
            tapControlTeams.Name = "tapControlTeams";
            tapControlTeams.SelectedIndex = 0;
            tapControlTeams.Size = new Size(615, 424);
            tapControlTeams.TabIndex = 0;
            // 
            // tapTeamsControl
            // 
            tapTeamsControl.BackColor = Color.White;
            tapTeamsControl.Controls.Add(activeTeamsDataGrip);
            tapTeamsControl.Location = new Point(4, 31);
            tapTeamsControl.Margin = new Padding(3, 2, 3, 2);
            tapTeamsControl.Name = "tapTeamsControl";
            tapTeamsControl.Padding = new Padding(3, 2, 3, 2);
            tapTeamsControl.Size = new Size(607, 389);
            tapTeamsControl.TabIndex = 1;
            tapTeamsControl.Text = "Active Teams ";
            // 
            // activeTeamsDataGrip
            // 
            activeTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            activeTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeTeamsDataGrip.Location = new Point(3, 2);
            activeTeamsDataGrip.Margin = new Padding(3, 2, 3, 2);
            activeTeamsDataGrip.Name = "activeTeamsDataGrip";
            activeTeamsDataGrip.RowHeadersWidth = 51;
            activeTeamsDataGrip.Size = new Size(602, 395);
            activeTeamsDataGrip.TabIndex = 0;
            // 
            // editTeamBtn
            // 
            editTeamBtn.BackColor = Color.FromArgb(0, 123, 250);
            editTeamBtn.ForeColor = Color.White;
            editTeamBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            editTeamBtn.IconColor = Color.White;
            editTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editTeamBtn.Location = new Point(14, 277);
            editTeamBtn.Margin = new Padding(3, 2, 3, 2);
            editTeamBtn.Name = "editTeamBtn";
            editTeamBtn.Size = new Size(170, 37);
            editTeamBtn.TabIndex = 4;
            editTeamBtn.Text = "Edit Team";
            editTeamBtn.UseVisualStyleBackColor = false;
            editTeamBtn.Click += editTeamBtn_Click;
            // 
            // deleteTeamBtn
            // 
            deleteTeamBtn.BackColor = Color.Red;
            deleteTeamBtn.ForeColor = Color.White;
            deleteTeamBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            deleteTeamBtn.IconColor = Color.White;
            deleteTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteTeamBtn.Location = new Point(209, 277);
            deleteTeamBtn.Margin = new Padding(3, 2, 3, 2);
            deleteTeamBtn.Name = "deleteTeamBtn";
            deleteTeamBtn.Size = new Size(170, 37);
            deleteTeamBtn.TabIndex = 5;
            deleteTeamBtn.Text = "    Delete Team";
            deleteTeamBtn.UseVisualStyleBackColor = false;
            deleteTeamBtn.Click += deleteTeamBtn_Click;
            // 
            // teamPanel
            // 
            teamPanel.BackColor = Color.WhiteSmoke;
            teamPanel.Controls.Add(pointsTextBox);
            teamPanel.Controls.Add(pointsLabel);
            teamPanel.Controls.Add(loosesTextBox);
            teamPanel.Controls.Add(loosesLabel);
            teamPanel.Controls.Add(winsTextBox);
            teamPanel.Controls.Add(winsLabel);
            teamPanel.Controls.Add(coachComboBox);
            teamPanel.Controls.Add(coachLabel);
            teamPanel.Controls.Add(deleteTeamLabel);
            teamPanel.Controls.Add(editTeamLabel);
            teamPanel.Controls.Add(teamNameTextBox);
            teamPanel.Controls.Add(editTeamBtn);
            teamPanel.Controls.Add(teamNameLabel);
            teamPanel.Controls.Add(deleteTeamBtn);
            teamPanel.Controls.Add(addTeamBtn);
            teamPanel.Location = new Point(620, 94);
            teamPanel.Margin = new Padding(3, 2, 3, 2);
            teamPanel.Name = "teamPanel";
            teamPanel.Size = new Size(595, 424);
            teamPanel.TabIndex = 2;
            // 
            // pointsTextBox
            // 
            pointsTextBox.Location = new Point(14, 201);
            pointsTextBox.Margin = new Padding(3, 2, 3, 2);
            pointsTextBox.Name = "pointsTextBox";
            pointsTextBox.PlaceholderText = "Default: 0";
            pointsTextBox.Size = new Size(170, 23);
            pointsTextBox.TabIndex = 17;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pointsLabel.Location = new Point(14, 170);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(52, 19);
            pointsLabel.TabIndex = 16;
            pointsLabel.Text = "Points";
            // 
            // loosesTextBox
            // 
            loosesTextBox.Location = new Point(209, 130);
            loosesTextBox.Margin = new Padding(3, 2, 3, 2);
            loosesTextBox.Name = "loosesTextBox";
            loosesTextBox.PlaceholderText = "Default: 0";
            loosesTextBox.Size = new Size(170, 23);
            loosesTextBox.TabIndex = 15;
            // 
            // loosesLabel
            // 
            loosesLabel.AutoSize = true;
            loosesLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loosesLabel.Location = new Point(209, 98);
            loosesLabel.Name = "loosesLabel";
            loosesLabel.Size = new Size(58, 19);
            loosesLabel.TabIndex = 14;
            loosesLabel.Text = "Looses";
            // 
            // winsTextBox
            // 
            winsTextBox.Location = new Point(209, 57);
            winsTextBox.Margin = new Padding(3, 2, 3, 2);
            winsTextBox.Name = "winsTextBox";
            winsTextBox.PlaceholderText = "Default: 0";
            winsTextBox.Size = new Size(170, 23);
            winsTextBox.TabIndex = 13;
            // 
            // winsLabel
            // 
            winsLabel.AutoSize = true;
            winsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winsLabel.Location = new Point(209, 28);
            winsLabel.Name = "winsLabel";
            winsLabel.Size = new Size(43, 19);
            winsLabel.TabIndex = 12;
            winsLabel.Text = "Wins";
            // 
            // coachComboBox
            // 
            coachComboBox.FormattingEnabled = true;
            coachComboBox.Location = new Point(14, 129);
            coachComboBox.Margin = new Padding(3, 2, 3, 2);
            coachComboBox.Name = "coachComboBox";
            coachComboBox.Size = new Size(163, 23);
            coachComboBox.TabIndex = 11;
            // 
            // coachLabel
            // 
            coachLabel.AutoSize = true;
            coachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coachLabel.Location = new Point(14, 98);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new Size(115, 19);
            coachLabel.TabIndex = 10;
            coachLabel.Text = "Coach Name";
            // 
            // deleteTeamLabel
            // 
            deleteTeamLabel.AutoSize = true;
            deleteTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTeamLabel.Location = new Point(209, 241);
            deleteTeamLabel.Name = "deleteTeamLabel";
            deleteTeamLabel.Size = new Size(106, 19);
            deleteTeamLabel.TabIndex = 9;
            deleteTeamLabel.Text = "Delete Team";
            // 
            // editTeamLabel
            // 
            editTeamLabel.AutoSize = true;
            editTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTeamLabel.Location = new Point(14, 241);
            editTeamLabel.Name = "editTeamLabel";
            editTeamLabel.Size = new Size(84, 19);
            editTeamLabel.TabIndex = 8;
            editTeamLabel.Text = "Edit Team";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(14, 57);
            teamNameTextBox.Margin = new Padding(3, 2, 3, 2);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(170, 23);
            teamNameTextBox.TabIndex = 7;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.Location = new Point(14, 28);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(106, 19);
            teamNameLabel.TabIndex = 6;
            teamNameLabel.Text = "Team Name";
            // 
            // teamErrorProvider
            // 
            teamErrorProvider.ContainerControl = this;
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 519);
            Controls.Add(teamPanel);
            Controls.Add(contentTeamsPanel);
            Controls.Add(headerTeamsPanel);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)teamErrorProvider).EndInit();
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
        private Panel teamPanel;
        private Label teamNameLabel;
        private TextBox teamNameTextBox;
        private Label editTeamLabel;
        private Label deleteTeamLabel;
        private Label coachLabel;
        private ComboBox coachComboBox;
        private Label winsLabel;
        private TextBox winsTextBox;
        private Label loosesLabel;
        private TextBox loosesTextBox;
        private Label pointsLabel;
        private TextBox pointsTextBox;
        private FontAwesome.Sharp.IconButton searchTeamBtn;
        private ErrorProvider teamErrorProvider;
    }
}