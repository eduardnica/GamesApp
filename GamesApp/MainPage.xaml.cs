using Microsoft.EntityFrameworkCore;
using SQLite;
using Microsoft.Maui.Controls;

namespace GamesApp
{
    public partial class MainPage : ContentPage
    {

        StackLayout Page1Content;
        StackLayout Page2Content;

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


    }
}