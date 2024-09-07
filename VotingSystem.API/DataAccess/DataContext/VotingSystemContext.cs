using Microsoft.EntityFrameworkCore;
using VotingSystem.API.Domain.Models;

namespace VotingSystem.API.DataAccess.DataContext
{
    public class VotingSystemContext :DbContext
    {
        public VotingSystemContext(DbContextOptions options) : base(options) { }

      public  DbSet<UserProfile>Users { get; set; }
        public DbSet<Voter> Voters { get; set; }

        public DbSet<Candidate>Candidates { get; set; } 
        public DbSet<Vote> Votes { get; set; }

    }
}
