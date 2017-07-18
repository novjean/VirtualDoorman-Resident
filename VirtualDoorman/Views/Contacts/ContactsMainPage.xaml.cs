using System;
using System.Collections.Generic;
using System.Diagnostics;
using VirtualDoorman.Models.ContactModels;
using VirtualDoorman.Services;
using Xamarin.Forms;

namespace VirtualDoorman.Views.Contacts
{
    public partial class ContactsMainPage : ContentPage
    {
        private User userObject;
        private ContactService _service = new ContactService();

        public ContactsMainPage()
        {
            InitializeComponent();
        }

        public ContactsMainPage(User userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
            Init();
            PopulatePage(userObject);

        }

        async private void PopulatePage(User userObject)
        {
            ContactsResponse res = await _service.RetreiveContacts(userObject);
            Debug.WriteLine($"ContactResponse Received: {res.Message}");
            List<Contact> listOfContacts = res.Result;
            listContacts.ItemsSource = listOfContacts;
        }

        //Backup Init
        void Init()
		{
			BackgroundColor = Constants.BackgroundColor;
		}

		private void Init(User userObject)
		{
			if (userObject == null)
				throw new ArgumentNullException(nameof(userObject));
			BackgroundColor = Constants.BackgroundColor;

		}
    }
}
