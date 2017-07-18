using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public partial class OrderAccessCardPageOne : ContentPage
    {
        private User user;
        
        void ContinueClicked(object sender, System.EventArgs e)
        {
            Cart cart = new Cart();

            cart.fobCount = Int32.Parse(fobCount.Items[fobCount.SelectedIndex]);
			cart.cardCount = Int32.Parse(cardCount.Items[cardCount.SelectedIndex]);
            cart.loginGUID = user.Result.LoginGUID;
			cart.totalKeys = cart.fobCount + cart.cardCount;
            //cart.keysForGuest = switchKeysForGuests.IsToggled;       

            Debug.WriteLine($"Total Keys= {cart.totalKeys}");

            cart.keys = GenerateOrderKeysForCart(cart);

			Navigation.PushAsync(new OrderAccessCardPageTwo(cart));
		}

        private List<OrderKey> GenerateOrderKeysForCart(Cart cart)
        {
            Debug.WriteLine($"Generating {cart.fobCount} FOB and {cart.cardCount} Cards");
            List<OrderKey> keys = new List<OrderKey>();

            for (int index = 1; index <= cart.fobCount; index++)
            {
                OrderKey key = new OrderKey();
                key.resident_id = user.Result.Id;
                key.visitor_id = "Not Implemented";
                key.card_type = "Fob";
                key.package_room_access = "deny";
                key.front_door_access = "allow";

                key.shipping_fullname = user.Result.FirstName + " " + user.Result.LastName;
                key.shipping_phone = user.Result.CellPhone;
                key.shipping_street = user.Result.Street;
                key.shipping_apartment_number = user.Result.ApartmentNumber;
                key.shipping_state = user.Result.State;
                key.shipping_country = "USA";
                key.shipping_zip = user.Result.ZipCode;

                keys.Add(key);
            }

            for (int index = 1; index <= cart.cardCount; index++)
			{
				OrderKey key = new OrderKey();
				key.resident_id = user.Result.Id;
				key.visitor_id = "Not Implemented";
				key.card_type = "Card";
				key.package_room_access = "deny";
				key.front_door_access = "allow";

				key.shipping_fullname = user.Result.FirstName + " " + user.Result.LastName;
				key.shipping_phone = user.Result.CellPhone;
				key.shipping_street = user.Result.Street;
				key.shipping_apartment_number = user.Result.ApartmentNumber;
				key.shipping_state = user.Result.State;
				key.shipping_country = "USA";
				key.shipping_zip = user.Result.ZipCode;

				keys.Add(key);
			}

            return keys;
        }

        public OrderAccessCardPageOne(User user)
        {
            this.user = user;
            NavigationPage.SetBackButtonTitle(this,"");
            InitializeComponent();
            Init();
        }

		public OrderAccessCardPageOne()
		{
			InitializeComponent();
            Init();
		}

        void Init(){
            BackgroundColor = Constants.BackgroundColor;
        }

    }
}
