using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VirtualDoorman.Views.OrderAccessCard
{
    public partial class TermsAndConditionPage : ContentPage
    {
        void webOnEndNavigating(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Web navigating ended";
        }

        void webOnNavigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Loading...";
        }

        public TermsAndConditionPage()
        {
            InitializeComponent();
            Browser.HeightRequest = 500;
            Browser.WidthRequest = 500;
            Browser.Source = "https://portal.virtualdoorman.com/vdm/owner/terms_and_conditions.php";
            //Browser.Source = "https://iosiasoliveira.github.io/tattoweek/index.html";
        }
    }
}
