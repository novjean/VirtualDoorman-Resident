using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class AddGuestPage : ContentPage
    {
        void OnPermissionTypeTapped(object sender, System.EventArgs e)
        {
            var page = new PermissionTypesPage();
            page.PermissionTypes.ItemSelected += (source, args) =>
            {
                permissionType.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        private User userObject;

        public AddGuestPage()
        {
            InitializeComponent();
        }

        public AddGuestPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            init();
            populatePage(userObject);
        }

        private void populatePage(User userObject)
        {
			foreach (var cellProvider in GetCellProviders())
				pickerCellProvider.Items.Add(cellProvider.Name);
        }

        public void init(){
            BackgroundColor = Constants.BackgroundColor;
        }

		public IList<CellProvider> GetCellProviders()
		{
			return new List<CellProvider>{
				new CellProvider{Id=1, Name="AT&T"},
				new CellProvider{Id=2, Name="T Mobile"},
				new CellProvider{Id=3, Name="Sprint"},
				new CellProvider{Id=4, Name="Verizon"},
				new CellProvider{Id=5, Name="Project Fi"},
			};
		}
    }
}
