

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTransactionPage : ContentPage
    {
        

        public AddTransactionPage()
        {
            InitializeComponent();
            //App.Database.SaveTransactionAsync()
            
          //  BindingContext = new AddTransactionPageViewModel();

        }

          async void SubmitTransaction(object sender, EventArgs args)
        {

        }
        

        
    }
}