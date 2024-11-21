namespace PresentationLayer.ManagerForms
{
    partial class StatsForm
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
            panelObjetiveSeason = new Panel();
            ipbTrophy = new FontAwesome.Sharp.IconPictureBox();
            labelObjetiveStatus = new Label();
            labelObejtiveCompetition = new Label();
            labelGoalsScored = new Label();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelObjetiveSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelObjetiveSeason
            // 
            panelObjetiveSeason.BackColor = Color.FromArgb(220, 38, 38);
            panelObjetiveSeason.Controls.Add(ipbTrophy);
            panelObjetiveSeason.Controls.Add(labelObjetiveStatus);
            panelObjetiveSeason.Controls.Add(labelObejtiveCompetition);
            panelObjetiveSeason.Controls.Add(labelGoalsScored);
            panelObjetiveSeason.Location = new Point(258, 60);
            panelObjetiveSeason.Name = "panelObjetiveSeason";
            panelObjetiveSeason.Size = new Size(505, 152);
            panelObjetiveSeason.TabIndex = 5;
            // 
            // ipbTrophy
            // 
            ipbTrophy.BackColor = Color.Transparent;
            ipbTrophy.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            ipbTrophy.IconColor = Color.White;
            ipbTrophy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbTrophy.IconSize = 40;
            ipbTrophy.Location = new Point(454, 11);
            ipbTrophy.Name = "ipbTrophy";
            ipbTrophy.Size = new Size(40, 40);
            ipbTrophy.TabIndex = 3;
            ipbTrophy.TabStop = false;
            // 
            // labelObjetiveStatus
            // 
            labelObjetiveStatus.AutoSize = true;
            labelObjetiveStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObjetiveStatus.ForeColor = Color.White;
            labelObjetiveStatus.Location = new Point(23, 115);
            labelObjetiveStatus.Name = "labelObjetiveStatus";
            labelObjetiveStatus.Size = new Size(139, 23);
            labelObjetiveStatus.TabIndex = 4;
            labelObjetiveStatus.Text = "in the season";
            // 
            // labelObejtiveCompetition
            // 
            labelObejtiveCompetition.AutoSize = true;
            labelObejtiveCompetition.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObejtiveCompetition.ForeColor = Color.White;
            labelObejtiveCompetition.Location = new Point(13, 50);
            labelObejtiveCompetition.Name = "labelObejtiveCompetition";
            labelObejtiveCompetition.Size = new Size(200, 51);
            labelObejtiveCompetition.TabIndex = 3;
            labelObejtiveCompetition.Text = "36 goals";
            // 
            // labelGoalsScored
            // 
            labelGoalsScored.AutoSize = true;
            labelGoalsScored.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGoalsScored.ForeColor = Color.White;
            labelGoalsScored.Location = new Point(134, 11);
            labelGoalsScored.Name = "labelGoalsScored";
            labelGoalsScored.Size = new Size(141, 23);
            labelGoalsScored.TabIndex = 0;
            labelGoalsScored.Text = "Goals Scored";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 38, 38);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(258, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 152);
            panel1.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(454, 11);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 115);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 4;
            label1.Text = "in the season";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(200, 51);
            label2.TabIndex = 3;
            label2.Text = "12 goals";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 11);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 0;
            label3.Text = "Goals Conceded";
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 575);
            Controls.Add(panel1);
            Controls.Add(panelObjetiveSeason);
            Name = "StatsForm";
            Text = "StatsForm";
            panelObjetiveSeason.ResumeLayout(false);
            panelObjetiveSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbTrophy).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelObjetiveSeason;
        private Label labelObjetiveStatus;
        private Label labelObejtiveCompetition;
        private Label labelGoalsScored;
        private FontAwesome.Sharp.IconPictureBox ipbTrophy;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}