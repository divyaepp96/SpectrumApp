using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

namespace SpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private readonly ViewModel.ListViewModel listViewModel;
        public ListPage()
        {
            InitializeComponent();
            listViewModel = new ViewModel.ListViewModel();
            BindingContext = listViewModel;
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
            }
        }

        private void lvTimesheets_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                if (sender is ListView lv)
                {
                    lv.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private async void filter_tapped(object sender, EventArgs e)
        {
            try
            {
                listViewModel.FillData();
                var result = await DisplayActionSheet("Sort by (Ascending)", "Cancel", null, new string[] { "Address", "Date" });
                switch (result)
                {
                    case "Address":
                        listViewModel.Timesheets.OrderBy(x => x.Address);
                        BindingContext = listViewModel;
                        break;
                    case "Date":
                        listViewModel.Timesheets.OrderBy(x => x.JobDate);
                        BindingContext = listViewModel;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void TimesheetsView_Tapped(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void dpkFilter_DateSelected(object sender, DateChangedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAddNew_Clicked(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void deleteEntry_tapped(object sender, EventArgs e)
        {

        }

        private void ExtEntry_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (txtSearch.Text != null)
            {
                listViewModel.FillData();
                listViewModel.Timesheets.Where(x => x.Address.Contains(txtSearch.Text));
                BindingContext = listViewModel;
            }
        }
    }
}