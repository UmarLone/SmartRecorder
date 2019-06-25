#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace SmartRecord.Views.ViewModels.Login1
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    public class LoginPageViewModel : LoginViewModel
    {
        private string password;

        public LoginPageViewModel()
        {
            LoginCommand = new Command(LoginClicked);
            SignUpCommand = new Command(SignUpClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
            SocialMediaLoginCommand = new Command(SocialLoggedIn);
        }

        /// <summary>
        /// This property is bound with an entry that gets the password from the user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password == value)
                {
                    return;
                }
                password = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// This command is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// This command is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// This command is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        /// <summary>
        /// This command is executed when the social media login button is clicked.
        /// </summary>
        public Command SocialMediaLoginCommand { get; set; }

        private void LoginClicked(object obj)
        {

        }

        private void SignUpClicked(object obj)
        {

        }

        private void ForgotPasswordClicked(object obj)
        {

        }

        private void SocialLoggedIn()
        {

        }
    }
}