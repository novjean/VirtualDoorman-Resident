using System;
using System.Diagnostics;
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

            string greeting = getGreeting();
            //welcomeStack.BackgroundColor = getUserLevelColor(userObject.Result);

            medalImage.Source = getUserLevelColor(userObject.Result);

            welcomeTitle.Text = $"{greeting}, {userObject.Result.FirstName} {userObject.Result.LastName}."; 
		}

        private string getUserLevelColor(Result result)
        {
            //Color set  = Color.FromHex("#ffffff");
            //if (result.UserLevel.Equals("GLD"))
            //    set = Color.FromHex("#ffdf80");
            //else if (result.UserLevel.Equals("SLR"))
            //    set = Color.FromHex("#C0C0C0");
            //else
            //    set = Color.FromHex("#cc6633");
            //return set;
            string set;

			if (result.UserLevel.Equals("GLD"))
			    set = "levelGold.png";
			else if (result.UserLevel.Equals("SLR"))
			    set = "levelSilver.png";
			else
			    set = "levelBronze.png";
            return set;

		}

        private string getGreeting()
        {
            DateTime now = DateTime.Now;
            if (now.Hour.CompareTo(5) >= 0 && now.Hour.CompareTo(12) < 0)
                return "Good morning";
            else if (now.Hour.CompareTo(12) >= 0 && now.Hour.CompareTo(17) < 0)
                return "Good afternoon";
            else if (now.Hour.CompareTo(17) >= 0 && now.Hour.CompareTo(22) < 0)
                return "Good evening";
            else
                return "Good night";
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
