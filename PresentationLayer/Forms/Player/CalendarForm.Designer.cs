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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            yearLabel = new Label();
            monthLabel = new Label();
            comboBox1 = new ComboBox();
            calendarLabel = new Label();
            calendarIcon = new FontAwesome.Sharp.IconPictureBox();
            headerPanel = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(yearLabel);
            groupBox1.Controls.Add(monthLabel);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(57, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(945, 550);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calendar Activities ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 356);
            dataGridView1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(243, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 31);
            comboBox2.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 31);
            comboBox1.TabIndex = 0;
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
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 706);
            Controls.Add(headerPanel);
            Controls.Add(groupBox1);
            Name = "CalendarForm";
            Text = "CalendarForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarIcon).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label calendarLabel;
        private FontAwesome.Sharp.IconPictureBox calendarIcon;
        private ComboBox comboBox1;
        private Label yearLabel;
        private Label monthLabel;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Panel headerPanel;
    }
}