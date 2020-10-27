using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace application
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Synopsis : ContentPage
    {
        public Synopsis()
        {
            InitializeComponent();
            PLAY.IsEnabled = false;
            wait();

        }

        private async void wait()
        {
            await Task.Delay(5000);
            PLAY.IsEnabled = true;

        }
            private async void PLAY_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Page1()));
        }
    }
}