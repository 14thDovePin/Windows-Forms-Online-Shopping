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
            TopNavBar.Margin = new Padding(3, 2, 3, 2);
            TopNavBar.Name = "TopNavBar";
            TopNavBar.Size = new Size(1180, 79);
            TopNavBar.TabIndex = 0;
            // 
            // Logo_PicBox
            // 
            Logo_PicBox.BackgroundImageLayout = ImageLayout.None;
            Logo_PicBox.Image = (Image)resources.GetObject("Logo_PicBox.Image");
            Logo_PicBox.Location = new Point(23, 23);
            Logo_PicBox.Margin = new Padding(3, 2, 3, 2);
            Logo_PicBox.Name = "Logo_PicBox";
            Logo_PicBox.Size = new Size(157, 40);
            Logo_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            Logo_PicBox.TabIndex = 0;
            Logo_PicBox.TabStop = false;
            // 
            // Line_PicBox
            // 
            Line_PicBox.BackgroundImageLayout = ImageLayout.None;
            Line_PicBox.Image = (Image)resources.GetObject("Line_PicBox.Image");
            Line_PicBox.Location = new Point(179, 23);
            Line_PicBox.Margin = new Padding(3, 2, 3, 2);
            Line_PicBox.Name = "Line_PicBox";
            Line_PicBox.Size = new Size(33, 36);
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
            SignIn_NavBarLbl.Location = new Point(206, 22);
            SignIn_NavBarLbl.Name = "SignIn_NavBarLbl";
            SignIn_NavBarLbl.Size = new Size(78, 30);
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
            Search_Btn.BorderRadius = 25;
            Search_Btn.BorderSize = 0;
            Search_Btn.FlatAppearance.BorderSize = 0;
            Search_Btn.FlatStyle = FlatStyle.Flat;
            Search_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_Btn.ForeColor = Color.White;
            Search_Btn.Location = new Point(838, 26);
            Search_Btn.Margin = new Padding(3, 2, 3, 2);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(66, 25);
            Search_Btn.TabIndex = 8;
            Search_Btn.TextColor = Color.White;
            Search_Btn.TextImageRelation = TextImageRelation.ImageAboveText;
            Search_Btn.UseVisualStyleBackColor = false;
            // 
            // SearchBox_TxtBox
            // 
            SearchBox_TxtBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox_TxtBox.Location = new Point(418, 23);
            SearchBox_TxtBox.Margin = new Padding(3, 2, 3, 2);
            SearchBox_TxtBox.Multiline = true;
            SearchBox_TxtBox.Name = "SearchBox_TxtBox";
            SearchBox_TxtBox.PlaceholderText = "Search";
            SearchBox_TxtBox.Size = new Size(490, 31);
            SearchBox_TxtBox.TabIndex = 13;
            // 
            // NotificationIcon_PicBox
            // 
            NotificationIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            NotificationIcon_PicBox.Image = (Image)resources.GetObject("NotificationIcon_PicBox.Image");
            NotificationIcon_PicBox.Location = new Point(923, 18);
            NotificationIcon_PicBox.Margin = new Padding(3, 2, 3, 2);
            NotificationIcon_PicBox.Name = "NotificationIcon_PicBox";
            NotificationIcon_PicBox.Size = new Size(67, 41);
            NotificationIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            NotificationIcon_PicBox.TabIndex = 9;
            NotificationIcon_PicBox.TabStop = false;
            // 
            // CartIcon_PicBox
            // 
            CartIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            CartIcon_PicBox.Image = (Image)resources.GetObject("CartIcon_PicBox.Image");
            CartIcon_PicBox.Location = new Point(999, 16);
            CartIcon_PicBox.Margin = new Padding(3, 2, 3, 2);
            CartIcon_PicBox.Name = "CartIcon_PicBox";
            CartIcon_PicBox.Size = new Size(61, 44);
            CartIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            CartIcon_PicBox.TabIndex = 10;
            CartIcon_PicBox.TabStop = false;
            // 
            // ProfileIcon_PicBox
            // 
            ProfileIcon_PicBox.BackgroundImageLayout = ImageLayout.None;
            ProfileIcon_PicBox.Image = (Image)resources.GetObject("ProfileIcon_PicBox.Image");
            ProfileIcon_PicBox.Location = new Point(1075, 16);
            ProfileIcon_PicBox.Margin = new Padding(3, 2, 3, 2);
            ProfileIcon_PicBox.Name = "ProfileIcon_PicBox";
            ProfileIcon_PicBox.Size = new Size(60, 44);
            ProfileIcon_PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileIcon_PicBox.TabIndex = 11;
            ProfileIcon_PicBox.TabStop = false;
            // 
            // SignIn_Btn
            // 
            SignIn_Btn.BackColor = Color.FromArgb(45, 103, 119);
            SignIn_Btn.BackgroundColor = Color.FromArgb(45, 103, 119);
            SignIn_Btn.BorderColor = Color.PaleVioletRed;
            SignIn_Btn.BorderRadius = 52;
            SignIn_Btn.BorderSize = 0;
            SignIn_Btn.FlatAppearance.BorderSize = 0;
            SignIn_Btn.FlatStyle = FlatStyle.Flat;
            SignIn_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn_Btn.ForeColor = Color.White;
            SignIn_Btn.Location = new Point(16, 361);
            SignIn_Btn.Margin = new Padding(3, 2, 3, 2);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(363, 52);
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
            SignIn_Panel.Location = new Point(401, 105);
            SignIn_Panel.Margin = new Padding(3, 2, 3, 2);
            SignIn_Panel.Name = "SignIn_Panel";
            SignIn_Panel.Size = new Size(394, 450);
            SignIn_Panel.TabIndex = 2;
            SignIn_Panel.Visible = false;
            // 
            // SignIn_HeaderLbl
            // 
            SignIn_HeaderLbl.AutoSize = true;
            SignIn_HeaderLbl.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn_HeaderLbl.Location = new Point(127, 22);
            SignIn_HeaderLbl.Name = "SignIn_HeaderLbl";
            SignIn_HeaderLbl.Size = new Size(131, 46);
            SignIn_HeaderLbl.TabIndex = 0;
            SignIn_HeaderLbl.Text = "Sign in";
            SignIn_HeaderLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email_SignInLbl
            // 
            Email_SignInLbl.AutoSize = true;
            Email_SignInLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Email_SignInLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Email_SignInLbl.Location = new Point(16, 111);
            Email_SignInLbl.Name = "Email_SignInLbl";
            Email_SignInLbl.Size = new Size(47, 20);
            Email_SignInLbl.TabIndex = 5;
            Email_SignInLbl.Text = "Email";
            Email_SignInLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Email_SignInTxtBox
            // 
            Email_SignInTxtBox.Location = new Point(16, 135);
            Email_SignInTxtBox.Margin = new Padding(3, 2, 3, 2);
            Email_SignInTxtBox.Multiline = true;
            Email_SignInTxtBox.Name = "Email_SignInTxtBox";
            Email_SignInTxtBox.Size = new Size(364, 54);
            Email_SignInTxtBox.TabIndex = 6;
            // 
            // Password_SignInLbl
            // 
            Password_SignInLbl.AutoSize = true;
            Password_SignInLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password_SignInLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Password_SignInLbl.Location = new Point(16, 212);
            Password_SignInLbl.Name = "Password_SignInLbl";
            Password_SignInLbl.Size = new Size(76, 20);
            Password_SignInLbl.TabIndex = 4;
            Password_SignInLbl.Text = "Password";
            Password_SignInLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Password_SignInTxtBox
            // 
            Password_SignInTxtBox.Location = new Point(16, 235);
            Password_SignInTxtBox.Margin = new Padding(3, 2, 3, 2);
            Password_SignInTxtBox.Multiline = true;
            Password_SignInTxtBox.Name = "Password_SignInTxtBox";
            Password_SignInTxtBox.Size = new Size(364, 54);
            Password_SignInTxtBox.TabIndex = 7;
            // 
            // ForgotPassword_Lbl
            // 
            ForgotPassword_Lbl.AutoSize = true;
            ForgotPassword_Lbl.Font = new Font("Segoe UI", 10F);
            ForgotPassword_Lbl.ImageAlign = ContentAlignment.MiddleLeft;
            ForgotPassword_Lbl.Location = new Point(16, 292);
            ForgotPassword_Lbl.Name = "ForgotPassword_Lbl";
            ForgotPassword_Lbl.Size = new Size(118, 19);
            ForgotPassword_Lbl.TabIndex = 3;
            ForgotPassword_Lbl.Text = "Forgot Password?";
            ForgotPassword_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SignUp_FooterLbl
            // 
            SignUp_FooterLbl.AutoSize = true;
            SignUp_FooterLbl.Font = new Font("Segoe UI", 11F);
            SignUp_FooterLbl.Location = new Point(54, 416);
            SignUp_FooterLbl.Name = "SignUp_FooterLbl";
            SignUp_FooterLbl.Size = new Size(255, 20);
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
            SignUp_Panel.Location = new Point(401, 105);
            SignUp_Panel.Margin = new Padding(3, 2, 3, 2);
            SignUp_Panel.Name = "SignUp_Panel";
            SignUp_Panel.Size = new Size(394, 450);
            SignUp_Panel.TabIndex = 8;
            // 
            // SignUp_HeaderLbl
            // 
            SignUp_HeaderLbl.AutoSize = true;
            SignUp_HeaderLbl.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_HeaderLbl.Location = new Point(127, 22);
            SignUp_HeaderLbl.Name = "SignUp_HeaderLbl";
            SignUp_HeaderLbl.Size = new Size(142, 46);
            SignUp_HeaderLbl.TabIndex = 0;
            SignUp_HeaderLbl.Text = "Sign up";
            SignUp_HeaderLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username_Lbl
            // 
            Username_Lbl.AutoSize = true;
            Username_Lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Username_Lbl.ImageAlign = ContentAlignment.MiddleLeft;
            Username_Lbl.Location = new Point(16, 95);
            Username_Lbl.Name = "Username_Lbl";
            Username_Lbl.Size = new Size(80, 20);
            Username_Lbl.TabIndex = 5;
            Username_Lbl.Text = "Username";
            Username_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Username_TxtBox
            // 
            Username_TxtBox.Location = new Point(16, 116);
            Username_TxtBox.Margin = new Padding(3, 2, 3, 2);
            Username_TxtBox.Multiline = true;
            Username_TxtBox.Name = "Username_TxtBox";
            Username_TxtBox.Size = new Size(364, 32);
            Username_TxtBox.TabIndex = 6;
            // 
            // Email_SignUpLbl
            // 
            Email_SignUpLbl.AutoSize = true;
            Email_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Email_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Email_SignUpLbl.Location = new Point(18, 155);
            Email_SignUpLbl.Name = "Email_SignUpLbl";
            Email_SignUpLbl.Size = new Size(47, 20);
            Email_SignUpLbl.TabIndex = 7;
            Email_SignUpLbl.Text = "Email";
            Email_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Email_SignUpTxtBox
            // 
            Email_SignUpTxtBox.Location = new Point(16, 176);
            Email_SignUpTxtBox.Margin = new Padding(3, 2, 3, 2);
            Email_SignUpTxtBox.Multiline = true;
            Email_SignUpTxtBox.Name = "Email_SignUpTxtBox";
            Email_SignUpTxtBox.Size = new Size(364, 32);
            Email_SignUpTxtBox.TabIndex = 8;
            // 
            // Password_SignUpLbl
            // 
            Password_SignUpLbl.AutoSize = true;
            Password_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            Password_SignUpLbl.Location = new Point(18, 215);
            Password_SignUpLbl.Name = "Password_SignUpLbl";
            Password_SignUpLbl.Size = new Size(76, 20);
            Password_SignUpLbl.TabIndex = 9;
            Password_SignUpLbl.Text = "Password";
            Password_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Password_SignUpTxtBox
            // 
            Password_SignUpTxtBox.Location = new Point(16, 237);
            Password_SignUpTxtBox.Margin = new Padding(3, 2, 3, 2);
            Password_SignUpTxtBox.Multiline = true;
            Password_SignUpTxtBox.Name = "Password_SignUpTxtBox";
            Password_SignUpTxtBox.Size = new Size(364, 32);
            Password_SignUpTxtBox.TabIndex = 10;
            // 
            // RepeatPassword_SignUpLbl
            // 
            RepeatPassword_SignUpLbl.AutoSize = true;
            RepeatPassword_SignUpLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RepeatPassword_SignUpLbl.ImageAlign = ContentAlignment.MiddleLeft;
            RepeatPassword_SignUpLbl.Location = new Point(18, 277);
            RepeatPassword_SignUpLbl.Name = "RepeatPassword_SignUpLbl";
            RepeatPassword_SignUpLbl.Size = new Size(129, 20);
            RepeatPassword_SignUpLbl.TabIndex = 11;
            RepeatPassword_SignUpLbl.Text = "Repeat Password";
            RepeatPassword_SignUpLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RepeatPassword_SignUpTxtBox
            // 
            RepeatPassword_SignUpTxtBox.Location = new Point(16, 298);
            RepeatPassword_SignUpTxtBox.Margin = new Padding(3, 2, 3, 2);
            RepeatPassword_SignUpTxtBox.Multiline = true;
            RepeatPassword_SignUpTxtBox.Name = "RepeatPassword_SignUpTxtBox";
            RepeatPassword_SignUpTxtBox.Size = new Size(364, 32);
            RepeatPassword_SignUpTxtBox.TabIndex = 12;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.FromArgb(45, 103, 119);
            SignUp_Btn.BackgroundColor = Color.FromArgb(45, 103, 119);
            SignUp_Btn.BorderColor = Color.PaleVioletRed;
            SignUp_Btn.BorderRadius = 52;
            SignUp_Btn.BorderSize = 0;
            SignUp_Btn.FlatAppearance.BorderSize = 0;
            SignUp_Btn.FlatStyle = FlatStyle.Flat;
            SignUp_Btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUp_Btn.ForeColor = Color.White;
            SignUp_Btn.Location = new Point(16, 361);
            SignUp_Btn.Margin = new Padding(3, 2, 3, 2);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(363, 52);
            SignUp_Btn.TabIndex = 1;
            SignUp_Btn.Text = "Sign up";
            SignUp_Btn.TextColor = Color.White;
            SignUp_Btn.UseVisualStyleBackColor = false;
            // 
            // SignIn_FooterLbl
            // 
            SignIn_FooterLbl.AutoSize = true;
            SignIn_FooterLbl.Font = new Font("Segoe UI", 11F);
            SignIn_FooterLbl.Location = new Point(54, 416);
            SignIn_FooterLbl.Name = "SignIn_FooterLbl";
            SignIn_FooterLbl.Size = new Size(251, 20);
            SignIn_FooterLbl.TabIndex = 2;
            SignIn_FooterLbl.Text = "Already have an account yet? Sign in";
            SignIn_FooterLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1350, 729);
            Controls.Add(TopNavBar);
            Controls.Add(SignUp_Panel);
            Controls.Add(SignIn_Panel);
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
