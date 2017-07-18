using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.GuestsAndDeliveries
{
    public partial class GuestDetailPage : ContentPage
    {

        public Guest _guest;
        private GuestsService _guestService = new GuestsService();

        //Constructors
        public GuestDetailPage()
        {
            InitializeComponent();
        }

        public GuestDetailPage(Guest guest)
        {
            if (guest == null)
                throw new ArgumentNullException(nameof(guest));
                
            _guest = guest;

            InitializeComponent();

            BindingContext = this._guest;
            init(guest);
        }

        public void init(Guest guest){

			foreach (var cellProvider in GetCellProviders())
				pickerCellProvider.Items.Add(cellProvider.Name);

            if (guest.SecretQuestion.Equals(""))
                switchSecurity.IsToggled = false;
            else
                switchSecurity.IsToggled = true;
        }

		void OnPermissionTypeTapped(object sender, System.EventArgs e)
		{
            var page = new PermissionTypesPage();
            page.PermissionTypes.ItemSelected += (source, args) => {
                permissionType.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
		}

		void OnSunClicked(object sender, System.EventArgs e)
		{
			if (btnSun.BackgroundColor.Equals(Color.Transparent))
			{
				btnSun.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnSun.BackgroundColor = Color.Transparent;
			}
		}

		void OnSatClicked(object sender, System.EventArgs e)
		{
			if (btnSat.BackgroundColor.Equals(Color.Transparent))
			{
				btnSat.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnSat.BackgroundColor = Color.Transparent;
			}
		}

		void OnFriClicked(object sender, System.EventArgs e)
		{
            if (btnFri.BackgroundColor.Equals(Color.Transparent))
			{
				btnFri.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
                btnFri.BackgroundColor = Color.Transparent;
			}

		}

		void OnThurClicked(object sender, System.EventArgs e)
		{
			if (btnThur.BackgroundColor.Equals(Color.Transparent))
			{
				btnThur.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnThur.BackgroundColor = Color.Transparent;
			}

		}

		void OnWedClicked(object sender, System.EventArgs e)
		{
            if (btnWed.BackgroundColor.Equals(Color.Transparent))
			{
				btnWed.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnWed.BackgroundColor = Color.Transparent;
			}

		}

		void OnTueClicked(object sender, System.EventArgs e)
		{
            if (btnTue.BackgroundColor.Equals(Color.Transparent))
			{
				btnTue.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnTue.BackgroundColor = Color.Transparent;
			}

		}

		void OnMonClicked(object sender, System.EventArgs e)
		{
			if (btnMon.BackgroundColor.Equals(Color.Transparent))
			{
				btnMon.BackgroundColor = Color.FromHex("#58eaa1");
			}
			else
			{
				btnMon.BackgroundColor = Color.Transparent;
			}

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
