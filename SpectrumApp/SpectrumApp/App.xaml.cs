using DLToolkit.Forms.Controls;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpectrumApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Official Release : 18.2.0.44 Key
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAwODU1QDMxMzgyZTMyMmUzMEd3dTlCM3dsYW5jNEIvajBsbUMrUmhpQis2MHRkajBxRjNqQjB4ajRvSG89");

            FlowListView.Init();
            MainPage = new Views.InitialScreenPage();
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
