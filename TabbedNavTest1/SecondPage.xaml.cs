using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedNavTest1
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
