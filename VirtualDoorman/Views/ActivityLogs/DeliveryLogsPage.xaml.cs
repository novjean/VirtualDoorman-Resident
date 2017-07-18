using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models.BusinessLogModels;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.ActivityLogs
{
    public partial class DeliveryLogsPage : ContentPage
    {
        private User userObject;
        private BusinessLogService _service = new BusinessLogService();

        public DeliveryLogsPage()
        {
            InitializeComponent();
            init();
        }

        public DeliveryLogsPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            init();
            PopulatePage(userObject);
        }

       
        async private void PopulatePage(User userObject)
        {
            BusinessLogResponse res = await _service.RetrieveDeliveryLogs(userObject);
            Debug.WriteLine($"BusinessLogResponse Received: {res.Message}");
            List<DeliveryReport> listOfDeliveries = new List<DeliveryReport>();
            foreach(var log in res.Result){
                if(log.ReportType.Equals("delivery")){
                    listOfDeliveries.Add(log);
                }
            }
            deliveryLogs.ItemsSource = listOfDeliveries;
        }

        public void init(){
            BackgroundColor = Constants.BackgroundColor;
        }
    }
}
