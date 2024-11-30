namespace PresentationLayer.Forms
{
    partial class SettingsForm
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
            headerPanel = new Panel();
            managementIcon = new FontAwesome.Sharp.IconPictureBox();
            userManagementLabel = new Label();
            administrationGroupBox = new GroupBox();
            logOutLabel = new Label();
            pdfLabel = new Label();
            PDFBtn = new FontAwesome.Sharp.IconButton();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)managementIcon).BeginInit();
            administrationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(managementIcon);
            headerPanel.Controls.Add(userManagementLabel);
            headerPanel.Controls.Add(administrationGroupBox);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.ForeColor = Color.White;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1370, 712);
            headerPanel.TabIndex = 0;
            // 
            // managementIcon
            // 
            managementIcon.BackColor = SystemColors.Control;
            managementIcon.ForeColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            managementIcon.IconColor = Color.FromArgb(0, 123, 250);
            managementIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            managementIcon.IconSize = 40;
            managementIcon.Location = new Point(25, 12);
            managementIcon.Name = "managementIcon";
            managementIcon.Size = new Size(40, 40);
            managementIcon.TabIndex = 2;
            managementIcon.TabStop = false;
            // 
            // userManagementLabel
            // 
            userManagementLabel.AutoSize = true;
            userManagementLabel.BackColor = Color.Transparent;
            userManagementLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userManagementLabel.ForeColor = Color.Black;
            userManagementLabel.Location = new Point(85, 25);
            userManagementLabel.Name = "userManagementLabel";
            userManagementLabel.Size = new Size(218, 27);
            userManagementLabel.TabIndex = 1;
            userManagementLabel.Text = "User Management";
            // 
            // administrationGroupBox
            // 
            administrationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            administrationGroupBox.Controls.Add(logOutLabel);
            administrationGroupBox.Controls.Add(pdfLabel);
            administrationGroupBox.Controls.Add(PDFBtn);
            administrationGroupBox.Controls.Add(logOutBtn);
            administrationGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrationGroupBox.Location = new Point(137, 164);
            administrationGroupBox.Name = "administrationGroupBox";
            administrationGroupBox.Size = new Size(935, 468);
            administrationGroupBox.TabIndex = 0;
            administrationGroupBox.TabStop = false;
            administrationGroupBox.Text = "Management";
            // 
            // logOutLabel
            // 
            logOutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logOutLabel.AutoSize = true;
            logOutLabel.BackColor = Color.Transparent;
            logOutLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutLabel.ForeColor = Color.Black;
            logOutLabel.Location = new Point(183, 266);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(94, 27);
            logOutLabel.TabIndex = 11;
            logOutLabel.Text = "Log out";
            // 
            // pdfLabel
            // 
            pdfLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pdfLabel.AutoSize = true;
            pdfLabel.BackColor = Color.Transparent;
            pdfLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdfLabel.ForeColor = Color.Black;
            pdfLabel.Location = new Point(183, 49);
            pdfLabel.Name = "pdfLabel";
            pdfLabel.Size = new Size(165, 27);
            pdfLabel.TabIndex = 3;
            pdfLabel.Text = "Generate PDF";
            // 
            // PDFBtn
            // 
            PDFBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PDFBtn.BackColor = Color.YellowGreen;
            PDFBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            PDFBtn.ForeColor = Color.White;
            PDFBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            PDFBtn.IconColor = Color.White;
            PDFBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PDFBtn.Location = new Point(174, 125);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(588, 71);
            PDFBtn.TabIndex = 10;
            PDFBtn.Text = "Generate PDF";
            PDFBtn.UseVisualStyleBackColor = false;
            //PDFBtn.Click += PDFBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logOutBtn.BackColor = Color.Red;
            logOutBtn.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            logOutBtn.IconColor = Color.White;
            logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(174, 349);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(588, 62);
            logOutBtn.TabIndex = 9;
            logOutBtn.Text = "Log out";
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 712);
            Controls.Add(headerPanel);
            Name = "SettingsForm";
            Text = "SettingsForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)managementIcon).EndInit();
            administrationGroupBox.ResumeLayout(false);
            administrationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private GroupBox administrationGroupBox;
        private Label userManagementLabel;
        private FontAwesome.Sharp.IconPictureBox managementIcon;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private FontAwesome.Sharp.IconButton PDFBtn;
        private Label pdfLabel;
        private Label logOutLabel;
    }
}