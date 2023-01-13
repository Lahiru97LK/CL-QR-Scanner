using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QR_Scanner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnQRScan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QRScanner());
        }

        private void btnSearchByCode_Clicked(object sender, EventArgs e)
        {

        }

        private void btnReportBugs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReportBugs());
        }
    }
}