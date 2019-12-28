using BGoodMusic.Models;
using System.Data.Entity;

namespace BGoodMusic.EFDAL
{
    public partial class BGoodMusicDbContext //BGoodMusicDbContext2.cs
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rehearsal>()
                .HasKey(x => x.Id)
                .ToTable("bgm_Rehearsals");

            base.OnModelCreating(modelBuilder);
        }
    }
}
