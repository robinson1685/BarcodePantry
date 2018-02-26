using Pantry.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Pantry.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PantryView : ContentPage
    {
        ZXingScannerPage scanPage;
        PantryViewModel vm;

        public PantryView()
        {
            InitializeComponent();
            vm = new PantryViewModel();
            listPantry.ItemsSource = vm.Pantry;
            ButtonScanner.Clicked += ButtonScanner_Clicked;
        }

        private async void ButtonScanner_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    DisplayAlert("Updated Quantity: ", result.Text, "OK");
                    UpdateQuantity(result.Text);
                });
            };

            await Navigation.PushModalAsync(scanPage);
        }

        private void UpdateQuantity(string result)
        {
            switch (result)
            {
                case "1":
                //Apple
                case "2":
                //Salt
                case "3":
                //Bread
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}