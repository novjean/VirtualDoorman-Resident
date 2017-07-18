using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models.GuestLogModels;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.ActivityLogs
{
    public partial class GuestsLogPage : ContentPage
    {
        private User userObject;
        private GuestsLogService _service = new GuestsLogService();

        public GuestsLogPage()
        {
            InitializeComponent();
        }

        public GuestsLogPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            Init();
            PopulatePage(userObject);
        }

        async public void PopulatePage(User userObject){
            GuestLogResponse res = await _service.RetreiveGuestLogs(userObject);
            Debug.WriteLine($"GuestLogResponse Received: {res.Message}");
            List<LogReport> listOfGuestReports = new List<LogReport>();
            foreach(var log in res.Result){
                if(log.ReportType.Equals("guest"))
                {
                    
                    listOfGuestReports.Add(log);
                }
            }
            guestLogs.ItemsSource = listOfGuestReports;
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
