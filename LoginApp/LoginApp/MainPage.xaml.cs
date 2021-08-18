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

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text))
                await DisplayAlert("Error", "Campos Vacios", "OK");
            else
                await DisplayAlert("Bienvenido", $"Hola {idEntry.Text}", "OK");
        }

    }
}
