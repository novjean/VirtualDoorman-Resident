using System;
using System.Collections.Generic;
using VirtualDoorman.Models;
using VirtualDoorman.Services;
using VirtualDoorman.Views.OrderAccessCard;
using Xamarin.Forms;

namespace VirtualDoorman
{
    //public class Region{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

	public class State
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

    public partial class RegisterPage2 : ContentPage
    {
        async void buttonViewTerms(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TermsAndConditionPage());
        }

        private RegisterUser user;
        RegisterService _regServ = new RegisterService();


        //Default constructor
		public RegisterPage2()
		{
			InitializeComponent();
			Init();
		}

        //Constructor that get called with the partial RegisterUser object
		public RegisterPage2(RegisterUser user)
		{
		    this.user = user;

			InitializeComponent();
			Init();
		}

        //Initializations when the page loads
        void Init(){
            BackgroundColor = Constants.BackgroundColor;

            //Setting the Picker for the corresponding fields
            //foreach (var region in GetRegions())
                //regionPicker.Items.Add(region.Name);

            foreach (var state in GetStates())
                statePicker.Items.Add(state.Name);

            foreach (var city in GetCities())
                cityPicker.Items.Add(city.Name);
        }

        //Perform the call to Save the object to DB
		async void OnSaveClicked(object sender, System.EventArgs e)
		{
            RegisterUser createdUser = CreateUser(user);

            if (!user.Equals(null))
            {
                await _regServ.PostResponse(createdUser);
                await DisplayAlert(
                    "Save",
                    "Thank you for registering.",
                    "OK");
                await Navigation.PopToRootAsync();
            }
            else
            {
                await DisplayAlert(
                    "Error",
                    "Some fields are missing. Please fill all fields mentioned",
                    "OK");
            }
		}

        private RegisterUser CreateUser(RegisterUser user)
        {
            user.work_phone = "";
            user.address = address.Text;
            user.street = "";
            user.apartment_number = apartment_number.Text;
            user.state = statePicker.Items[statePicker.SelectedIndex].ToString();
            user.city = cityPicker.Items[cityPicker.SelectedIndex].ToString();
            user.country = "US";
            user.secret_question = secretQuestion.Text;
            user.secret_answer = secretAnswer.Text;

            if (_regServ.CheckUserRegisterInfo2(user))
                return user;
            else
                return null;

        }


        //Temporarily Hardcoded data
   //     public IList<Region> GetRegions(){
   //         return new List<Region>
   //         {
   //             new Region{Id = 1, Name="North East"},
			//	new Region{Id = 2, Name="South East"},
			//	new Region{Id = 3, Name="Mid West"},
			//	new Region{Id = 4, Name="South West"},
			//	new Region{Id = 5, Name="West Coast South"},
			//	new Region{Id = 6, Name="West Coast North"}
			//};
        //}

        public IList<State> GetStates()
		{
			return new List<State>
			{
				new State{Id = 1, Name="New York"},
                new State{Id = 2, Name="Connecticut"},
                new State{Id = 3, Name="Maine"},
                new State{Id = 4, Name="Maryland"},
                new State{Id = 5, Name="Massachusetts"},
                new State{Id = 6, Name="New Hampshire"},
                new State{Id = 7, Name="New Jersey"},
				new State{Id = 8, Name="Pennsylvania"},
				new State{Id = 9, Name="Rhode Island"},
				new State{Id = 10, Name="Vermont"}
			};
		}

		public IList<City> GetCities()
		{
			return new List<City>
			{
				new City{Id = 1, Name="Brooklyn"},
				new City{Id = 2, Name="Manhattan Harlem"},
				new City{Id = 3, Name="Manhattan Uptown"},
				new City{Id = 4, Name="Manhattan Midtown"},
				new City{Id = 5, Name="Manhattan Downtown"},
				new City{Id = 6, Name="Queens"},
				new City{Id = 7, Name="Staten Island"},
				new City{Id = 8, Name="Harlem"},
				new City{Id = 9, Name="Bronx"},
				new City{Id = 10, Name="Scarsdale"},
				new City{Id = 11, Name="Far Rockaway"},
                new City{Id = 12, Name="Long Island City"},
                new City{Id = 13, Name="Port Chester"},
                new City{Id = 14, Name="Carnegie Hill"},
                new City{Id = 15, Name="Tribeca"}
			};
		}
    }
}