using Microcharts;
using SkiaSharp;
using SQLite;

namespace GamesApp;

public partial class Page2 : ContentPage
{

    ChartEntry[] entries = new[]
    {

                 new ChartEntry(600)
                {
                    Label = "The Witcher 3: Wild Hunt",
                    ValueLabel = "112",
                    Color = SKColor.Parse("#2d3e54") 

                },
                new ChartEntry(128)
                {
                    Label = "Red Dead Redemption 2",
                    ValueLabel = "600",
                    Color = SKColor.Parse("#2a3e54")

                },
                new ChartEntry(38)
                {
                    Label = "The Legend of Zelda: Breath of the Wild",
                    ValueLabel = "38",
                    Color = SKColor.Parse("#2b3e54")

                }

    };




    public Page2()
    {
        InitializeComponent();

        chartView.Chart = new BarChart
        {
            Entries = entries
        };

    }




}