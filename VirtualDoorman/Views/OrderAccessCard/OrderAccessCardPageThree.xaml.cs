using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public partial class OrderAccessCardPageThree : ContentPage
    {
        private Cart cart;

        public OrderAccessCardPageThree()
        {
            InitializeComponent();
        }

        public OrderAccessCardPageThree(Cart cart)
        {
            this.cart = cart;
            InitializeComponent();
            Init();
            populatePage(cart);
        }

        private void populatePage(Cart cart)
        {
            Debug.WriteLine($"loginGUID: {cart.loginGUID}");
        }

        //Initial Configurations
        void Init()
		{
			BackgroundColor = Constants.BackgroundColor;

		}

		//Buttons and Taps
		void OnContinueClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new OrderAccessCardPageFour(cart));
		}
    }
}
