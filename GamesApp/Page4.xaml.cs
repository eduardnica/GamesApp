using Microcharts;
using SkiaSharp;
using SQLite;

namespace GamesApp;

public partial class Page4 : ContentPage
{


    List<ChartEntry> entries = new List<ChartEntry>();

    public Page4()
    {
        InitializeComponent();
        var databasePath = @"C:\Eduard\Master\PDM\GamesApp\games.db";
        var connection = new SQLiteConnection(databasePath);
        var games = connection.Query<Game>("SELECT * FROM Games").ToList();
        double maxDate = DateTime.Now.Year;

        foreach (var game in games)
        {
            entries.Add(new ChartEntry((float)game.ReleaseDate)
            {
                Label = game.Name,
                ValueLabel = game.ReleaseDate.ToString(),
                Color = SKColor.Parse("#9de0ad"),
                TextColor = SKColor.Parse("#45ada8"),
                ValueLabelColor = SKColor.Parse("#45ada8"),

            });
        }
        chartView.Chart = new LineChart
        {
            Entries = entries.OrderBy(entry => entry.Value).ToList(),
            BackgroundColor = SKColor.Parse("#2c3e50"),
            LabelTextSize = 25,
            Margin = 70,
            MaxValue = (float)Math.Ceiling(maxDate),
            MinValue = 2000
        };
    }
}