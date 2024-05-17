using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;

namespace GamesApp;

public partial class Page6AddData : ContentPage
{
    private GameDbContext dbContext;
    private ObservableCollection<Game> games;

    public Page6AddData()
    {
        InitializeComponent();
        dbContext = new GameDbContext();
        dbContext.Database.EnsureCreated();
        LoadGames();
    }

    private void LoadGames()
    {
        games = new ObservableCollection<Game>(dbContext.Games.ToList());
        GamesCollectionView.ItemsSource = games;
    }

    private void OnAddGameClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text) ||
            string.IsNullOrWhiteSpace(DescriptionEntry.Text) ||
            string.IsNullOrWhiteSpace(PriceEntry.Text) ||
            string.IsNullOrWhiteSpace(DeveloperEntry.Text) ||
            string.IsNullOrWhiteSpace(ReleaseDateEntry.Text) ||
            string.IsNullOrWhiteSpace(CategoryEntry.Text) ||
            string.IsNullOrWhiteSpace(RatingEntry.Text))
        {
            DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        if (!double.TryParse(PriceEntry.Text, out double price) ||
            !int.TryParse(ReleaseDateEntry.Text, out int releaseDate) ||
            !double.TryParse(RatingEntry.Text, out double rating))
        {
            DisplayAlert("Error", "Please enter valid numbers for Price, Release Date, and Rating.", "OK");
            return;
        }

        var game = new Game
        {
            Name = NameEntry.Text,
            Description = DescriptionEntry.Text,
            Price = price,
            Developer = DeveloperEntry.Text,
            ReleaseDate = releaseDate,
            Category = CategoryEntry.Text,
            Rating = rating
        };

        dbContext.Games.Add(game);
        dbContext.SaveChanges();
        games.Add(game);
        ClearEntries();
    }

    private void OnDeleteGameClicked(object sender, EventArgs e)
    {
        if (GamesCollectionView.SelectedItem != null)
        {
            var selectedGame = (Game)GamesCollectionView.SelectedItem;
            dbContext.Games.Remove(selectedGame);
            dbContext.SaveChanges();
            games.Remove(selectedGame);
        }
        else
        {
            DisplayAlert("Error", "Please select a game to delete.", "OK");
        }
    }

    private void ClearEntries()
    {
        NameEntry.Text = string.Empty;
        DescriptionEntry.Text = string.Empty;
        PriceEntry.Text = string.Empty;
        DeveloperEntry.Text = string.Empty;
        ReleaseDateEntry.Text = string.Empty;
        CategoryEntry.Text = string.Empty;
        RatingEntry.Text = string.Empty;
    }
}
