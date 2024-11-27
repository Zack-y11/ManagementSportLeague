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
            playersDataGridView = new DataGridView();
            labelName = new Label();
            panelPlayers = new Panel();
            playerBirthdateDateTimePicker = new DateTimePicker();
            playerPasswordTextBox = new TextBox();
            playerPasswordLabel = new Label();
            playerEmailTextBox = new TextBox();
            playerEmailLabel = new Label();
            positionTextbox = new TextBox();
            PositionLabel = new Label();
            btnAddPlayer = new FontAwesome.Sharp.IconButton();
            playerBirthdateLabel = new Label();
            btnEditPlayer = new FontAwesome.Sharp.IconButton();
            btnDeletePlayer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)playersDataGridView).BeginInit();
            panelPlayers.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 180);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(166, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(20, 35);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(262, 36);
            labelPlayers.TabIndex = 2;
            labelPlayers.Text = "Add a new player";
            // 
            // playersDataGridView
            // 
            playersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playersDataGridView.Location = new Point(35, 35);
            playersDataGridView.Name = "playersDataGridView";
            playersDataGridView.RowHeadersWidth = 51;
            playersDataGridView.Size = new Size(542, 283);
            playersDataGridView.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(15, 184);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 18);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // panelPlayers
            // 
            panelPlayers.BackColor = Color.FromArgb(202, 138, 4);
            panelPlayers.Controls.Add(playerBirthdateDateTimePicker);
            panelPlayers.Controls.Add(playerPasswordTextBox);
            panelPlayers.Controls.Add(playerPasswordLabel);
            panelPlayers.Controls.Add(playerEmailTextBox);
            panelPlayers.Controls.Add(playerEmailLabel);
            panelPlayers.Controls.Add(positionTextbox);
            panelPlayers.Controls.Add(PositionLabel);
            panelPlayers.Controls.Add(btnAddPlayer);
            panelPlayers.Controls.Add(playerBirthdateLabel);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Controls.Add(textBoxName);
            panelPlayers.Controls.Add(labelName);
            panelPlayers.Location = new Point(600, 12);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(421, 429);
            panelPlayers.TabIndex = 9;
            // 
            // playerBirthdateDateTimePicker
            // 
            playerBirthdateDateTimePicker.Location = new Point(188, 230);
            playerBirthdateDateTimePicker.Name = "playerBirthdateDateTimePicker";
            playerBirthdateDateTimePicker.Size = new Size(186, 27);
            playerBirthdateDateTimePicker.TabIndex = 20;
            // 
            // playerPasswordTextBox
            // 
            playerPasswordTextBox.Location = new Point(101, 124);
            playerPasswordTextBox.Name = "playerPasswordTextBox";
            playerPasswordTextBox.Size = new Size(166, 27);
            playerPasswordTextBox.TabIndex = 18;
            // 
            // playerPasswordLabel
            // 
            playerPasswordLabel.AutoSize = true;
            playerPasswordLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerPasswordLabel.ForeColor = Color.White;
            playerPasswordLabel.Location = new Point(15, 128);
            playerPasswordLabel.Name = "playerPasswordLabel";
            playerPasswordLabel.Size = new Size(83, 18);
            playerPasswordLabel.TabIndex = 19;
            playerPasswordLabel.Text = "Password";
            // 
            // playerEmailTextBox
            // 
            playerEmailTextBox.Location = new Point(101, 81);
            playerEmailTextBox.Name = "playerEmailTextBox";
            playerEmailTextBox.Size = new Size(166, 27);
            playerEmailTextBox.TabIndex = 16;
            // 
            // playerEmailLabel
            // 
            playerEmailLabel.AutoSize = true;
            playerEmailLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerEmailLabel.ForeColor = Color.White;
            playerEmailLabel.Location = new Point(15, 85);
            playerEmailLabel.Name = "playerEmailLabel";
            playerEmailLabel.Size = new Size(50, 18);
            playerEmailLabel.TabIndex = 17;
            playerEmailLabel.Text = "Email";
            // 
            // positionTextbox
            // 
            positionTextbox.Location = new Point(101, 279);
            positionTextbox.Name = "positionTextbox";
            positionTextbox.Size = new Size(166, 27);
            positionTextbox.TabIndex = 15;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PositionLabel.ForeColor = Color.White;
            PositionLabel.Location = new Point(20, 288);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(70, 18);
            PositionLabel.TabIndex = 14;
            PositionLabel.Text = "Position";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.FlatAppearance.BorderSize = 0;
            btnAddPlayer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlayer.ForeColor = Color.Black;
            btnAddPlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            btnAddPlayer.IconColor = Color.Black;
            btnAddPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPlayer.Location = new Point(15, 329);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Padding = new Padding(12, 0, 0, 0);
            btnAddPlayer.Size = new Size(248, 46);
            btnAddPlayer.TabIndex = 11;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // playerBirthdateLabel
            // 
            playerBirthdateLabel.AutoSize = true;
            playerBirthdateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerBirthdateLabel.ForeColor = Color.White;
            playerBirthdateLabel.Location = new Point(18, 236);
            playerBirthdateLabel.Name = "playerBirthdateLabel";
            playerBirthdateLabel.Size = new Size(164, 18);
            playerBirthdateLabel.TabIndex = 9;
            playerBirthdateLabel.Text = "Fecha de nacimiento";
            // 
            // btnEditPlayer
            // 
            btnEditPlayer.FlatAppearance.BorderSize = 0;
            btnEditPlayer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPlayer.ForeColor = Color.Black;
            btnEditPlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            btnEditPlayer.IconColor = Color.Black;
            btnEditPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditPlayer.Location = new Point(329, 341);
            btnEditPlayer.Name = "btnEditPlayer";
            btnEditPlayer.Padding = new Padding(12, 0, 0, 0);
            btnEditPlayer.Size = new Size(248, 46);
            btnEditPlayer.TabIndex = 13;
            btnEditPlayer.Text = "Edit Player";
            btnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.FlatAppearance.BorderSize = 0;
            btnDeletePlayer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePlayer.ForeColor = Color.Black;
            btnDeletePlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            btnDeletePlayer.IconColor = Color.Black;
            btnDeletePlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletePlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePlayer.Location = new Point(35, 341);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Padding = new Padding(12, 0, 0, 0);
            btnDeletePlayer.Size = new Size(248, 46);
            btnDeletePlayer.TabIndex = 12;
            btnDeletePlayer.Text = "Delete Player";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 574);
            Controls.Add(panelPlayers);
            Controls.Add(playersDataGridView);
            Controls.Add(btnDeletePlayer);
            Controls.Add(btnEditPlayer);
            Name = "PlayersForm";
            Text = "PlayersForm";
            ((System.ComponentModel.ISupportInitialize)playersDataGridView).EndInit();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private Label labelPlayers;
        private DataGridView playersDataGridView;
        private Label labelName;
        private Label labelLastname;
        private TextBox textBoxLastname;
        private Panel panelPlayers;
        private TextBox textBoxAge;
        private Label playerBirthdateLabel;
        private FontAwesome.Sharp.IconButton btnAddPlayer;
        private FontAwesome.Sharp.IconButton btnEditPlayer;
        private FontAwesome.Sharp.IconButton btnDeletePlayer;
        private TextBox positionTextbox;
        private Label PositionLabel;
        private TextBox playerEmailTextBox;
        private Label playerEmailLabel;
        private TextBox playerPasswordTextBox;
        private Label playerPasswordLabel;
        private DateTimePicker playerBirthdateDateTimePicker;
    }
}