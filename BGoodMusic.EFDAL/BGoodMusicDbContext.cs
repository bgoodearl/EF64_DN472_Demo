using BGoodMusic.Models;
using System.Data.Entity;

namespace BGoodMusic.EFDAL
{
    public partial class BGoodMusicDbContext : DbContext
    {
        public BGoodMusicDbContext()
            : base()
        {
        }

        public BGoodMusicDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Rehearsal> Rehearsals { get; set; }
    }
}
