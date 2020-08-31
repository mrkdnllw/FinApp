using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;
using FinApp.Models;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace FinApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {

        public static IList<Page> children;
       
        public MainPage()
        {
            
            InitializeComponent();            

            //n sample code para sa preferences
            Console.WriteLine("preference 'foo''s value is: " + Preferences.Get("foo", "no value"));

            //n diri isetup ang mga children nga dynamic
            children = Children;
            
        }    


    }
}
