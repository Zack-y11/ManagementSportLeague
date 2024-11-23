namespace PresentationLayer.Forms
{
    partial class CoachForm
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
            contentPanel = new Panel();
            comboBox1 = new ComboBox();
            teamCoachLabel = new Label();
            coachInformationLabel = new Label();
            textBox1 = new TextBox();
            createCoachLabel = new Label();
            coachDataGrip = new DataGridView();
            rightPanel = new Panel();
            addCoachLabel = new Label();
            addCoachBtn = new FontAwesome.Sharp.IconButton();
            editCoachLabel = new Label();
            editCoachBtn = new FontAwesome.Sharp.IconButton();
            deleteCoachLabel = new Label();
            deleteCoachBtn = new FontAwesome.Sharp.IconButton();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coachDataGrip).BeginInit();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.WhiteSmoke;
            contentPanel.Controls.Add(rightPanel);
            contentPanel.Controls.Add(comboBox1);
            contentPanel.Controls.Add(teamCoachLabel);
            contentPanel.Controls.Add(coachInformationLabel);
            contentPanel.Controls.Add(textBox1);
            contentPanel.Controls.Add(createCoachLabel);
            contentPanel.Controls.Add(coachDataGrip);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1406, 716);
            contentPanel.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 16;
            // 
            // teamCoachLabel
            // 
            teamCoachLabel.AutoSize = true;
            teamCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamCoachLabel.Location = new Point(15, 120);
            teamCoachLabel.Name = "teamCoachLabel";
            teamCoachLabel.Size = new Size(149, 23);
            teamCoachLabel.TabIndex = 15;
            teamCoachLabel.Text = "Coach's Team";
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
            // textBox1
            // 
            textBox1.Location = new Point(15, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 6;
            // 
            // createCoachLabel
            // 
            createCoachLabel.AutoSize = true;
            createCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createCoachLabel.Location = new Point(15, 24);
            createCoachLabel.Name = "createCoachLabel";
            createCoachLabel.Size = new Size(143, 23);
            createCoachLabel.TabIndex = 5;
            createCoachLabel.Text = "Coach Name";
            // 
            // coachDataGrip
            // 
            coachDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coachDataGrip.Location = new Point(15, 417);
            coachDataGrip.Name = "coachDataGrip";
            coachDataGrip.RowHeadersWidth = 51;
            coachDataGrip.Size = new Size(714, 255);
            coachDataGrip.TabIndex = 6;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.Controls.Add(addCoachLabel);
            rightPanel.Controls.Add(addCoachBtn);
            rightPanel.Controls.Add(editCoachLabel);
            rightPanel.Controls.Add(editCoachBtn);
            rightPanel.Controls.Add(deleteCoachLabel);
            rightPanel.Controls.Add(deleteCoachBtn);
            rightPanel.Location = new Point(880, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(514, 713);
            rightPanel.TabIndex = 18;
            // 
            // addCoachLabel
            // 
            addCoachLabel.AutoSize = true;
            addCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCoachLabel.Location = new Point(29, 21);
            addCoachLabel.Name = "addCoachLabel";
            addCoachLabel.Size = new Size(124, 23);
            addCoachLabel.TabIndex = 18;
            addCoachLabel.Text = "Add Coach";
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
            addCoachBtn.Location = new Point(29, 63);
            addCoachBtn.Name = "addCoachBtn";
            addCoachBtn.Size = new Size(226, 43);
            addCoachBtn.TabIndex = 4;
            addCoachBtn.Text = "Add coach";
            addCoachBtn.UseVisualStyleBackColor = false;
            // 
            // editCoachLabel
            // 
            editCoachLabel.AutoSize = true;
            editCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCoachLabel.Location = new Point(29, 170);
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
            editCoachBtn.Location = new Point(29, 231);
            editCoachBtn.Name = "editCoachBtn";
            editCoachBtn.Size = new Size(226, 43);
            editCoachBtn.TabIndex = 4;
            editCoachBtn.Text = "Edit coach";
            editCoachBtn.UseVisualStyleBackColor = false;
            // 
            // deleteCoachLabel
            // 
            deleteCoachLabel.AutoSize = true;
            deleteCoachLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCoachLabel.Location = new Point(29, 341);
            deleteCoachLabel.Name = "deleteCoachLabel";
            deleteCoachLabel.Size = new Size(147, 23);
            deleteCoachLabel.TabIndex = 8;
            deleteCoachLabel.Text = "Delete Coach";
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
            deleteCoachBtn.Location = new Point(29, 414);
            deleteCoachBtn.Name = "deleteCoachBtn";
            deleteCoachBtn.Size = new Size(226, 43);
            deleteCoachBtn.TabIndex = 9;
            deleteCoachBtn.Text = "Delete Coach";
            deleteCoachBtn.UseVisualStyleBackColor = false;
            // 
            // CoachForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 716);
            Controls.Add(contentPanel);
            Name = "CoachForm";
            Text = "CoachForm";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coachDataGrip).EndInit();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Label coachInformationLabel;
        private TextBox textBox1;
        private Label createCoachLabel;
        private DataGridView coachDataGrip;
        private Label teamCoachLabel;
        private ComboBox comboBox1;
        private Panel rightPanel;
        private Label addCoachLabel;
        private FontAwesome.Sharp.IconButton addCoachBtn;
        private Label editCoachLabel;
        private FontAwesome.Sharp.IconButton editCoachBtn;
        private Label deleteCoachLabel;
        private FontAwesome.Sharp.IconButton deleteCoachBtn;
    }
}