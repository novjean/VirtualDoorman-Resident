using System;
using VirtualDoorman.Views.ActivityLogs;
using VirtualDoorman.Views.Contacts;
using VirtualDoorman.Views.GuestsAndDeliveries;
using VirtualDoorman.Views.OrderAccessCard;
using Xamarin.Forms;

namespace VirtualDoorman
{
    public partial class MainPage : ContentPage
    {
		private User userObject;

        public MainPage(User userObject)
        {
            this.userObject = userObject;

            //Hiding the Back button
			NavigationPage.SetHasBackButton(this, false); 
			
            InitializeComponent();
            Init(userObject);
        }

        private void Init(User userObject)
        {
            if (userObject == null)
                throw new ArgumentNullException(nameof(userObject));
            
            BackgroundColor = Constants.BackgroundColor;
            welcomeTitle.Text = $"Hello {userObject.Result.FirstName} {userObject.Result.LastName}"; 
		}

		//Backup Init
		void Init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

		//Constructor for rendering
		public MainPage()
		{
			NavigationPage.SetHasBackButton(this, false);
			InitializeComponent();
			Init();
		}

        //Buttons and Taps
		async void OnContactsClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ContactsMainPage(userObject));
		}

		async void OnLogoutClicked(object sender, System.EventArgs e)
		{
			await Navigation.PopToRootAsync();
		}

		async void OnRecentActivityClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new LogsMainPage(userObject));
		}

		async void OrderAccessCardClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new OrderAccessCardPageOne(userObject));
		}

		async void OnGuestsDeliveriesClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new GuestsAndDeliveriesMainPage(userObject));
		}

	}
}
