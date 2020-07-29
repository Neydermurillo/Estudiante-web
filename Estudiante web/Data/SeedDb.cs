using Soccer.web.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTeamsAsync();
            await CheckTournamentsAsync();
        }

        private async Task CheckTeamsAsync()
        {
            if (!_context.Teams.Any())
            {
                AddTeam("America");
                AddTeam("Argentina");
                AddTeam("Bolivia");
                AddTeam("Brasil");
                AddTeam("Bucaramanga");
                AddTeam("Canada");
                AddTeam("Chile");
                AddTeam("Colombia");
                AddTeam("Costa Rica");
                AddTeam("Ecuador");
                AddTeam("Honduras");
                AddTeam("Junior");
                AddTeam("Medellin");
                AddTeam("Mexico");
                AddTeam("Millonarios");
                AddTeam("Nacional");
                AddTeam("Once Caldas");
                AddTeam("Panama");
                AddTeam("Paraguay");
                AddTeam("Peru");
                AddTeam("Santa Fe");
                AddTeam("Uruguay");
                AddTeam("USA");
                AddTeam("Venezuela");
                await _context.SaveChangesAsync();
            }
        }

        private void AddTeam(string name)
        {
            _context.Teams.Add(new TeamEntity { Name = name, LogoPth = $"~/images/Teams/{name}.jpg" });
        }


        private Task CheckTournamentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
