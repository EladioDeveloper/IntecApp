using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (ID.Text == "" || Password.Text == "")
                await DisplayAlert("Error", "Campos Vacios", "OK");
            else
                await DisplayAlert("Bienvenido", $"Hola {ID.Text}", "OK");
        }
    }
}
