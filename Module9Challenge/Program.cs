namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5});
            games.Add(new VideoGame { Name = "Call of Duty", Genre = "FPS", Rating = 3});
            games.Add(new VideoGame { Name = "Resident Evil", Genre = "Horror", Rating = 4});
            games.Add(new VideoGame { Name = "Minecraft", Genre = "Survival", Rating = 5});
            games.Add(new VideoGame { Name = "Fortnite", Genre = "Battle Royale", Rating = 5});

            var topRatedGames = (from game in games
                     where game.Rating >= 4
                     select game).ToList();

            var sortedGames = (from game in topRatedGames
                   orderby game.Name
                   select game).ToList();

            foreach (var game in sortedGames)
                {
                    Console.WriteLine(game.Name);
                }
        }
    }
}
