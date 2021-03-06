﻿
using PocketGuide.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PocketGuide
{
    public partial class App : Application
    {
        static Database database;

        public App()
        {
            InitializeComponent();
            MainPage = new Views.MainPage();
            //MainPage = new PocketGuides.WHMIS.TableOfContent();
            //MainPage =  new NavigationPage(new PocketGuides.WHMIS.PageTitle());
            
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

        public static Database Database
        {
            get {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Checklist.db3"));
                }
                return database;
            }
        }

    }
}
