using System;
using System.Collections.Generic;
using VirtualDoorman.Models;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman
{
    
    public class CellProvider{
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class RegisterPage : ContentPage
    {
        RegisterService _regServ = new RegisterService();
        
        async void OnNextClicked(object sender, System.EventArgs e)
        {
            RegisterUser user = CreateUser();
            System.Diagnostics.Debug.WriteLine($"User=  {user.username}");
            if(!user.Equals(null)){
                System.Diagnostics.Debug.WriteLine("Going to register Page 2");
				await Navigation.PushAsync(new RegisterPage2(user));
            }
            else{
                await DisplayAlert("Incomplete" , "Please check the information entered. All fields are required.",
                            "OK");    
            }
        }

        private RegisterUser CreateUser()
        {
            RegisterUser user = new RegisterUser();

			user.first_name = firstName.Text;
			user.last_name = lastName.Text;

			user.primary_email = primaryEmail.Text;
			user.secondary_email = secondaryEmail.Text;
			user.primary_phone = primaryPhone.Text;
			user.cell_phone = cellPhone.Text;

			user.username = username.Text;
			user.password = password.Text;

            if (_regServ.CheckUserRegisterInfo(user))
                return user;
            else
                return null;
        }

        void Init(){
            BackgroundColor = Constants.BackgroundColor;

            foreach (var cellProvider in GetCellProviders())
                pickerCellProvider.Items.Add(cellProvider.Name);
        }

        public RegisterPage()
        {
            InitializeComponent();
            Init();
        }

        public IList<CellProvider> GetCellProviders(){
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
