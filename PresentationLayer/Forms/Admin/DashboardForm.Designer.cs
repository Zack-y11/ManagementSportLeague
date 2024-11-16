namespace PresentationLayer.Forms
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
            centerPanel = new Panel();
            contentPanel = new Panel();
            matchInformation = new DataGridView();
            matchInformationLabel = new Label();
            matchPanel = new Panel();
            editMatchLabel = new Label();
            deleteMatchLabel = new Label();
            vsTeamLabel = new Label();
            deleteMatchBtn = new FontAwesome.Sharp.IconButton();
            editMatchBtn = new FontAwesome.Sharp.IconButton();
            addMatchBtn = new FontAwesome.Sharp.IconButton();
            vsTeamComboBox = new ComboBox();
            vsLabel = new Label();
            teamLabel = new Label();
            matchTeamComboBox = new ComboBox();
            createMatchLabel = new Label();
            editCoachPanel = new Panel();
            coachInformationLabel = new Label();
            addCoachBtn = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            deleteCoachBtn = new FontAwesome.Sharp.IconButton();
            deleteCoachLabel = new Label();
            createCoachLabel = new Label();
            editCoachLabel = new Label();
            editCoachBtn = new FontAwesome.Sharp.IconButton();
            coachDataGrip = new DataGridView();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matchInformation).BeginInit();
            matchPanel.SuspendLayout();
            editCoachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coachDataGrip).BeginInit();
            SuspendLayout();
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 0);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(1371, 716);
            centerPanel.TabIndex = 10;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(matchInformation);
            contentPanel.Controls.Add(matchInformationLabel);
            contentPanel.Controls.Add(matchPanel);
            contentPanel.Controls.Add(editCoachPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1371, 716);
            contentPanel.TabIndex = 11;
            // 
            // matchInformation
            // 
            matchInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matchInformation.Location = new Point(536, 417);
            matchInformation.Name = "matchInformation";
            matchInformation.RowHeadersWidth = 51;
            matchInformation.Size = new Size(567, 255);
            matchInformation.TabIndex = 13;
            // 
            // matchInformationLabel
            // 
            matchInformationLabel.AutoSize = true;
            matchInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchInformationLabel.Location = new Point(536, 376);
            matchInformationLabel.Name = "matchInformationLabel";
            matchInformationLabel.Size = new Size(189, 23);
            matchInformationLabel.TabIndex = 12;
            matchInformationLabel.Text = "Match Information";
            // 
            // matchPanel
            // 
            matchPanel.Controls.Add(editMatchLabel);
            matchPanel.Controls.Add(deleteMatchLabel);
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
            matchPanel.Size = new Size(838, 353);
            matchPanel.TabIndex = 11;
            // 
            // editMatchLabel
            // 
            editMatchLabel.AutoSize = true;
            editMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMatchLabel.Location = new Point(347, 167);
            editMatchLabel.Name = "editMatchLabel";
            editMatchLabel.Size = new Size(112, 23);
            editMatchLabel.TabIndex = 15;
            editMatchLabel.Text = "Edit Match";
            // 
            // deleteMatchLabel
            // 
            deleteMatchLabel.AutoSize = true;
            deleteMatchLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMatchLabel.Location = new Point(347, 250);
            deleteMatchLabel.Name = "deleteMatchLabel";
            deleteMatchLabel.Size = new Size(142, 23);
            deleteMatchLabel.TabIndex = 15;
            deleteMatchLabel.Text = "Delete Match";
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
            deleteMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            deleteMatchBtn.IconColor = Color.White;
            deleteMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteMatchBtn.Location = new Point(347, 285);
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
            editMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            editMatchBtn.IconColor = Color.White;
            editMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editMatchBtn.Location = new Point(347, 197);
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
            addMatchBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            addMatchBtn.IconColor = Color.White;
            addMatchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addMatchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMatchBtn.Location = new Point(347, 108);
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
            vsTeamComboBox.Size = new Size(238, 28);
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
            matchTeamComboBox.Size = new Size(238, 28);
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
            editCoachPanel.Controls.Add(createCoachLabel);
            editCoachPanel.Controls.Add(editCoachLabel);
            editCoachPanel.Controls.Add(editCoachBtn);
            editCoachPanel.Controls.Add(coachDataGrip);
            editCoachPanel.Dock = DockStyle.Left;
            editCoachPanel.Location = new Point(0, 0);
            editCoachPanel.Name = "editCoachPanel";
            editCoachPanel.Size = new Size(524, 716);
            editCoachPanel.TabIndex = 10;
            // 
            // coachInformationLabel
            // 
            coachInformationLabel.AutoSize = true;
            coachInformationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coachInformationLabel.Location = new Point(25, 376);
            coachInformationLabel.Name = "coachInformationLabel";
            coachInformationLabel.Size = new Size(194, 23);
            coachInformationLabel.TabIndex = 14;
            coachInformationLabel.Text = "Coach Information";
            // 
            // addCoachBtn
            // 
            addCoachBtn.BackColor = Color.Green;
            addCoachBtn.FlatStyle = FlatStyle.Flat;
            addCoachBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCoachBtn.ForeColor = Color.White;
            addCoachBtn.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            addCoachBtn.IconColor = Color.White;
            addCoachBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
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
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 6;
            // 
            // deleteCoachBtn
            // 
            deleteCoachBtn.BackColor = Color.Red;
            deleteCoachBtn.FlatStyle = FlatStyle.Flat;
            deleteCoachBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCoachBtn.ForeColor = Color.White;
            deleteCoachBtn.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            deleteCoachBtn.IconColor = Color.White;
            deleteCoachBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteCoachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteCoachBtn.Location = new Point(12, 288);
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
            deleteCoachLabel.Location = new Point(12, 253);
            deleteCoachLabel.Name = "deleteCoachLabel";
            deleteCoachLabel.Size = new Size(147, 23);
            deleteCoachLabel.TabIndex = 8;
            deleteCoachLabel.Text = "Delete Coach";
            // 
            // createCoachLabel
            // 
            createCoachLabel.AutoSize = true;
            createCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createCoachLabel.Location = new Point(15, 24);
            createCoachLabel.Name = "createCoachLabel";
            createCoachLabel.Size = new Size(174, 23);
            createCoachLabel.TabIndex = 5;
            createCoachLabel.Text = "Add New Coach";
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
            editCoachBtn.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            editCoachBtn.IconColor = Color.White;
            editCoachBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
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
            coachDataGrip.Location = new Point(15, 417);
            coachDataGrip.Name = "coachDataGrip";
            coachDataGrip.RowHeadersWidth = 51;
            coachDataGrip.Size = new Size(484, 255);
            coachDataGrip.TabIndex = 6;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 716);
            Controls.Add(contentPanel);
            Controls.Add(centerPanel);
            Name = "DashboardForm";
            Text = "DashboardForm";
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
        private Panel centerPanel;
        private Panel contentPanel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton addCoachBtn;
        private Label createCoachLabel;
        private Panel editCoachPanel;
        private FontAwesome.Sharp.IconButton editCoachBtn;
        private DataGridView coachDataGrip;
        private Label deleteCoachLabel;
        private Label editCoachLabel;
        private FontAwesome.Sharp.IconButton deleteCoachBtn;
        private Label createMatchLabel;
        private Panel matchPanel;
        private Label teamLabel;
        private ComboBox matchTeamComboBox;
        private Label vsLabel;
        private ComboBox vsTeamComboBox;
        private FontAwesome.Sharp.IconButton addMatchBtn;
        private FontAwesome.Sharp.IconButton editMatchBtn;
        private FontAwesome.Sharp.IconButton deleteMatchBtn;
        private Label vsTeamLabel;
        private Label matchInformationLabel;
        private DataGridView matchInformation;
        private Label coachInformationLabel;
        private Label deleteMatchLabel;
        private Label editMatchLabel;
    }
}