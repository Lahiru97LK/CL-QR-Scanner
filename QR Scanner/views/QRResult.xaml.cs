using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QR_Scanner.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRResult : ContentPage
    {
        public QRResult()
        {
            InitializeComponent();

            qrScannedResult.Text = $"Scanned QR result : {Application.Current.Properties["QRCODE"].ToString()}";
        }
    }
}