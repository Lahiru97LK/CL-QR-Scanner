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
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();

            splashAnimation();
        }

        private async Task splashAnimation()
        {
            ceylifeLogo.Opacity = 0;
            await ceylifeLogo.FadeTo(1, 4000);
            Application.Current.MainPage = new MainMenu();
        }
    }
}