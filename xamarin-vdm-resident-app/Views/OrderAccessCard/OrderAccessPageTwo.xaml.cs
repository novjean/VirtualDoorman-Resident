using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models;
using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{

    public partial class OrderAccessPageTwo : ContentPage
    {
        private Cart cart;

        public OrderAccessPageTwo()
        {
            InitializeComponent();
            Init();
        }

        public OrderAccessPageTwo(Cart cart)
        {
            this.cart = cart;

			InitializeComponent();
			Init();
        }

        void Init()
		{
			BackgroundColor = Constants.BackgroundColor;

            foreach (OrderKey key in cart.keys)
                Debug.WriteLine($"{key.card_type}");

		}


		
    }
}
