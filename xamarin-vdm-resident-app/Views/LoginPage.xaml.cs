using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman
{
    public partial class LoginPage : ContentPage
    {
        private LoginService _loginService = new LoginService();

		void clearFields()
		{
			entryPassword.Text = "";
		}

		async public void OnSignUpClicked(object sender, System.EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Register clicked");
			await Navigation.PushAsync(new RegisterPage());
		}

        async public void OnLoginClicked(object sender, System.EventArgs e)
        {
            
            System.Diagnostics.Debug.WriteLine($"Login clicked:{entryUsername.Text} , {entryPassword.Text} ");
            activitySpinner.IsVisible = true;

            LoginUser user = new LoginUser(entryUsername.Text, entryPassword.Text);
            if(user.CheckInformation()){
                
                User userObject = await _loginService.CheckLogin(user);  //Checking the input values entered
                //System.Diagnostics.Debug.WriteLine($"UserObject=  {userObject.Status}");

                //Success Login
                if(!userObject.Status.Equals("FAIL")){
					activitySpinner.IsVisible = false;  //turning the spinner off
					await Navigation.PushAsync(new MainPage(userObject)); //navigating to the main page
				}
                //Failed Login Credentials
				else
				{
					activitySpinner.IsVisible = false;
					clearFields();
					await DisplayAlert("Login", "Incorrect username/password", "Okay");
				}
            }
            else{
                activitySpinner.IsVisible = false;
                clearFields();
                await DisplayAlert("Login", "Incorrect username/password", "Okay");
            }

        }

        void Init(){
            //BackgroundColor = Constants.BackgroundColor;
            //lblPassword.TextColor = Constants.MainTextColor;
            //lblUsername.TextColor = Constants.MainTextColor;
            entryUsername.Text = "";
            entryPassword.Text = "";
            activitySpinner.IsVisible = false;

            entryUsername.Completed += (s, e) => entryPassword.Focus();
            entryPassword.Completed += (s, e) => btnLogin.Focus();
        }

        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false); //Hide the navigation bar

            InitializeComponent();
            Init();
        }
    }
}
