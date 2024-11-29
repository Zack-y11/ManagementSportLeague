namespace PresentationLayer.ManagerForms
{
    partial class PositionForm
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
            panelPositionTable = new Panel();
            ipbPositionTable = new FontAwesome.Sharp.IconPictureBox();
            positionTableDataGrip = new DataGridView();
            labelPositionTable = new Label();
            panelPositionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positionTableDataGrip).BeginInit();
            SuspendLayout();
            // 
            // panelPositionTable
            // 
            panelPositionTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            panelPositionTable.Controls.Add(ipbPositionTable);
            panelPositionTable.Controls.Add(positionTableDataGrip);
            panelPositionTable.Controls.Add(labelPositionTable);
            panelPositionTable.Location = new Point(211, 52);
            panelPositionTable.Name = "panelPositionTable";
            panelPositionTable.Size = new Size(981, 588);
            panelPositionTable.TabIndex = 6;
            // 
            // ipbPositionTable
            // 
            ipbPositionTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ipbPositionTable.BackColor = Color.FromArgb(147, 51, 234);
            ipbPositionTable.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            ipbPositionTable.IconColor = Color.White;
            ipbPositionTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbPositionTable.IconSize = 40;
            ipbPositionTable.Location = new Point(925, 6);
            ipbPositionTable.Name = "ipbPositionTable";
            ipbPositionTable.Size = new Size(40, 40);
            ipbPositionTable.TabIndex = 2;
            ipbPositionTable.TabStop = false;
            // 
            // positionTableDataGrip
            // 
            positionTableDataGrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            positionTableDataGrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            positionTableDataGrip.Location = new Point(59, 68);
            positionTableDataGrip.Name = "positionTableDataGrip";
            positionTableDataGrip.RowHeadersWidth = 51;
            positionTableDataGrip.Size = new Size(867, 473);
            positionTableDataGrip.TabIndex = 1;
            // 
            // labelPositionTable
            // 
            labelPositionTable.AutoSize = true;
            labelPositionTable.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPositionTable.ForeColor = Color.White;
            labelPositionTable.Location = new Point(59, 6);
            labelPositionTable.Name = "labelPositionTable";
            labelPositionTable.Size = new Size(165, 27);
            labelPositionTable.TabIndex = 0;
            labelPositionTable.Text = "Position Table";
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 652);
            Controls.Add(panelPositionTable);
            Name = "PositionForm";
            Text = "PositionForm";
            panelPositionTable.ResumeLayout(false);
            panelPositionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbPositionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)positionTableDataGrip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPositionTable;
        private FontAwesome.Sharp.IconPictureBox ipbPositionTable;
        private DataGridView positionTableDataGrip;
        private Label labelPositionTable;
    }
}