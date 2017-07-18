using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models.BusinessModels;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class ViewBusinessesPage : ContentPage
    {
        private User userObject;
        private BusinessService _service = new BusinessService();

        public ViewBusinessesPage()
        {
            InitializeComponent();
            Init();
        }

        public ViewBusinessesPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            Init(userObject);
            PopulatePage(userObject);

        }

        async public void PopulatePage(User userObject){

            BusinessResponse res = await _service.RetreiveBusinesses(userObject);
            Debug.WriteLine($"BusinessResponse received: {res.Message}");
            List<Business> listOfBusinesses = res.Result;
            businessListView.ItemsSource = listOfBusinesses;
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
