namespace GamesApp;

public partial class Page1 : ContentPage
{


    private readonly GameDbContext _dbContext;

    public IList<Game> Games { get; }


    public Page1()
	{
		InitializeComponent();

        _dbContext = new GameDbContext();
        _dbContext.Database.EnsureCreated();
        if (!_dbContext.Games.Any())
        {
            SeedInitialData();
        }
        Games = _dbContext.Games.ToList();
        BindingContext = this;

    }

    private void SeedInitialData()
    {

        _dbContext.Games.AddRange(new List<Game>
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
                },
                new Game
                {
                    Name = "Grand Theft Auto V",
                    Description = "An action-adventure game developed by Rockstar North and published by Rockstar Games.",
                    Price = 29.99,
                    Developer = "Rockstar North",
                    ReleaseDate = 2013,
                    Category = "Open World",
                    Rating = 9.6
                },
                new Game
                {
                    Name = "Minecraft",
                    Description = "A sandbox video game developed and published by Mojang Studios.",
                    Price = 19.99,
                    Developer = "Mojang Studios",
                    ReleaseDate = 2011,
                    Category = "Sandbox",
                    Rating = 9.0
                },
                new Game
                {
                    Name = "League of Legends",
                    Description = "A multiplayer online battle arena video game developed and published by Riot Games.",
                    Price = 0.00,
                    Developer = "Riot Games",
                    ReleaseDate = 2009,
                    Category = "MOBA",
                    Rating = 9.0
                },
                new Game
                {
                    Name = "Overwatch",
                    Description = "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.",
                    Price = 39.99,
                    Developer = "Blizzard Entertainment",
                    ReleaseDate = 2016,
                    Category = "First-Person Shooter",
                    Rating = 8.5
                },
                new Game
                {
                    Name = "The Elder Scrolls V: Skyrim",
                    Description = "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.",
                    Price = 39.99,
                    Developer = "Bethesda Game Studios",
                    ReleaseDate = 2011,
                    Category = "Action RPG",
                    Rating = 9.3
                },
                new Game
                {
                    Name = "The Last of Us Part II",
                    Description = "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.",
                    Price = 59.99,
                    Developer = "Naughty Dog",
                    ReleaseDate = 2020,
                    Category = "Action Adventure",
                    Rating = 9.5
                },
                new Game
                {
                    Name = "Cyberpunk 2077",
                    Description = "An action role-playing video game developed and published by CD Projekt.",
                    Price = 59.99,
                    Developer = "CD Projekt Red",
                    ReleaseDate = 2020,
                    Category = "Action RPG",
                    Rating = 7.0
                },
                new Game
                {
                    Name = "Halo Infinite",
                    Description = "A first-person shooter game developed by 343 Industries and published by Xbox Game Studios.",
                    Price = 59.99,
                    Developer = "343 Industries",
                    ReleaseDate = 2021,
                    Category = "First-Person Shooter",
                    Rating = 8.0
                },
                new Game
                {
                    Name = "Assassin's Creed Valhalla",
                    Description = "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.",
                    Price = 59.99,
                    Developer = "Ubisoft Montreal",
                    ReleaseDate = 2020,
                    Category = "Action RPG",
                    Rating = 8.5
                },
                new Game
                {
                    Name = "Among Us",
                    Description = "An online multiplayer social deduction game developed and published by InnerSloth.",
                    Price = 4.99,
                    Developer = "InnerSloth",
                    ReleaseDate = 2018,
                    Category = "Social Deduction",
                    Rating = 8.0
                },
                new Game
                {
                    Name = "Animal Crossing: New Horizons",
                    Description = "A life simulation video game developed and published by Nintendo.",
                    Price = 59.99,
                    Developer = "Nintendo",
                    ReleaseDate = 2020,
                    Category = "Life Simulation",
                    Rating = 9.0
                },
                new Game
                {
                    Name = "FIFA 21",
                    Description = "A football simulation video game published by Electronic Arts as part of the FIFA series.",
                    Price = 59.99,
                    Developer = "EA Vancouver",
                    ReleaseDate = 2020,
                    Category = "Sports",
                    Rating = 7.5
                },
                new Game
                {
                    Name = "Super Mario Odyssey",
                    Description = "A platform game developed and published by Nintendo for the Nintendo Switch.",
                    Price = 59.99,
                    Developer = "Nintendo",
                    ReleaseDate = 2017,
                    Category = "Platformer",
                    Rating = 9.5
                },
                new Game
                {
                    Name = "The Sims 4",
                    Description = "A life simulation video game developed by Maxis and published by Electronic Arts.",
                    Price = 39.99,
                    Developer = "Maxis",
                    ReleaseDate = 2014,
                    Category = "Life Simulation",
                    Rating = 8.0
                },
                new Game
                {
                    Name = "Valorant",
                    Description = "A free-to-play multiplayer tactical first-person shooter game developed and published by Riot Games.",
                    Price = 0.00,
                    Developer = "Riot Games",
                    ReleaseDate = 2020,
                    Category = "First-Person Shooter",
                    Rating = 8.0
                },
                new Game
                {
                    Name = "Death Stranding",
                    Description = "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.",
                    Price = 59.99,
                    Developer = "Kojima Productions",
                    ReleaseDate = 2019,
                    Category = "Action",
                    Rating = 8.0
                },
                new Game
                {
                    Name = "Horizon Zero Dawn",
                    Description = "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.",
                    Price = 19.99,
                    Developer = "Guerrilla Games",
                    ReleaseDate = 2017,
                    Category = "Action RPG",
                    Rating = 9.0
                }
            }) ; 

        _dbContext.SaveChanges();

    }
}