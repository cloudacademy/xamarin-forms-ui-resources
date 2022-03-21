﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xaml_UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LayoutsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.TabbedLayoutPage());
        }
    }
}
