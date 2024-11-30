namespace PresentationLayer.Forms.Player
{
    partial class CalendarForm
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
            calendarGroupBox = new GroupBox();
            calendarDataGrip = new DataGridView();
            yearComboBox = new ComboBox();
            yearLabel = new Label();
            monthLabel = new Label();
            monthComboBox = new ComboBox();
            calendarLabel = new Label();
            calendarIcon = new FontAwesome.Sharp.IconPictureBox();
            contentCalendarPanel = new Panel();
            calendarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).BeginInit();
            contentCalendarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // calendarGroupBox
            // 
            calendarGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarGroupBox.BackColor = Color.White;
            calendarGroupBox.Controls.Add(calendarDataGrip);
            calendarGroupBox.Controls.Add(yearComboBox);
            calendarGroupBox.Controls.Add(yearLabel);
            calendarGroupBox.Controls.Add(monthLabel);
            calendarGroupBox.Controls.Add(monthComboBox);
            calendarGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calendarGroupBox.Location = new Point(167, 122);
            calendarGroupBox.Name = "calendarGroupBox";
            calendarGroupBox.Size = new Size(945, 521);
            calendarGroupBox.TabIndex = 0;
            calendarGroupBox.TabStop = false;
            calendarGroupBox.Text = "Calendar Activities ";
            // 
            // calendarDataGrip
            // 
            calendarDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarDataGrip.Location = new Point(63, 131);
            calendarDataGrip.Name = "calendarDataGrip";
            calendarDataGrip.RowHeadersWidth = 51;
            calendarDataGrip.Size = new Size(823, 331);
            calendarDataGrip.TabIndex = 4;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(243, 74);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(165, 31);
            yearComboBox.TabIndex = 3;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(243, 37);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(54, 23);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "Year";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(17, 37);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(71, 23);
            monthLabel.TabIndex = 1;
            monthLabel.Text = "Month";
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(17, 74);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(165, 31);
            monthComboBox.TabIndex = 0;
            // 
            // calendarLabel
            // 
            calendarLabel.AutoSize = true;
            calendarLabel.BackColor = Color.Transparent;
            calendarLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calendarLabel.ForeColor = Color.FromArgb(0, 123, 252);
            calendarLabel.Location = new Point(167, 30);
            calendarLabel.Name = "calendarLabel";
            calendarLabel.Size = new Size(236, 34);
            calendarLabel.TabIndex = 1;
            calendarLabel.Text = "Calendar Events";
            // 
            // calendarIcon
            // 
            calendarIcon.BackColor = Color.FromArgb(0, 123, 252);
            calendarIcon.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            calendarIcon.IconColor = Color.White;
            calendarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            calendarIcon.IconSize = 48;
            calendarIcon.Location = new Point(60, 15);
            calendarIcon.Name = "calendarIcon";
            calendarIcon.Size = new Size(48, 49);
            calendarIcon.TabIndex = 2;
            calendarIcon.TabStop = false;
            // 
            // contentCalendarPanel
            // 
            contentCalendarPanel.BackColor = SystemColors.HighlightText;
            contentCalendarPanel.Controls.Add(calendarLabel);
            contentCalendarPanel.Controls.Add(calendarGroupBox);
            contentCalendarPanel.Controls.Add(calendarIcon);
            contentCalendarPanel.Dock = DockStyle.Fill;
            contentCalendarPanel.Location = new Point(0, 0);
            contentCalendarPanel.Name = "contentCalendarPanel";
            contentCalendarPanel.Size = new Size(1223, 706);
            contentCalendarPanel.TabIndex = 4;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 706);
            Controls.Add(contentCalendarPanel);
            Name = "CalendarForm";
            Text = "CalendarForm";
            calendarGroupBox.ResumeLayout(false);
            calendarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calendarDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).EndInit();
            contentCalendarPanel.ResumeLayout(false);
            contentCalendarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox calendarGroupBox;
        private Label calendarLabel;
        private FontAwesome.Sharp.IconPictureBox calendarIcon;
        private ComboBox monthComboBox;
        private Label yearLabel;
        private Label monthLabel;
        private DataGridView calendarDataGrip;
        private ComboBox yearComboBox;
        private Panel contentCalendarPanel;
    }
}