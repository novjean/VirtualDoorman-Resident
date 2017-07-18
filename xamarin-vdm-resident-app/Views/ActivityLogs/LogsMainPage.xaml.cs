using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.ActivityLogs
{
    public partial class LogsMainPage : ContentPage
    {
        private User userObject;

        public LogsMainPage()
        {
            InitializeComponent();
        }

        public LogsMainPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            init();
        }

		public void init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

		void OnPackageDeliveriesClicked(object sender, System.EventArgs e)
		{
            Navigation.PushAsync(new DeliveryLogsPage(userObject));
		}

		void OnGuestsLogClicked(object sender, System.EventArgs e)
		{
            Navigation.PushAsync(new GuestsLogPage(userObject));
		}
    }
}
