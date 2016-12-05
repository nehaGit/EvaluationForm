﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TalentAcquisition
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage = new TalentAcquisition.MainPage ();//new NavigationPage(new TalentAcquisition.MainPage()){
			//	BarBackgroundColor=Color.FromHex("#384653")};
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
