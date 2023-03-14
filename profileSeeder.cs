
using Microsoft.EntityFrameworkCore;
using queueUp.Entities;

public class profileSeeder
{
    private readonly PlayerProfileDbContext _context;

    public profileSeeder(PlayerProfileDbContext context)
    {
        _context = context;
    }
    public void Seed()
    {

        if (_context.Database.CanConnect())
        {
            if(!_context.PlayerProfiles.Any())
            {
                var profiles = GetProfiles();
            }
        }
    }

    private IEnumerable<PlayerProfile> GetProfiles()
    {
        var profiles = new List<PlayerProfile>()
        {
            new PlayerProfile()
            {
                NickName = "obl",
                GameId =1
            },

            new PlayerProfile()
            {
                NickName = "obl",
                GameId =1
            }
        };

        return profiles;
    }

    private IEnumerable<Game> GetGames()
    {
        var games = new List<Game>()
        {
            new Game()
            {
                GameTitle = "League of Legends",
                GameDescription = "League is a MOBA video game developed and published by Riot Games, in which two teams of five players battle in a PvP combat.",
                Position = "Midlane",
                Rank = "Diamond"
            },

            new Game()
            {
                GameTitle = "Counter=Strike: Global Offensive",
                GameDescription = "CS:GO is a multiplayer FPS developed by Valve and Hidden Path Entertainment, in which two teams: Terrorists and Counter-Terrorists, against each other in objective based game modes",
                Position = "Sniper",
                Rank = "Legendary Eagle"
            }
        };

        return games;
    }
}