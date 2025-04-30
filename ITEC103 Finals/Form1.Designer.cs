namespace ITEC103_Finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TopNavBar = new Panel();
            Logo_PicBox = new PictureBox();
            Line_PicBox = new PictureBox();
            SignIn_NavBarLbl = new Label();
            Search_Btn = new ITEC103_Finals.AddControls.RoundedButton();
            SearchBox_TxtBox = new TextBox();
            NotificationIcon_PicBox = new PictureBox();
            CartIcon_PicBox = new PictureBox();
            ProfileIcon_PicBox = new PictureBox();
            SignIn_Btn = new ITEC103_Finals.AddControls.RoundedButton();
            SignIn_Panel = new Panel();
            SignIn_HeaderLbl = new Label();
            Email_SignInLbl = new Label();
            Email_SignInTxtBox = new TextBox();
            Password_SignInLbl = new Label();
            Password_SignInTxtBox = new TextBox();
            ForgotPassword_Lbl = new Label();
            SignUp_FooterLbl = new Label();
            SignUp_Panel = new Panel();
            SignUp_HeaderLbl = new Label();
            Username_Lbl = new Label();
            Username_TxtBox = new TextBox();
            Email_SignUpLbl = new Label();
            Email_SignUpTxtBox = new TextBox();
            Password_SignUpLbl = new Label();
            Password_SignUpTxtBox = new TextBox();
            RepeatPassword_SignUpLbl = new Label();
            RepeatPassword_SignUpTxtBox = new TextBox();
            SignUp_Btn = new ITEC103_Finals.AddControls.RoundedButton();
            SignIn_FooterLbl = new Label();
            TopNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo_PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line_PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon_PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartIcon_PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfileIcon_PicBox).BeginInit();
            SignIn_Panel.SuspendLayout();
            SignUp_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // TopNavBar
            // 
            TopNavBar.BackColor = Color.FromArgb(82, 171, 153);
            TopNavBar.Controls.Add(Logo_PicBox);
            TopNavBar.Controls.Add(Line_PicBox);
            TopNavBar.Controls.Add(SignIn_NavBarLbl);
            TopNavBar.Controls.Add(Search_Btn);
            TopNavBar.Controls.Add(SearchBox_TxtBox);
            TopNavBar.Controls.Add(NotificationIcon_PicBox);
            TopNavBar.Controls.Add(CartIcon_PicBox);
            TopNavBar.Controls.Add(ProfileIcon_PicBox);
            TopNavBar.Location = new Point(0, 1);
            TopNavBar.Name = "TopNavBar";
            TopNavBar.Size = new Size(1349, 105);
            TopNavBar.TabIndex = 0;
            // 
            // Logo_PicBox
            // 
            Logo_PicBox.BackgroundImageLayout = ImageLayout.None;
            Logo_PicBox.Image = (Image)resources.GetObject("Logo_PicBox.Image");
            Logo_PicBox.Location = new Point(26, 31);
            Logo_PicBox.Name = "Logo_PicBox";
            Logo_PicBox.Size = new Size(179, 53);
            Logo_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Logo_PicBox.TabIndex = 0;
            Logo_PicBox.TabStop = false;
            // 
            // Line_PicBox
            // 
            Line_PicBox.BackgroundImageLayout = ImageLayout.None;
            Line_PicBox.Image = (Image)resources.GetObject("Line_PicBox.Image");
            Line_PicBox.Location = new Point(205, 31);
            Line_PicBox.Name = "Line_PicBox";
            Line_PicBox.Size = new Size(38, 48);
            Line_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Line_PicBox.TabIndex = 12;
            Line_PicBox.TabStop = false;
            // 
            // SignIn_NavBarLbl
            // 
            SignIn_NavBarLbl.AutoSize = true;
            SignIn_NavBarLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn_NavBarLbl.ForeColor = Color.White;
            SignIn_NavBarLbl.ImageAlign = ContentAlignment.MiddleLeft;
            SignIn_NavBarLbl.Location = new Point(235, 29);
            SignIn_NavBarLbl.Name = "SignIn_NavBarLbl";
            SignIn_NavBarLbl.Size = new Size(102, 38);
            SignIn_NavBarLbl.TabIndex = 8;
            SignIn_NavBarLbl.Text = "Sign in";
            SignIn_NavBarLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Search_Btn
            // 
            Search_Btn.BackColor = Color.FromArgb(45, 103, 119);
            Search_Btn.BackgroundColor = Color.FromArgb(45, 103, 119);
            Search_Btn.BackgroundImage = (Image)resources.GetObject("Search_Btn.BackgroundImage");
            Search_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Search_Btn.BorderColor = Color.PaleVioletRed;
            Search_Btn.BorderRadius = 33;
            Search_Btn.BorderSize = 0;
            Search_Btn.FlatAppearance.BorderSize = 0;
            Search_Btn.FlatStyle = FlatStyle.Flat;
            Search_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_Btn.ForeColor = Color.White;
            Search_Btn.Location = new Point(958, 35);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(75, 33);
            Search_Btn.TabIndex = 8;
            Search_Btn.TextColor = Color.White;
            Search_Btn.TextImageRelation = TextImageRelation.ImageAboveText;
            Search_Btn.UseVisualStyleBackColor = false;
            // 
            // SearchBox_TxtBox
            // 
            SearchBox_TxtBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox_TxtBox.Location = new Point(478, 31);
            SearchBox_TxtBox.Multiline = true;
            SearchBox_TxtBox.Name = "SearchBox_TxtBox";
            SearchBox_TxtBox.PlaceholderText = "Search";
            SearchBox_TxtBox.Size = new Size(559, 40);
            SearchBox_TxtBox.TabIndex = 13;
            // 
            // NotificationIcon_PicBox
            // 
            NotificationIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            NotificationIcon_PicBox.Image = (Image)resources.GetObject("NotificationIcon_PicBox.Image");
            NotificationIcon_PicBox.Location = new Point(1055, 24);
            NotificationIcon_PicBox.Name = "NotificationIcon_PicBox";
            NotificationIcon_PicBox.Size = new Size(77, 55);
            NotificationIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            NotificationIcon_PicBox.TabIndex = 9;
            NotificationIcon_PicBox.TabStop = false;
            // 
            // CartIcon_PicBox
            // 
            CartIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            CartIcon_PicBox.Image = (Image)resources.GetObject("CartIcon_PicBox.Image");
            CartIcon_PicBox.Location = new Point(1142, 21);
            CartIcon_PicBox.Name = "CartIcon_PicBox";
            CartIcon_PicBox.Size = new Size(70, 59);
            CartIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            CartIcon_PicBox.TabIndex = 10;
            CartIcon_PicBox.TabStop = false;
            // 
            // ProfileIcon_PicBox
            // 
            ProfileIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            ProfileIcon_PicBox.Image = (Image)resources.GetObject("ProfileIcon_PicBox.Image");
            ProfileIcon_PicBox.Location = new Point(1229, 21);
            ProfileIcon_PicBox.Name = "ProfileIcon_PicBox";
            ProfileIcon_PicBox.Size = new Size(69, 59);
            ProfileIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileIcon_PicBox.TabIndex = 11;
            ProfileIcon_PicBox.TabStop = false;
            // 
            // SignIn_Btn
            // 
            SignIn_Btn.BackColor = Color.FromArgb(45, 103, 119);
            SignIn_Btn.BackgroundColor = Color.FromArgb(45, 103, 119);
            SignIn_Btn.BorderColor = Color.PaleVioletRed;
            SignIn_Btn.BorderRadius = 69;
            SignIn_Btn.BorderSize = 0;
            SignIn_Btn.FlatAppearance.BorderSize = 0;
            SignIn_Btn.FlatStyle = FlatStyle.Flat;
            SignIn_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn_Btn.ForeColor = Color.White;
            SignIn_Btn.Location = new Point(18, 481);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(415, 69);
            SignIn_Btn.TabIndex = 1;
            SignIn_Btn.Text = "Sign in";
            SignIn_Btn.TextColor = Color.White;
            SignIn_Btn.UseVisualStyleBackColor = false;
            // 
            // SignIn_Panel
            // 
            SignIn_Panel.BackColor = Color.White;
            SignIn_Panel.Controls.Add(SignIn_HeaderLbl);
            SignIn_Panel.Controls.Add(Email_SignInLbl);
            SignIn_Panel.Controls.Add(Email_SignInTxtBox);
            SignIn_Panel.Controls.Add(Password_SignInLbl);
            SignIn_Panel.Controls.Add(Password_SignInTxtBox);
            SignIn_Panel.Controls.Add(ForgotPassword_Lbl);
            SignIn_Panel.Controls.Add(SignIn_Btn);
            SignIn_Panel.Controls.Add(SignUp_FooterLbl);
            SignIn_Panel.Location = new Point(449, 112);
            SignIn_Panel.Name = "SignIn_Panel";
            SignIn_Panel.Size = new Size(450, 600);
            SignIn_Panel.TabIndex = 2;
            SignIn_Panel.Visible = false;
            // 
            // SignIn_HeaderLbl
            // 
            SignIn_HeaderLbl.AutoSize = true;
            SignIn_HeaderLbl.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn_HeaderLbl.Location = new Point(145, 29);
            SignIn_HeaderLbl.Name = "SignIn_HeaderLbl";
            SignIn_HeaderLbl.Size = new Size(161, 57);
            SignIn_HeaderLbl.TabIndex = 0;
            SignIn_HeaderLbl.Text = "Sign in";
            SignIn_HeaderLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email_SignInLbl
            // 
            Email_SignInLbl.AutoSize = true;
            Email_SignInLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Email_SignInLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Email_SignInLbl.Location = new Point(18, 148);
            Email_SignInLbl.Name = "Email_SignInLbl";
            Email_SignInLbl.Size = new Size(59, 25);
            Email_SignInLbl.TabIndex = 5;
            Email_SignInLbl.Text = "Email";
            Email_SignInLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Email_SignInTxtBox
            // 
            Email_SignInTxtBox.Location = new Point(18, 180);
            Email_SignInTxtBox.Multiline = true;
            Email_SignInTxtBox.Name = "Email_SignInTxtBox";
            Email_SignInTxtBox.Size = new Size(415, 71);
            Email_SignInTxtBox.TabIndex = 6;
            // 
            // Password_SignInLbl
            // 
            Password_SignInLbl.AutoSize = true;
            Password_SignInLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password_SignInLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Password_SignInLbl.Location = new Point(18, 283);
            Password_SignInLbl.Name = "Password_SignInLbl";
            Password_SignInLbl.Size = new Size(97, 25);
            Password_SignInLbl.TabIndex = 4;
            Password_SignInLbl.Text = "Password";
            Password_SignInLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Password_SignInTxtBox
            // 
            Password_SignInTxtBox.Location = new Point(18, 313);
            Password_SignInTxtBox.Multiline = true;
            Password_SignInTxtBox.Name = "Password_SignInTxtBox";
            Password_SignInTxtBox.Size = new Size(415, 71);
            Password_SignInTxtBox.TabIndex = 7;
            // 
            // ForgotPassword_Lbl
            // 
            ForgotPassword_Lbl.AutoSize = true;
            ForgotPassword_Lbl.Font = new Font("Segoe UI", 10F);
            ForgotPassword_Lbl.ImageAlign = ContentAlignment.MiddleLeft;
            ForgotPassword_Lbl.Location = new Point(18, 389);
            ForgotPassword_Lbl.Name = "ForgotPassword_Lbl";
            ForgotPassword_Lbl.Size = new Size(143, 23);
            ForgotPassword_Lbl.TabIndex = 3;
            ForgotPassword_Lbl.Text = "Forgot Password?";
            ForgotPassword_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SignUp_FooterLbl
            // 
            SignUp_FooterLbl.AutoSize = true;
            SignUp_FooterLbl.Font = new Font("Segoe UI", 11F);
            SignUp_FooterLbl.Location = new Point(62, 555);
            SignUp_FooterLbl.Name = "SignUp_FooterLbl";
            SignUp_FooterLbl.Size = new Size(326, 25);
            SignUp_FooterLbl.TabIndex = 2;
            SignUp_FooterLbl.Text = "Doesn't have an account yet? Sign up";
            SignUp_FooterLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUp_Panel
            // 
            SignUp_Panel.BackColor = Color.White;
            SignUp_Panel.Controls.Add(SignUp_HeaderLbl);
            SignUp_Panel.Controls.Add(Username_Lbl);
            SignUp_Panel.Controls.Add(Username_TxtBox);
            SignUp_Panel.Controls.Add(Email_SignUpLbl);
            SignUp_Panel.Controls.Add(Email_SignUpTxtBox);
            SignUp_Panel.Controls.Add(Password_SignUpLbl);
            SignUp_Panel.Controls.Add(Password_SignUpTxtBox);
            SignUp_Panel.Controls.Add(RepeatPassword_SignUpLbl);
            SignUp_Panel.Controls.Add(RepeatPassword_SignUpTxtBox);
            SignUp_Panel.Controls.Add(SignUp_Btn);
            SignUp_Panel.Controls.Add(SignIn_FooterLbl);
            SignUp_Panel.Location = new Point(449, 112);
            SignUp_Panel.Name = "SignUp_Panel";
            SignUp_Panel.Size = new Size(450, 600);
            SignUp_Panel.TabIndex = 8;
            // 
            // SignUp_HeaderLbl
            // 
            SignUp_HeaderLbl.AutoSize = true;
            SignUp_HeaderLbl.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_HeaderLbl.Location = new Point(145, 29);
            SignUp_HeaderLbl.Name = "SignUp_HeaderLbl";
            SignUp_HeaderLbl.Size = new Size(175, 57);
            SignUp_HeaderLbl.TabIndex = 0;
            SignUp_HeaderLbl.Text = "Sign up";
            SignUp_HeaderLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username_Lbl
            // 
            Username_Lbl.AutoSize = true;
            Username_Lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Username_Lbl.ImageAlign = ContentAlignment.MiddleLeft;
            Username_Lbl.Location = new Point(18, 127);
            Username_Lbl.Name = "Username_Lbl";
            Username_Lbl.Size = new Size(101, 25);
            Username_Lbl.TabIndex = 5;
            Username_Lbl.Text = "Username";
            Username_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Username_TxtBox
            // 
            Username_TxtBox.Location = new Point(18, 155);
            Username_TxtBox.Multiline = true;
            Username_TxtBox.Name = "Username_TxtBox";
            Username_TxtBox.Size = new Size(415, 41);
            Username_TxtBox.TabIndex = 6;
            // 
            // Email_SignUpLbl
            // 
            Email_SignUpLbl.AutoSize = true;
            Email_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Email_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Email_SignUpLbl.Location = new Point(21, 207);
            Email_SignUpLbl.Name = "Email_SignUpLbl";
            Email_SignUpLbl.Size = new Size(59, 25);
            Email_SignUpLbl.TabIndex = 7;
            Email_SignUpLbl.Text = "Email";
            Email_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Email_SignUpTxtBox
            // 
            Email_SignUpTxtBox.Location = new Point(18, 235);
            Email_SignUpTxtBox.Multiline = true;
            Email_SignUpTxtBox.Name = "Email_SignUpTxtBox";
            Email_SignUpTxtBox.Size = new Size(415, 41);
            Email_SignUpTxtBox.TabIndex = 8;
            // 
            // Password_SignUpLbl
            // 
            Password_SignUpLbl.AutoSize = true;
            Password_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Password_SignUpLbl.Location = new Point(21, 287);
            Password_SignUpLbl.Name = "Password_SignUpLbl";
            Password_SignUpLbl.Size = new Size(97, 25);
            Password_SignUpLbl.TabIndex = 9;
            Password_SignUpLbl.Text = "Password";
            Password_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Password_SignUpTxtBox
            // 
            Password_SignUpTxtBox.Location = new Point(18, 316);
            Password_SignUpTxtBox.Multiline = true;
            Password_SignUpTxtBox.Name = "Password_SignUpTxtBox";
            Password_SignUpTxtBox.Size = new Size(415, 41);
            Password_SignUpTxtBox.TabIndex = 10;
            // 
            // RepeatPassword_SignUpLbl
            // 
            RepeatPassword_SignUpLbl.AutoSize = true;
            RepeatPassword_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RepeatPassword_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            RepeatPassword_SignUpLbl.Location = new Point(21, 369);
            RepeatPassword_SignUpLbl.Name = "RepeatPassword_SignUpLbl";
            RepeatPassword_SignUpLbl.Size = new Size(163, 25);
            RepeatPassword_SignUpLbl.TabIndex = 11;
            RepeatPassword_SignUpLbl.Text = "Repeat Password";
            RepeatPassword_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RepeatPassword_SignUpTxtBox
            // 
            RepeatPassword_SignUpTxtBox.Location = new Point(18, 397);
            RepeatPassword_SignUpTxtBox.Multiline = true;
            RepeatPassword_SignUpTxtBox.Name = "RepeatPassword_SignUpTxtBox";
            RepeatPassword_SignUpTxtBox.Size = new Size(415, 41);
            RepeatPassword_SignUpTxtBox.TabIndex = 12;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.FromArgb(45, 103, 119);
            SignUp_Btn.BackgroundColor = Color.FromArgb(45, 103, 119);
            SignUp_Btn.BorderColor = Color.PaleVioletRed;
            SignUp_Btn.BorderRadius = 69;
            SignUp_Btn.BorderSize = 0;
            SignUp_Btn.FlatAppearance.BorderSize = 0;
            SignUp_Btn.FlatStyle = FlatStyle.Flat;
            SignUp_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUp_Btn.ForeColor = Color.White;
            SignUp_Btn.Location = new Point(18, 481);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(415, 69);
            SignUp_Btn.TabIndex = 1;
            SignUp_Btn.Text = "Sign up";
            SignUp_Btn.TextColor = Color.White;
            SignUp_Btn.UseVisualStyleBackColor = false;
            // 
            // SignIn_FooterLbl
            // 
            SignIn_FooterLbl.AutoSize = true;
            SignIn_FooterLbl.Font = new Font("Segoe UI", 11F);
            SignIn_FooterLbl.Location = new Point(62, 555);
            SignIn_FooterLbl.Name = "SignIn_FooterLbl";
            SignIn_FooterLbl.Size = new Size(321, 25);
            SignIn_FooterLbl.TabIndex = 2;
            SignIn_FooterLbl.Text = "Already have an account yet? Sign in";
            SignIn_FooterLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 244);
            ClientSize = new Size(1348, 721);
            Controls.Add(TopNavBar);
            Controls.Add(SignIn_Panel);
            Controls.Add(SignUp_Panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Add Program Label Here";
            TopNavBar.ResumeLayout(false);
            TopNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo_PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line_PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon_PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartIcon_PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfileIcon_PicBox).EndInit();
            SignIn_Panel.ResumeLayout(false);
            SignIn_Panel.PerformLayout();
            SignUp_Panel.ResumeLayout(false);
            SignUp_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopNavBar;
        private AddControls.RoundedButton SignIn_Btn;
        private Panel SignIn_Panel;
        private Label SignIn_HeaderLbl;
        private Label ForgotPassword_Lbl;
        private Label SignUp_FooterLbl;
        private Label Password_SignInLbl;
        private Label Email_SignInLbl;
        private TextBox Email_SignInTxtBox;
        private TextBox Password_SignInTxtBox;
        private PictureBox Logo_PicBox;
        private Label SignIn_NavBarLbl;
        private PictureBox NotificationIcon_PicBox;
        private PictureBox CartIcon_PicBox;
        private PictureBox ProfileIcon_PicBox;
        private PictureBox Line_PicBox;
        private TextBox SearchBox_TxtBox;
        private AddControls.RoundedButton Search_Btn;
        private Panel SignUp_Panel;
        private Label SignUp_HeaderLbl;
        private Label Username_Lbl;
        private TextBox Username_TxtBox;
        private AddControls.RoundedButton SignUp_Btn;
        private Label SignIn_FooterLbl;
        private TextBox Email_SignUpTxtBox;
        private Label Email_SignUpLbl;
        private Label Password_SignUpLbl;
        private TextBox Password_SignUpTxtBox;
        private Label RepeatPassword_SignUpLbl;
        private TextBox RepeatPassword_SignUpTxtBox;
    }
}
