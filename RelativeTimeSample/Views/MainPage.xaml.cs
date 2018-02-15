using System;
using System.Collections.Generic;
using RelativeTimeSample.ViewModels;
using Xamarin.Forms;

namespace RelativeTimeSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
