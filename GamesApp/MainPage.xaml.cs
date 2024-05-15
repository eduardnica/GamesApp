using Microsoft.EntityFrameworkCore;
using SQLite;
using Microsoft.Maui.Controls;

namespace GamesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        public async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        public async void Button3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        public async void Button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        public async void Button5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}