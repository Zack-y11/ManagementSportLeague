namespace PresentationLayer.ManagerForms
{
    partial class PlayersForm
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
            textBoxName = new TextBox();
            labelPlayers = new Label();
            playerInfoDataGrip = new DataGridView();
            labelName = new Label();
            labelLastname = new Label();
            textBoxLastname = new TextBox();
            panelPlayers = new Panel();
            assistsTextBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            birthdayLabel = new Label();
            teamComboBox = new ComboBox();
            teamLabel = new Label();
            textBox1 = new TextBox();
            labelPosition = new Label();
            btnEditPlayer = new FontAwesome.Sharp.IconButton();
            btnDeletePlayer = new FontAwesome.Sharp.IconButton();
            btnAddPlayer = new FontAwesome.Sharp.IconButton();
            textBoxAge = new TextBox();
            labelAge = new Label();
            ((System.ComponentModel.ISupportInitialize)playerInfoDataGrip).BeginInit();
            panelPlayers.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(148, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(20, 35);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(292, 37);
            labelPlayers.TabIndex = 2;
            labelPlayers.Text = "Players Information";
            // 
            // playerInfoDataGrip
            // 
            playerInfoDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            playerInfoDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerInfoDataGrip.Location = new Point(35, 12);
            playerInfoDataGrip.Name = "playerInfoDataGrip";
            playerInfoDataGrip.RowHeadersWidth = 51;
            playerInfoDataGrip.Size = new Size(432, 518);
            playerInfoDataGrip.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(15, 100);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 18);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastname.ForeColor = Color.White;
            labelLastname.Location = new Point(267, 100);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(80, 18);
            labelLastname.TabIndex = 6;
            labelLastname.Text = "LastName";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(358, 96);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(147, 27);
            textBoxLastname.TabIndex = 8;
            // 
            // panelPlayers
            // 
            panelPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelPlayers.BackColor = Color.FromArgb(202, 138, 4);
            panelPlayers.Controls.Add(assistsTextBox);
            panelPlayers.Controls.Add(label1);
            panelPlayers.Controls.Add(dateTimePicker1);
            panelPlayers.Controls.Add(birthdayLabel);
            panelPlayers.Controls.Add(teamComboBox);
            panelPlayers.Controls.Add(teamLabel);
            panelPlayers.Controls.Add(textBox1);
            panelPlayers.Controls.Add(labelPosition);
            panelPlayers.Controls.Add(btnEditPlayer);
            panelPlayers.Controls.Add(btnDeletePlayer);
            panelPlayers.Controls.Add(btnAddPlayer);
            panelPlayers.Controls.Add(textBoxAge);
            panelPlayers.Controls.Add(labelAge);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Controls.Add(textBoxLastname);
            panelPlayers.Controls.Add(textBoxName);
            panelPlayers.Controls.Add(labelName);
            panelPlayers.Controls.Add(labelLastname);
            panelPlayers.Location = new Point(710, 12);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(527, 518);
            panelPlayers.TabIndex = 9;
            // 
            // assistsTextBox
            // 
            assistsTextBox.Location = new Point(101, 265);
            assistsTextBox.Name = "assistsTextBox";
            assistsTextBox.Size = new Size(148, 27);
            assistsTextBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 274);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 20;
            label1.Text = "Assists";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(358, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthdayLabel.ForeColor = Color.White;
            birthdayLabel.Location = new Point(267, 161);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(68, 18);
            birthdayLabel.TabIndex = 18;
            birthdayLabel.Text = "Birthday";
            // 
            // teamComboBox
            // 
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(101, 161);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(148, 28);
            teamComboBox.TabIndex = 17;
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamLabel.ForeColor = Color.White;
            teamLabel.Location = new Point(20, 161);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(48, 18);
            teamLabel.TabIndex = 16;
            teamLabel.Text = "Team";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 15;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(20, 216);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(63, 18);
            labelPosition.TabIndex = 14;
            labelPosition.Text = "Position";
            // 
            // btnEditPlayer
            // 
            btnEditPlayer.FlatAppearance.BorderSize = 0;
            btnEditPlayer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPlayer.ForeColor = Color.Black;
            btnEditPlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            btnEditPlayer.IconColor = Color.Black;
            btnEditPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditPlayer.Location = new Point(267, 329);
            btnEditPlayer.Name = "btnEditPlayer";
            btnEditPlayer.Padding = new Padding(12, 0, 0, 0);
            btnEditPlayer.Size = new Size(225, 46);
            btnEditPlayer.TabIndex = 13;
            btnEditPlayer.Text = "   Edit Player";
            btnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.FlatAppearance.BorderSize = 0;
            btnDeletePlayer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePlayer.ForeColor = Color.Black;
            btnDeletePlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            btnDeletePlayer.IconColor = Color.Black;
            btnDeletePlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletePlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePlayer.Location = new Point(20, 420);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Padding = new Padding(12, 0, 0, 0);
            btnDeletePlayer.Size = new Size(229, 46);
            btnDeletePlayer.TabIndex = 12;
            btnDeletePlayer.Text = "   Delete Player";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.FlatAppearance.BorderSize = 0;
            btnAddPlayer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlayer.ForeColor = Color.Black;
            btnAddPlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            btnAddPlayer.IconColor = Color.Black;
            btnAddPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPlayer.Location = new Point(20, 329);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Padding = new Padding(12, 0, 0, 0);
            btnAddPlayer.Size = new Size(229, 46);
            btnAddPlayer.TabIndex = 11;
            btnAddPlayer.Text = "   Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(358, 216);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(147, 27);
            textBoxAge.TabIndex = 10;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(267, 216);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(51, 18);
            labelAge.TabIndex = 9;
            labelAge.Text = "Goals";
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 574);
            Controls.Add(panelPlayers);
            Controls.Add(playerInfoDataGrip);
            Name = "PlayersForm";
            Text = "PlayersForm";
            ((System.ComponentModel.ISupportInitialize)playerInfoDataGrip).EndInit();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private Label labelPlayers;
        private DataGridView playerInfoDataGrip;
        private Label labelName;
        private Label labelLastname;
        private TextBox textBoxLastname;
        private Panel panelPlayers;
        private TextBox textBoxAge;
        private Label labelAge;
        private FontAwesome.Sharp.IconButton btnAddPlayer;
        private FontAwesome.Sharp.IconButton btnEditPlayer;
        private FontAwesome.Sharp.IconButton btnDeletePlayer;
        private TextBox textBox1;
        private Label labelPosition;
        private Label teamLabel;
        private ComboBox teamComboBox;
        private Label birthdayLabel;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox assistsTextBox;
    }
}