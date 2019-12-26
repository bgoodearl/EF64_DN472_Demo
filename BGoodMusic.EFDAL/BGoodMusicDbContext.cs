using BGoodMusic.Models;
using System.Data.Entity;

namespace BGoodMusic.EFDAL
{
    public partial class BGoodMusicDbContext : DbContext
    {
        public BGoodMusicDbContext()
        {
        }

        public DbSet<Rehearsal> Rehearsals { get; set; }
    }
}
