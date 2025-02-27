using Microsoft.EntityFrameworkCore;

namespace cSharp2022.Models
{
    // MuhContext is of DbContext: the class represents a session with our MySQL db allowing to query/save data.
    // Running update database will scaffold this
    public class MuhContext : DbContext
    {
        public MuhContext(DbContextOptions options) : base(options) { }

        public DbSet<Recordis> Recs { get; set; } //this will be actual SQL table's name!
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Connect> Connects { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Aversion> Aversions { get; set; }
    }
}