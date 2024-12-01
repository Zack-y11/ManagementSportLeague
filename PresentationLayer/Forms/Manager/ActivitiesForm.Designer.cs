namespace PresentationLayer.ManagerForms
{
    partial class ActivitiesForm
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
            panelPlayers = new Panel();
            activiteComboBox = new ComboBox();
            typeLabel = new Label();
            placeTextBox = new TextBox();
            placeLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttomEditActivity = new FontAwesome.Sharp.IconButton();
            buttomDeleteActivity = new FontAwesome.Sharp.IconButton();
            buttomAddActivity = new FontAwesome.Sharp.IconButton();
            labelDay = new Label();
            labelPlayers = new Label();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelDescrition = new Label();
            ActivityInformationDataGridView = new DataGridView();
            panelPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActivityInformationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelPlayers
            // 
            panelPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelPlayers.BackColor = Color.FromArgb(37, 99, 235);
            panelPlayers.Controls.Add(activiteComboBox);
            panelPlayers.Controls.Add(typeLabel);
            panelPlayers.Controls.Add(placeTextBox);
            panelPlayers.Controls.Add(placeLabel);
            panelPlayers.Controls.Add(dateTimePicker1);
            panelPlayers.Controls.Add(buttomEditActivity);
            panelPlayers.Controls.Add(buttomDeleteActivity);
            panelPlayers.Controls.Add(buttomAddActivity);
            panelPlayers.Controls.Add(labelDay);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Controls.Add(textBoxDescription);
            panelPlayers.Controls.Add(textBoxName);
            panelPlayers.Controls.Add(labelName);
            panelPlayers.Controls.Add(labelDescrition);
            panelPlayers.Location = new Point(72, 54);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(450, 654);
            panelPlayers.TabIndex = 12;
            // 
            // activiteComboBox
            // 
            activiteComboBox.FormattingEnabled = true;
            activiteComboBox.Location = new Point(162, 288);
            activiteComboBox.Name = "activiteComboBox";
            activiteComboBox.Size = new Size(161, 28);
            activiteComboBox.TabIndex = 18;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeLabel.ForeColor = Color.White;
            typeLabel.Location = new Point(54, 292);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(102, 18);
            typeLabel.TabIndex = 17;
            typeLabel.Text = "Activite Type";
            // 
            // placeTextBox
            // 
            placeTextBox.Location = new Point(162, 243);
            placeTextBox.Name = "placeTextBox";
            placeTextBox.Size = new Size(161, 27);
            placeTextBox.TabIndex = 16;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeLabel.ForeColor = Color.White;
            placeLabel.Location = new Point(54, 243);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(50, 18);
            placeLabel.TabIndex = 15;
            placeLabel.Text = "Place";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // buttomEditActivity
            // 
            buttomEditActivity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttomEditActivity.FlatAppearance.BorderSize = 0;
            buttomEditActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttomEditActivity.ForeColor = Color.Black;
            buttomEditActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            buttomEditActivity.IconColor = Color.Black;
            buttomEditActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttomEditActivity.ImageAlign = ContentAlignment.MiddleLeft;
            buttomEditActivity.Location = new Point(84, 384);
            buttomEditActivity.Name = "buttomEditActivity";
            buttomEditActivity.Padding = new Padding(12, 0, 0, 0);
            buttomEditActivity.Size = new Size(239, 46);
            buttomEditActivity.TabIndex = 13;
            buttomEditActivity.Text = "Edit Activity";
            buttomEditActivity.UseVisualStyleBackColor = true;
            // 
            // buttomDeleteActivity
            // 
            buttomDeleteActivity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttomDeleteActivity.FlatAppearance.BorderSize = 0;
            buttomDeleteActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttomDeleteActivity.ForeColor = Color.Black;
            buttomDeleteActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            buttomDeleteActivity.IconColor = Color.Black;
            buttomDeleteActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttomDeleteActivity.ImageAlign = ContentAlignment.MiddleLeft;
            buttomDeleteActivity.Location = new Point(84, 436);
            buttomDeleteActivity.Name = "buttomDeleteActivity";
            buttomDeleteActivity.Padding = new Padding(12, 0, 0, 0);
            buttomDeleteActivity.Size = new Size(239, 46);
            buttomDeleteActivity.TabIndex = 12;
            buttomDeleteActivity.Text = "   Delete Activity";
            buttomDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // buttomAddActivity
            // 
            buttomAddActivity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttomAddActivity.FlatAppearance.BorderSize = 0;
            buttomAddActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttomAddActivity.ForeColor = Color.Black;
            buttomAddActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            buttomAddActivity.IconColor = Color.Black;
            buttomAddActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttomAddActivity.ImageAlign = ContentAlignment.MiddleLeft;
            buttomAddActivity.Location = new Point(84, 332);
            buttomAddActivity.Name = "buttomAddActivity";
            buttomAddActivity.Padding = new Padding(12, 0, 0, 0);
            buttomAddActivity.Size = new Size(239, 46);
            buttomAddActivity.TabIndex = 11;
            buttomAddActivity.Text = "Add Activity";
            buttomAddActivity.UseVisualStyleBackColor = true;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.ForeColor = Color.White;
            labelDay.Location = new Point(51, 143);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(43, 18);
            labelDay.TabIndex = 9;
            labelDay.Text = "Date";
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(41, 25);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(296, 37);
            labelPlayers.TabIndex = 2;
            labelPlayers.Text = "Activity Information";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(162, 193);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(161, 27);
            textBoxDescription.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(162, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(161, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(51, 92);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 18);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // labelDescrition
            // 
            labelDescrition.AutoSize = true;
            labelDescrition.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescrition.ForeColor = Color.White;
            labelDescrition.Location = new Point(51, 193);
            labelDescrition.Name = "labelDescrition";
            labelDescrition.Size = new Size(91, 18);
            labelDescrition.TabIndex = 6;
            labelDescrition.Text = "Description";
            // 
            // ActivityInformationDataGridView
            // 
            ActivityInformationDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ActivityInformationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActivityInformationDataGridView.Location = new Point(887, 54);
            ActivityInformationDataGridView.Name = "ActivityInformationDataGridView";
            ActivityInformationDataGridView.RowHeadersWidth = 51;
            ActivityInformationDataGridView.Size = new Size(449, 654);
            ActivityInformationDataGridView.TabIndex = 10;
            // 
            // ActivitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 720);
            Controls.Add(panelPlayers);
            Controls.Add(ActivityInformationDataGridView);
            Name = "ActivitiesForm";
            Text = "ActivitiesForm";
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ActivityInformationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPlayers;
        private FontAwesome.Sharp.IconButton buttomEditActivity;
        private FontAwesome.Sharp.IconButton buttomDeleteActivity;
        private FontAwesome.Sharp.IconButton buttomAddActivity;
        private TextBox textBoxDay;
        private Label labelDay;
        private Label labelPlayers;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelDescrition;
        private DataGridView ActivityInformationDataGridView;
        private Label placeLabel;
        private DateTimePicker dateTimePicker1;
        private TextBox placeTextBox;
        private Label typeLabel;
        private ComboBox activiteComboBox;
    }
}