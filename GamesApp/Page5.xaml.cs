using Microcharts;
using SkiaSharp;
using SQLite;

namespace GamesApp
{
    public partial class Page5 : ContentPage
    {
        List<ChartEntry> entries = new List<ChartEntry>();

        public Page5()
        {
            InitializeComponent();
            var databasePath = @"C:\Eduard\Master\PDM\GamesApp\games.db";
            var connection = new SQLiteConnection(databasePath);
            var games = connection.Query<Game>("SELECT * FROM Games").ToList();

            var categoryCounts = games.GroupBy(g => g.Category)
                                      .Select(group => new { Category = group.Key, Count = group.Count() });

            string[] colors = { "#3498db", "#2ecc71", "#9b59b6", "#f1c40f", "#e74c3c", "#1abc9c", "#f39c12" };

            int colorIndex = 0;
            foreach (var categoryCount in categoryCounts)
            {
                entries.Add(new ChartEntry(categoryCount.Count)
                {
                    Label = categoryCount.Category,
                    ValueLabel = categoryCount.Count.ToString(),
                    Color = SKColor.Parse(colors[colorIndex % colors.Length]) 
                });
                colorIndex++;
            }

            chartView.Chart = new DonutChart
            {
                Entries = entries,
                BackgroundColor = SKColor.Parse("#34495e"), 
                LabelTextSize = 30, 
                HoleRadius = 0.5f
            };
        }
    }
}
