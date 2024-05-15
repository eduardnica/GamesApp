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


        foreach (var game in games)
        {
            entries.Add(new ChartEntry((float)game.Rating)
            {
                Label = game.Name,
                ValueLabel = game.Rating.ToString(),
                Color = SKColor.Parse("#3498db"), 
                TextColor = SKColor.Parse("#ffffff"), 
                ValueLabelColor = SKColor.Parse("#ffffff"), 
                
            });
        }

        chartView.Chart = new BarChart
        {
            Entries = entries,
            BackgroundColor = SKColor.Parse("#2c3e50"),
            LabelTextSize = 30,
            Margin = 20
        };

    }




}