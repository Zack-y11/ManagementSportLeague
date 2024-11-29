namespace PresentationLayer.Forms.Player
{
    partial class SettingsPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPlayerForm));
            headerPanel = new Panel();
            shildIcon = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            contentGroupBox = new GroupBox();
            pdfLabel = new Label();
            PDFButton = new FontAwesome.Sharp.IconButton();
            settingsContentPanel = new Panel();
            reportStatuspictureBox = new PictureBox();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shildIcon).BeginInit();
            contentGroupBox.SuspendLayout();
            settingsContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportStatuspictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.Highlight;
            headerPanel.Controls.Add(shildIcon);
            headerPanel.Controls.Add(label2);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1331, 100);
            headerPanel.TabIndex = 7;
            // 
            // shildIcon
            // 
            shildIcon.BackColor = Color.Transparent;
            shildIcon.ForeColor = SystemColors.Control;
            shildIcon.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            shildIcon.IconColor = SystemColors.Control;
            shildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            shildIcon.IconSize = 40;
            shildIcon.Location = new Point(39, 25);
            shildIcon.Name = "shildIcon";
            shildIcon.Size = new Size(40, 40);
            shildIcon.TabIndex = 1;
            shildIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 31);
            label2.Name = "label2";
            label2.Size = new Size(191, 34);
            label2.TabIndex = 0;
            label2.Text = "User Settings ";
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.Red;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.Transparent;
            logOutBtn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logOutBtn.IconColor = Color.White;
            logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(232, 261);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(263, 43);
            logOutBtn.TabIndex = 6;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // contentGroupBox
            // 
            contentGroupBox.Controls.Add(pdfLabel);
            contentGroupBox.Controls.Add(PDFButton);
            contentGroupBox.Controls.Add(logOutBtn);
            contentGroupBox.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contentGroupBox.Location = new Point(79, 85);
            contentGroupBox.Name = "contentGroupBox";
            contentGroupBox.Size = new Size(701, 416);
            contentGroupBox.TabIndex = 8;
            contentGroupBox.TabStop = false;
            contentGroupBox.Text = "Settings";
            // 
            // pdfLabel
            // 
            pdfLabel.AutoSize = true;
            pdfLabel.Location = new Point(232, 88);
            pdfLabel.Name = "pdfLabel";
            pdfLabel.Size = new Size(261, 19);
            pdfLabel.TabIndex = 8;
            pdfLabel.Text = "Generate PDF of your stadistics";
            // 
            // PDFButton
            // 
            PDFButton.BackColor = Color.YellowGreen;
            PDFButton.FlatStyle = FlatStyle.Flat;
            PDFButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            PDFButton.ForeColor = Color.Transparent;
            PDFButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            PDFButton.IconColor = Color.White;
            PDFButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFButton.ImageAlign = ContentAlignment.MiddleLeft;
            PDFButton.Location = new Point(232, 143);
            PDFButton.Name = "PDFButton";
            PDFButton.Size = new Size(263, 43);
            PDFButton.TabIndex = 7;
            PDFButton.Text = "Generate PDF";
            PDFButton.UseVisualStyleBackColor = false;
            // 
            // settingsContentPanel
            // 
            settingsContentPanel.BackColor = SystemColors.ControlLightLight;
            settingsContentPanel.Controls.Add(reportStatuspictureBox);
            settingsContentPanel.Controls.Add(contentGroupBox);
            settingsContentPanel.Dock = DockStyle.Fill;
            settingsContentPanel.Location = new Point(0, 100);
            settingsContentPanel.Name = "settingsContentPanel";
            settingsContentPanel.Size = new Size(1331, 654);
            settingsContentPanel.TabIndex = 8;
            // 
            // reportStatuspictureBox
            // 
            reportStatuspictureBox.Image = (Image)resources.GetObject("reportStatuspictureBox.Image");
            reportStatuspictureBox.Location = new Point(816, 222);
            reportStatuspictureBox.Name = "reportStatuspictureBox";
            reportStatuspictureBox.Size = new Size(174, 167);
            reportStatuspictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            reportStatuspictureBox.TabIndex = 9;
            reportStatuspictureBox.TabStop = false;
            // 
            // SettingsPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 754);
            Controls.Add(settingsContentPanel);
            Controls.Add(headerPanel);
            Name = "SettingsPlayerForm";
            Text = "SettingsForm";
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shildIcon).EndInit();
            contentGroupBox.ResumeLayout(false);
            contentGroupBox.PerformLayout();
            settingsContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reportStatuspictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel headerPanel;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox shildIcon;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private GroupBox contentGroupBox;
        private FontAwesome.Sharp.IconButton PDFButton;
        private Label pdfLabel;
        private Panel settingsContentPanel;
        private PictureBox reportStatuspictureBox;
    }
}