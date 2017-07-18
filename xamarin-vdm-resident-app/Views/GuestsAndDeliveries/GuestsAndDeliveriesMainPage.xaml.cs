using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class GuestsAndDeliveriesMainPage : ContentPage
    {
        private User userObject;

        public GuestsAndDeliveriesMainPage()
		{
			InitializeComponent();
            Init();
		}

        public GuestsAndDeliveriesMainPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            Init(userObject);

        }

		//Backup Init for Rendering
		void Init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

        private void Init(User userObject){
			if (userObject == null)
				throw new ArgumentNullException(nameof(userObject));

			BackgroundColor = Constants.BackgroundColor;
        }

        void OnAddBusinessClicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnViewBusinessesClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ViewBusinessesPage(userObject));
        }

        void OnAddGuestsClicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnViewGuestsClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ViewGuestsPage(userObject));
        }

    }
}
