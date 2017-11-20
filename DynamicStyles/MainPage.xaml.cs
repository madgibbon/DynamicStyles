using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DynamicStyles
{
    public partial class MainPage : ContentPage
    {
        private bool done = false;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            done = false;

            Device.StartTimer(TimeSpan.FromSeconds(1), () => { 
                Resources["now"] = DateTime.Now.ToString();
                return !done;
            });

            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            done = true;

            base.OnDisappearing();
        }
    }
}
