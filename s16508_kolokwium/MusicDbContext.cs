using Microsoft.EntityFrameworkCore;
using s16508_kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s16508_kolokwium
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<MusicianTrack> MusicianTracks { get; set; }
        public DbSet<Musician> Musicians { get; set; }



        public MusicDbContext()
        {

        }

        public MusicDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
