using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            txtUsername.Text = "spectrum123@gmail.com";
            txtPassword.Text = "MySpectrum@1";
        }

        private void btnSignUp_Clicked(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        private async void btnSignIn_Clicked(object sender, EventArgs e)
        {
            grdSpinner.IsVisible = true;
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    grdSpinner.IsVisible = false;
                    DisplayAlert("Alert", "Username or Email required.", "OK").Wait();
                    return;
                }
                else if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    grdSpinner.IsVisible = false;
                    DisplayAlert("Alert", "Password required.", "OK").Wait();
                    return;
                }
                grdSpinner.IsVisible = true;
                await Task.Delay(1000);
                App.Current.MainPage = new ListPage();
               
            }
            catch (Exception ex)
            {
            }
            finally
            {
                grdSpinner.IsVisible = false;
            }
        }

        
            private void btnForgotPassword_Clicked(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void txt_Focused(object sender, FocusEventArgs e)
        {
            try
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    scrContant.Padding = new Thickness(0, 0, 0, 300);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void txt_UnFocushed(object sender, FocusEventArgs e)
        {
            try
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    scrContant.Padding = 0;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}