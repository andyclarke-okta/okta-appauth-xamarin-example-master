using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OktaDemo.XF.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OktaDemo.XF.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthInfoPage : ContentPage
    {
        public AuthInfoPage(string name, string email, string preferredUsername)
        {
            InitializeComponent();
            _nameLabel.Text = name;
            _emailLabel.Text = email;
            _preferredUsernameLabel.Text = preferredUsername;
        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("LogoutButton_Clicked");
            var loginProvider = DependencyService.Get<ILoginProvider>();
            IsBusy = true;
            await loginProvider.LogoutAsync();

            await Navigation.PushAsync(new MainPage());

        }
    }
}