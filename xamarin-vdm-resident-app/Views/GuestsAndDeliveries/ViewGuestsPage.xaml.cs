using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class ViewGuestsPage : ContentPage
    {
        private User userObject;
        private GuestsService _service = new GuestsService();

        public ViewGuestsPage()
        {
            InitializeComponent();
            Init();
        }

        public ViewGuestsPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            Init(userObject);
            PopulatePage(userObject);

        }

        async public void PopulatePage(User userObject)
        {
			//Debug.WriteLine($"Login GUID= {userObject.Result.LoginGUID}");
			GuestResponse res = await _service.RetreiveGuests(userObject);
            Debug.WriteLine($"GuestResponse Received: {res.Message}");
            List<Guest> listOfGuests = res.Result;
            guestListView.ItemsSource = listOfGuests;

        }

		async void OnGuestSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
            if (e.SelectedItem == null)
                return;

            var guest = e.SelectedItem as Guest;

            guestListView.SelectedItem = null;

            await Navigation.PushAsync(new GuestDetailPage(guest));
		}

        //Backup Init
        void Init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

		private void Init(User userObject)
		{
			if (userObject == null)
				throw new ArgumentNullException(nameof(userObject));
			BackgroundColor = Constants.BackgroundColor;

		}
    }
}
