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
            SignInLabel = new Label();
            YourAccountGroupBox = new GroupBox();
            SignInButtom = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            presentationLoginPanel = new Panel();
            welcomeAccessLabel = new Label();
            titleWelcomeLabel = new Label();
            headerPanel = new Panel();
            IconsPanel = new Panel();
            maximizeBtn = new FontAwesome.Sharp.IconButton();
            closeBtn = new FontAwesome.Sharp.IconButton();
            resetBtn = new FontAwesome.Sharp.IconButton();
            YourAccountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            presentationLoginPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            IconsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SignInLabel
            // 
            SignInLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignInLabel.AutoSize = true;
            SignInLabel.BackColor = Color.Transparent;
            SignInLabel.FlatStyle = FlatStyle.Flat;
            SignInLabel.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignInLabel.ForeColor = SystemColors.HotTrack;
            SignInLabel.Location = new Point(25, 30);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(173, 57);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Sign In";
            // 
            // YourAccountGroupBox
            // 
            YourAccountGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            YourAccountGroupBox.BackColor = Color.White;
            YourAccountGroupBox.Controls.Add(SignInButtom);
            YourAccountGroupBox.Controls.Add(SignInLabel);
            YourAccountGroupBox.Controls.Add(passwordTextBox);
            YourAccountGroupBox.Controls.Add(emailTextBox);
            YourAccountGroupBox.Controls.Add(PasswordLabel);
            YourAccountGroupBox.Controls.Add(EmailLabel);
            YourAccountGroupBox.Controls.Add(pictureBox2);
            YourAccountGroupBox.Controls.Add(pictureBox1);
            YourAccountGroupBox.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            YourAccountGroupBox.ForeColor = Color.White;
            YourAccountGroupBox.Location = new Point(601, 152);
            YourAccountGroupBox.Name = "YourAccountGroupBox";
            YourAccountGroupBox.Size = new Size(590, 435);
            YourAccountGroupBox.TabIndex = 1;
            YourAccountGroupBox.TabStop = false;
            // 
            // SignInButtom
            // 
            SignInButtom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignInButtom.BackColor = SystemColors.HotTrack;
            SignInButtom.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignInButtom.Location = new Point(212, 368);
            SignInButtom.Name = "SignInButtom";
            SignInButtom.Size = new Size(233, 44);
            SignInButtom.TabIndex = 6;
            SignInButtom.Text = "Sign in";
            SignInButtom.UseVisualStyleBackColor = false;
            SignInButtom.Click += SignInButtom_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(188, 301);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(283, 34);
            passwordTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(188, 159);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(283, 34);
            emailTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = SystemColors.HotTrack;
            PasswordLabel.Location = new Point(188, 257);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(100, 23);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = SystemColors.HotTrack;
            EmailLabel.Location = new Point(188, 129);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(144, 23);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email address";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // presentationLoginPanel
            // 
            presentationLoginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            presentationLoginPanel.BackColor = SystemColors.HotTrack;
            presentationLoginPanel.Controls.Add(welcomeAccessLabel);
            presentationLoginPanel.Controls.Add(titleWelcomeLabel);
            presentationLoginPanel.Location = new Point(44, 152);
            presentationLoginPanel.Name = "presentationLoginPanel";
            presentationLoginPanel.Size = new Size(562, 435);
            presentationLoginPanel.TabIndex = 2;
            // 
            // welcomeAccessLabel
            // 
            welcomeAccessLabel.AutoSize = true;
            welcomeAccessLabel.BackColor = Color.Transparent;
            welcomeAccessLabel.FlatStyle = FlatStyle.Flat;
            welcomeAccessLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomeAccessLabel.ForeColor = Color.White;
            welcomeAccessLabel.Location = new Point(100, 225);
            welcomeAccessLabel.Name = "welcomeAccessLabel";
            welcomeAccessLabel.Size = new Size(357, 26);
            welcomeAccessLabel.TabIndex = 8;
            welcomeAccessLabel.Text = "Sign in to access your account";
            // 
            // titleWelcomeLabel
            // 
            titleWelcomeLabel.AutoSize = true;
            titleWelcomeLabel.BackColor = Color.Transparent;
            titleWelcomeLabel.FlatStyle = FlatStyle.Flat;
            titleWelcomeLabel.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleWelcomeLabel.ForeColor = Color.White;
            titleWelcomeLabel.Location = new Point(85, 159);
            titleWelcomeLabel.Name = "titleWelcomeLabel";
            titleWelcomeLabel.Size = new Size(383, 57);
            titleWelcomeLabel.TabIndex = 7;
            titleWelcomeLabel.Text = "Welcome Back!";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(IconsPanel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1242, 100);
            headerPanel.TabIndex = 3;
            // 
            // IconsPanel
            // 
            IconsPanel.Controls.Add(resetBtn);
            IconsPanel.Controls.Add(maximizeBtn);
            IconsPanel.Controls.Add(closeBtn);
            IconsPanel.Dock = DockStyle.Right;
            IconsPanel.Location = new Point(1071, 0);
            IconsPanel.Name = "IconsPanel";
            IconsPanel.Size = new Size(171, 100);
            IconsPanel.TabIndex = 6;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatStyle = FlatStyle.Popup;
            maximizeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Clone;
            maximizeBtn.IconColor = Color.White;
            maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizeBtn.Location = new Point(62, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(58, 100);
            maximizeBtn.TabIndex = 3;
            maximizeBtn.UseVisualStyleBackColor = true;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatStyle = FlatStyle.Popup;
            closeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.IconChar = FontAwesome.Sharp.IconChar.Close;
            closeBtn.IconColor = Color.White;
            closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeBtn.Location = new Point(120, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(51, 100);
            closeBtn.TabIndex = 5;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Dock = DockStyle.Right;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            resetBtn.IconColor = Color.White;
            resetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetBtn.Location = new Point(4, 0);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(58, 100);
            resetBtn.TabIndex = 4;
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1242, 730);
            Controls.Add(headerPanel);
            Controls.Add(presentationLoginPanel);
            Controls.Add(YourAccountGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForms";
            Text = "LoginForms";
            YourAccountGroupBox.ResumeLayout(false);
            YourAccountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            presentationLoginPanel.ResumeLayout(false);
            presentationLoginPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            IconsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label SignInLabel;
        private GroupBox YourAccountGroupBox;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label PasswordLabel;
        private Label EmailLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button SignInButtom;
        private Panel presentationLoginPanel;
        private Label welcomeAccessLabel;
        private Label titleWelcomeLabel;
        private Panel headerPanel;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton resetBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private Panel IconsPanel;
    }
}