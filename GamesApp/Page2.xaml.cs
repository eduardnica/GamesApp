using Microcharts;
using SkiaSharp;
using SQLite;

namespace GamesApp;

public partial class Page2 : ContentPage
{
        List<ChartEntry> entries = new List<ChartEntry>();

    public Page2()
    {
        InitializeComponent();

        var databasePath = @"C:\Eduard\Master\PDM\GamesApp\games.db";
        var connection = new SQLiteConnection(databasePath);
        var games = connection.Query<Game>("SELECT * FROM Games").ToList();
        double maxRating = 10;

        foreach (var game in games)
        {
            entries.Add(new ChartEntry((float)game.Rating)
            {
                Label = game.Name,
                ValueLabel = game.Rating.ToString(),
                Color = SKColor.Parse("#9de0ad"),
                TextColor = SKColor.Parse("#45ada8"),
                ValueLabelColor = SKColor.Parse("#45ada8"),

            });
        }

        chartView.Chart = new BarChart
        {
            Entries = entries.OrderBy(entry => entry.Value).ToList(),
            BackgroundColor = SKColor.Parse("#2c3e50"),
            LabelTextSize = 25,
            Margin = 20,
            MaxValue = (float)Math.Ceiling(maxRating)
        };

    }

}