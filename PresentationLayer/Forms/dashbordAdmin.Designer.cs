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
            dashboardBtn = new IconButton();
            settingsBtn = new IconButton();
            statisticsBtn = new IconButton();
            featuresBtn = new IconButton();
            teamsBtn = new IconButton();
            iconPictureBox1 = new IconPictureBox();
            sportLabel = new Label();
            headerPanel = new Panel();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            headerPanel.Controls.Add(textBox1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(263, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1156, 61);
            headerPanel.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 21);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search teams, players...";
            textBox1.Size = new Size(238, 26);
            textBox1.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(263, 61);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1156, 692);
            contentPanel.TabIndex = 3;
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
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label sportLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel headerPanel;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton teamsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private IconButton featuresBtn;
        private IconButton statisticsBtn;
        private IconButton settingsBtn;
        private Panel contentPanel;
        private IconButton dashboardBtn;
    }
}