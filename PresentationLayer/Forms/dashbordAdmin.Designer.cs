using FontAwesome.Sharp;

namespace PresentationLayer.Forms
{
    partial class dashboardAdmin
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
            panel1 = new Panel();
            panel2 = new Panel();
            dashboardBtn = new IconButton();
            settingsBtn = new IconButton();
            statisticsBtn = new IconButton();
            featuresBtn = new IconButton();
            teamsBtn = new IconButton();
            iconPictureBox1 = new IconPictureBox();
            sportLabel = new Label();
            headerPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contentPanel = new Panel();
            matchInformation = new DataGridView();
            matchInformationLabel = new Label();
            matchPanel = new Panel();
            deleteMachLabel = new Label();
            editMatchLabel = new Label();
            vsTeamLabel = new Label();
            deleteMatchBtn = new IconButton();
            editMatchBtn = new IconButton();
            addMatchBtn = new IconButton();
            vsTeamComboBox = new ComboBox();
            vsLabel = new Label();
            teamLabel = new Label();
            matchTeamComboBox = new ComboBox();
            createMatchLabel = new Label();
            editCoachPanel = new Panel();
            coachInformationLabel = new Label();
            addCoachBtn = new IconButton();
            textBox1 = new TextBox();
            deleteCoachBtn = new IconButton();
            deleteCoachLabel = new Label();
            label1 = new Label();
            editCoachLabel = new Label();
            editCoachBtn = new IconButton();
            coachDataGrip = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).BeginInit();
            matchPanel.SuspendLayout();
            editCoachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coachDataGrip).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(statisticsBtn);
            panel1.Controls.Add(featuresBtn);
            panel1.Controls.Add(teamsBtn);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(sportLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 753);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 139);
            panel2.TabIndex = 0;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dashboardBtn.IconChar = IconChar.Newspaper;
            dashboardBtn.IconColor = Color.Black;
            dashboardBtn.IconFont = IconFont.Auto;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(0, 120);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(263, 59);
            dashboardBtn.TabIndex = 7;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            settingsBtn.IconChar = IconChar.Cogs;
            settingsBtn.IconColor = Color.Black;
            settingsBtn.IconFont = IconFont.Auto;
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(0, 342);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(263, 59);
            settingsBtn.TabIndex = 6;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // statisticsBtn
            // 
            statisticsBtn.FlatStyle = FlatStyle.Flat;
            statisticsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            statisticsBtn.IconChar = IconChar.Squarespace;
            statisticsBtn.IconColor = Color.Black;
            statisticsBtn.IconFont = IconFont.Auto;
            statisticsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            statisticsBtn.Location = new Point(0, 286);
            statisticsBtn.Name = "statisticsBtn";
            statisticsBtn.Size = new Size(263, 59);
            statisticsBtn.TabIndex = 5;
            statisticsBtn.Text = "Statistics";
            statisticsBtn.UseVisualStyleBackColor = true;
            // 
            // featuresBtn
            // 
            featuresBtn.FlatStyle = FlatStyle.Flat;
            featuresBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            featuresBtn.IconChar = IconChar.FileText;
            featuresBtn.IconColor = Color.Black;
            featuresBtn.IconFont = IconFont.Auto;
            featuresBtn.ImageAlign = ContentAlignment.MiddleLeft;
            featuresBtn.Location = new Point(0, 231);
            featuresBtn.Name = "featuresBtn";
            featuresBtn.Size = new Size(263, 59);
            featuresBtn.TabIndex = 4;
            featuresBtn.Text = "Features";
            featuresBtn.UseVisualStyleBackColor = true;
            // 
            // teamsBtn
            // 
            teamsBtn.FlatStyle = FlatStyle.Flat;
            teamsBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            teamsBtn.IconChar = IconChar.Users;
            teamsBtn.IconColor = Color.Black;
            teamsBtn.IconFont = IconFont.Auto;
            teamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            teamsBtn.Location = new Point(0, 175);
            teamsBtn.Name = "teamsBtn";
            teamsBtn.Size = new Size(263, 59);
            teamsBtn.TabIndex = 3;
            teamsBtn.Text = "Teams";
            teamsBtn.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.HotTrack;
            iconPictureBox1.IconChar = IconChar.Trophy;
            iconPictureBox1.IconColor = SystemColors.HotTrack;
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // sportLabel
            // 
            sportLabel.AutoSize = true;
            sportLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            sportLabel.Location = new Point(58, 21);
            sportLabel.Name = "sportLabel";
            sportLabel.Size = new Size(186, 32);
            sportLabel.TabIndex = 2;
            sportLabel.Text = "Sport League";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(263, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1156, 61);
            headerPanel.TabIndex = 2;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.Control;
            contentPanel.Controls.Add(matchInformation);
            contentPanel.Controls.Add(matchInformationLabel);
            contentPanel.Controls.Add(matchPanel);
            contentPanel.Controls.Add(editCoachPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(263, 61);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1156, 692);
            contentPanel.TabIndex = 5;
            // 
            // matchInformation
            // 
            matchInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matchInformation.Location = new Point(533, 422);
            matchInformation.Name = "matchInformation";
            matchInformation.RowHeadersWidth = 51;
            matchInformation.Size = new Size(589, 226);
            matchInformation.TabIndex = 14;
            // 
            // matchInformationLabel
            // 
            matchInformationLabel.AutoSize = true;
            matchInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchInformationLabel.Location = new Point(544, 379);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(189, 23);
            matchInformationLabel.TabIndex = 13;
            matchInformationLabel.Text = "Match Information";
            // 
            // matchPanel
            // 
            matchPanel.BackColor = SystemColors.Control;
            matchPanel.Controls.Add(deleteMachLabel);
            matchPanel.Controls.Add(editMatchLabel);
            matchPanel.Controls.Add(vsTeamLabel);
            matchPanel.Controls.Add(deleteMatchBtn);
            matchPanel.Controls.Add(editMatchBtn);
            matchPanel.Controls.Add(addMatchBtn);
            matchPanel.Controls.Add(vsTeamComboBox);
            matchPanel.Controls.Add(vsLabel);
            matchPanel.Controls.Add(teamLabel);
            matchPanel.Controls.Add(matchTeamComboBox);
            matchPanel.Controls.Add(createMatchLabel);
            matchPanel.Location = new Point(530, 3);
            matchPanel.Name = "matchPanel";
            matchPanel.Size = new Size(586, 353);
            matchPanel.TabIndex = 12;
            // 
            // deleteMachLabel
            // 
            deleteMachLabel.AutoSize = true;
            deleteMachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMachLabel.Location = new Point(347, 241);
            deleteMachLabel.Name = "deleteMachLabel";
            deleteMachLabel.Size = new Size(142, 23);
            deleteMachLabel.TabIndex = 17;
            deleteMachLabel.Text = "Delete Match";
            // 
            // editMatchLabel
            // 
            editMatchLabel.AutoSize = true;
            editMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchLabel.Location = new Point(347, 156);
            editMatchLabel.Name = "editMatchLabel";
            editMatchLabel.Size = new Size(112, 23);
            editMatchLabel.TabIndex = 16;
            editMatchLabel.Text = "Edit Match";
            // 
            // vsTeamLabel
            // 
            vsTeamLabel.AutoSize = true;
            vsTeamLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            vsTeamLabel.Location = new Point(3, 209);
            vsTeamLabel.Name = "vsTeamLabel";
            vsTeamLabel.Size = new Size(59, 19);
            vsTeamLabel.TabIndex = 15;
            vsTeamLabel.Text = "Team:";
            // 
            // deleteMatchBtn
            // 
            deleteMatchBtn.BackColor = Color.Red;
            deleteMatchBtn.FlatStyle = FlatStyle.Flat;
            deleteMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMatchBtn.ForeColor = Color.White;
            deleteMatchBtn.IconChar = IconChar.UserSlash;
            deleteMatchBtn.IconColor = Color.White;
            deleteMatchBtn.IconFont = IconFont.Auto;
            deleteMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteMatchBtn.Location = new Point(347, 269);
            deleteMatchBtn.Name = "deleteMatchBtn";
            deleteMatchBtn.Size = new Size(226, 43);
            deleteMatchBtn.TabIndex = 10;
            deleteMatchBtn.Text = "Delete Match";
            deleteMatchBtn.UseVisualStyleBackColor = false;
            // 
            // editMatchBtn
            // 
            editMatchBtn.BackColor = Color.FromArgb(0, 123, 250);
            editMatchBtn.FlatStyle = FlatStyle.Flat;
            editMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchBtn.ForeColor = Color.White;
            editMatchBtn.IconChar = IconChar.UserCheck;
            editMatchBtn.IconColor = Color.White;
            editMatchBtn.IconFont = IconFont.Auto;
            editMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editMatchBtn.Location = new Point(347, 183);
            editMatchBtn.Name = "editMatchBtn";
            editMatchBtn.Size = new Size(226, 43);
            editMatchBtn.TabIndex = 10;
            editMatchBtn.Text = "Edit Match";
            editMatchBtn.UseVisualStyleBackColor = false;
            // 
            // addMatchBtn
            // 
            addMatchBtn.BackColor = Color.Green;
            addMatchBtn.FlatStyle = FlatStyle.Flat;
            addMatchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMatchBtn.ForeColor = Color.White;
            addMatchBtn.IconChar = IconChar.UserPlus;
            addMatchBtn.IconColor = Color.White;
            addMatchBtn.IconFont = IconFont.Auto;
            addMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMatchBtn.Location = new Point(347, 96);
            addMatchBtn.Name = "addMatchBtn";
            addMatchBtn.Size = new Size(226, 43);
            addMatchBtn.TabIndex = 10;
            addMatchBtn.Text = "Create Match";
            addMatchBtn.UseVisualStyleBackColor = false;
            // 
            // vsTeamComboBox
            // 
            vsTeamComboBox.FormattingEnabled = true;
            vsTeamComboBox.Location = new Point(0, 241);
            vsTeamComboBox.Name = "vsTeamComboBox";
            vsTeamComboBox.Size = new Size(238, 26);
            vsTeamComboBox.TabIndex = 14;
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            vsLabel.ForeColor = Color.Gold;
            vsLabel.Location = new Point(3, 156);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(40, 23);
            vsLabel.TabIndex = 13;
            vsLabel.Text = "VS:";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            teamLabel.Location = new Point(3, 63);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(59, 19);
            teamLabel.TabIndex = 12;
            teamLabel.Text = "Team:";
            // 
            // matchTeamComboBox
            // 
            matchTeamComboBox.FormattingEnabled = true;
            matchTeamComboBox.Location = new Point(3, 98);
            matchTeamComboBox.Name = "matchTeamComboBox";
            matchTeamComboBox.Size = new Size(238, 26);
            matchTeamComboBox.TabIndex = 11;
            // 
            // createMatchLabel
            // 
            createMatchLabel.AutoSize = true;
            createMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMatchLabel.Location = new Point(3, 21);
            createMatchLabel.Name = "createMatchLabel";
            createMatchLabel.Size = new Size(145, 23);
            createMatchLabel.TabIndex = 10;
            createMatchLabel.Text = "Create Match";
            // 
            // editCoachPanel
            // 
            editCoachPanel.BackColor = Color.WhiteSmoke;
            editCoachPanel.Controls.Add(coachInformationLabel);
            editCoachPanel.Controls.Add(addCoachBtn);
            editCoachPanel.Controls.Add(textBox1);
            editCoachPanel.Controls.Add(deleteCoachBtn);
            editCoachPanel.Controls.Add(deleteCoachLabel);
            editCoachPanel.Controls.Add(label1);
            editCoachPanel.Controls.Add(editCoachLabel);
            editCoachPanel.Controls.Add(editCoachBtn);
            editCoachPanel.Controls.Add(coachDataGrip);
            editCoachPanel.Dock = DockStyle.Left;
            editCoachPanel.Location = new Point(0, 0);
            editCoachPanel.Name = "editCoachPanel";
            editCoachPanel.Size = new Size(524, 692);
            editCoachPanel.TabIndex = 11;
            // 
            // coachInformationLabel
            // 
            coachInformationLabel.AutoSize = true;
            coachInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coachInformationLabel.Location = new Point(15, 379);
            coachInformationLabel.Name = "coachInformationLabel";
            coachInformationLabel.Size = new Size(194, 23);
            coachInformationLabel.TabIndex = 15;
            coachInformationLabel.Text = "Coach Information";
            // 
            // addCoachBtn
            // 
            addCoachBtn.BackColor = Color.Green;
            addCoachBtn.FlatStyle = FlatStyle.Flat;
            addCoachBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCoachBtn.ForeColor = Color.White;
            addCoachBtn.IconChar = IconChar.Users;
            addCoachBtn.IconColor = Color.White;
            addCoachBtn.IconFont = IconFont.Auto;
            addCoachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addCoachBtn.Location = new Point(15, 111);
            addCoachBtn.Name = "addCoachBtn";
            addCoachBtn.Size = new Size(226, 43);
            addCoachBtn.TabIndex = 4;
            addCoachBtn.Text = "Add coach";
            addCoachBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 26);
            textBox1.TabIndex = 6;
            // 
            // deleteCoachBtn
            // 
            deleteCoachBtn.BackColor = Color.Red;
            deleteCoachBtn.FlatStyle = FlatStyle.Flat;
            deleteCoachBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCoachBtn.ForeColor = Color.White;
            deleteCoachBtn.IconChar = IconChar.Users;
            deleteCoachBtn.IconColor = Color.White;
            deleteCoachBtn.IconFont = IconFont.Auto;
            deleteCoachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteCoachBtn.Location = new Point(15, 281);
            deleteCoachBtn.Name = "deleteCoachBtn";
            deleteCoachBtn.Size = new Size(226, 43);
            deleteCoachBtn.TabIndex = 9;
            deleteCoachBtn.Text = "Delete Coach";
            deleteCoachBtn.UseVisualStyleBackColor = false;
            // 
            // deleteCoachLabel
            // 
            deleteCoachLabel.AutoSize = true;
            deleteCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCoachLabel.Location = new Point(15, 253);
            deleteCoachLabel.Name = "deleteCoachLabel";
            deleteCoachLabel.Size = new Size(147, 23);
            deleteCoachLabel.TabIndex = 8;
            deleteCoachLabel.Text = "Delete Coach";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(174, 23);
            label1.TabIndex = 5;
            label1.Text = "Add New Coach";
            // 
            // editCoachLabel
            // 
            editCoachLabel.AutoSize = true;
            editCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCoachLabel.Location = new Point(15, 170);
            editCoachLabel.Name = "editCoachLabel";
            editCoachLabel.Size = new Size(117, 23);
            editCoachLabel.TabIndex = 7;
            editCoachLabel.Text = "Edit Coach";
            // 
            // editCoachBtn
            // 
            editCoachBtn.BackColor = Color.FromArgb(0, 123, 250);
            editCoachBtn.FlatStyle = FlatStyle.Flat;
            editCoachBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCoachBtn.ForeColor = Color.White;
            editCoachBtn.IconChar = IconChar.Users;
            editCoachBtn.IconColor = Color.White;
            editCoachBtn.IconFont = IconFont.Auto;
            editCoachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editCoachBtn.Location = new Point(15, 200);
            editCoachBtn.Name = "editCoachBtn";
            editCoachBtn.Size = new Size(226, 43);
            editCoachBtn.TabIndex = 4;
            editCoachBtn.Text = "Edit coach";
            editCoachBtn.UseVisualStyleBackColor = false;
            // 
            // coachDataGrip
            // 
            coachDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coachDataGrip.Location = new Point(15, 422);
            coachDataGrip.Name = "coachDataGrip";
            coachDataGrip.RowHeadersWidth = 51;
            coachDataGrip.Size = new Size(483, 226);
            coachDataGrip.TabIndex = 6;
            // 
            // dashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1419, 753);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashbordAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).EndInit();
            matchPanel.ResumeLayout(false);
            matchPanel.PerformLayout();
            editCoachPanel.ResumeLayout(false);
            editCoachPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coachDataGrip).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label sportLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel headerPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton teamsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private IconButton featuresBtn;
        private IconButton statisticsBtn;
        private IconButton settingsBtn;
        private IconButton dashboardBtn;
        private Panel panel2;
        private Panel contentPanel;
        private Panel editCoachPanel;
        private IconButton addCoachBtn;
        private TextBox textBox1;
        private IconButton deleteCoachBtn;
        private Label deleteCoachLabel;
        private Label label1;
        private Label editCoachLabel;
        private IconButton editCoachBtn;
        private DataGridView coachDataGrip;
        private Panel matchPanel;
        private Label vsTeamLabel;
        private IconButton deleteMatchBtn;
        private IconButton editMatchBtn;
        private IconButton addMatchBtn;
        private ComboBox vsTeamComboBox;
        private Label vsLabel;
        private Label teamLabel;
        private ComboBox matchTeamComboBox;
        private Label createMatchLabel;
        private Label coachInformationLabel;
        private Label matchInformationLabel;
        private DataGridView matchInformation;
        private Label editMatchLabel;
        private Label deleteMachLabel;
    }
}