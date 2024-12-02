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
            buttonsPanel = new Panel();
            PDFButton = new FontAwesome.Sharp.IconButton();
            pdfLabel = new Label();
            logOutBtn = new FontAwesome.Sharp.IconButton();
            shildIcon = new FontAwesome.Sharp.IconPictureBox();
            userLabel = new Label();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shildIcon).BeginInit();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonsPanel.BackColor = SystemColors.ControlLight;
            buttonsPanel.Controls.Add(PDFButton);
            buttonsPanel.Controls.Add(pdfLabel);
            buttonsPanel.Controls.Add(logOutBtn);
            buttonsPanel.Location = new Point(302, 134);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(672, 361);
            buttonsPanel.TabIndex = 10;
            // 
            // PDFButton
            // 
            PDFButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PDFButton.BackColor = Color.YellowGreen;
            PDFButton.FlatStyle = FlatStyle.Flat;
            PDFButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            PDFButton.ForeColor = Color.Transparent;
            PDFButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            PDFButton.IconColor = Color.White;
            PDFButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PDFButton.ImageAlign = ContentAlignment.MiddleLeft;
            PDFButton.Location = new Point(113, 151);
            PDFButton.Name = "PDFButton";
            PDFButton.Size = new Size(477, 43);
            PDFButton.TabIndex = 7;
            PDFButton.Text = "Generate PDF";
            PDFButton.UseVisualStyleBackColor = false;
            // 
            // pdfLabel
            // 
            pdfLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pdfLabel.AutoSize = true;
            pdfLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdfLabel.Location = new Point(30, 32);
            pdfLabel.Name = "pdfLabel";
            pdfLabel.Size = new Size(317, 25);
            pdfLabel.TabIndex = 8;
            pdfLabel.Text = "Generate PDF of your stadistics";
            // 
            // logOutBtn
            // 
            logOutBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logOutBtn.BackColor = Color.Red;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.Transparent;
            logOutBtn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            logOutBtn.IconColor = Color.White;
            logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logOutBtn.Location = new Point(113, 239);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(477, 43);
            logOutBtn.TabIndex = 6;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // shildIcon
            // 
            shildIcon.BackColor = Color.FromArgb(0, 123, 252);
            shildIcon.ForeColor = SystemColors.Control;
            shildIcon.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            shildIcon.IconColor = SystemColors.Control;
            shildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            shildIcon.IconSize = 40;
            shildIcon.Location = new Point(32, 28);
            shildIcon.Name = "shildIcon";
            shildIcon.Size = new Size(40, 40);
            shildIcon.TabIndex = 1;
            shildIcon.TabStop = false;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.FromArgb(0, 123, 252);
            userLabel.Location = new Point(114, 34);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(229, 32);
            userLabel.TabIndex = 0;
            userLabel.Text = "Player Settings ";
            // 
            // SettingsPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 628);
            Controls.Add(buttonsPanel);
            Controls.Add(userLabel);
            Controls.Add(shildIcon);
            Name = "SettingsPlayerForm";
            Text = "SettingsPlayerForm";
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shildIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel buttonsPanel;
        private FontAwesome.Sharp.IconButton PDFButton;
        private Label pdfLabel;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private FontAwesome.Sharp.IconPictureBox shildIcon;
        private Label userLabel;
    }
}