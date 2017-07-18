using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public partial class KeyUsersPage : ContentPage
    {
        public KeyUsersPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init(){
            listView.ItemsSource = GetRegisteredUsers();
		}

        public ListView KeyUsers {
            get{
                return listView;
            }
        }

		//Temporarily Hardcoded data
		public IList<CardUser> GetRegisteredUsers()
		{
			return new List<CardUser>
			{
				//new CardUser{Id = 1, Name="Ralph Stein"},
				//new CardUser{Id = 2, Name="Travis Brooks"},
				//new CardUser{Id = 3, Name="Colin Foster"},
				//new CardUser{Id = 4, Name="Aaron"},
				//new CardUser{Id = 5, Name="Jackie Williams"},
				//new CardUser{Id = 6, Name="Suzanne Arcoleo"}
			};
		}
    }
}
