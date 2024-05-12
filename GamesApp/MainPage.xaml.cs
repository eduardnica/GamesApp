namespace GamesApp
{
    public partial class MainPage : ContentPage
    {

        public IList<Game> Games { get; }

        public MainPage()
        {
            InitializeComponent();

            Games = new List<Game>
            {
            new Game
                {
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "An action role-playing game developed and published by CD Projekt.",
                    Price = 29.99,
                    Developer = "CD Projekt Red",
                    ReleaseDate = 2015,
                    Category = "Action RPG",
                    Rating = 9.3
                },
                new Game
                {
                    Name = "Red Dead Redemption 2",
                    Description = "An action-adventure game developed and published by Rockstar Games.",
                    Price = 39.99,
                    Developer = "Rockstar Games",
                    ReleaseDate = 2018,
                    Category = "Open World",
                    Rating = 9.5
                },
                new Game
                {
                    Name = "The Legend of Zelda: Breath of the Wild",
                    Description = "An action-adventure game developed and published by Nintendo.",
                    Price = 49.99,
                    Developer = "Nintendo",
                    ReleaseDate = 2017,
                    Category = "Action Adventure",
                    Rating = 9.7
                }
            };
            BindingContext = this;

        }

       
    }

}