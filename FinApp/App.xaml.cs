using FinApp.Data;
using System;
using System.IO;
using Xamarin.Forms;

namespace FinApp
{
    public partial class App : Application
    {
        static FinAppDatabase database;

         public static FinAppDatabase Database
        {
            get
            {
                Console.WriteLine("app static Database reached");
                if (database == null)
                {
                    database = new FinAppDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Miscs.db3"));
                }
                return database;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new AddTransactionPage();
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
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
