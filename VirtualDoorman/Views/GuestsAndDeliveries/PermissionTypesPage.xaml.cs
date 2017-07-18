using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class PermissionTypesPage : ContentPage
    {
        public PermissionTypesPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<string>{
                "Any Day",
                "Date Period",
                "Days of Week"
            };
        }

        public ListView PermissionTypes{
            get {
                return listView;
            }
        }
    }
}
