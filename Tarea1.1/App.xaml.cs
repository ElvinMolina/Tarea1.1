﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1._1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraApp.MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
