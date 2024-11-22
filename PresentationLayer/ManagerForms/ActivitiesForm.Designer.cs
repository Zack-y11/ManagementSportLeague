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
            btnEditActivity = new FontAwesome.Sharp.IconButton();
            btnDeleteActivity = new FontAwesome.Sharp.IconButton();
            btnAddActivity = new FontAwesome.Sharp.IconButton();
            textBoxDay = new TextBox();
            labelDay = new Label();
            labelPlayers = new Label();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelDescrition = new Label();
            dataGridView1 = new DataGridView();
            panelPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelPlayers
            // 
            panelPlayers.BackColor = Color.FromArgb(37, 99, 235);
            panelPlayers.Controls.Add(btnEditActivity);
            panelPlayers.Controls.Add(btnDeleteActivity);
            panelPlayers.Controls.Add(btnAddActivity);
            panelPlayers.Controls.Add(textBoxDay);
            panelPlayers.Controls.Add(labelDay);
            panelPlayers.Controls.Add(labelPlayers);
            panelPlayers.Controls.Add(textBoxDescription);
            panelPlayers.Controls.Add(textBoxName);
            panelPlayers.Controls.Add(labelName);
            panelPlayers.Controls.Add(labelDescrition);
            panelPlayers.Location = new Point(636, 23);
            panelPlayers.Name = "panelPlayers";
            panelPlayers.Size = new Size(323, 500);
            panelPlayers.TabIndex = 12;
            // 
            // btnEditActivity
            // 
            btnEditActivity.FlatAppearance.BorderSize = 0;
            btnEditActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditActivity.ForeColor = Color.Black;
            btnEditActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            btnEditActivity.IconColor = Color.Black;
            btnEditActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditActivity.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditActivity.Location = new Point(40, 422);
            btnEditActivity.Name = "btnEditActivity";
            btnEditActivity.Padding = new Padding(12, 0, 0, 0);
            btnEditActivity.Size = new Size(248, 46);
            btnEditActivity.TabIndex = 13;
            btnEditActivity.Text = "Edit Activity";
            btnEditActivity.UseVisualStyleBackColor = true;
            // 
            // btnDeleteActivity
            // 
            btnDeleteActivity.FlatAppearance.BorderSize = 0;
            btnDeleteActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteActivity.ForeColor = Color.Black;
            btnDeleteActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            btnDeleteActivity.IconColor = Color.Black;
            btnDeleteActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteActivity.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteActivity.Location = new Point(40, 370);
            btnDeleteActivity.Name = "btnDeleteActivity";
            btnDeleteActivity.Padding = new Padding(12, 0, 0, 0);
            btnDeleteActivity.Size = new Size(248, 46);
            btnDeleteActivity.TabIndex = 12;
            btnDeleteActivity.Text = "Delete Activity";
            btnDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // btnAddActivity
            // 
            btnAddActivity.FlatAppearance.BorderSize = 0;
            btnAddActivity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddActivity.ForeColor = Color.Black;
            btnAddActivity.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            btnAddActivity.IconColor = Color.Black;
            btnAddActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddActivity.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddActivity.Location = new Point(40, 318);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Padding = new Padding(12, 0, 0, 0);
            btnAddActivity.Size = new Size(248, 46);
            btnAddActivity.TabIndex = 11;
            btnAddActivity.Text = "Add Activity";
            btnAddActivity.UseVisualStyleBackColor = true;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(123, 237);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(166, 27);
            textBoxDay.TabIndex = 10;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.ForeColor = Color.White;
            labelDay.Location = new Point(20, 241);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(38, 18);
            labelDay.TabIndex = 9;
            labelDay.Text = "Day";
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayers.ForeColor = Color.White;
            labelPlayers.Location = new Point(20, 35);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(296, 37);
            labelPlayers.TabIndex = 2;
            labelPlayers.Text = "Activity Information";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(123, 177);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(166, 27);
            textBoxDescription.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(123, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(166, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(20, 117);
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
            labelDescrition.Location = new Point(20, 177);
            labelDescrition.Name = "labelDescrition";
            labelDescrition.Size = new Size(91, 18);
            labelDescrition.TabIndex = 6;
            labelDescrition.Text = "Description";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 283);
            dataGridView1.TabIndex = 10;
            // 
            // ActivitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 546);
            Controls.Add(panelPlayers);
            Controls.Add(dataGridView1);
            Name = "ActivitiesForm";
            Text = "ActivitiesForm";
            panelPlayers.ResumeLayout(false);
            panelPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPlayers;
        private FontAwesome.Sharp.IconButton btnEditActivity;
        private FontAwesome.Sharp.IconButton btnDeleteActivity;
        private FontAwesome.Sharp.IconButton btnAddActivity;
        private TextBox textBoxDay;
        private Label labelDay;
        private Label labelPlayers;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelDescrition;
        private DataGridView dataGridView1;
    }
}