namespace PresentationLayer.LoginF
{
    partial class LoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForms));
            LoginLabel = new Label();
            YourAccountGroupBox = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            UserLabel = new Label();
            PasswordLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SignInButtom = new Button();
            YourAccountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.FlatStyle = FlatStyle.Flat;
            LoginLabel.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(525, 67);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(155, 57);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login";
            // 
            // YourAccountGroupBox
            // 
            YourAccountGroupBox.BackColor = Color.Transparent;
            YourAccountGroupBox.Controls.Add(SignInButtom);
            YourAccountGroupBox.Controls.Add(textBox2);
            YourAccountGroupBox.Controls.Add(textBox1);
            YourAccountGroupBox.Controls.Add(PasswordLabel);
            YourAccountGroupBox.Controls.Add(UserLabel);
            YourAccountGroupBox.Controls.Add(pictureBox2);
            YourAccountGroupBox.Controls.Add(pictureBox1);
            YourAccountGroupBox.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            YourAccountGroupBox.ForeColor = Color.White;
            YourAccountGroupBox.Location = new Point(281, 159);
            YourAccountGroupBox.Name = "YourAccountGroupBox";
            YourAccountGroupBox.Size = new Size(661, 396);
            YourAccountGroupBox.TabIndex = 1;
            YourAccountGroupBox.TabStop = false;
            YourAccountGroupBox.Text = "Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(125, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(195, 90);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(51, 28);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "User";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(195, 200);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(94, 28);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 34);
            textBox2.TabIndex = 5;
            // 
            // SignInButtom
            // 
            SignInButtom.BackColor = Color.DodgerBlue;
            SignInButtom.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInButtom.Location = new Point(263, 305);
            SignInButtom.Name = "SignInButtom";
            SignInButtom.Size = new Size(114, 44);
            SignInButtom.TabIndex = 6;
            SignInButtom.Text = "Sign in";
            SignInButtom.UseVisualStyleBackColor = false;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1183, 642);
            Controls.Add(YourAccountGroupBox);
            Controls.Add(LoginLabel);
            Name = "LoginForms";
            Text = "LoginForms";
            YourAccountGroupBox.ResumeLayout(false);
            YourAccountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private GroupBox YourAccountGroupBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label PasswordLabel;
        private Label UserLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button SignInButtom;
    }
}