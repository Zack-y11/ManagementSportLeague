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
            editTeamBtn = new FontAwesome.Sharp.IconButton();
            deleteTeamBtn = new FontAwesome.Sharp.IconButton();
            teamPanel = new Panel();
            PDFBtn = new FontAwesome.Sharp.IconButton();
            addTeamLabel = new Label();
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
            activeTeamsDataGrip = new DataGridView();
            contentTeamsPanel = new Panel();
            pdfLabel = new Label();
            headerTeamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            teamPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teamErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).BeginInit();
            contentTeamsPanel.SuspendLayout();
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
            headerTeamsPanel.Name = "headerTeamsPanel";
            headerTeamsPanel.Size = new Size(1370, 125);
            headerTeamsPanel.TabIndex = 0;
            // 
            // searchTeamBtn
            // 
            searchTeamBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTeamBtn.BackColor = Color.YellowGreen;
            searchTeamBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTeamBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            searchTeamBtn.IconColor = Color.Black;
            searchTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchTeamBtn.Location = new Point(1051, 76);
            searchTeamBtn.Name = "searchTeamBtn";
            searchTeamBtn.Size = new Size(240, 39);
            searchTeamBtn.TabIndex = 7;
            searchTeamBtn.Text = "Search";
            searchTeamBtn.UseVisualStyleBackColor = false;
            // 
            // searchTeamTextBox
            // 
            searchTeamTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTeamTextBox.Location = new Point(98, 83);
            searchTeamTextBox.Multiline = true;
            searchTeamTextBox.Name = "searchTeamTextBox";
            searchTeamTextBox.PlaceholderText = "All teams";
            searchTeamTextBox.Size = new Size(655, 33);
            searchTeamTextBox.TabIndex = 2;
            searchTeamTextBox.TextChanged += searchTeamTextBox_TextChanged;
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
            teamsLabel.Location = new Point(30, 21);
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
            addTeamBtn.Location = new Point(30, 208);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(257, 45);
            addTeamBtn.TabIndex = 3;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = false;
            addTeamBtn.Click += addTeamBtn_Click;
            // 
            // editTeamBtn
            // 
            editTeamBtn.BackColor = Color.FromArgb(0, 123, 250);
            editTeamBtn.ForeColor = Color.White;
            editTeamBtn.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            editTeamBtn.IconColor = Color.White;
            editTeamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editTeamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editTeamBtn.Location = new Point(315, 208);
            editTeamBtn.Name = "editTeamBtn";
            editTeamBtn.Size = new Size(257, 45);
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
            deleteTeamBtn.Location = new Point(596, 208);
            deleteTeamBtn.Name = "deleteTeamBtn";
            deleteTeamBtn.Size = new Size(254, 45);
            deleteTeamBtn.TabIndex = 5;
            deleteTeamBtn.Text = "    Delete Team";
            deleteTeamBtn.UseVisualStyleBackColor = false;
            deleteTeamBtn.Click += deleteTeamBtn_Click;
            // 
            // teamPanel
            // 
            teamPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamPanel.BackColor = Color.WhiteSmoke;
            teamPanel.Controls.Add(pdfLabel);
            teamPanel.Controls.Add(PDFBtn);
            teamPanel.Controls.Add(addTeamLabel);
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
            teamPanel.Location = new Point(0, 125);
            teamPanel.Name = "teamPanel";
            teamPanel.Size = new Size(1370, 319);
            teamPanel.TabIndex = 2;
            // 
            // PDFBtn
            // 
            PDFBtn.BackColor = Color.YellowGreen;
            PDFBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            PDFBtn.ForeColor = Color.White;
            PDFBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            PDFBtn.IconColor = Color.White;
            PDFBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PDFBtn.Location = new Point(870, 208);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(231, 45);
            PDFBtn.TabIndex = 41;
            PDFBtn.Text = "   Generate PDF";
            PDFBtn.UseVisualStyleBackColor = false;
            PDFBtn.Click += PDFBtn_Click;
            // 
            // addTeamLabel
            // 
            addTeamLabel.AutoSize = true;
            addTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamLabel.Location = new Point(30, 171);
            addTeamLabel.Name = "addTeamLabel";
            addTeamLabel.Size = new Size(110, 23);
            addTeamLabel.TabIndex = 18;
            addTeamLabel.Text = "Add Team";
            // 
            // pointsTextBox
            // 
            pointsTextBox.Location = new Point(30, 129);
            pointsTextBox.Name = "pointsTextBox";
            pointsTextBox.PlaceholderText = "Default: 0";
            pointsTextBox.Size = new Size(278, 27);
            pointsTextBox.TabIndex = 17;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pointsLabel.Location = new Point(30, 100);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(66, 23);
            pointsLabel.TabIndex = 16;
            pointsLabel.Text = "Points";
            // 
            // loosesTextBox
            // 
            loosesTextBox.Location = new Point(385, 129);
            loosesTextBox.Name = "loosesTextBox";
            loosesTextBox.PlaceholderText = "Default: 0";
            loosesTextBox.Size = new Size(275, 27);
            loosesTextBox.TabIndex = 15;
            // 
            // loosesLabel
            // 
            loosesLabel.AutoSize = true;
            loosesLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loosesLabel.Location = new Point(385, 100);
            loosesLabel.Name = "loosesLabel";
            loosesLabel.Size = new Size(76, 23);
            loosesLabel.TabIndex = 14;
            loosesLabel.Text = "Looses";
            // 
            // winsTextBox
            // 
            winsTextBox.Location = new Point(385, 57);
            winsTextBox.Name = "winsTextBox";
            winsTextBox.PlaceholderText = "Default: 0";
            winsTextBox.Size = new Size(275, 27);
            winsTextBox.TabIndex = 13;
            // 
            // winsLabel
            // 
            winsLabel.AutoSize = true;
            winsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winsLabel.Location = new Point(385, 16);
            winsLabel.Name = "winsLabel";
            winsLabel.Size = new Size(54, 23);
            winsLabel.TabIndex = 12;
            winsLabel.Text = "Wins";
            // 
            // coachComboBox
            // 
            coachComboBox.FormattingEnabled = true;
            coachComboBox.Location = new Point(692, 57);
            coachComboBox.Name = "coachComboBox";
            coachComboBox.Size = new Size(186, 28);
            coachComboBox.TabIndex = 11;
            // 
            // coachLabel
            // 
            coachLabel.AutoSize = true;
            coachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coachLabel.Location = new Point(692, 16);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new Size(143, 23);
            coachLabel.TabIndex = 10;
            coachLabel.Text = "Coach Name";
            // 
            // deleteTeamLabel
            // 
            deleteTeamLabel.AutoSize = true;
            deleteTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTeamLabel.Location = new Point(596, 182);
            deleteTeamLabel.Name = "deleteTeamLabel";
            deleteTeamLabel.Size = new Size(133, 23);
            deleteTeamLabel.TabIndex = 9;
            deleteTeamLabel.Text = "Delete Team";
            // 
            // editTeamLabel
            // 
            editTeamLabel.AutoSize = true;
            editTeamLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTeamLabel.Location = new Point(315, 171);
            editTeamLabel.Name = "editTeamLabel";
            editTeamLabel.Size = new Size(103, 23);
            editTeamLabel.TabIndex = 8;
            editTeamLabel.Text = "Edit Team";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(30, 57);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(278, 27);
            teamNameTextBox.TabIndex = 7;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.Location = new Point(30, 16);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(129, 23);
            teamNameLabel.TabIndex = 6;
            teamNameLabel.Text = "Team Name";
            // 
            // teamErrorProvider
            // 
            teamErrorProvider.ContainerControl = this;
            // 
            // activeTeamsDataGrip
            // 
            activeTeamsDataGrip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activeTeamsDataGrip.BackgroundColor = SystemColors.ButtonFace;
            activeTeamsDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeTeamsDataGrip.Location = new Point(114, 367);
            activeTeamsDataGrip.Name = "activeTeamsDataGrip";
            activeTeamsDataGrip.RowHeadersWidth = 51;
            activeTeamsDataGrip.Size = new Size(1177, 209);
            activeTeamsDataGrip.TabIndex = 0;
            // 
            // contentTeamsPanel
            // 
            contentTeamsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentTeamsPanel.Controls.Add(activeTeamsDataGrip);
            contentTeamsPanel.Location = new Point(0, 125);
            contentTeamsPanel.Name = "contentTeamsPanel";
            contentTeamsPanel.Size = new Size(1367, 576);
            contentTeamsPanel.TabIndex = 1;
            // 
            // pdfLabel
            // 
            pdfLabel.AutoSize = true;
            pdfLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdfLabel.Location = new Point(870, 182);
            pdfLabel.Name = "pdfLabel";
            pdfLabel.Size = new Size(144, 23);
            pdfLabel.TabIndex = 42;
            pdfLabel.Text = "Generate PDF";
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 705);
            Controls.Add(teamPanel);
            Controls.Add(contentTeamsPanel);
            Controls.Add(headerTeamsPanel);
            Name = "TeamsForm";
            Text = "TeamsForm";
            headerTeamsPanel.ResumeLayout(false);
            headerTeamsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            teamPanel.ResumeLayout(false);
            teamPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teamErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)activeTeamsDataGrip).EndInit();
            contentTeamsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerTeamsPanel;
        private Label teamsLabel;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private TextBox searchTeamTextBox;
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
        private Panel contentTeamsPanel;
        private DataGridView activeTeamsDataGrip;
        private Label addTeamLabel;
        private FontAwesome.Sharp.IconButton PDFBtn;
        private Label pdfLabel;
    }
}