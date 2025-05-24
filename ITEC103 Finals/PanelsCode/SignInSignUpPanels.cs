namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        // Add Code Here

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Panel.BringToFront();
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn_Panel.BringToFront();
        }
        
        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            string username = Username_TxtBox.Text.Trim();
            string password = Password_SignUpTxtBox.Text.Trim();
            string repeatPassword = RepeatPassword_SignUpTxtBox.Text.Trim();
            try
            {
                //checks if all signup fields are filled -JM
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //checks if password and repeat password match -JM
                if (password != repeatPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //checks if username is already taken -JM
                if (api.UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                api.PushDataToUsers(username, password);

                MessageBox.Show("Sign up successful. Please wait for account approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Username_TxtBox.Clear();
                Password_SignUpTxtBox.Clear();
                RepeatPassword_SignUpTxtBox.Clear();

                SignIn_Panel.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during sign up:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Username_TxtBox.Clear();
                Password_SignUpTxtBox.Clear();
                RepeatPassword_SignUpTxtBox.Clear();
            }
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            string username = Email_SignInTxtBox.Text.Trim();
            string password = Password_SignInTxtBox.Text;

            try
            {
                //checks that both fields are filled -JM
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Authenticate the user -JM
                if (api.AuthenticateAccount(username, password))
                {
                    MessageBox.Show("Sign in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Email_SignInTxtBox.Clear();
                    Password_SignInTxtBox.Clear();

                    signed_in = true;
                    HomePage_Panel.BringToFront();
                }
                else
                {
                    MessageBox.Show("Sign in Failed! Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email_SignInTxtBox.Clear();
                    Password_SignInTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
