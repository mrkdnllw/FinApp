using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Collections.Generic;
using FinApp.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Collections;

namespace FinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesPage : ContentPage
    {
        //kinahanglan morefer ni sa data sa db
        //ObservableCollection<Transaction> transactions = new ObservableCollection<Transaction>((IEnumerable<Transaction>)(IEnumerable)App.Database.GetTransactionsAsync());
        //public ObservableCollection<Transaction> Transactions { get { return transactions; } }

        public ExpensesPage()
        {
            //n so modagan ni sha kada open 
            InitializeComponent();
            
            //TransactionView.ItemsSource = transactions;
            
        }

        async void AddTransaction(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddTransactionPage() { 
                BindingContext = new Transaction() //empty basket ni sha
            });
        }

        async void AddSampleData (object sender, EventArgs args)
        {
            //mag add og test data
           await App.Database.SaveTransactionAsync(new Transaction
            {
                Amount = "100",
                Description = "fare",
                Date = new DateTime()
            });

            await App.Database.SaveTransactionAsync(new Transaction
            {
                Amount = "70",
                Description = "2 ka coke",
                Date = new DateTime()
            });
        }




        protected override async void OnAppearing()
        {
            base.OnAppearing();
            TransactionView.ItemsSource = await App.Database.GetTransactionsAsync();

            
        }

    }

    //poco ni

   
}