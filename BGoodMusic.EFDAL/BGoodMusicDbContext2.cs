using BGoodMusic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGoodMusic.EFDAL
{
    public partial class BGoodMusicDbContext //BGoodMusicDbContext2.cs
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rehearsal>()
                .HasKey(x => x.Id)
                .ToTable("bgm_Rehearsals");
        }
    }
}
