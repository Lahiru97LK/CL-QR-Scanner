using QR_Scanner.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace QR_Scanner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRScanner : ContentPage
    {
        public QRScanner()
        {
            InitializeComponent();
        }

        private async void btnQRScan_Clicked(object sender, EventArgs e)
        {

            var scan = new ZXingScannerPage();
            await Navigation.PushModalAsync(scan);

            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopModalAsync();
                    //await DisplayAlert("Result", "" + result.Text, "OK");

                    Application.Current.Properties["QRCODE"] = result.Text;
                    if (result.Text.Length > 0)
                    {
                        await Navigation.PushAsync(new QRResult());
                    }
                });
            };
        }
    }
}