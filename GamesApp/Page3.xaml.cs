using Microcharts;
using SkiaSharp;
using SQLite;

namespace GamesApp;

public partial class Page3 : ContentPage
{
    List<ChartEntry> entries = new List<ChartEntry>();

    public Page3()
	{
		InitializeComponent();
        var databasePath = @"C:\Eduard\Master\PDM\GamesApp\games.db";
        var connection = new SQLiteConnection(databasePath);
        var games = connection.Query<Game>("SELECT * FROM Games").ToList();
        double maxPrice = games.Max(game => game.Price);

        foreach (var game in games)
        {
            entries.Add(new ChartEntry((float)game.Price)
            {
                Label = game.Name,
                ValueLabel = game.Price.ToString(),
                Color = SKColor.Parse("#45ada8"),
                TextColor = SKColor.Parse("#9de0ad"),
                ValueLabelColor = SKColor.Parse("#9de0ad"),
            });
        }

        chartView.Chart = new PointChart
        {
            Entries = entries.OrderBy(entry => entry.Value).ToList(),
            BackgroundColor = SKColor.Parse("#2c3e50"),
            LabelTextSize = 25,
            Margin = 30,
            MaxValue = (float)Math.Ceiling(maxPrice)
        };
    }
}