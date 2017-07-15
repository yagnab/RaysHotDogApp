using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RaysHotDogApp
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void ViewHotDogDetailsBtn_Clicked(object sender, EventArgs e)
        {
            //navigate to HotDogDetailsPage
            Navigation.PushAsync(new HotDogTypeMenuPage());
        }

        private void ContactDetailsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactDetailsPage());
        }
    }
}
