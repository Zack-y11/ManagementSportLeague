namespace PresentationLayer.ManagerForms
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
            eliminarEsteLabel = new Label();
            SuspendLayout();
            // 
            // eliminarEsteLabel
            // 
            eliminarEsteLabel.AutoSize = true;
            eliminarEsteLabel.Location = new Point(551, 253);
            eliminarEsteLabel.Name = "eliminarEsteLabel";
            eliminarEsteLabel.Size = new Size(106, 20);
            eliminarEsteLabel.TabIndex = 0;
            eliminarEsteLabel.Text = "Calendar Form";
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 712);
            Controls.Add(eliminarEsteLabel);
            Name = "CalendarForm";
            Text = "CalendarMach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label eliminarEsteLabel;
    }
}