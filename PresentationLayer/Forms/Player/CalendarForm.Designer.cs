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
            headerPanel = new Panel();
            contentCalendarPanel = new Panel();
            agendaIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            calendarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarDataGrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).BeginInit();
            headerPanel.SuspendLayout();
            contentCalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)agendaIconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // calendarGroupBox
            // 
            calendarGroupBox.BackColor = Color.White;
            calendarGroupBox.Controls.Add(agendaIconPictureBox);
            calendarGroupBox.Controls.Add(calendarDataGrip);
            calendarGroupBox.Controls.Add(yearComboBox);
            calendarGroupBox.Controls.Add(yearLabel);
            calendarGroupBox.Controls.Add(monthLabel);
            calendarGroupBox.Controls.Add(monthComboBox);
            calendarGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calendarGroupBox.Location = new Point(60, 33);
            calendarGroupBox.Name = "calendarGroupBox";
            calendarGroupBox.Size = new Size(945, 550);
            calendarGroupBox.TabIndex = 0;
            calendarGroupBox.TabStop = false;
            calendarGroupBox.Text = "Calendar Activities ";
            // 
            // calendarDataGrip
            // 
            calendarDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarDataGrip.Location = new Point(35, 129);
            calendarDataGrip.Name = "calendarDataGrip";
            calendarDataGrip.RowHeadersWidth = 51;
            calendarDataGrip.Size = new Size(871, 356);
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
            calendarLabel.ForeColor = Color.White;
            calendarLabel.Location = new Point(118, 36);
            calendarLabel.Name = "calendarLabel";
            calendarLabel.Size = new Size(236, 34);
            calendarLabel.TabIndex = 1;
            calendarLabel.Text = "Calendar Events";
            // 
            // calendarIcon
            // 
            calendarIcon.BackColor = Color.Transparent;
            calendarIcon.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            calendarIcon.IconColor = Color.White;
            calendarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            calendarIcon.IconSize = 48;
            calendarIcon.Location = new Point(34, 21);
            calendarIcon.Name = "calendarIcon";
            calendarIcon.Size = new Size(48, 49);
            calendarIcon.TabIndex = 2;
            calendarIcon.TabStop = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.Highlight;
            headerPanel.Controls.Add(calendarLabel);
            headerPanel.Controls.Add(calendarIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1223, 100);
            headerPanel.TabIndex = 3;
            // 
            // contentCalendarPanel
            // 
            contentCalendarPanel.BackColor = SystemColors.HighlightText;
            contentCalendarPanel.Controls.Add(calendarGroupBox);
            contentCalendarPanel.Dock = DockStyle.Fill;
            contentCalendarPanel.Location = new Point(0, 100);
            contentCalendarPanel.Name = "contentCalendarPanel";
            contentCalendarPanel.Size = new Size(1223, 606);
            contentCalendarPanel.TabIndex = 4;
            // 
            // agendaIconPictureBox
            // 
            agendaIconPictureBox.BackColor = Color.Transparent;
            agendaIconPictureBox.ForeColor = SystemColors.HotTrack;
            agendaIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            agendaIconPictureBox.IconColor = SystemColors.HotTrack;
            agendaIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agendaIconPictureBox.IconSize = 57;
            agendaIconPictureBox.Location = new Point(444, 48);
            agendaIconPictureBox.Name = "agendaIconPictureBox";
            agendaIconPictureBox.Size = new Size(61, 57);
            agendaIconPictureBox.TabIndex = 5;
            agendaIconPictureBox.TabStop = false;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 706);
            Controls.Add(contentCalendarPanel);
            Controls.Add(headerPanel);
            Name = "CalendarForm";
            Text = "CalendarForm";
            calendarGroupBox.ResumeLayout(false);
            calendarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calendarDataGrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentCalendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)agendaIconPictureBox).EndInit();
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
        private Panel headerPanel;
        private Panel contentCalendarPanel;
        private FontAwesome.Sharp.IconPictureBox agendaIconPictureBox;
    }
}