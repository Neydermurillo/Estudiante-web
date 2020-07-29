using System;
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

        private Task CheckTeamsAsync()
        {
            throw new NotImplementedException();
        }

        private Task CheckTournamentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
