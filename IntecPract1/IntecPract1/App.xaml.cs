﻿using IntecPract1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecPract1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainLoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
