using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialScreenPage : ContentPage
    {
        private bool isLoggedIn;
        public InitialScreenPage(bool isLoggedIn = false)
        {
            InitializeComponent();
            this.isLoggedIn = isLoggedIn;
        }

        protected async override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                await Task.Delay(2000);
                if (this.isLoggedIn)
                {
                    App.Current.MainPage = new NavigationPage(new Views.HomePage())
                    {
                        BarBackgroundColor = Color.FromHex("#0b66ea"),
                        BarTextColor = Color.White
                    };
                }
                else
                {
                    App.Current.MainPage = new Xamarin.Forms.NavigationPage(new Views.SignInPage())
                    {
                        BarBackgroundColor = Color.FromHex("#0b66ea"),
                        BarTextColor = Color.White
                    };
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}