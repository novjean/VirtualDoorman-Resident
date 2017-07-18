using System;
using System.Collections.Generic;
using VirtualDoorman.Models;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public class CardUser 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class OrderAccessCardPageTwo : ContentPage
    {

        private Cart cart;

        //Constructors
		public OrderAccessCardPageTwo(Cart cart)
		{
			this.cart = cart;
			InitializeComponent();
            Init();
			populateListCart(cart.keys);
		}

		public OrderAccessCardPageTwo()
		{
			InitializeComponent();
            Init();
		}

        //Initial Configurations
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;

        }
		
        //Populating the List view
        private void populateListCart(IEnumerable<OrderKey> keys)
		{
			List<CardUser> list = GetRegisteredUsers();
			pickerUser.ItemsSource = list;

			listCart.ItemsSource = keys;

		}

        //Buttons and Taps
		void OnContinueClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new OrderAccessCardPageThree(cart));
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var key = e.SelectedItem as OrderKey;
			DisplayAlert("Selected:", $"{key.shipping_fullname}", "OK");
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var key = e.Item as OrderKey;
			DisplayAlert("Tapped:", $"{key.shipping_fullname}", "OK");
		}

		//Temporarily Hardcoded data
		public List<CardUser> GetRegisteredUsers()
        {
            return new List<CardUser>
            {
                new CardUser{Id=1, Name="Ralph Stein"},
                new CardUser{Id=2, Name="Travis Brooks"},
                new CardUser{Id=3, Name="Colin Foster"},
                new CardUser{Id=4, Name="Aaron"},
                new CardUser{Id=5, Name="Jackie Williams"},
                new CardUser{Id=6, Name="Suzanne Arcoleo"}
            };
        }

 
    }
}
