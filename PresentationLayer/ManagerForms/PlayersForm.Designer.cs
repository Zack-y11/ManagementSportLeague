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
            dataGridViewPlayers = new DataGridView();
            labelName = new Label();
            labelLastname = new Label();
            textBoxLastname = new TextBox();
            panelPlayers = new Panel();
            textBox1 = new TextBox();
            labelPosition = new Label();
            btnEditPlayer = new FontAwesome.Sharp.IconButton();
            btnDeletePlayer = new FontAwesome.Sharp.IconButton();
            btnAddPlayer = new FontAwesome.Sharp.IconButton();
            textBoxAge = new TextBox();
            labelAge = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panelPlayers.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 114);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(166, 27);
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
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(35, 35);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.RowHeadersWidth = 51;
            dataGridViewPlayers.Size = new Size(542, 283);
            dataGridViewPlayers.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(15, 118);
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
            labelLastname.Location = new Point(15, 172);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(80, 18);
            labelLastname.TabIndex = 6;
            labelLastname.Text = "LastName";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(101, 172);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(166, 27);
            textBoxLastname.TabIndex = 8;
            // 
            // panelPlayers
            // 
            panelPlayers.BackColor = Color.FromArgb(202, 138, 4);
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
            panelPlayers.Location = new Point(642, 12);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(323, 500);
            panelPlayers.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 15;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(20, 288);
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
            btnEditPlayer.Location = new Point(40, 381);
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
            btnDeletePlayer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePlayer.ForeColor = Color.Black;
            btnDeletePlayer.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            btnDeletePlayer.IconColor = Color.Black;
            btnDeletePlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletePlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePlayer.Location = new Point(40, 433);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Padding = new Padding(12, 0, 0, 0);
            btnDeletePlayer.Size = new Size(248, 46);
            btnDeletePlayer.TabIndex = 12;
            btnDeletePlayer.Text = "Delete Player";
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
            btnAddPlayer.Location = new Point(40, 329);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Padding = new Padding(12, 0, 0, 0);
            btnAddPlayer.Size = new Size(248, 46);
            btnAddPlayer.TabIndex = 11;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(101, 227);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(166, 27);
            textBoxAge.TabIndex = 10;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(20, 236);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(39, 18);
            labelAge.TabIndex = 9;
            labelAge.Text = "Age";
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 574);
            Controls.Add(panelPlayers);
            Controls.Add(dataGridViewPlayers);
            Name = "PlayersForm";
            Text = "PlayersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private Label labelPlayers;
        private DataGridView dataGridViewPlayers;
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
    }
}